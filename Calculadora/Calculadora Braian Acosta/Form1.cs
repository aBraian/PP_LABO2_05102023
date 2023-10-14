using Entidades;
using System.ComponentModel;

namespace Calculadora_Braian_Acosta
{
    public partial class frmCalculadora : Form
    {

        //Atributos
        private Calculadora calculadora;
        //private IContainer components;

        //Constructor
        public frmCalculadora()
        {
            this.calculadora = new Calculadora("Braian Acosta");
            InitializeComponent();
        }

        //Metodos
        private void MostrarHistorial()
        {
            this.lstHistorial.DataSource = null;
            this.lstHistorial.DataSource = this.calculadora.Operaciones;
        }

        private Numeracion GetOperando(string value)
        {
            if (Calculadora.Sistema == ESistema.Binario)
            {
                return new SistemaBinario(value);
            }
            else if (Calculadora.Sistema == ESistema.Octal)
            {
                return new SistemaOctal(value);
            }
            return new SistemaDecimal(value);
        }

        //Eventos
        private void frmCalculadora_Load(object sender, EventArgs e)
        {
            this.cmbOperacion.DataSource = new char[] { '+', '-', '*', '/' };
        }

        private void btnOperar_Click(object sender, EventArgs e)
        {
            char operador;
            calculadora.PrimerOperando = this.GetOperando(this.txtPrimerOperando.Text);
            calculadora.SegundoOperando = this.GetOperando(this.txtSegundoOperando.Text);
            operador = (char)this.cmbOperacion.SelectedItem;
            this.calculadora.Calcular(operador);
            this.calculadora.ActualizaHistorialDeOperaciones(operador);
            this.lblResultado.Text = $"Resultado:{calculadora.Resultado.Valor}";
            this.MostrarHistorial();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            this.calculadora.EliminarHistorialDeOperaciones();
            this.txtPrimerOperando.Text = string.Empty;
            this.txtSegundoOperando.Text = string.Empty;
            this.lblResultado.Text = $"Resultado:";
            this.MostrarHistorial();
        }

        private void rdbDecimal_CheckedChanged(object sender, EventArgs e)
        {
            Calculadora.Sistema = ESistema.Decimal;
        }

        private void rdbBinario_CheckedChanged(object sender, EventArgs e)
        {
            Calculadora.Sistema = ESistema.Binario;
        }

        private void rdbOctal_CheckedChanged(object sender, EventArgs e)
        {
            Calculadora.Sistema = ESistema.Octal;
        }

        private void frmCalculadora_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }

        private void frmCalculadora_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Desea cerrar la calculadora?", "Cierre", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

    }
}