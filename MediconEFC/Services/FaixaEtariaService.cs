using Microsoft.EntityFrameworkCore;
using MediconEFC.Models;
using MediconEFC.Services.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediconEFC.Data;

namespace MediconEFC.Services
{
    public class FaixaEtariaService
    {
        private readonly MediconEFCContext _context;

        public FaixaEtariaService(MediconEFCContext context)
        {
            _context = context;
        }

        #region chamadas assincronas

        public async Task<List<FaixaEtaria>> FindAllAsync()
        {
            return await _context.FaixaEtaria.ToListAsync();
        }

        public async Task InsertAsync(FaixaEtaria obj)
        {
            _context.Add(obj);
            await _context.SaveChangesAsync();
        }

        public async Task<FaixaEtaria> FindByIdAsync(int id)
        {
            return await _context.FaixaEtaria.FirstOrDefaultAsync(m => m.Id == id);
        }

        public async Task RemoveAsync(int id)
        {
            try
            {
                var obj = await _context.FaixaEtaria.FindAsync(id);
                _context.FaixaEtaria.Remove(obj);
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException e)
            {
                throw new IntegrityException("Não é possível excluir FaixaEtaria porque ele já foi cadastrado em uma proposta!" + e);
            }
        }

        public async Task UpdateAsync(FaixaEtaria obj)
        {
            bool hasAny = await _context.FaixaEtaria.AnyAsync(x => x.Id == obj.Id);
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

        public FaixaEtaria FindById(int id)
        {
            return _context.FaixaEtaria.FirstOrDefault(m => m.Id == id);
        }

        public void CadastrarFaixaEtaria(FaixaEtaria obj)
        {
            _context.Add(obj);
            _context.SaveChanges();
        }

        public void RemoveFaixaEtaria(int id)
        {
            try
            {
                var obj = _context.FaixaEtaria.Find(id);
                _context.FaixaEtaria.Remove(obj);
                _context.SaveChanges();
            }
            catch (DbUpdateException e)
            {
                throw new IntegrityException("Não é possível excluir FaixaEtaria porque ele já foi cadastrado em uma proposta!" + e);
            }
        }

        public void AlterarFaixaEtaria(FaixaEtaria obj)
        {
            bool hasAny = _context.FaixaEtaria.Any(x => x.Id == obj.Id);
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
        /// Verifica se já existe FaixaEtaria com mesmo nome cadastrado no sistema
        /// </summary>
        /// <param name="FaixaEtaria"></param>
        /// <returns></returns>
        public bool ExistsFaixaEtaria(FaixaEtaria FaixaEtaria)
        {
            return _context.FaixaEtaria.ToList().Exists(x => x.Descricao.Trim() == FaixaEtaria.Descricao.Trim());            
        }


        #endregion

    }
}
