using System;
using Catalog.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Catalog.Infrastructure.SchemaDefinitions
{
    public class GenreEntitySchemaDefinition : IEntityTypeConfiguration<Genre>
    {
        public void Configure(EntityTypeBuilder<Genre> builder)
        {
            builder.ToTable("Genre");

            builder.HasKey(x => x.GenreId);

            builder.Property(x => x.GenreId)
                .IsRequired();

            builder.Property(x => x.GenreDescription)
                .IsRequired()
                .HasMaxLength(1000);
        }
    }
}