﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AppCore.Models
{
    /// <summary>
    /// Entidade do fornecedor
    /// </summary>
    public class Fornecedor : Entity
    {
        /// <summary>
        /// Nome do fornecedor
        /// </summary>
        public string Nome { get; set; }

        /// <summary>
        /// Id do fornecedor
        /// </summary>
        public int FornecedorId { get; set; }

        /// <summary>
        /// Documento do fornecedor
        /// </summary>
        public string Documento { get; set; }

        /// <summary>
        /// Tipo de fornecedor
        /// </summary>
        public TipoFornecedor TipoFornecedor { get; set; }

        /// <summary>
        /// Endereço do fornecedor
        /// </summary>
        public Endereco Endereco { get; set; }


        /// <summary>
        /// Flag ativo do fornecedor
        /// </summary>
        public bool Ativo { get; set; }

        /* para fins de EF relations 1 para muitos com produtos*/
        public IEnumerable<Produto> Produtos { get; set; }
    }
}
