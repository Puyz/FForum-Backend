using Entities.Concretes;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.Concretes.EntityFramework
{
    public class FForumContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=FForum;Trusted_Connection=true");
        }
                                                        
        public DbSet<Category>? Categories { get; set; }
        public DbSet<SubCategory>? SubCategories { get; set; }
        public DbSet<Message>? Messages { get; set; }
        public DbSet<Notification>? Notifications { get; set; }
        public DbSet<Post>? Posts { get; set; }
        public DbSet<Rank>? Ranks { get; set; }
        public DbSet<User>? Users { get; set; }
    }                                                   
}                                                       
                                                        