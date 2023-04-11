using System.ComponentModel.DataAnnotations;

namespace DWOficinas.Models
{
    public class MetodoPagamento
    {
        /// <summary>
        /// Identificador do Pagamento
        /// </summary>
        [Key]
        [Required]
        public int IdPagamento { get; set; }

        /// <summary>
        /// Tipo de Pagamento
        /// </summary>
        public string TipoPagamento { get; set; }
    }
}
