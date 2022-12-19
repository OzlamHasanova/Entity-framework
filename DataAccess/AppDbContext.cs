using ConsoleApp10.Core.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10.DataAccess;

    public class AppDbContext:DbContext
    {
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(@"Server=DESKTOP-IPH870M;Database=DbCodeFirst;Trusted_connection=true");
    }
    public DbSet<Employer> Employer { get; set; }
}

