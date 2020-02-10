using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FyrstaTilraun_Gagnagrunnur_1.Models
{
    public class Gagnagrunnur_1 : DbContext
    {
        public Gagnagrunnur_1(DbContextOptions<Gagnagrunnur_1> options):base(options)
        {

        }

        // https://www.youtube.com/watch?v=NemyDIUcC64&t=1652s
        // kominn til 6:22 núna (í dag er 9.2.2020, klukkan 22:30)
    }
}
