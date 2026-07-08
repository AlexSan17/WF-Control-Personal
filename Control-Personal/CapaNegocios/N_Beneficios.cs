using System;
using System.Data;
using Control_Personal.CapaDatos;

namespace Control_Personal.CapaNegocios
{
    public class N_Beneficios
    {
        private D_Empleado objDatos = new D_Empleado();

        public DataTable CalcularBeneficios()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Cédula");
            dt.Columns.Add("Empleado");
            dt.Columns.Add("Sueldo Base", typeof(decimal));
            dt.Columns.Add("Días Trab.", typeof(int));
            dt.Columns.Add("Decimotercero", typeof(decimal));
            dt.Columns.Add("Decimocuarto", typeof(decimal));
            dt.Columns.Add("Vacaciones", typeof(decimal));

            decimal salarioBasico = 482.00m;

            foreach (var emp in objDatos.Listar())
            {
                if (emp.Estado != null && emp.Estado.Trim().ToLower() == "activo")
                {
                    if (emp.FechaIngreso == DateTime.MinValue) continue;

                    int diasTrabajados = (DateTime.Now - emp.FechaIngreso).Days;
                    if (diasTrabajados < 0) diasTrabajados = 0;

                    decimal decimotercero = (emp.Sueldo / 360m) * diasTrabajados;
                    decimal decimocuarto = (salarioBasico / 360m) * diasTrabajados;
                    decimal vacaciones = (emp.Sueldo / 24m) * (diasTrabajados / 360m);

                    dt.Rows.Add(
                        emp.Cedula,
                        emp.Nombres + " " + emp.Apellidos,
                        Math.Round(emp.Sueldo, 2),
                        diasTrabajados,
                        Math.Round(decimotercero, 2),
                        Math.Round(decimocuarto, 2),
                        Math.Round(vacaciones, 2)
                    );
                }
            }
            return dt;
        }
    }
}
