using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class SistemaBinario : Numeracion
    {
        public SistemaBinario(string valor) : base(valor)
        {
        }

        internal override string ValorNumerico => throw new NotImplementedException();

        public Numeracion CambiarSistemaDeNumeracion(ESistema sistema)
        {
            switch (sistema) 
            {
                case ESistema.Binario:
                    return new SistemaBinario(valor);
                case ESistema.Decimal: 
                    return new SistemaDecimal(valor);
                case ESistema.Octal:
                    break;
            }
        }

        protected bool EsNumeracionValida(string valor)
        {
            if (!string.IsNullOrEmpty(valor) && EsSistemaBinarioValido(valor))
            {
                return true;
            } 
            return false;
        }

        private bool EsSistemaBinarioValido(string valor)
        {
            for (int i = 0; i < valor.Length; i++)
            {
                if (valor[i] != '1' && valor[i] != 0)
                {
                    return false;
                }
            }
            return true;
        }

        private SistemaDecimal BinarioADecimal()
        {
            
        }

        public static implicit operator SistemaBinario(string valor)
        {
            return new SistemaBinario(valor);
        }

    }
}
