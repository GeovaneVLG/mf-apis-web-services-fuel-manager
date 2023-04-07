using System.ComponentModel.DataAnnotations;

namespace mf_apis_web_services_fuel_manager.Models
{
    public class Consumo
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Descricao { get; set; }

        public DateTime Data { get; set; }

        public decimal Valor { get; set; }

        public TipoCombustivel Tipo { get; set; }

    }

    public enum TipoCombustivel{
        Diesel,
        Etanol,
        Gasolina
    }
}
