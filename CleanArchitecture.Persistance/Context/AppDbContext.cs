using CleanArchitecture.Domain.Abstractions;
using CleanArchitecture.Domain.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace CleanArchitecture.Persistance.Context;

public sealed class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions options) : base(options) {}

    public DbSet<Plan> Tbl_WB_001_01_Plans { get; set; }
    public DbSet<ErrorLog> ErrorLogs { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        //modelBuilder.ApplyConfigurationsFromAssembly(typeof(AssemblyRefence).Assembly);

        //modelBuilder.Ignore<IdentityUserLogin<string>>();
        //modelBuilder.Ignore<IdentityUserRole<string>>();
        //modelBuilder.Ignore<IdentityUserClaim<string>>();
        //modelBuilder.Ignore<IdentityUserToken<string>>();
        //modelBuilder.Ignore<IdentityRoleClaim<string>>();
        //modelBuilder.Ignore<IdentityRole<string>>();


    }
        

    public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
    {
        var entires = ChangeTracker.Entries<Entity>();
        foreach (var entry in entires)
        {
            //if(entry.State == EntityState.Added)
            //    entry.Property(p=> p.CreatedDate)
            //        .CurrentValue = DateTime.Now;

            //if (entry.State == EntityState.Modified)
            //    entry.Property(p => p.UpdatedDate)
            //        .CurrentValue = DateTime.Now;
        }
        return base.SaveChangesAsync(cancellationToken);
    }
}
