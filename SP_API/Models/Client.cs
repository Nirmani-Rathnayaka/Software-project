using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace SP_API.Models
{
    public class Client
    {
        
        public int client_ID { get; set; }
        public string company_name { get; set; }
        public int tele_no { get; set; }
        public string company_title { get; set; }
        public string email { get; set; }
    }
}
