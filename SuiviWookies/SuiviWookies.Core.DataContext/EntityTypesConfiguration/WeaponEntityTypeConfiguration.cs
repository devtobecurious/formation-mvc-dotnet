using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SuiviWookies.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuiviWookies.Core.DataContext.EntityTypesConfiguration
{
    public class WeaponEntityTypeConfiguration : IEntityTypeConfiguration<Weapon>
    {
        #region Public methods
        public void Configure(EntityTypeBuilder<Weapon> builder)
        {
            builder.ToTable("Weapon");
        }
        #endregion
    }
}
