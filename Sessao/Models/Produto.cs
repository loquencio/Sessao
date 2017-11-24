using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Sessao.Models
{
    public class Produto
    {
        public int ProdutoID { get; set; }
        public string Nome { get; set; }

        [DataType(DataType.Currency)]
        public double Preco { get; set; }
    }
}