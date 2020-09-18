using SocialMedia.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SocialMedia.Infrastructure.Repositories
{
    public class UserRepository
    {

        public IEnumerable<User> GetUsers()
        {
            var users = Enumerable.Range(1, 99).Select(x=> new User
            { 
            Id = x,
            Nombre = $"Nombre Nº {x}"
            });

            return users;
        }
    }
}
