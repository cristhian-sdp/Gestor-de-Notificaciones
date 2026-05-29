using System;

namespace CasoPracticoS1
{
    public class Lista
    {
        private Nodo cabeza;
        private int _tamaño;

        public int Tamaño
        {
            get { return _tamaño; }
        }

        public Lista()
        {
            cabeza = null;
            _tamaño = 0;
        }

        /// <summary>
        /// Inserta al inicio de la lista. Complejidad temporal: O(1).
        /// </summary>
        public void AnexarInicio(int monto)
        {
            Nodo nuevoNodo = new Nodo(monto);
            nuevoNodo.Siguiente = cabeza;
            cabeza = nuevoNodo;
            _tamaño++;
        }

        /// <summary>
        /// Inserta al final de la lista. Complejidad temporal: O(n).
        /// </summary>
        public void AnexarFinal(int monto)
        {
            Nodo nuevoNodo = new Nodo(monto);
            if (cabeza == null)
            {
                cabeza = nuevoNodo;
            }
            else
            {
                Nodo actual = cabeza;
                while (actual.Siguiente != null)
                {
                    actual = actual.Siguiente;
                }
                actual.Siguiente = nuevoNodo;
            }
            _tamaño++;
        }

        /// <summary>
        /// Inserta en una posición específica (0 = inicio). Complejidad temporal: O(n).
        /// </summary>
        public bool AnexarPosicion(int monto, int pos)
        {
            if (pos < 0 || pos > _tamaño) return false;

            if (pos == 0)
            {
                AnexarInicio(monto);
                return true;
            }

            Nodo nuevoNodo = new Nodo(monto);
            Nodo actual = cabeza;
            for (int i = 0; i < pos - 1; i++)
            {
                actual = actual.Siguiente;
            }

            nuevoNodo.Siguiente = actual.Siguiente;
            actual.Siguiente = nuevoNodo;
            _tamaño++;
            return true;
        }

        /// <summary>
        /// Elimina el primer nodo. Complejidad temporal: O(1).
        /// </summary>
        public bool BorrarInicio()
        {
            if (cabeza == null) return false;
            cabeza = cabeza.Siguiente;
            _tamaño--;
            return true;
        }

        /// <summary>
        /// Elimina el último nodo. Complejidad temporal: O(n).
        /// </summary>
        public bool BorrarFinal()
        {
            if (cabeza == null) return false;

            if (cabeza.Siguiente == null)
            {
                cabeza = null;
            }
            else
            {
                Nodo actual = cabeza;
                while (actual.Siguiente.Siguiente != null)
                {
                    actual = actual.Siguiente;
                }
                actual.Siguiente = null;
            }
            _tamaño--;
            return true;
        }

        /// <summary>
        /// Elimina la primera ocurrencia del monto. Complejidad temporal: O(n).
        /// </summary>
        public bool BorrarDato(int monto)
        {
            if (cabeza == null) return false;

            if (cabeza.Monto == monto)
            {
                return BorrarInicio();
            }

            Nodo actual = cabeza;
            while (actual.Siguiente != null && actual.Siguiente.Monto != monto)
            {
                actual = actual.Siguiente;
            }

            if (actual.Siguiente == null) return false;

            actual.Siguiente = actual.Siguiente.Siguiente;
            _tamaño--;
            return true;
        }

        /// <summary>
        /// Busca un nodo por su monto. Complejidad temporal: O(n).
        /// </summary>
        public Nodo BuscarNodo(int monto)
        {
            Nodo actual = cabeza;
            while (actual != null)
            {
                if (actual.Monto == monto) return actual;
                actual = actual.Siguiente;
            }
            return null;
        }

        /// <summary>
        /// Devuelve la posición de la primera ocurrencia del monto. Complejidad temporal: O(n).
        /// </summary>
        public int BuscarPosicion(int monto)
        {
            Nodo actual = cabeza;
            int pos = 0;
            while (actual != null)
            {
                if (actual.Monto == monto) return pos;
                actual = actual.Siguiente;
                pos++;
            }
            return -1;
        }

        /// <summary>
        /// Devuelve una representación en string de la lista. Complejidad temporal: O(n).
        /// </summary>
        public string Imprimir()
        {
            if (cabeza == null) return "[ ]";

            string resultado = "[ ";
            Nodo actual = cabeza;
            while (actual != null)
            {
                resultado += actual.Monto;
                if (actual.Siguiente != null)
                {
                    resultado += "->";
                }
                actual = actual.Siguiente;
            }
            resultado += " ]";
            return resultado;
        }

        /// <summary>
        /// Ordena la lista (Merge Sort). Complejidad temporal: O(n log n).
        /// </summary>
        public void Ordenar()
        {
            cabeza = MergeSort(cabeza);
        }

        private Nodo MergeSort(Nodo inicio)
        {
            if (inicio == null || inicio.Siguiente == null)
            {
                return inicio;
            }

            Nodo medio = GetMedio(inicio);
            Nodo mitadSiguiente = medio.Siguiente;
            medio.Siguiente = null;

            Nodo izq = MergeSort(inicio);
            Nodo der = MergeSort(mitadSiguiente);

            return Merge(izq, der);
        }

        private Nodo GetMedio(Nodo inicio)
        {
            if (inicio == null) return inicio;

            Nodo lento = inicio;
            Nodo rapido = inicio;

            while (rapido.Siguiente != null && rapido.Siguiente.Siguiente != null)
            {
                lento = lento.Siguiente;
                rapido = rapido.Siguiente.Siguiente;
            }
            return lento;
        }

        private Nodo Merge(Nodo a, Nodo b)
        {
            if (a == null) return b;
            if (b == null) return a;

            Nodo resultado = null;

            if (a.Monto <= b.Monto)
            {
                resultado = a;
                resultado.Siguiente = Merge(a.Siguiente, b);
            }
            else
            {
                resultado = b;
                resultado.Siguiente = Merge(a, b.Siguiente);
            }
            return resultado;
        }

        /// <summary>
        /// Mezclar dos listas ordenadas. Complejidad temporal: O(n + m).
        /// </summary>
        public Lista Mezclar(Lista otra)
        {
            Lista nuevaLista = new Lista();
            nuevaLista.cabeza = Merge(this.cabeza, otra.cabeza);

            // Recalcular tamaño
            int cont = 0;
            Nodo act = nuevaLista.cabeza;
            while(act != null) {
                cont++;
                act = act.Siguiente;
            }
            nuevaLista._tamaño = cont;

            return nuevaLista;
        }

        /// <summary>
        /// Método auxiliar para UI para recorrer y no usar colecciones.
        /// Devuelve un array con los montos en orden.
        /// </summary>
        public int[] ObtenerMontos()
        {
            int[] montos = new int[_tamaño];
            Nodo act = cabeza;
            int i = 0;
            while(act != null)
            {
                montos[i] = act.Monto;
                act = act.Siguiente;
                i++;
            }
            return montos;
        }

        public void CargarArreglo(int[] arr)
        {
            foreach(var item in arr)
            {
                AnexarFinal(item);
            }
        }

        public void Vaciar()
        {
            cabeza = null;
            _tamaño = 0;
        }
    }
}