using System;
using System.ComponentModel.DataAnnotations;

namespace AppCore.Models
{
    /// <summary>
    /// Entitdade do produto
    /// </summary>
    public class Produto : Entity
    {
        /// <summary>
        /// Chave estrangeira do Fornecedor
        /// </summary>
        public Guid FornecedorId { get; set; }

        /// <summary>
        /// Nome do produto
        /// </summary>
        [Required(ErrorMessage ="O campo {0} é obrigatório!")]
        [StringLength(200, ErrorMessage ="O campo {0} precisa ter entre {2} e {1} caracteres", MinimumLength = 2)]
        public string Nome { get; set; }

        /// <summary>
        /// Descrição do produto
        /// </summary>
        [Required(ErrorMessage = "O campo {0} é obrigatório!")]
        [StringLength(1000, ErrorMessage = "O campo {0} precisa ter entre {2} e {1} caracteres", MinimumLength = 2)]
        public string Descricao { get; set; }

        /// <summary>
        /// Imagem do produto
        /// </summary>
        [Required(ErrorMessage = "O campo {0} é obrigatório!")]
        [StringLength(200, ErrorMessage = "O campo {0} precisa ter entre {2} e {1} caracteres", MinimumLength = 2)]
        public string Imagem { get; set; }

        /// <summary>
        /// Valor do produto
        /// </summary>
        [Required(ErrorMessage = "O campo {0} é obrigatório!")]
        public decimal Valor { get; set; }

        /// <summary>
        /// Data de cadastro do produto
        /// </summary>
        public DateTime DataCadastro { get; set; }

        /* EF relation - relacionamento com o Fornecedor */
        public Fornecedor Fornecedor { get; set; }
    }
}
