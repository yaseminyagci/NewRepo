using pro.Models;
using Microsoft.EntityFrameworkCore;
using pro.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DpProcedur.Context
{
    public class DpContext:DbContext
    {
        public DpContext() { }
        public DpContext(DbContextOptions<DpContext> options)
            : base(options)
        {

        }

        // Might be best to move these to another partial class, so they don't get removed in any updates.
        public virtual DbSet<HotelTypes> types { get; set; }





        //private const string connectionString = "";
        //protected override void OnConfiguring(DbContextOptionsBuilder optionBuilder) 
        //{

        //    optionBuilder.UseSqlServer(connectionString);

        //}

    }
}
