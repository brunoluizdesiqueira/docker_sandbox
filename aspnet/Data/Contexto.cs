using aspnet.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace aspnet.Data
{
    public class Contexto : DbContext
    {

        public DbSet<Person> Persons { get; set; }
	
	static DbContextOptions<Contexto> Init ()
	{
		//string connectionString = @"Data Source=13.72.79.75;Initial Catalog=db1;Persist Security Info=True;User ID=sa;Password=P@ssw0rd";
		string connectionString = @"Data Source=haproxy;Initial Catalog=db1;Persist Security Info=True;User ID=sa;Password=P@ssw0rd;ApplicationIntent=ReadOnly";
		var options = new DbContextOptionsBuilder<Contexto>();
		return options.UseSqlServer(connectionString).Options;
	}
        
        public Contexto()
		:this(Init())
	{		
        }

        public Contexto(DbContextOptions<Contexto> options)
            : base(options)
        {

        }
    }
}




