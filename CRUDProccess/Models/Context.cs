
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRUDProccess.Models
{
    public class Context :DbContext
    {
        //Nuget olarak entity yükledim sonra :DbContext ekleme yapıyorum

        public Context(DbContextOptions<Context> options) : base(options)
        {

        }

        public DbSet<Student> Students { get; set; }


    }
}
