using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Calculadora
    {

        private string nombreAlumno;
        private List<string> operaciones;
        private Numeracion primerOperando;
        private Numeracion segundoOperando;
        private Numeracion resultado;
        private static ESistema sistema;

        //Constructores
        static Calculadora()
        {
            sistema = ESistema.Decimal;
        }

        public Calculadora()
        {
            operaciones = new List<string>();
        }

        public Calculadora(string nombreAlumno) : this()
        {
            NombreAlumno = nombreAlumno;
        }

        //Propiedades
        public string NombreAlumno
        {
            get
            {
                return nombreAlumno;
            }
            set
            {
                bool validacionNombre = false;
                if (!string.IsNullOrEmpty(value))
                {
                    validacionNombre = true;
                    foreach (char caracter in value)
                    {
                        if (!char.IsLetter(caracter) && caracter != ' ')
                        {
                            validacionNombre = false;
                            break;
                        }
                    }
                }
                if (validacionNombre)
                {
                    nombreAlumno = value;
                }
            }
        }

        public List<string> Operaciones
        {
            get
            {
                return operaciones;
            }
        }

        public Numeracion PrimerOperando
        {
            get
            {
                return primerOperando;
            }
            set
            {
                primerOperando = value;
            }
        }

        public Numeracion Resultado
        {
            get
            {
                return resultado;
            }
        }

        public Numeracion SegundoOperando
        {
            get
            {
                return segundoOperando;
            }
            set
            {
                segundoOperando = value;
            }
        }

        static public ESistema Sistema
        {
            get
            {
                return sistema;
            }
            set
            {
                sistema = value;
            }
        }

        //Metodos
        public void Calcular()
        {
            Calcular('+');
        }

        public void Calcular(char operador)
        {
            double aux = double.MinValue;
            if (primerOperando == segundoOperando)
            {
                switch (operador)
                {
                    case '+':
                        aux = primerOperando.ValorNumerico + segundoOperando.ValorNumerico;
                        break;
                    case '-':
                        aux = primerOperando.ValorNumerico - segundoOperando.ValorNumerico;
                        break;
                    case '*':
                        aux = primerOperando.ValorNumerico * segundoOperando.ValorNumerico;
                        break;
                    case '/':
                        aux = primerOperando.ValorNumerico / segundoOperando.ValorNumerico;
                        break;
                }
            }
            resultado = MapeaResultado(aux);
        }

        private Numeracion MapeaResultado(double valor)
        {
            SistemaDecimal retorno = valor;
            return retorno.CambiarSistemaDeNumeracion(Sistema);
        }

        public void ActualizaHistorialDeOperaciones(char operador)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"Sistema {Sistema} -> {primerOperando.Valor} {operador} {segundoOperando.Valor} = {resultado.Valor}");
            operaciones.Add(sb.ToString());
        }

        public void EliminarHistorialDeOperaciones()
        {
            operaciones.Clear();
        }

    }
}
