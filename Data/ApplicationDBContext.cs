using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models;

namespace WebApplication1.Data
{
    public class ApplicationDBContext : DbContext //this is inherited from the entityCore Framework
    {
        //we provide a dbcontextoptions variable and the after the colon, pass it  on to the base class
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options)
        {

        }

        //Add dbSets for each object table e.g Item table for Item  objects
        public DbSet<Item> Items { get; set; } //public  DbSet<ObjectType> TableName {properties}
        public DbSet<User> Users { get; set; }
        public DbSet<Note> Notes { get; set; }

    }
}
