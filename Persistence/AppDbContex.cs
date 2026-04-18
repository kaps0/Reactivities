using System;
using Domain;
using Microsoft.EntityFrameworkCore;

namespace Persistence;

public class AppDbContex(DbContextOptions options) : DbContext(options)
{
    public required DbSet<Activity> Activities {get;set;}
}
