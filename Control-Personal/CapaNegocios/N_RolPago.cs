using System;

namespace Control_Personal.CapaNegocios
{
    public class N_RolPago
    {
        private const decimal PORCENTAJE_IESS = 0.0945m;

        public decimal CalcularIESS(decimal sueldoBase, decimal horasExtras)
        {
            decimal ingresosCalculables = sueldoBase + horasExtras;
            return Math.Round(ingresosCalculables * PORCENTAJE_IESS, 2);
        }

        public decimal CalcularLiquidoAPagar(decimal sueldoBase, decimal horasExtras, decimal iess, decimal anticipos)
        {
            decimal totalIngresos = sueldoBase + horasExtras;
            decimal totalEgresos = iess + anticipos;
            
            return Math.Round(totalIngresos - totalEgresos, 2);
        }
    }
}
