using IaMochila.Control;
using IaMochila.Model;
using Mochila.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IaMochila.View
{
    public partial class Resultados : Form
    {
        

        public Resultados()
        {
            InitializeComponent();
        }

        private void button_GerarItens_Click(object sender, EventArgs e)
        {
            ListObjItem itens = new ListObjItem();
            itens.CommitList();
            int ValorItem = 0;
            int PesoItem = 0;
            listBox_Itens.Items.Clear();
            itens.ForEach(delegate (ObjItem item) {
                listBox_Itens.Items.Add(item.Nome+" = "+ item.Peso+"Kg - R$ "+item.Valor);
                ValorItem += item.Valor;
                PesoItem += item.Peso;
            });
            ValorCol1.Text = "R$ " + ValorItem.ToString();
            PesoCol1.Text = PesoItem.ToString() + " Kg";

        }

        private void Resultados_Load(object sender, EventArgs e)
        {
            
        }

        private void button_AprimorarPopulacao_Click(object sender, EventArgs e)
        {
            ObjParameters parameters = new ObjParameters();
            ListObjMochila objMochila = new ListObjMochila();
            objMochila.CommitList();
            
            listBox_Mochilas.Items.Clear();
            
            parameters.GetMochilas().ForEach(delegate (ObjMochila mochila) {
                listBox_Mochilas.Items.Add(mochila.Nome + " = " + mochila.getPeso() + "Kg - R$ " + mochila.getValor());
            });
        }

        private void listBox_Mochilas_SelectedIndexChanged(object sender, EventArgs e)
        {
            int indexMochila = listBox_Mochilas.SelectedIndex;

            ObjParameters parameters = new ObjParameters();

            ObjMochila objMochila = parameters.GetMochilas()[indexMochila];

            listBox_Itens_Mochila.Items.Clear();
            for (int i = 0; i < objMochila.ListItens.Count; i++)
            {
                if (objMochila.ListItens[i] == 1)
                {
                    ObjItem item = parameters.GetItens()[i];
                    listBox_Itens_Mochila.Items.Add(item.Nome + " = " + item.Peso + "Kg - R$ " + item.Valor);
                }

            }


        }

        private void button1_config_Click(object sender, EventArgs e)
        {
            Form_Parametros form_Parametros = new Form_Parametros();
            form_Parametros.Visible = true;
        }

        private void button_Processar_Click(object sender, EventArgs e)
        {
            Processo processo = new Processo();
            ObjParameters parameters = new ObjParameters();
            listBox_Mochilas_best.Items.Clear();

            parameters.GetMochilas().ForEach(delegate (ObjMochila mochila) {
                listBox_Mochilas_best.Items.Add(mochila.Nome + " = " + mochila.getPeso() + "Kg - R$ " + mochila.getValor());
            });

            Console.WriteLine(parameters.QtdMutacoes);
            mutacoesLabel.Text = "Mutações: " + parameters.QtdMutacoes;
        }


        private void listBox_Mochilas_best_SelectedIndexChanged(object sender, EventArgs e)
        {
            ObjParameters parameters = new ObjParameters();
            string conteudo = listBox_Mochilas_best.SelectedItem.ToString();
            int ini = conteudo.IndexOf(" =");
            int fin = conteudo.Length - ini;

            string aux = conteudo.Substring(ini, fin);
            conteudo = conteudo.Replace(aux,"");
            ObjMochila objMochila = parameters.GetMochilas().Single(s => s.Nome == conteudo);

            listBox_bestItens.Items.Clear();
            for (int i = 0; i < objMochila.ListItens.Count; i++)
            {
                if (objMochila.ListItens[i] == 1)
                {
                    ObjItem item = parameters.GetItens()[i];
                    listBox_bestItens.Items.Add(item.Nome + " = " + item.Peso + "Kg - R$ " + item.Valor);
                }

            }
        }
    }
}
