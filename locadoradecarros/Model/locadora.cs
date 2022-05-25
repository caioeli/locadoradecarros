using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace locadoradecarros.Model
{
    public class locadora
    {
        private static int idcarro;
        private static string modelo;
        private static string ano;
        private static Array imagem;
        private static string preco;
        private static string marca;
        private static string disponivel;

        private static string retorno;

        public static int Idcarro { get => Idcarro1; set => Idcarro1 = value; }
        public static int Idcarro1 { get => idcarro; set => idcarro = value; }
        public static string Modelo { get => modelo; set => modelo = value; }
        public static string Ano { get => ano; set => ano = value; }
        public static Array Imagem { get => imagem; set => imagem = value; }
        public static string Preco { get => preco; set => preco = value; }
        public static string Marca { get => marca; set => marca = value; }
        public static string Disponivel { get => disponivel; set => disponivel = value; }
        public static string Retorno { get => retorno; set => retorno = value; }
    }
}
