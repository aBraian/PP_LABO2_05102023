using Microsoft.VisualBasic;
using System.Net;

namespace Entidades
{

    public abstract class Numeracion
    {

        //Atributos
        protected static string msgError;
        protected string valor = "";

        //Constructores
        static Numeracion()
        {
            msgError = "Numero Invalido";
        }

        protected Numeracion(string valor)
        {
            InicializaValor(valor);
        }

        //Propiedades
        public string Valor
        {
            get
            {
                return valor;
            }
        }

        internal abstract double ValorNumerico
        {
            get;
        }
        
        //Metodos
        public abstract Numeracion CambiarSistemaDeNumeracion(ESistema sistema);

        protected virtual bool EsNumeracionValida(string valor)
        {
            return !string.IsNullOrWhiteSpace(valor);
        }

        private void InicializaValor(string valor)
        {
            if (EsNumeracionValida(valor))
            {
                this.valor = valor;
            }
            else
            {
                this.valor = "Numero Invalido";
            }
        }

        //Sobrecargas
        public static bool operator ==(Numeracion n1, Numeracion n2)
        {
            if (n1 is null || n2 is null)
            {
                return false;
            }
            return n1.GetType() == n2.GetType();
        }

        public static bool operator !=(Numeracion n1, Numeracion n2)
        {
            return !(n1 == n2);
        }

        public static explicit operator double(Numeracion numeracion)
        {
            if (numeracion is not null && double.TryParse(numeracion.valor, out double esNumerico))
            {
                return esNumerico;
            }
            return double.NaN;
        }

        public override bool Equals(object? obj)
        {
            return obj is Numeracion numeracion &&
                   valor == numeracion.valor &&
                   Valor == numeracion.Valor &&
                   ValorNumerico == numeracion.ValorNumerico;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(valor, Valor, ValorNumerico);
        }

    }
}
