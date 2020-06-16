using Library.Contexts;
using Library.Data;
using Library.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Library.Services
{
    public interface IAuthRepository
    {
        Task<TResponse> AuthenticateUser<TResponse>(TResponse model);
        Task<TResponse> RegisterUser<TResponse>(TResponse model);
        Task<TResponse> ValidateAccess<TResponse>(TResponse model);
    }
    public class AuthRepository : IAuthRepository
    {
        private readonly IdentityContext _context;

        public AuthRepository(IdentityContext context)
        {
            _context = context;
        }

        public Task<TResponse> AuthenticateUser<TResponse>(TResponse model)
        {
            throw new NotImplementedException();
        }

        public Task<TResponse> RegisterUser<TResponse>(TResponse model)
        {
            throw new NotImplementedException();
        }

        public Task<TResponse> ValidateAccess<TResponse>(TResponse model)
        {
            throw new NotImplementedException();
        }
    }

}
