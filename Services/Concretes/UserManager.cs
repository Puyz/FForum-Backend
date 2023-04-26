using Core.Utilities.Results.Concretes;
using Core.Utilities.Results.Abstracts;
using Entities.Concretes;
using Repositories.Abstracts;
using Services.Abstracts;

namespace Services.Concretes
{
    public class UserManager : IUserService
    {
        IUserRepository userRepository;

        public UserManager(IUserRepository userRepository)
        {
            this.userRepository = userRepository;
        }

        public IResult Add(User user)
        {
            userRepository.Add(user);
            return new SuccessResult("Kullanıcı eklendi");
        }

        public IDataResult<List<User>> GetAll()
        {
            List<User> users = userRepository.GetAll();
            return new SuccessDataResult<List<User>>(users);
        }

        public IDataResult<User> GetByUsername(string username)
        {
            User user = userRepository.GetByUsername(username);
            return new SuccessDataResult<User>(user);
        }
    }
}
