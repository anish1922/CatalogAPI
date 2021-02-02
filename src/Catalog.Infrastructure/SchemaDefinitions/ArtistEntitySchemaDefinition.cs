using System;
using Catalog.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Catalog.Infrastructure.SchemaDefinitions
{
    public class ArtistEntitySchemaDefinition : IEntityTypeConfiguration<Artist>
    {
        public void Configure(EntityTypeBuilder<Artist> builder)
        {
            builder.ToTable("Artist");

            builder.HasKey(x => x.ArtistId);

            builder.Property(x => x.ArtistId)
                .IsRequired();

            builder.Property(x => x.ArtistName)
                .IsRequired()
                .HasMaxLength(200);
        }
    }
}