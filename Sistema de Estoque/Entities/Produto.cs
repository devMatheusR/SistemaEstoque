using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaEstoque.Entities
{
    class Produto 
    {

        //Atributos

        private String nome;
        private String descricao;
        private Double preco;
        private int quantidade;

        //Métodos
             
        //Métodos especiais
        public string Nome   
        {
            get { return nome; }  
            set { nome = value; }  
        }

        public string Descricao
        {
            get { return descricao; }
            set { descricao = value; }
        }

        public double Preco
        {
            get { return preco; }
            set { preco = value; }
        }

        public int Quantidade
        {
            get { return quantidade; }
            set { quantidade = value; }
        }
    }
}

