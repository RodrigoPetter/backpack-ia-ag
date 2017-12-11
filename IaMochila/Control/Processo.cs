using IaMochila.Model;
using Mochila.Model;
using System;
using System.Collections.Generic;
using System.Linq;

using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IaMochila.Control
{
    class Processo
    {
        ObjParameters objParameters = new ObjParameters();
        List<ObjMochila> mochilas;
        Random rdm = new Random();

        public Processo()
        {
            this.mochilas = objParameters.GetMochilas();
            OrdenarByValor();
            for (int i = 0; i < objParameters.NumeroGeracoes; i++)
            {            
                List<ObjMochila> novasMochilas = Cruzamento();
                mochilas.AddRange(novasMochilas);
                OrdenarByValor();
                EliminarPiores(novasMochilas.Count);
            }
            OrdenarByValor();
            objParameters.CommitListMochila(mochilas);

            Console.WriteLine(objParameters.QtdMutacoes);
        }

        private void EliminarPiores(int qtdEliminar)
        {
            if (qtdEliminar <= 0)
                return;

            int remover = mochilas.Count - qtdEliminar;

            for (int i = mochilas.Count-1; i >= remover ; i--)
            {
                mochilas.RemoveAt(i);
            }
        }

        private List<ObjMochila> Cruzamento()
        {
            int total = objParameters.MelhoresPais;
            List<ObjMochila> novasMochilas = new List<ObjMochila>();

            for (int i = 0; i < total; i++)
            {
                int index1 = i;
                int index2 = i+1;
                
                ObjMochila mochila1 = mochilas[index1];
                ObjMochila mochila2 = mochilas[index2];

                novasMochilas.Add(mochilaFilha(mochila1, mochila2));
                objParameters.Index += 1;
                novasMochilas.Add(mochilaFilha(mochila2, mochila1));
                objParameters.Index += 1;

            }

            return novasMochilas;
        }

        private ObjMochila mochilaFilha(ObjMochila mochila1, ObjMochila mochila2)
        {
            ObjMochila nova = new ObjMochila();
            nova.Nome = "Mochila-" + (objParameters.Index + 1);
            for (int a = 0; a < mochila1.ListItens.Count; a++)
            {
                if (mochila1.ListItens[a] % 2 == 0)
                {
                    nova.addItens(a, Mutacao(mochila1.ListItens[a]));
                }
                else
                {
                    nova.addItens(a, Mutacao(mochila2.ListItens[a]));
                }
            }
            return nova;
        }

        private int Mutacao(int value)
        {
            
            int numero = rdm.Next(0, 100);
            if (numero <= objParameters.TaxaMutacao)
            {

                objParameters.QtdMutacoes++;

                if (value == 1)
                {
                    value = 0;
                }
                else
                {
                    value = 1;
                }
            }
            return value;
        }



        private void OrdenarByValor()
        {
            ObjMochila MochilaMaiorValor;
            List<ObjMochila> mochilas_aux = new List<ObjMochila>();

            for (int i = 1; i < mochilas.Count; i++)
            {
                //Ordena por valor
                for (int a = 0; a < mochilas.Count; a++)
                {
                    if (mochilas[i].getValor() > mochilas[a].getValor())
                    {
                        MochilaMaiorValor = mochilas[i];
                        mochilas[i] = mochilas[a];
                        mochilas[a] = MochilaMaiorValor;
                    }
                }
            }

            //Se os valores forem iguais então deixa o menor peso na parte de cima.
            for (int i = 1; i < mochilas.Count; i++)
            {
                for (int a = 0; a < mochilas.Count; a++)
                {
                    if (mochilas[i].getValor() == mochilas[a].getValor())
                    {
                        if (mochilas[i].getPeso() < mochilas[a].getPeso())
                        {
                            MochilaMaiorValor = mochilas[i];
                            mochilas[i] = mochilas[a];
                            mochilas[a] = MochilaMaiorValor;
                        }
                    }
                }
            }

            for (int i = 0; i < mochilas.Count; i++)
            {
                //Se os valores forem iguais então deixa o menor peso na parte de cima.
                if (mochilas[i].getPeso() > objParameters.PesoMaxMochilas)
                {
                    mochilas_aux.Add(mochilas[i]);
                    mochilas.RemoveAt(i);
                    i--;
                }
            }


            if (mochilas.Count == 0)
            {
                for (int i = 0; i < mochilas_aux.Count; i++)
                {
                    mochilas.Insert(0, mochilas_aux[i]);                   
                }
            }
            else
            {
                for (int i = 0; i < mochilas_aux.Count; i++)
                {
                    mochilas.Add(mochilas_aux[i]);
                }
            }
        }




    }
}
