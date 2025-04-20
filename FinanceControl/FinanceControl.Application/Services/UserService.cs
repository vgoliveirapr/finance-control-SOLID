using FinanceControl.Application.Interfaces;
using FinanceControl.Domain.DTOs;
using FinanceControl.Domain.Entities;
using FinanceControl.Infrastructure.Interfaces;
using BCrypt.Net;

namespace FinanceControl.Application.Services
{
    public class UserService : IUserService
    {
        private readonly IJwtService _jwtService;
        private readonly IUserRepository _userRepository;
        private readonly IUserTokenRepository _userTokenRepository;

        public UserService(IJwtService jwtService, IUserRepository userRepository, IUserTokenRepository userTokenRepository)
        {
            _jwtService = jwtService;
            _userRepository = userRepository;
            _userTokenRepository = userTokenRepository;
        }

        public async Task CreateUser(UserDTO userDTO)
        {
            string passwordHash = BCrypt.Net.BCrypt.HashPassword(userDTO.PasswordEncrypted);

            User user = new(userDTO.Name, userDTO.Username, passwordHash);

            await _userRepository.CreateUser(user);

            string token = _jwtService.GenerateToken(userDTO);

            UserToken userToken = new(user.IdUser, token, DateTime.Now, DateTime.Now.AddHours(2));

            await _userTokenRepository.AddUserToken(userToken);

            await Task.FromResult(_userTokenRepository.GetUserTokenById(user.IdUser));
        }

        public Task Login(UserDTO user)
        {
            throw new NotImplementedException();
        }
    }
}
