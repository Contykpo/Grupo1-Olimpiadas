using System;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;

namespace Olimpiadas.Core
{
	class ContextoBaseDeDatos : DbContext
	{
		private string mIp;

		public ContextoBaseDeDatos()
		{
			
		}

		public ContextoBaseDeDatos(string _ip)
		{
			mIp = _ip;
		}

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			SqlConnectionStringBuilder connectionStrBuilder = new SqlConnectionStringBuilder
			{
				//TODO: Reemplazar por la ip cuando este todo terminado
				DataSource = $"localhost",
				InitialCatalog = $"Db",
				UserID = $"{Environment.MachineName}",
				IntegratedSecurity = true
			};

			optionsBuilder.UseSqlServer(new SqlConnection(connectionStrBuilder.ToString()));
		}

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			
		}
	}
}
