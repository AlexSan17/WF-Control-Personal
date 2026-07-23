using System;
using System.Data;
using System.Linq;
using Control_Personal.CapaDatos;

namespace Control_Personal.CapaNegocios
{
    public class N_Beneficios
    {
        private D_Empleado objDatos = new D_Empleado();

        public DataTable CalcularBeneficios(string criterio = "", string valorBuscar = "", string tipoBeneficio = "Todos", string tipoPago = "Acumulado")
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Cédula");
            dt.Columns.Add("Empleado");
            
            if (tipoBeneficio == "Todos")
            {
                dt.Columns.Add("Sueldo Base", typeof(decimal));
                dt.Columns.Add("Días Trab.", typeof(int));
                dt.Columns.Add("Decimotercero", typeof(decimal));
                dt.Columns.Add("Decimocuarto", typeof(decimal));
                dt.Columns.Add("Vacaciones", typeof(decimal));
            }
            else if (tipoBeneficio == "Décimo Tercero" || tipoBeneficio == "Décimo Cuarto")
            {
                dt.Columns.Add("Sueldo Base", typeof(decimal));
                if (tipoPago == "Mensual")
                {
                    dt.Columns.Add("Proporcional Mensual", typeof(decimal));
                    dt.Columns.Add("Total a Recibir", typeof(decimal));
                }
                else
                {
                    dt.Columns.Add("Días Trab.", typeof(int));
                    dt.Columns.Add("Total Acumulado", typeof(decimal));
                }
            }
            else if (tipoBeneficio == "Vacaciones")
            {
                dt.Columns.Add("Sueldo Base", typeof(decimal));
                dt.Columns.Add("Días Trab.", typeof(int));
                dt.Columns.Add("Proporcional Vacaciones", typeof(decimal));
            }

            decimal salarioBasico = 482.00m;
            var empleados = objDatos.Listar().Where(e => e.Estado != null && e.Estado.Trim().ToLower() == "activo");

            if (!string.IsNullOrWhiteSpace(valorBuscar))
            {
                valorBuscar = valorBuscar.ToLower();
                if (criterio == "Codigo" || criterio == "Código")
                    empleados = empleados.Where(e => e.Codigo != null && e.Codigo.ToLower().Contains(valorBuscar));
                else if (criterio == "Cedula" || criterio == "Cédula")
                    empleados = empleados.Where(e => e.Cedula != null && e.Cedula.ToLower().Contains(valorBuscar));
                else if (criterio == "Nombre")
                    empleados = empleados.Where(e => e.Nombres != null && e.Nombres.ToLower().Contains(valorBuscar));
                else if (criterio == "Apellido")
                    empleados = empleados.Where(e => e.Apellidos != null && e.Apellidos.ToLower().Contains(valorBuscar));
                else if (criterio == "Departamento")
                    empleados = empleados.Where(e => e.Departamento != null && e.Departamento.ToLower().Contains(valorBuscar));
            }
            else
            {
                empleados = empleados.Take(20);
            }

            foreach (var emp in empleados)
            {
                if (emp.FechaIngreso == DateTime.MinValue) continue;

                int diasTrabajadosTotales = (DateTime.Now - emp.FechaIngreso).Days;
                if (diasTrabajadosTotales < 0) diasTrabajadosTotales = 0;

                DateTime inicioAnio = new DateTime(DateTime.Now.Year, 1, 1);
                DateTime fechaInicioPeriodo = emp.FechaIngreso > inicioAnio ? emp.FechaIngreso : inicioAnio;
                int diasTrabajadosPeriodo = (DateTime.Now - fechaInicioPeriodo).Days;
                if (diasTrabajadosPeriodo > 360) diasTrabajadosPeriodo = 360;

                decimal decimoterceroAcumulado = (emp.Sueldo / 360m) * diasTrabajadosPeriodo;
                decimal decimocuartoAcumulado = (salarioBasico / 360m) * diasTrabajadosPeriodo;
                decimal decimoterceroMensual = emp.Sueldo / 12m;
                decimal decimocuartoMensual = salarioBasico / 12m;
                
                decimal vacaciones = (emp.Sueldo / 24m) * ((decimal)diasTrabajadosTotales / 360m);

                DataRow row = dt.NewRow();
                row["Cédula"] = emp.Cedula;
                row["Empleado"] = emp.Nombres + " " + emp.Apellidos;

                if (tipoBeneficio == "Todos")
                {
                    row["Sueldo Base"] = Math.Round(emp.Sueldo, 2);
                    row["Días Trab."] = diasTrabajadosPeriodo;
                    row["Decimotercero"] = Math.Round(decimoterceroAcumulado, 2);
                    row["Decimocuarto"] = Math.Round(decimocuartoAcumulado, 2);
                    row["Vacaciones"] = Math.Round(vacaciones, 2);
                }
                else if (tipoBeneficio == "Décimo Tercero")
                {
                    row["Sueldo Base"] = Math.Round(emp.Sueldo, 2);
                    if (tipoPago == "Mensual")
                    {
                        row["Proporcional Mensual"] = Math.Round(decimoterceroMensual, 2);
                        row["Total a Recibir"] = Math.Round(emp.Sueldo + decimoterceroMensual, 2);
                    }
                    else
                    {
                        row["Días Trab."] = diasTrabajadosPeriodo;
                        row["Total Acumulado"] = Math.Round(decimoterceroAcumulado, 2);
                    }
                }
                else if (tipoBeneficio == "Décimo Cuarto")
                {
                    row["Sueldo Base"] = Math.Round(emp.Sueldo, 2);
                    if (tipoPago == "Mensual")
                    {
                        row["Proporcional Mensual"] = Math.Round(decimocuartoMensual, 2);
                        row["Total a Recibir"] = Math.Round(emp.Sueldo + decimocuartoMensual, 2);
                    }
                    else
                    {
                        row["Días Trab."] = diasTrabajadosPeriodo;
                        row["Total Acumulado"] = Math.Round(decimocuartoAcumulado, 2);
                    }
                }
                else if (tipoBeneficio == "Vacaciones")
                {
                    row["Sueldo Base"] = Math.Round(emp.Sueldo, 2);
                    row["Días Trab."] = diasTrabajadosTotales;
                    row["Proporcional Vacaciones"] = Math.Round(vacaciones, 2);
                }

                dt.Rows.Add(row);
            }
            return dt;
        }
    }
}
