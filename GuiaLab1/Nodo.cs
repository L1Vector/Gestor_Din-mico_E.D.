using System;
using System.Collections.Generic;
using System.Text;

namespace GuiaLab1
{
    class Nodo
    {
        // Variables que se requieren almacenar en el nodo
        private string codigo;
        private string descripcion;
        private string prioridad;
        private Nodo referencia;
        public Nodo(string Codigo, string Descripcion, string Prioridad)
        {
            this.codigo = Codigo;
            this.descripcion = Descripcion;
            this.prioridad = Prioridad;
            this.referencia = null;
        }
        // Este comando permite obtener y establecer el valor del dato del nodo
        internal Nodo Referencia { get => referencia; set => referencia = value; }

        // Este comando reescribe el método ToString para devolver el valor del dato del nodo como una cadena
        public override string ToString()
        {
            string a = codigo.ToString();
            string b = descripcion.ToString();
            string c = prioridad.ToString();
            string d = referencia.ToString();
            return a + " - " + b + " - " + c + " - " + d;
        }
    }
}
