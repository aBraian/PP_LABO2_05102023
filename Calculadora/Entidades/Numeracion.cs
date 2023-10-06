using Microsoft.VisualBasic;
using System.Net;

namespace Entidades
{

    //Enumerador
    public enum ESistema
    {
        Binario,
        Decimal,
        Octal
    }

    public abstract class Numeracion
    {

        //Atributos
        protected static string msgError;
        protected string valor;

        //Constructores
        static Numeracion()
        {
            msgError = "Numero Invalido";
        }

        protected Numeracion(string valor)
        {
            this.valor = valor;//Regresar
        }

        //Propiedades
        public string Valor
        {
            get
            {
                return valor;
            }
        }

        internal abstract string ValorNumerico
        {
            get;
        }

        //Metodos
        protected bool esNumeracionValida(string valor)
        {
            return !string.IsNullOrWhiteSpace(valor);
        }

        private void InicializaValor(string valor)
        {
            if (esNumeracionValida(valor))
            {
                this.valor = valor;
            }
            else
            {
                this.valor = "Numero Invalido";
            }
        }

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

        public override bool Equals(object? obj)
        {
            Numeracion? numeracion = obj as Numeracion;
            return numeracion is not null && this == numeracion;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public static explicit operator double(Numeracion numeracion)
        {
            if (numeracion is not null && double.TryParse(numeracion.valor, out double esNumerico))
            {
                return esNumerico;
            }
            return 0d;
        }

    }
}