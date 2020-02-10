using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace FyrstaTilraun_Gagnagrunnur_1.Models
{
    public class GagnaModel_1
    {
        [Key]
        public int id { get; set; }
        [Column(TypeName ="nvarchar(10)")]
        public int uttekt { get; set; }
        [Column(TypeName = "nvarchar(140)")] // alveg eins og á twitter :)
        public string athugasemd { get; set; }

    }
}
