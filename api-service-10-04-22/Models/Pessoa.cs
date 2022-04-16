using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace api_service_10_04_22.Models
{
    [Table("tb_users")]
    public class Pessoa
    {
        public int id { get; set; }

        public String nome { get; set; }
        
        public String email { get; set; }

        public String senha { get; set; }

        public int perfil { get; set; }

        public DateTime created { get; set; }

        public DateTime updated { get; set; }
    }


}
