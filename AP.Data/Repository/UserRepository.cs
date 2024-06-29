using AP.Data.Models;

namespace AP.Data.Repository;

public interface IUserRepository
{
    bool AddEntity(User user);
}

public class UserRepository(ApdatadbContext context) : Repository<User>(context), IUserRepository
{
    public bool AddEntity(User user)
    {
        return user == null
            ? throw new ArgumentNullException("User does not exist!") 
            : Add(user);
    }
}
