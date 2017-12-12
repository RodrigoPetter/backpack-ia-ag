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

namespace IaMochila
{
    public partial class Form_Parametros : Form
    {
        

        public Form_Parametros()
        {
            InitializeComponent();
            ObjParameters objParameters = new ObjParameters();
            PesoMaxMochilas.Text = objParameters.PesoMaxMochilas.ToString();
            NumeroObjetos.Text = objParameters.NumeroObjetos.ToString();
            ValorMinObjetos.Text = objParameters.ValorMinObjetos.ToString();
            ValorMaxObjetos.Text = objParameters.ValorMaxObjetos.ToString();
            PesoMinObjetos.Text = objParameters.PesoMinObjetos.ToString();
            PesoMaxObjetos.Text = objParameters.PesoMaxObjetos.ToString();
            TamanhoPopulacao.Text = objParameters.TamanhoPopulacao.ToString();
            NumeroGeracoes.Text = objParameters.NumeroGeracoes.ToString();
            MelhoresPais.Text = objParameters.MelhoresPais.ToString();
            TaxaMutacao.Text = objParameters.TaxaMutacao.ToString();
            percentOtimo.Text = objParameters.PercentOtimo.ToString();
        }
        

        private void Form_Parametros_Load(object sender, EventArgs e)
        {



        }


        private void button_Salvar_Click(object sender, EventArgs e)
        {
            ObjParameters objParameters = new ObjParameters();
            objParameters.PesoMaxMochilas = int.Parse(PesoMaxMochilas.Text);
            objParameters.NumeroObjetos = int.Parse(NumeroObjetos.Text);
            objParameters.ValorMinObjetos = int.Parse(ValorMinObjetos.Text);
            objParameters.ValorMaxObjetos = int.Parse(ValorMaxObjetos.Text);
            objParameters.PesoMinObjetos = int.Parse(PesoMinObjetos.Text);
            objParameters.PesoMaxObjetos = int.Parse(PesoMaxObjetos.Text);
            objParameters.TamanhoPopulacao = int.Parse(TamanhoPopulacao.Text);
            objParameters.NumeroGeracoes = int.Parse(NumeroGeracoes.Text);
            objParameters.MelhoresPais = int.Parse(MelhoresPais.Text);
            objParameters.TaxaMutacao = int.Parse(TaxaMutacao.Text);
            objParameters.PercentOtimo = int.Parse(percentOtimo.Text);
            this.Visible = false;
        }
    }
}
