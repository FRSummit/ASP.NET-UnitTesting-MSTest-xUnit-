using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace UMS.Models
{
    public class Address
    {
        [Key]
        public int Id { get; set; }
        public int HouseNo{ get; set; }
        public int StreetNo { get; set; }
        public String Block { get; set; }
        public String PostOffice{ get; set; }
        public String PoliceStatuon{ get; set; }
        public String District { get; set; }
    }
}
