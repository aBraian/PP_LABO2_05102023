using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class SistemaDecimal : Numeracion
    {

        //Constructor
        public SistemaDecimal(string valor) : base(valor)
        {

        }

        //Propiedades
        internal override double ValorNumerico
        {
            get
            {
                return (double)this;
            }
        }

        //Metodos
        public override Numeracion CambiarSistemaDeNumeracion(ESistema sistema)
        {
            switch (sistema)
            {
                case ESistema.Binario:
                case ESistema.Octal:
            }
        }

        protected override bool EsNumeracionValida(string valor)
        {
            if (base.EsNumeracionValida(valor) && !string.IsNullOrEmpty(valor) && EsSistemaDecimalValido(valor))
            {
                return true;
            }
            return false;
        }

        private bool EsSistemaDecimalValido(string valor)
        {
            return double.TryParse(valor, out _);
        }

        private SistemaBinario DecimalABinario()
        {
            if (this.ValorNumerico > 0)
            {
                int parteEntera = (int)Math.Floor(this.ValorNumerico);
                int resto;
                string numeroBinario = "";
                while (parteEntera != 0)
                {
                    resto = parteEntera % 2;
                    numeroBinario = resto.ToString() + numeroBinario;
                    parteEntera /= 2;
                }
                return new SistemaBinario(numeroBinario);
            }
            return new SistemaBinario(msgError);
        }

        private SistemaOctal DecimalAOctal()
        {

        }

        public static implicit operator SistemaDecimal(double valor)
        {
            return new SistemaDecimal(valor.ToString());
        }

        public static implicit operator SistemaDecimal(string valor)
        {
            return new SistemaDecimal(valor);
        }

    }
}
