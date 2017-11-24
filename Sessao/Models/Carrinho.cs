using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Sessao.Models
{
    public class Carrinho
    {
        private List<Produto> produtos;

        public Carrinho()
        {
            this.produtos = new List<Produto>();
        }

        public void setProdutos(List<Produto> p)
        {
            produtos = p;
        }

        public List<Produto> getProdutos()
        {
            return produtos;
        }

        public void addProduto(Produto p)
        {
            produtos.Add(p);
        }

        public bool popProduto(Produto p)
        {
            return produtos.Remove(p);
        }

        public Produto popProduto(int id)
        {
            foreach(var p in produtos)
            {
                if (p.ProdutoID == id)
                {
                    produtos.Remove(p);
                    return p;
                }
            }

            return null;
        }
    }
}