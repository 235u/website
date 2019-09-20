﻿using ActinUranium.Web.Extensions;
using ActinUranium.Web.Helpers;
using ActinUranium.Web.Services;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ActinUranium.Web.Models
{
    [Description("Kunde")]
    public sealed class Customer
    {
        internal const int SlugMaxLength = 64;

        [Key]
        [MaxLength(SlugMaxLength)]
        public string Slug { get; set; }

        [Required(AllowEmptyStrings = false)]
        [MaxLength(SlugMaxLength)]
        [Display(Name = "Bezeichnung")]
        [DisplayFormat(HtmlEncode = false)]
        public string Name { get; set; }

        [Required]
        [MaxLength(Image.SourceMaxLength)]
        [DataType(DataType.Url)]
        public string LogoSource { get; set; }

        [ForeignKey(nameof(LogoSource))]
        public Image Logo { get; set; }

        public string Website => "https://translate.google.com/#view=home&op=translate&sl=la&tl=de&text=" +
            Uri.EscapeDataString(Name);

        internal static void OnModelCreating(EntityTypeBuilder<Customer> typeBuilder)
        {
            typeBuilder.HasIndex(c => c.Name)
                .IsUnique();
        }

        internal static void Seed(ApplicationDbContext dbContext)
        {
            const char Nbsp = UnicodeLiterals.NoBreakSpace;

            dbContext.Customers.AddRange(
                CreateCustomer($"Aliquid{Nbsp}AG", "aliquid.svg"),
                CreateCustomer($"Ande Animi{Nbsp}GmbH", "ande-animi.svg"),
                CreateCustomer("Culpa Porro Commodi", "culpa-porro-comodi.svg"),
                CreateCustomer($"Delectus Ratione{Nbsp}GmbH", "delectus-ratione.svg"),
                CreateCustomer($"Dolore Odio Corrupti{Nbsp}GmbH", "dolore-odio-corrupti.svg"),
                CreateCustomer($"Facilis{Nbsp}AG", "facilis.svg"),
                CreateCustomer($"Maiores{Nbsp}AG", "maiores.svg"),
                CreateCustomer("Nostrum Tenetur Voluptas", "nostrum-tenetur-voluptas.svg"),
                CreateCustomer($"Rem Vel{Nbsp}AG", "rem-vel.svg"),
                CreateCustomer($"Sapiente Numquam{Nbsp}GmbH", "sapiente-numquam.svg"),
                CreateCustomer($"Tempora{Nbsp}GmbH", "tempora.svg"),
                CreateCustomer("Vero Harum Veniam Nemo", "vero-harum-veniam-nemo.svg"));

            dbContext.SaveChanges();
        }

        private static Customer CreateCustomer(string name, string fileName)
        {
            return new Customer
            {
                Slug = name.Slugify(),
                Name = name,
                Logo = new Image
                {
                    Title = name,
                    AlternativeText = name + " Logo",
                    Source = "/img/customers/" + fileName,
                }
            };
        }
    }
}
