using System;
using System.ComponentModel.DataAnnotations;

namespace Microgreens.Models
{
    public class SowRatesL
    {
        [Key]
        public int SowRatesId { get; set; }
        public decimal SowWeight { get; set; }
        public int TraysPerPack { get; set; }
        public decimal CostPerTray { get; set; }
        public int ProductsId { get; set; }
        public DateTime DateIn { get; set; }
        public DateTime DateOut { get; set; }
        public Products Product { get; set; }
        public Yields Yield { get; set; }

    }
}
