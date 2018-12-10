using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MVCCore.Models;

namespace MVCCore.EF
{
	public class ArtifactContext : DbContext
	{
		public DbSet<CardSet> CardSets { get; set; }
		public DbSet<Language> Languages { get; set; }
		public DbSet<CardColour> CardColours { get; set; }
		public DbSet<CardType> CardTypes { get; set; }
		public DbSet<CardReferenceType> CardReferenceTypes { get;set; }
		public DbSet<Card> Cards { get; set; }



		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=ArtifactDB;Trusted_Connection=True;");
		}
	}
}
