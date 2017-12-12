using Mochila.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IaMochila.Model
{
    
    class ObjMochila
    {
        ObjParameters objParameters;
        private int Peso;
        private int Valor;
        private List<int> listItens = new List<int>();

        public ObjMochila() { }
        public ObjMochila(int pesoMaximo, int objetoPesoMinimo, int objetoValorMaximo) {
            while((this.Peso + objetoPesoMinimo) <= pesoMaximo)
            {
                this.Peso += objetoPesoMinimo;
                this.Valor += objetoValorMaximo;
            }
        }

        public string Nome { get; set; }

        public List<int> ListItens {
            get {
                return this.listItens;
            } set {
                for(int i = 0; i<value.Count; i++)
                {
                    addItens(i, value[i]);
                }
            }
        }


        public int getPeso()
        {
            return this.Peso;
        }

        public int getValor()
        {
            return this.Valor;
        }

        public void addItens(int index, int value) {
            objParameters = new ObjParameters();
            ObjItem objItem = objParameters.GetItens()[index];
           
            if (value == 1)
            {
                this.Peso += objItem.Peso;
                this.Valor += objItem.Valor;
            }
            this.listItens.Add(value);
        }

        public void removeItens(int index)
        {
            objParameters = new ObjParameters();
            ObjItem objItem = objParameters.GetItens()[index];
            this.Peso -= objItem.Peso;
            this.Valor -= objItem.Valor;
            this.listItens[index] = 0;
        }

        public int getPercentOtimo()
        {
            int percentValor = (this.Valor * 100) / objParameters.MelhorMochilaPossivel.Valor;
            int percentPeso = (this.Peso * 100) / objParameters.MelhorMochilaPossivel.Peso;

            percentPeso = percentPeso > 100 ? 0 : percentPeso;

            return (percentValor+ percentPeso)-100;
        }
    }
}
