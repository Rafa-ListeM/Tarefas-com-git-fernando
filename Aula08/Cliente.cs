using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tarefa2
{
    public class Pessoas
    {
        public Pessoas(string nome, string cpf, int idade, decimal peso)
        {
            Nome = nome;
            CPF = cpf;
            Idade = idade;
            Peso = peso;
        }

        private string Nome;
        private string CPF;
        private int Idade;
        private decimal Peso;

        public string getNome()
        {
            return "Nome: " + Nome;
        }

        public string getCPF()
        {
            return "CPF: " + CPF;
        }

        public string getIdade() 
        {
            return "Idade: " + Idade;
        }

        public string getPeso()
        {
            return "Peso: " + Peso;
        }
    }
}

