using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_Manha
{
    internal class Endereco
    {

        private string Rua;
        private string Numero;
        private string CEP;
        private string Bairro;
        private string Cidade;
        private string Estado;
        public Endereco(string rua, string numero, string cep, string bairro, string cidade, string estado)
        {
            Rua = rua;
            Numero = numero;
            CEP = cep;
            Bairro = bairro;
            Cidade = cidade;
            Estado = estado;
        }
        public string getRua()
        {
            return Rua;
        }
        public void setRua(string rua)
        {
            Rua = rua;
        }
        public string getnumero()
        {
            return Numero;
        }
        public void setNumero(string numero)
        {
            Numero = numero;
        }
        public string getCEP()
        {
            return CEP;
        }
        public void setCEP(string cep)
        {
            CEP = cep;
        }
        public string getBairro()
        {
            return Bairro;
        }
        public void setBairro(string bairro)
        {
            Bairro = bairro;
        }
        public string getEstado()
        {
            return Estado;
        }
        public void setEstado(string estado)
        {
            Estado = estado;
        }
        public string getCidade()
        {
            return Cidade;
        }
        public void setCidade(string cidade)
        {
            Cidade = cidade;
        }

    }
}
