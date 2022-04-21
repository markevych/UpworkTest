using Microsoft.EntityFrameworkCore;
using UpworkTest.Models;

namespace UpworkTest.Context
{
    /// <summary>
    /// This is imitation of store (DB or cache store)
    /// </summary>
    public class Context : DbContext
    {
        /// <summary>
        /// Constructor of context
        /// </summary>
        /// <param name="options"></param>
        public Context(DbContextOptions<Context> options)
            : base(options)
        {
        }

        /// <summary>
        /// Users collection
        /// Representing user model store
        /// </summary>
        public DbSet<User> Users { get; set; }
    }
}
