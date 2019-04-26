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
    public class PlanoService
    {
        private readonly MediconEFCContext _context;

        public PlanoService(MediconEFCContext context)
        {
            _context = context;
        }

        #region chamadas assincronas

        public async Task<List<Plano>> FindAllAsync()
        {
            var result_Post = (from p in _context.Plano
                               select new
                               {
                                   p.Id,
                                   p.Nome
                               }).Take(5).OrderByDescending(ps => ps.Id);



            return await _context.Plano.ToListAsync();
        }

        public async Task InsertAsync(Plano obj)
        {
            _context.Add(obj);
            await _context.SaveChangesAsync();
        }

        public async Task<Plano> FindByIdAsync(int id)
        {
            return await _context.Plano.FirstOrDefaultAsync(m => m.Id == id);
        }

        public async Task RemoveAsync(int id)
        {
            try
            {
                var obj = await _context.Plano.FindAsync(id);
                _context.Plano.Remove(obj);
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException e)
            {
                throw new IntegrityException("Não é possível excluir o PLano porque ele já foi cadastrado em uma proposta!" + e);
            }
        }

        public async Task UpdateAsync(Plano obj)
        {
            bool hasAny = await _context.Plano.AnyAsync(x => x.Id == obj.Id);
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

        public Plano FindById(int id)
        {
            return  _context.Plano.FirstOrDefault(m => m.Id == id);
        }

        public void CadastrarPlano(Plano obj)
        {
            _context.Add(obj);
            _context.SaveChanges();
        }

        public void RemovePlano(int id)
        {
            try
            {
                var obj = _context.Plano.Find(id);
                _context.Plano.Remove(obj);
                _context.SaveChanges();
            }
            catch (DbUpdateException e)
            {
                throw new IntegrityException("Não é possível excluir o PLano porque ele já foi cadastrado em uma proposta!" + e);
            }
        }

        public void AlterarPlano(Plano obj)
        {
            bool hasAny = _context.Plano.Any(x => x.Id == obj.Id);
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
        /// Verifica se já existe plano com mesmo nome cadastrado no sistema
        /// </summary>
        /// <param name="plano"></param>
        /// <returns></returns>
        public bool ExistsPlano(Plano plano)
        {
            return _context.Plano.ToList().Exists(x => x.Nome.Trim() == plano.Nome.Trim());                
        }


        #endregion

    }
}
