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
    public class CorretorService
    {
        private readonly MediconEFCContext _context;

        public CorretorService(MediconEFCContext context)
        {
            _context = context;
        }

        #region chamadas assincronas

        public async Task<List<Corretor>> FindAllAsync()
        {
            return await _context.Corretor.ToListAsync();
        }

        public async Task InsertAsync(Corretor obj)
        {
            _context.Add(obj);
            await _context.SaveChangesAsync();
        }

        public async Task<Corretor> FindByIdAsync(int id)
        {
            return await _context.Corretor.FirstOrDefaultAsync(m => m.Id == id);
        }

        public async Task RemoveAsync(int id)
        {
            try
            {
                var obj = await _context.Corretor.FindAsync(id);
                _context.Corretor.Remove(obj);
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException e)
            {
                throw new IntegrityException("Não é possível excluir o Corretor porque ele já foi cadastrado em uma proposta!" + e);
            }
        }

        public async Task UpdateAsync(Corretor obj)
        {
            bool hasAny = await _context.Corretor.AnyAsync(x => x.Id == obj.Id);
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

        #region chamadas ajax

        public Corretor FindById(int id)
        {
            return _context.Corretor.FirstOrDefault(m => m.Id == id);
        }

        public void CadastrarCorretor(Corretor obj)
        {
            _context.Add(obj);
            _context.SaveChanges();
        }

        public void RemoveCorretor(int id)
        {
            try
            {
                var obj = _context.Corretor.Find(id);
                _context.Corretor.Remove(obj);
                _context.SaveChanges();
            }
            catch (DbUpdateException e)
            {
                throw new IntegrityException("Não é possível excluir o Corretor porque ele já foi cadastrado em uma proposta!" + e);
            }
        }

        public void AlterarCorretor(Corretor obj)
        {
            bool hasAny = _context.Corretor.Any(x => x.Id == obj.Id);
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
        /// Verifica se já existe Corretor com mesmo nome cadastrado no sistema
        /// </summary>
        /// <param name="Corretor"></param>
        /// <returns></returns>
        public bool ExistsCorretor(Corretor Corretor)
        {
            return _context.Corretor.ToList().Exists(x => x.Nome.Trim() == Corretor.Nome.Trim());                
        }


        #endregion
    }
}
