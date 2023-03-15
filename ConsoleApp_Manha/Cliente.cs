using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_Manha
{
    public class Cliente
    {
        
        private int Id;
        private string Nome;
        private int Telefone;
        private Endereco Endereco;
        public Cliente(string nome, int id, int telefone, Endereco endereco)
        {
            Nome = nome;
            Telefone = telefone;
            Id = id;
            Endereco = endereco;
        }

        public Endereco getEndereco()
        {
            return Endereco;
        }

        public void setEndereco(Endereco endereco)
        {
            Endereco = endereco;
        }
        public string getNome()
        {
            return Nome;
        }

        public void setNome(string nome)
        {
            Nome = nome;
        }
        
        public int getId()
        {
            return Id;
        }
        public void setId(int id)
        {
            if (id != 0)
            {
                Id = id;
            }
        }

        public int getTelefone()
        {
            return Telefone;
        }
        public void setTelefone(int telefone)
        {
            Telefone = telefone;
        }
    }
}
