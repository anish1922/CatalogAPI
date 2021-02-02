using Catalog.Domain.Entities;
using Catalog.Infrastructure.Extensions;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Catalog.Infrastructure
{
    public class SeedDataContext : CatalogContext
    {
        public SeedDataContext(DbContextOptions<CatalogContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Seed<Artist>("./Data/artist.json");
            modelBuilder.Seed<Genre>("./Data/genre.json");
            modelBuilder.Seed<Item>("./Data/item.json");
            base.OnModelCreating(modelBuilder);
        }
    }
}
