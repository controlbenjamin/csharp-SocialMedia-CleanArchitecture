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


        //public async Task<IActionResult> GetPosts()
        //{
        //    var posts = await _postRepository.GetPosts();

        //    return Ok(posts);
        //}

        [HttpGet]
        public async Task<IEnumerable<Publicacion>> Get() {


            return await _postRepository.GetPosts();

        }
    }
}
