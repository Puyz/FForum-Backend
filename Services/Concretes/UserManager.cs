using Core.Utilities.Results.Abstracts;
using Core.Utilities.Results.Concretes;
using Entities.Concretes;
using Entities.DTOs;
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

        public IDataResult<List<UserDto>> GetAllWithRank()
        {
            List<UserDto> users = userRepository.GetAllWithRank();
            return new SuccessDataResult<List<UserDto>>(users);
        }

        public IDataResult<User> GetByUsername(string username)
        {
            User user = userRepository.GetByUsername(username);
            return new SuccessDataResult<User>(user);
        }
    }
}
