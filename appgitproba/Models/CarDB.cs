using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace appgitproba.Models
{
    public class CarDB :DbContext
    {
        public DbSet<Car> Cars { get; set; }
    }
}