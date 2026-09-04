using System;
using System.Collections.Generic;
using System.Text;

namespace GuiaLab1
{
    class ListaEnlazadaTickets
    {
        // Variables empleadas para la lista enlazada
        private Nodo cabeza, ultimo, temp;
        public ListaEnlazadaTickets()
        {
            // Inicializa la lista enlazada con la cabeza en null
            cabeza = null;
        }
        public bool insertarNodo(Nodo nuevo)
        {
            // Nodo temporal creado para evitar duplicados
            Nodo duplicado = cabeza;

            // Si la lista está vacía, el nuevo nodo se convierte en la cabeza y el último nodo
            if (cabeza == null)
            {
                cabeza = nuevo;
                cabeza.Referencia = null;
                ultimo = cabeza;
                return true;
            }
            // Si la lista no está vacía, se agrega el nuevo nodo al final
            else
            {
                while (duplicado != null)
                {
                    if (duplicado.Codigo == nuevo.Codigo)
                    {
                        nuevo = null;
                        return false;
                    }
                    else
                    {
                        duplicado = duplicado.Referencia;
                    }
                }

                ultimo.Referencia = nuevo;
                nuevo.Referencia = null;
                ultimo = nuevo;
                return true;
            }
        }
        public bool mostrarLista(ListBox lista)
        {
            // Nodo temporal para recorrer la lista enlazada
            // Variable que almacena la información de la lista enlazada
            Nodo actual = cabeza;
            if (actual != null)
            {
                while (actual != null)
                {
                    // Agrega el nodo directamente al ListBox
                    lista.Items.Add(actual);
                    actual = actual.Referencia;
                }
                return true;
            }
            return false;
        }
        public bool buscarNodo(string codigo)
        {
            // Variable temporal para recorrer la lista enlazada
            Nodo busca = cabeza;
            if (busca != null)
            {
                // Recorre la lista enlazada hasta encontrar el nodo con el código especificado o hasta llegar al final de la lista
                while (busca != null)
                {
                    if (busca.Codigo == codigo) return true;
                    else busca = busca.Referencia;
                }
            }
            return false;
        }
        public bool eliminarNodo(string codigo)
        {
            Nodo temp = cabeza;
            Nodo anterior = null;

            if (cabeza != null)
            {
                while (temp != null)
                {
                    if (temp.Codigo == codigo)
                    {
                        if (temp == cabeza)
                        {
                            // El nodo a eliminar es la cabeza
                            cabeza = cabeza.Referencia;
                        }
                        else if (temp == ultimo)
                        {
                            // El nodo a eliminar es el último nodo
                            anterior.Referencia = null;
                            ultimo = anterior;
                        }
                        else
                        {
                            // El nodo a eliminar está en el medio de la lista
                            anterior.Referencia = temp.Referencia;
                        }
                        return true;
                    }
                    anterior = temp;
                    temp = temp.Referencia;
                }
                return false;
            }
            else
            {
                return false;
            }
        }
    }
}
