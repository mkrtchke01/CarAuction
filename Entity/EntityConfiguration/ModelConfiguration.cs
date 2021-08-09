﻿using Entity.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace Entity.EntityConfiguration
{
    class ModelConfiguration : IEntityTypeConfiguration<Model>
    {
        public void Configure(EntityTypeBuilder<Model> builder)
        {
            builder.HasOne(x => x.Brand).WithMany(x => x.Models).HasForeignKey(x => x.BrandId);

            builder.HasKey(x => x.Id);
            builder.Property(x => x.Name).IsRequired().HasMaxLength(50);

            builder.HasData(new Model
            {
                Id = 1,
                Name = "A6",
                BrandId = 1
            });

        }
    }
}
