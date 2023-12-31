﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class SistemaBinario : Numeracion
    {

        //Constructor
        public SistemaBinario(string valor) : base(valor)
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
                    return BinarioADecimal();
            }
            return this;
        }

        protected override bool EsNumeracionValida(string valor)
        {
            if (base.EsNumeracionValida(valor) && !string.IsNullOrEmpty(valor) && EsSistemaBinarioValido(valor))
            {
                return true;
            }
            return false;
        }

        private bool EsSistemaBinarioValido(string valor)
        {
            foreach (char digito in valor)
            {
                if (digito != '0' && digito != '1')
                {
                    return false;
                }
            }
            return true;
        }

        private SistemaDecimal BinarioADecimal()
        {
            SistemaDecimal numeroDecimal;
            if (Valor != msgError && EsNumeracionValida(Valor))
            {
                int posicion = 0;
                double conversionADecimal = 0;
                for (int i = Valor.Length - 1; i >= 0; i--)
                {
                    double.TryParse(Valor[i].ToString(), out double numeroBinario);
                    conversionADecimal += numeroBinario * Math.Pow(2, posicion);
                    posicion++;
                }
                numeroDecimal = conversionADecimal;
            }
            else
            {
                numeroDecimal = Double.MinValue;
            }
            return numeroDecimal;
        }

        //Sobrecargas
        public static implicit operator SistemaBinario(string valor)
        {
            return new SistemaBinario(valor);
        }

    }
}
