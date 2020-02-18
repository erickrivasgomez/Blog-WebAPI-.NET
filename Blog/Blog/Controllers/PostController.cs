using Blog.Models;
using Blog.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;

namespace Blog.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PostController : ControllerBase
    {
        private PostService _postService;
        private readonly ILogger<PostController> _logger;

        public PostController(ILogger<PostController> logger, PostService postService)
        {
            _postService = postService;
            _logger = logger;
        }

        // GET: api/Post
        [HttpGet]
        public PostDTO Get()
        {
            return _postService.GetPosts();
        }
        
        /*
        // GET: api/Post/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }
        */

        // POST: api/Post
        [HttpPost]
        public PostDTO Post([FromBody] Post post)
        {
            return _postService.AddPost(post);
        }

        // PUT: api/Post/5
        [HttpPut("{id}")]
        public PostDTO Put(int id, [FromBody] Post post)
        {
            return _postService.EditPost(id, post);
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public PostDTO Delete(int id)
        {
            return _postService.DeletePost(id);
        }
    }
}
