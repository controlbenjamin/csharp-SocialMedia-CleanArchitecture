using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SocialMedia.Application.Common.Interfaces;
using SocialMedia.Domain.Entities;
using SocialMedia.Infrastructure.Repositories;

namespace SocialMedia.WebUI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PostController : ControllerBase
    {
        private readonly IPostRepository _postRepository;

        public PostController(IPostRepository postRepository)
        {
            _postRepository = postRepository;
        }


        [HttpGet]
        public async Task<IEnumerable<Post>> GetAll()
        {


            return await _postRepository.GetPosts();

        }

        [HttpGet("{id}")]
        public async Task<Post> Get(int id)
        {

            return await _postRepository.GetPost(id);

        }
    }
}
