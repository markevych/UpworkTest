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
        /// Users collection
        /// Representing user model store
        /// </summary>
        public List<User> Users { get; set; }
    }
}
