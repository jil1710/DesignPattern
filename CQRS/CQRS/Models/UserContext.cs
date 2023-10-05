using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace RepositoryPattern.Models;

public partial class UserContext : DbContext
{

    public UserContext(DbContextOptions<UserContext> options)
        : base(options)
    {
    }

    //public virtual DbSet<AuditEntry> AuditEntries { get; set; }

    //public virtual DbSet<Student> Students { get; set; }

    public DbSet<User> Users { get; set; }


    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        
        base.OnModelCreating(modelBuilder); 
    }

    
}
