using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using Control_Personal.CapaDatos;
using Control_Personal.Entidades;

namespace Control_Personal.CapaNegocios
{
    public class N_Empleado
    {
        private D_Empleado objDatos = new D_Empleado();

        public List<Empleado> Listar()
        {
            return objDatos.Listar();
        }

        public bool Registrar(Empleado empleado, out string mensaje)
        {
            mensaje = string.Empty;



            if (objDatos.Listar().Any(e => e.Codigo == empleado.Codigo))
            {
                mensaje = "El código del empleado ya existe.";
                return false;
            }

            if (objDatos.Listar().Any(e => e.Cedula == empleado.Cedula))
            {
                mensaje = "La cédula ya está registrada.";
                return false;
            }



            objDatos.Insertar(empleado);
            return true;
        }

        public bool Editar(Empleado empleado, out string mensaje)
        {
            mensaje = string.Empty;



            if (objDatos.Listar().Any(e => e.Cedula == empleado.Cedula && e.Codigo != empleado.Codigo))
            {
                mensaje = "La cédula ya está registrada en otro empleado.";
                return false;
            }



            objDatos.Editar(empleado);
            return true;
        }

        public bool Eliminar(string codigo, out string mensaje)
        {
            mensaje = string.Empty;
            if (string.IsNullOrWhiteSpace(codigo))
            {
                mensaje = "Debe proporcionar un código.";
                return false;
            }

            objDatos.Eliminar(codigo);
            return true;
        }

        public List<Empleado> Consultar(string criterio, string busqueda)
        {
            var lista = objDatos.Listar();
            if (string.IsNullOrWhiteSpace(busqueda)) return lista;

            busqueda = busqueda.ToLower();

            if (criterio == "Codigo" || criterio == "Código")
                return lista.Where(e => e.Codigo != null && e.Codigo.ToLower().Contains(busqueda)).ToList();
            if (criterio == "Cedula" || criterio == "Cédula")
                return lista.Where(e => e.Cedula != null && e.Cedula.ToLower().Contains(busqueda)).ToList();
            if (criterio == "Nombre")
                return lista.Where(e => e.Nombres != null && e.Nombres.ToLower().Contains(busqueda)).ToList();
            if (criterio == "Apellido")
                return lista.Where(e => e.Apellidos != null && e.Apellidos.ToLower().Contains(busqueda)).ToList();
            if (criterio == "Departamento")
                return lista.Where(e => e.Departamento != null && e.Departamento.ToLower().Contains(busqueda)).ToList();

            return lista;
        }


    }
}
