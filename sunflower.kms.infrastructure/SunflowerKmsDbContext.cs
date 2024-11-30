using System;
using Microsoft.EntityFrameworkCore;
using sunflower.kms.domain.Entities;

namespace sunflower.kms.infrastructure;

public class SunflowerKmsDbContext : DbContext
{
    public SunflowerKmsDbContext(DbContextOptions<SunflowerKmsDbContext> options) : base(options) { }

    public DbSet<m_key_types> m_key_types { get; set; }

}
