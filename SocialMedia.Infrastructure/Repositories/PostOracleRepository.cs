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
        public Task<Post> GetPost(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Post>> GetPosts()
        {
            var posts = Enumerable.Range(1, 99).Select(x => new Post
            {
              PostId = x,
              UserId = x * 3,
              Date = DateTime.Now,
              Description = "Oracle Description" + x.ToString()
            });

            await Task.Delay(1500);

            return posts;
        }
    }
}
