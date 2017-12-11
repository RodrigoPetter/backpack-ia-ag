using Mochila.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IaMochila.Model
{
    class ListObjItem : List<ObjItem>
    {

        ObjParameters objParameters = new ObjParameters();
        Random rnd = new Random();
        public ListObjItem() {

            for (int i = 0; i < objParameters.NumeroObjetos; i++) {
                this.Add(new ObjItem()
                {
                    Nome  = "Item-"+i,
                    Peso  = rnd.Next(objParameters.PesoMinObjetos, objParameters.PesoMaxObjetos),  // creates a number between 1 and 12
                    Valor = rnd.Next(objParameters.ValorMinObjetos, objParameters.ValorMaxObjetos) // creates a number between 1 and 12
            });
            }
        }

        public void CommitList()
        {
            objParameters.CommitListItem(this);
        }
    }
}
