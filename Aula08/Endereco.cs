using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula08
{
    internal class Produto
    {
        private int Id;
        private string Descricao;
        private decimal Valor;

        public Produto(int id, string descricao, decimal valor)
        {
            Id = id;
            Descricao = descricao;
            Valor = valor;
        }

        public int getId( )
        { 
            return Id;
        } 

        public void setId( int id ) 
        {
            if (id > 0)
            {
                Id =id;
            }
        }

        public string getDescricao( ) 
        {
            return Descricao;
        }

        public void setDescricao(string descricao) 
        {
           Descricao = descricao;
        }

        public decimal getValor( )
        {
            return  Valor;
        }

        public void setValue( decimal valor )
        {
            Valor = valor; 
        }
    }


















}
