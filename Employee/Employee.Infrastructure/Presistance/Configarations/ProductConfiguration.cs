using Employee.Model;
using Employee.Shared.Enums;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee.Infrastructure.Presistance.Configarations
{
    public class ProductConfiguration : IEntityTypeConfiguration<Products>
    {
        public void Configure(EntityTypeBuilder<Products> builder)
        {
            builder.ToTable("Product", schema: "Emp");
            builder.HasKey(x => x.Id);
            builder.HasIndex(x => x.ProductName);
            builder.HasData(new
            {
                Id = 1,
                ProductName = "Computer",
                Description = "Taka",
                CountryId = 1,
                RatingPrice=400,
                BarCode="1234",
                SellPrice=1,
                Created = DateTimeOffset.Now,
                Status = EntityStatus.Created
            });
        }
    }
}
