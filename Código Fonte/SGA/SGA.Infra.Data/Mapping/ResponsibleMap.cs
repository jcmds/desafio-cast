﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SGA.Domain.Entities.Models;

namespace SGA.Infra.Repository.Mapping
{
    internal class ResponsibleMap : IEntityTypeConfiguration<Responsible>
    {
        public void Configure(EntityTypeBuilder<Responsible> builder)
        {
            builder.ToTable("responsavel", "dbo");

            builder.HasKey(f => f.Id);

            builder.Property(f => f.Id)
                .HasColumnName("cd_responsavel");

            builder.Property(c => c.Name)
                .HasColumnName("nm_responsavel")
                .HasColumnType("varchar(50)")
                .HasMaxLength(50)
                .IsRequired();


            // Map Number Object
            builder.OwnsOne(s => s.Email, cb =>
            {
                cb.Property(c => c.Address)
                    .HasColumnName("email_responsavel")
                    .HasColumnType("varchar(30)")
                    .IsRequired();
            });

            builder.OwnsOne(s => s.Cpf, cb =>
            {
                cb.Property(c => c.Number)
                    .HasColumnName("cpf_responsavel")
                    .HasColumnType("varchar(11)")
                    .IsRequired();
            });
        }
    }
}