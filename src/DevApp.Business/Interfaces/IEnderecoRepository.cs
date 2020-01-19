using AppCore.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DevApp.Business.Interfaces
{
    public interface IEnderecoRepository : IRepository<Endereco>
    {
        Task<Endereco> ObterEnderecoPorFornecedor(Guid fornecedorId);
    }
}
