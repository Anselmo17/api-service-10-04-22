using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace api_service_10_04_22.Models
{
    [Table("tb_produto")]
    public class Produto
    {
        [Key]
        [Column("COD")]
        public int Cod { get; set; }
        
        [Column("NOME")]
        public String Nome { get; set; }

        [Column("TIPO_PRODUTO")]
        public int TipoProduto { get; set; }

        [Column("created")]
        public DateTime Created { get; set; }

        [Column("updated")]
        public DateTime Updated { get; set; }
    }
}
