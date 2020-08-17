using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LuminiHireApi.Models
{
    public class CityReturn
    {
        [Key]
        public int CityId { get; set; }
        public string Region { get; set; }
        public int QtdRegiao { get; set; }
        public string Titulo { get; set; }
    }
}
