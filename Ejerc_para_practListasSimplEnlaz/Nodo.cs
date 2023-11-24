using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejerc_para_practListasSimplEnlaz
{
    public class Nodo
    {
        private int _valor;
        private Nodo _Siguiente;

        public Nodo(int valor) 
        {
            _valor = valor;
            _Siguiente = null;
        }

        public Nodo(int valor, Nodo siguiente)
        {
            _valor = valor;
            _Siguiente = siguiente;
        }

        public int getValor()
        {
            return _valor;
        }

        public Nodo getSiguiente()
        {
            return _Siguiente;
        }

        public void setSiguiente(Nodo siguiente)
        {
            _Siguiente = _Siguiente;
        }
    }
}
