using System.Collections.Generic;
using System.Linq;
using Control_Personal.Entidades;

namespace Control_Personal.CapaDatos
{
    public class D_Empleado
    {
        public List<Empleado> Listar()
        {
            return Datos.ListaEmpleados.ToList();
        }

        public void Insertar(Empleado empleado)
        {
            Datos.ListaEmpleados.Add(empleado);
        }

        public void Editar(Empleado empleado)
        {
            var emp = Datos.ListaEmpleados.FirstOrDefault(e => e.Codigo == empleado.Codigo);
            if (emp != null)
            {
                emp.Cedula = empleado.Cedula;
                emp.Nombres = empleado.Nombres;
                emp.Apellidos = empleado.Apellidos;
                emp.Edad = empleado.Edad;
                emp.Sexo = empleado.Sexo;
                emp.Direccion = empleado.Direccion;
                emp.Telefono = empleado.Telefono;
                emp.Correo = empleado.Correo;
                emp.Cargo = empleado.Cargo;
                emp.Departamento = empleado.Departamento;
                emp.FechaIngreso = empleado.FechaIngreso;
                emp.Sueldo = empleado.Sueldo;
                emp.Estado = empleado.Estado;
            }
        }

        public void Eliminar(string codigo)
        {
            var emp = Datos.ListaEmpleados.FirstOrDefault(e => e.Codigo == codigo);
            if (emp != null)
            {
                Datos.ListaEmpleados.Remove(emp);   
            
            }
        }
    }
}
