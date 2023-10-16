using Entities.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Entities.Configuration
{
    public class BuyerConfiguration : IEntityTypeConfiguration<Buyer>
    {
        public void Configure(EntityTypeBuilder<Buyer> builder)
        {
            builder.HasData
            (
            new Buyer
            {
                Id = new Guid("c2d4c053-49b6-410c-bc78-2d54a9991870"),
                Name = "Dmitry",
                Address = "Saransk, Botevgradsky86k63",
                Country = "Russia",
                PhoneNumber = "89969603973"
            },
            new Buyer
            {
                Id = new Guid("4d490a70-94ce-4d15-9494-5248280c2ce3"),
                Name = "Egor",
                Address = "Saransk, Poleshaeva10k2",
                Country = "Russia",
                PhoneNumber = "89969603514"
            }
            ); ;
        }
    }
}
