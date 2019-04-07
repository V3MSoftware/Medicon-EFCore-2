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
    public class ClienteService
    {
        private readonly MediconEFCContext _context;

        public ClienteService(MediconEFCContext context)
        {
            _context = context;
        }

        public async Task<List<Cliente>> FindAllAsync()
        {
            return await _context.Cliente.ToListAsync();
        }

        public async Task InsertAsync(Cliente obj)
        {
            _context.Add(obj);
            await _context.SaveChangesAsync();
        }
        public async Task<Cliente> FindByIdAsync(int id)
        {
            return await _context.Cliente.FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task RemoveAsync(int id)
        {
            try
            {
                var obj = await _context.Cliente.FindAsync(id);
                _context.Cliente.Remove(obj);
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException e)
            {
                throw new IntegrityException("Não é possível excluir o Cliente porque ele já foi cadastrado em uma proposta!" + e);
            }
        }

        public async Task UpdateAsync(Cliente obj)
        {
            bool hasAny = await _context.Cliente.AnyAsync(x => x.Id == obj.Id);
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

        #region chamadas sincronas

        public Cliente FindById(int id)
        {
            return _context.Cliente.FirstOrDefault(m => m.Id == id);
        }

        public void CadastrarCliente(Cliente obj)
        {
            _context.Add(obj);
            _context.SaveChanges();
        }

        public void RemoveCliente(int id)
        {
            try
            {
                var obj = _context.Cliente.Find(id);
                _context.Cliente.Remove(obj);
                _context.SaveChanges();
            }
            catch (DbUpdateException e)
            {
                throw new IntegrityException("Não é possível excluir o Cliente porque ele já foi cadastrado em uma proposta!" + e);
            }
        }

        public void AlterarCliente(Cliente obj)
        {
            bool hasAny = _context.Cliente.Any(x => x.Id == obj.Id);
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
        /// Verifica se já existe cliente com mesmo nome cadastrado no sistema
        /// </summary>
        /// <param name="cliente"></param>
        /// <returns></returns>
        public bool ExistsCliente(Cliente cliente)
        {
            return _context.Cliente.ToList().Exists(x => x.Nome.Trim() == cliente.Nome.Trim());                
        }


        #endregion


    }
}
