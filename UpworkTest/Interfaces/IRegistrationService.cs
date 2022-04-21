using UpworkTest.Models;

namespace UpworkTest.Interfaces
{
    /// <summary>
    /// Registration service interface
    /// is an abstraction for actions that could be applied to user store
    /// </summary>
    public interface IRegistrationService
    {
        /// <summary>
        /// Add activated user to store
        /// </summary>
        /// <param name="model"></param>
        void RegisterUser(User model);

        /// <summary>
        /// Add unactivated user to store
        /// </summary>
        /// <param name="model"></param>
        void AddUser(User model);

        /// <summary>
        /// Get User entity from store
        /// </summary>
        /// <param name="id">User identification</param>
        /// <returns>User entity</returns>
        User GetUser(int id);

        /// <summary>
        /// Remove user from store by id
        /// </summary>
        /// <param name="id">User identification</param>
        void RemoveUser(int id);
    }
}
