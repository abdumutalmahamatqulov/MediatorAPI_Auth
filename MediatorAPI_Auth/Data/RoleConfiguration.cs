using MediatorAPI_Auth.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MediatorAPI_Auth.Data;

internal sealed class RoleConfiguration : IEntityTypeConfiguration<IdentityRole>
{
    public RoleConfiguration(IServiceProvider services)
    {
        this.Services = services;
    }

    public IServiceProvider Services { get; set; }

    public void Configure(EntityTypeBuilder<IdentityRole> builder)
    {
        var roleManager = Services.GetRequiredService<RoleManager<IdentityRole>>();

        //var roles = Enum.GetNames<ERole>().Select(x => new IdentityRole(x.ToUpper()) { NormalizedName = roleManager.NormalizeKey(x.ToUpper()) });

        var roles = new List<IdentityRole>
        {
            new IdentityRole(""){Id= ""}
        };
        
        builder.HasData(roles);
    }
}
