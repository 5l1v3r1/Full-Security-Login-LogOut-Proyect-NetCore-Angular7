using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Models
{
    public class ContextoDeAutenticacion : IdentityDbContext
    {
        public ContextoDeAutenticacion(DbContextOptions options):base(options)
        {

        }

        public DbSet<AplicacionDeUsuario> AplicacionDeUsuario { get; set; }
    }
}
