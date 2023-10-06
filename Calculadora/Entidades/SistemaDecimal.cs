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
        public SistemaDecimal(string valor) : base(valor)
        {
        }

        internal override string ValorNumerico
        {
            get
            {
                return valor;
            }
        }

        protected bool EsNumeracionValida(string valor)
        {
            if (!string.IsNullOrEmpty(valor) && EsSistemaDecimalValido(valor))
            {
                return true;
            }
            return false;
        }

        private bool EsSistemaDecimalValido(string valor)
        {
            return double.TryParse(valor, out double _);
        }

        private SistemaBinario DecimalABinario()
        {

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
