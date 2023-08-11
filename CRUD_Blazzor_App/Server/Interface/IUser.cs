using CRUD_Blazzor_App.Shared.Models;

namespace CRUD_Blazzor_App.Server.Interface
{
    public interface IUser
    {
        public List<User> GetUserDetails();
        public void AddUser(User user);
        public void UpdateUserDetails(User user);
        public User GetUserData(int id);
        public void DeleteUser(int id);
    }
}
