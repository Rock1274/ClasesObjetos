using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pjBoletaVent
{
    public class Boleta
    {
        public int NumeroBoleta { get; set; }
        public string NombreCliente { get; set; }
        public string DireccionCliente { get; set; }
        public string CedulaCliente { get; set; }
        public DateTime FechaRegistro { get; set; }
        public string DescripcionProducto { get; set; }
        public int CantidadComprada { get; set; }


        public double determinaPrecio()
        {


            switch(DescripcionProducto)
            {
                case "PS5 + 1 MANDO DS5": return 500;
                case "P´S4(1TB) + 1 MANDO DS4": return 619;
                case "Mando PS5/DS5": return 69;
                case "Mando PS4/DS4": return 60;
            }

            return 0;
        }
        //Metodo para dewterminar el importe
        public double calculaImporte()
        {
            return CantidadComprada * determinaPrecio();
        }
    }
}
