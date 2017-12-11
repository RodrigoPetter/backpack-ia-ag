using Mochila.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IaMochila.Model
{
    class ListObjMochila : List<ObjMochila>
    {
        ObjParameters objParameters = new ObjParameters();
        Random rnd = new Random();
        public ListObjMochila()
        {

            for (int i = 0; i < objParameters.TamanhoPopulacao; i++)
            {
                List<int> listitens = new List<int>();
                for (int a = 0; a < objParameters.NumeroObjetos; a++)
                {
                    listitens.Add(rnd.Next(0, 2)); 
                }
                objParameters.Index += 1;
                this.Add(new ObjMochila()
                {
                    Nome = "Mochila-" + objParameters.Index,
                    ListItens = listitens
                });
                
            }
        }

        public void CommitList()
        {
            objParameters.CommitListMochila(this);
        }







    }
}
