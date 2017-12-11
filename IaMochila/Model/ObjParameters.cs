using IaMochila.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mochila.Model
{
    class ObjParameters
    {
            private static int pesoMaxMochilas = 200;
            private static int numeroObjetos = 100;
            private static int valorMinObjetos = 1;
            private static int valorMaxObjetos = 30;
            private static int pesoMinObjetos = 1;
            private static int pesoMaxObjetos = 20;
            private static int tamanhoPopulacao = 100;
            private static int numeroGeracoes = 1000;
            private static int melhoresPais = 10;
            private static int taxaMutacao = 15;

            private static int index = 0;


        private static List<ObjItem> itens = new List<ObjItem>();
        private static List<ObjMochila> mochilas = new List<ObjMochila>();

        public int PesoMaxMochilas { get => pesoMaxMochilas; set => pesoMaxMochilas = value; }
        public int NumeroObjetos { get => numeroObjetos; set => numeroObjetos = value; }
        public int ValorMinObjetos { get => valorMinObjetos; set => valorMinObjetos = value; }
        public int ValorMaxObjetos { get => valorMaxObjetos; set => valorMaxObjetos = value; }
        public int PesoMinObjetos { get => pesoMinObjetos; set => pesoMinObjetos = value; }
        public int PesoMaxObjetos { get => pesoMaxObjetos; set => pesoMaxObjetos = value; }
        public int TamanhoPopulacao { get => tamanhoPopulacao; set => tamanhoPopulacao = value; }
        public int NumeroGeracoes { get => numeroGeracoes; set => numeroGeracoes = value; }
        public int MelhoresPais { get => melhoresPais; set => melhoresPais = value; }
        public int TaxaMutacao { get => taxaMutacao; set => taxaMutacao = value; }
        public int Index { get => index; set => index = value; }

        public void CommitListItem(List<ObjItem> lista) {
            itens = lista;
        }
        public List<ObjItem> GetItens()
        {
            return itens;
        }

        public void CommitListMochila(List<ObjMochila> lista)
        {
            mochilas = lista;
        }
        public List<ObjMochila> GetMochilas()
        {
            return mochilas;
        }

        public ObjParameters(){}

        


    }
}
