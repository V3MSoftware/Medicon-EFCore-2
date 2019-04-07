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
    public class DependenteService
    {
        private readonly MediconEFCContext _context;

        public DependenteService( MediconEFCContext context)
        {
            _context = context;
        }

        #region chamadas assincronas               
        public async Task<List<Dependente>> FindAllAsync()
        {            
            return await _context.Dependente.ToListAsync();
        }


        public async Task InsertAsync(Dependente obj)
        {
            _context.Add(obj);
            await _context.SaveChangesAsync();
        }

        public async Task<Dependente> FindByIdAsync(int id)
        {
            return await _context.Dependente.FindAsync(id);
        }

        public async Task RemoveAsync(int id)
        {
            try
            {
                var obj = await _context.Dependente.FindAsync(id);
                _context.Dependente.Remove(obj);
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException e)
            {
                throw new IntegrityException("Não foi possível excluir o dependente!!" + e);
            }
        }

        public async Task UpdateAsync(Dependente obj)
        {
            bool hasAny = await _context.Dependente.AnyAsync(x => x.Id == obj.Id);
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

        public Dependente FindById(int id)
        {
            return _context.Dependente.FirstOrDefault(m => m.Id == id);
        }

        public void CadastrarDependente(Dependente obj)
        {
            _context.Add(obj);
            _context.SaveChanges();
        }

        public void RemoveDependente(int id)
        {
            try
            {
                var obj = _context.Dependente.Find(id);
                _context.Dependente.Remove(obj);
                _context.SaveChanges();
            }
            catch (DbUpdateException e)
            {
                throw new IntegrityException("Não é possível excluir Dependente!" + e);
            }
        }


        public void AlterarDependente(Dependente obj)
        {
            bool hasAny = _context.Dependente.Any(x => x.Id == obj.Id);
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
        /// Verifica se já existe Dependente com mesmo nome cadastrado no sistema para mesma proposta
        /// </summary>
        /// <param name="Dependente"></param>
        /// <returns></returns>
        public bool ExistsDependente(Dependente dependente)
        {
            return _context.Dependente.ToList().Exists(x => x.Cpf.Trim() == dependente.Cpf.Trim());            
        }

        #endregion

    }
}
