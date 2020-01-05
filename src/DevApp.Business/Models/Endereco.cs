using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AppCore.Models
{
    /// <summary>
    /// Entidade do endereço
    /// </summary>
    public class Endereco:  Entity
    {
        /// <summary>
        /// Id do fornecedor
        /// </summary>
        public Guid FornecedorId { get; set; }

        /// <summary>
        /// Logradouro do endereço
        /// </summary>
        public string Logradouro { get; set; }

        /// <summary>
        /// Número do endereço
        /// </summary>
        public string Numero { get; set; }

        /// <summary>
        /// Complemento do endereço
        /// </summary>
        public string Complemento { get; set; }

        /// <summary>
        /// CEP do endereço
        /// </summary>
        public string CEP { get; set; }

        /// <summary>
        /// Bairro do endereço
        /// </summary>
        public string Bairro { get; set; }

        /// <summary>
        /// Cidade do endereço
        /// </summary>
        public string Cidade { get; set; }

        /// <summary>
        /// Estado do endereço
        /// </summary>
        public string Estado { get; set; }

        /* EF relation - relacionamento com o Fornecedor */
        public Fornecedor Fornecedor { get; set; }
    }
}
