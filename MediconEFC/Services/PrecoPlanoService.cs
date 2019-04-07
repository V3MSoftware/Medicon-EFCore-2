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
    public class PrecoPlanoService
    {
        private readonly MediconEFCContext _context;

        public PrecoPlanoService(MediconEFCContext context)
        {
            _context = context;
        }

        #region chamadas assincronas

        public async Task<List<PrecoPlano>> FindAllAsync()
        {
            return await _context.PrecoPlano
                .Include(p => p.AbrangenciaPlano)
                .Include(p => p.FaixaEtaria)
                .Include(p => p.TipoAcomodacao)
                .Include(p => p.TipoContrato)
                .Include(p => p.TipoPlano)
                .ToListAsync();            
        }

        public async Task InsertAsync(PrecoPlano obj)
        {
            _context.Add(obj);
            await _context.SaveChangesAsync();
        }

        public async Task<PrecoPlano> FindByIdAsync(int id)
        {
            return await _context.PrecoPlano
                .Include(p => p.AbrangenciaPlano)
                .Include(p => p.FaixaEtaria)
                .Include(p => p.TipoAcomodacao)
                .Include(p => p.TipoContrato)
                .Include(p => p.TipoPlano)
                .FirstOrDefaultAsync(m => m.Id == id);
        }

        public async Task RemoveAsync(int id)
        {
            try
            {
                var obj = await _context.PrecoPlano.FindAsync(id);
                _context.PrecoPlano.Remove(obj);
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException e)
            {
                throw new IntegrityException("Não é possível excluir o preço plano porque ele já foi cadastrado em uma proposta!" + e);
            }
        }

        public async Task UpdateAsync(PrecoPlano obj)
        {
            bool hasAny = await _context.PrecoPlano.AnyAsync(x => x.Id == obj.Id);
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

        public PrecoPlano FindById(int id)
        {
            return _context.PrecoPlano.FirstOrDefault(m => m.Id == id);
        }

        public void CadastrarPrecoPlano(PrecoPlano obj)
        {
            _context.Add(obj);
            _context.SaveChanges();
        }

        public void RemovePrecoPlano(int id)
        {
            try
            {
                var obj = _context.PrecoPlano.Find(id);
                _context.PrecoPlano.Remove(obj);
                _context.SaveChanges();
            }
            catch (DbUpdateException e)
            {
                throw new IntegrityException("Não é possível excluir o preço plano porque ele já foi cadastrado em uma proposta!" + e);
            }
        }

        public void AlterarPrecoPlano(PrecoPlano obj)
        {
            bool hasAny = _context.PrecoPlano.Any(x => x.Id == obj.Id);
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
        /// Verifica se já existe PrecoPlano com mesmo nome cadastrado no sistema
        /// </summary>
        /// <param name="PrecoPlano"></param>
        /// <returns></returns>
        public bool ExistsPrecoPlano(PrecoPlano p)
        {
            return _context.PrecoPlano.ToList().Exists(x => x.Valor == p.Valor && 
            x.TipoAcomodacaoId == p.TipoAcomodacaoId && x.AbrangenciaPlanoId == p.AbrangenciaPlanoId &&
            x.TipoContratoId == p.TipoContratoId && x.TipoPlanoId == p.TipoPlanoId);
        }

        #endregion

    }
}
