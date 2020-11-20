using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace SP_API.Models
{
    public class Client
    {
        public int client_NIC { get; set; }
        public string F_name { get; set; }
        public string L_name { get; set; }
        public int tele_no { get; set; }
        public string Address { get; set; }
        public string email { get; set; }
    }
}
