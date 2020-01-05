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
        public string Nome { get; set; }

        /// <summary>
        /// Descrição do produto
        /// </summary>
        public string Descricao { get; set; }

        /// <summary>
        /// Imagem do produto
        /// </summary>
              
        public string Imagem { get; set; }

        /// <summary>
        /// Valor do produto
        /// </summary>
        public decimal Valor { get; set; }

        /// <summary>
        /// Data de cadastro do produto
        /// </summary>
        public DateTime DataCadastro { get; set; }

        /* EF relation - relacionamento com o Fornecedor */
        public Fornecedor Fornecedor { get; set; }
    }
}
