using MediconEFC.Data;
using MediconEFC.Models;
using MediconEFC.Services.Exceptions;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MediconEFC.Services
{
    public class EquipeService
    {
        private readonly MediconEFCContext _context;

        public EquipeService(MediconEFCContext context)
        {
            _context = context;
        }

        #region chamadas assincronas

        public async Task<List<Equipe>> FindAllAsync()
        {
            //return await _context.Equipe.ToListAsync();

            var listaEquipe = _context.Equipe.Include(e => e.Corretor);
            return await listaEquipe.ToListAsync();

        }

        public async Task InsertAsync(Equipe obj)
        {
            _context.Add(obj);
            await _context.SaveChangesAsync();
        }

        public async Task<Equipe> FindByIdAsync(int id)
        {
            //return await _context.Equipe.FirstOrDefaultAsync(m => m.Id == id);
            return await _context.Equipe.Include(obj => obj.Corretor).FirstOrDefaultAsync(obj => obj.Id == id); // Equipe.FirstOrDefaultAsync(m => m.Id == id);
        }

        public async Task RemoveAsync(int id)
        {
            try
            {
                var obj = await _context.Equipe.FindAsync(id);
                _context.Equipe.Remove(obj);
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException e)
            {
                throw new IntegrityException("Não é possível excluir o Equipe porque ele já foi cadastrado em uma proposta!" + e);
            }
        }

        public async Task UpdateAsync(Equipe obj)
        {
            bool hasAny = await _context.Equipe.AnyAsync(x => x.Id == obj.Id);
            if (!hasAny)
            {
                throw new NotFoundException("Id not found");
            }

            try
            {
                _context.Update(obj);
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException e)
            {
                throw new DbConcurrencyException(e.Message);
            }

        }

        #endregion

        #region chamadas sincronas

        public Equipe FindById(int id)
        {
            return _context.Equipe.FirstOrDefault(m => m.Id == id);
        }

        public void CadastrarEquipe(Equipe obj)
        {
            _context.Add(obj);
            _context.SaveChanges();
        }

        public void RemoveEquipe(int id)
        {
            try
            {
                var obj = _context.Equipe.Find(id);
                _context.Equipe.Remove(obj);
                _context.SaveChanges();
            }
            catch (DbUpdateException e)
            {
                throw new IntegrityException("Não é possível excluir o Equipe porque ele já foi cadastrado em uma proposta!" + e);
            }
        }

        public void AlterarEquipe(Equipe obj)
        {
            bool hasAny = _context.Equipe.Any(x => x.Id == obj.Id);
            if (!hasAny)
            {
                throw new NotFoundException("Id not found");
            }

            try
            {
                _context.Update(obj);
                _context.SaveChanges();
            }
            catch (DbUpdateConcurrencyException e)
            {
                throw new DbConcurrencyException(e.Message);
            }

        }

        /// <summary>
        /// Verifica se já existe Equipe com mesmo nome cadastrado no sistema
        /// </summary>
        /// <param name="Equipe"></param>
        /// <returns></returns>
        public bool ExistsEquipe(Equipe equipe)
        {
            return _context.Equipe.ToList().Exists(x => x.Nome.Trim() == equipe.Nome.Trim());               
        }


        #endregion
    }
}
