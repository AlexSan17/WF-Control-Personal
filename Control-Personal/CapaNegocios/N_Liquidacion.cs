using System;

namespace Control_Personal.CapaNegocios
{
    public class ResultadosLiquidacion
    {
        public int AniosServicio { get; set; }
        public int DiasLaboradosTotales { get; set; }
        public decimal DecimoTercero { get; set; }
        public decimal DecimoCuarto { get; set; }
        public decimal Vacaciones { get; set; }
        public decimal Desahucio { get; set; }
        public decimal DespidoIntempestivo { get; set; }
        public decimal AporteIESSProporcional { get; set; }
        public decimal TotalLiquidacion { get; set; }
    }

    public class N_Liquidacion
    {
        public ResultadosLiquidacion Calcular(decimal sueldo, DateTime fechaIngreso, DateTime fechaSalida, string motivo)
        {
            var res = new ResultadosLiquidacion();
            decimal sbu = 482.00m; 

            if (fechaSalida < fechaIngreso)
                throw new Exception("La fecha de salida no puede ser menor a la fecha de ingreso.");

            int diasTotales = (fechaSalida - fechaIngreso).Days + 1; 
            res.DiasLaboradosTotales = diasTotales;

            double aniosCompletos = diasTotales / 365.0;
            res.AniosServicio = (int)Math.Ceiling(aniosCompletos);
            if (res.AniosServicio == 0) res.AniosServicio = 1;

            DateTime ultimoDic = new DateTime(fechaSalida.Year, 12, 1);
            if (fechaSalida < ultimoDic)
            {
                ultimoDic = new DateTime(fechaSalida.Year - 1, 12, 1);
            }
            if (fechaIngreso > ultimoDic) ultimoDic = fechaIngreso;

            int diasDecimoTercero = (fechaSalida - ultimoDic).Days + 1;

            res.DecimoTercero = (sueldo / 360m) * diasDecimoTercero;

            DateTime ultimoMar = new DateTime(fechaSalida.Year, 3, 1);
            if (fechaSalida < ultimoMar)
            {
                ultimoMar = new DateTime(fechaSalida.Year - 1, 3, 1);
            }
            if (fechaIngreso > ultimoMar) ultimoMar = fechaIngreso;

            int diasDecimoCuarto = (fechaSalida - ultimoMar).Days + 1;
            res.DecimoCuarto = (sbu / 360m) * diasDecimoCuarto;

            DateTime ultimoAniversario = new DateTime(fechaSalida.Year, fechaIngreso.Month, fechaIngreso.Day);
            if (fechaSalida < ultimoAniversario)
            {
                ultimoAniversario = new DateTime(fechaSalida.Year - 1, fechaIngreso.Month, fechaIngreso.Day);
            }
            int diasVacaciones = (fechaSalida - ultimoAniversario).Days + 1;
            
            decimal ganadoEnPeriodo = (sueldo / 30m) * diasVacaciones;
            res.Vacaciones = ganadoEnPeriodo / 24m;

            res.Desahucio = (sueldo * 0.25m) * res.AniosServicio;

            res.DespidoIntempestivo = 0;
            if (motivo == "Despido Intempestivo")
            {
                if (res.AniosServicio <= 3)
                {
                    res.DespidoIntempestivo = sueldo * 3m;
                }
                else
                {
                    res.DespidoIntempestivo = sueldo * res.AniosServicio;

                    if (res.DespidoIntempestivo > sueldo * 25m)
                    {
                        res.DespidoIntempestivo = sueldo * 25m;
                    }
                }
            }

            int diasMesSalida = fechaSalida.Day;
            if (fechaIngreso.Month == fechaSalida.Month && fechaIngreso.Year == fechaSalida.Year)
            {
                diasMesSalida = diasTotales;
            }
            decimal sueldoUltimoMes = (sueldo / 30m) * diasMesSalida;
            res.AporteIESSProporcional = sueldoUltimoMes * 0.0945m;

            res.TotalLiquidacion = res.DecimoTercero + res.DecimoCuarto + res.Vacaciones + res.Desahucio + res.DespidoIntempestivo - res.AporteIESSProporcional;

            return res;
        }
    }
}
