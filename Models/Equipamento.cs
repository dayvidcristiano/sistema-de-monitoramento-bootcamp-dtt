using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using sistema_de_monitoramento.Models.Enums;

namespace sistema_de_monitoramento.Models
{
    [Table("Equipamentos")]
    public class Equipamento
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string Codigo { get; set; } = string.Empty;

        [Required]
        public TipoEquipamento Tipo { get; set; }

        [Required]
        [MaxLength(100)]
        public string Modelo { get; set; } = string.Empty;

        [Range(typeof(decimal), "0", "79228162514264337593543950335")]
        public decimal Horimetro { get; set; }

        [Required]
        public StatusOperacional StatusOperacional { get; set; }

        public DateTime DataAquisicao { get; set; }

        [MaxLength(150)]
        public string? LocalizacaoAtual { get; set; }
    }
}
