using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace FootBallCodeFirstAppr.Models
{
    public class FootBallContext : DbContext
    {
        public FootBallContext() : base("name=conn")
        {

        }
        public DbSet<FootBall> FootBalls { get; set; }
    }
}