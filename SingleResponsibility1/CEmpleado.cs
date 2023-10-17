using System;

namespace SingleResponsibility1
{
    class CEmpleado
    {
        private string nombre;
        private string puesto;
        private int edad;
        private double sueldo;

        public CEmpleado(string pNombre, string pPuesto, int pEdad, double pSueldo)
        {
            nombre = pNombre;
            puesto = pPuesto;
            edad = pEdad;
            sueldo = pSueldo;
        }

        public override string ToString()
        {
            return string.Format("{0},{1},{2},{3}", nombre, puesto, edad, sueldo);
        }

        // Aqui van otros metodos propios de empleado
        // AsignarHorario
        // ProyectoActual

        // Ahora colocamos algo que no es responsabilidad del empleado
        // Tenemos DOS razones para cambiar la clase
        // Cuando cambia algo del empleado y
        // cuando cambia algo relacionado con los impuestos

        public double CalcularImpuesto() 
        { 
            return sueldo * 0.35; 
        }

        public void PagarImpuesto() 
        {
            double imp = CalcularImpuesto();
            Console.WriteLine("Se pago {0} en impuestos por parte de {1}", imp, nombre);
        }
    }
}
