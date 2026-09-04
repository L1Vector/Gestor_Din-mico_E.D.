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
        public void insertarNodo(Nodo nuevo)
        {
            // Si la lista está vacía, el nuevo nodo se convierte en la cabeza y el último nodo
            if (cabeza == null)
            {
                cabeza = nuevo;
                cabeza.Referencia = null;
                ultimo = cabeza;
            }
            // Si la lista no está vacía, se agrega el nuevo nodo al final
            else
            {
                ultimo.Referencia = nuevo;
                nuevo.Referencia = null;
                ultimo = nuevo;
            }
        }
        public string mostrarLista()
        {
            // Variable que almacena la información de la lista enlazada
            string vA = "";
            temp = cabeza;
            while (temp != null)
            {
                // Agrega la información del nodo actual a la variable vA y avanza al siguiente nodo
                vA += temp.ToString() + Environment.NewLine;
                temp = temp.Referencia;
            }
            return vA;
        }
        public void buscarNodo(string codigo)
        {
            temp = cabeza;
            while (temp != null)
            {
                // Si se encuentra el nodo con el código especificado, se muestra su información
                if (temp.ToString().Contains(codigo))
                {
                    Console.WriteLine("Nodo encontrado: " + temp.ToString());
                    return;
                }
                temp = temp.Referencia;
            }
            // Si no se encuentra el nodo, se muestra un mensaje indicando que no se encontró
            MessageBox.Show("Nodo no encontrado");
        }
        public void eliminarNodo(string codigo)
        {
            temp = cabeza;
            Nodo anterior = null;
            while (temp != null)
            {
                if (temp.ToString().Contains(codigo))
                {
                    if (anterior == null)
                    {
                        cabeza = temp.Referencia;
                    }
                    else
                    {
                        anterior.Referencia = temp.Referencia;
                    }
                    if (temp == ultimo)
                    {
                        ultimo = anterior;
                    }
                    Console.WriteLine("Nodo eliminado: " + temp.ToString());
                    return;
                }
                anterior = temp;
                temp = temp.Referencia;
            }
            Console.WriteLine("Nodo no encontrado");
        }
    }
}
