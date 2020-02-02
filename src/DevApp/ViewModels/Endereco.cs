using AppCore.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AppCore.ViewModels
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
        [StringLength(200, ErrorMessage = "O campo {0} precisa ter entre {2} e {1} caracteres", MinimumLength = 2)]
        public string Logradouro { get; set; }

        /// <summary>
        /// Número do endereço
        /// </summary>
        [StringLength(50, ErrorMessage = "O campo {0} precisa ter entre {2} e {1} caracteres", MinimumLength = 2)]
        public string Numero { get; set; }

        /// <summary>
        /// Complemento do endereço
        /// </summary>
        public string Complemento { get; set; }

        /// <summary>
        /// CEP do endereço
        /// </summary>
        [StringLength(8, ErrorMessage = "O campo {0} precisa ter entre {1}", MinimumLength = 8)]
        public string CEP { get; set; }

        /// <summary>
        /// Bairro do endereço
        /// </summary>
        [StringLength(100, ErrorMessage = "O campo {0} precisa ter entre {2} e {1} caracteres", MinimumLength = 2)]
        public string Bairro { get; set; }

        /// <summary>
        /// Cidade do endereço
        /// </summary>
        [StringLength(100, ErrorMessage = "O campo {0} precisa ter entre {2} e {1} caracteres", MinimumLength = 2)]
        public string Cidade { get; set; }

        /// <summary>
        /// Estado do endereço
        /// </summary>
        [StringLength(50, ErrorMessage = "O campo {0} precisa ter entre {2} e {1} caracteres", MinimumLength = 2)]
        public string Estado { get; set; }

        /* EF relation - relacionamento com o Fornecedor */
        public Fornecedor Fornecedor { get; set; }
    }
}
