using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class SistemaOctal : Numeracion
    {

        //Constructor
        public SistemaOctal(string valor) : base(valor)
        {

        }

        //Propiedad
        internal override double ValorNumerico
        {
            get
            {
                return (double)CambiarSistemaDeNumeracion(ESistema.Decimal);
            }
        }

        //Metodos
        public override Numeracion CambiarSistemaDeNumeracion(ESistema sistema)
        {
            switch (sistema)
            {
                case ESistema.Decimal:
                    return OctalADecimal();
            }
            return this;
        }

        protected override bool EsNumeracionValida(string valor)
        {
            if (base.EsNumeracionValida(valor) && !string.IsNullOrEmpty(valor) && EsSistemaOctalValido(valor))
            {
                return true;
            }
            return false;
        }

        private bool EsSistemaOctalValido(string valor)
        {
            foreach (char digito in valor)
            {
                if (digito < '0' || digito > '7')
                {
                    return false;
                }
            }
            return true;
        }

        private SistemaDecimal OctalADecimal()
        {
            SistemaDecimal numeroDecimal;
            if (Valor != msgError && EsNumeracionValida(Valor))
            {
                int posicion = 0;
                double conversionADecimal = 0;
                for (int i = Valor.Length - 1; i >= 0; i--)
                {
                    double.TryParse(Valor[i].ToString(), out double numeroOctal);
                    conversionADecimal += numeroOctal * Math.Pow(8, posicion);
                    posicion++;
                }
                numeroDecimal = conversionADecimal;
            }
            else
            {
                numeroDecimal = double.MinValue;
            }
            return numeroDecimal;
        }

        //Sobrecargas
        public static implicit operator SistemaOctal(string valor)
        {
            return new SistemaOctal(valor);
        }

    }
}
