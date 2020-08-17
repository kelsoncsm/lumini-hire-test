using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LuminiHireApi.Models
{
    public class City
    {
        [Key]
        public int CityId { get; set; }
        public string CityName { get; set; }
        public int PopulationYear2018 { get; set; }
        public int PopulationYear2019 { get; set; }
        public int PopulationYear2020 { get; set; }
        public string Region { get; set; }
    }
}
