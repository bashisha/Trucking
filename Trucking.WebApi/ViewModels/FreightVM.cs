using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Trucking.WebApi.ViewModels
{
    public class FreightVM
    {
        public FreightVM() { }
        public int Id { get; set; }
        public int WeightInTonnes { get; set; }
        public string FreightType { get; set; }
        public string FromZipCode { get; set; }
        public string ToZipCode { get; set; }
        public decimal TotalDistance { get; set; }
        public string Image { get; set; }
    }
}
