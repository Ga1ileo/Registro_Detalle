using System.ComponentModel.DataAnnotations;

namespace Registro_Detalle.Models
{
    public class MoraDetalles
    {
        [Key]
        public int MoraDetalleId { get; set; }
        public int MoraId { get; set; }
        public int PrestamoId { get; set; }
        public decimal Valor { get; set; }

        public MoraDetalles()
        {
            MoraDetalleId = 0;
            MoraId = 0;
            PrestamoId = 0;
            Valor = 0;
        }
    }
}