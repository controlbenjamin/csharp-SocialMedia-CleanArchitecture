using SocialMedia.Application.Common.Interfaces;
using SocialMedia.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialMedia.Infrastructure.Repositories
{
    public class PostOracleRepository : IPostRepository
    {
        public async Task<IEnumerable<Publicacion>> GetPosts()
        {
            var posts = Enumerable.Range(1, 99).Select(x => new Publicacion
            {
              IdPublicacion = x,
              IdUsuario = x * 3,
              Fecha = DateTime.Now,
              Descripcion = "Oracle Descripcion" + x.ToString()
            });

            await Task.Delay(1500);

            return posts;
        }
    }
}
