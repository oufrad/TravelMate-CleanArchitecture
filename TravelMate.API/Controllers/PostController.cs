using Microsoft.AspNetCore.Mvc;
using TravelMate.Api.Dtos.Post;

namespace TravelMate.Api.Controllers;

[Route("api/posts")]
[ApiController]
public class PostController : ControllerBase
{
    public PostController()
    {
    }

    [HttpGet]
    public async Task<IActionResult> GetAllPosts()
    {
        return Ok();
    }


    [HttpGet("{id}")]
    public async Task<IActionResult> GetOnePostById([FromRoute] int id)
    {
        return Ok();
    }

    [HttpPost]
    public async Task<IActionResult> AddPost([FromBody] CreatePostDto createPostDto)
    {
        return Ok();
    }

    [HttpPut]
    [Route("{id}")]
    public async Task<IActionResult> UpdatePost([FromRoute] int id, [FromBody] UpdatePostDto updatePostDto)
    {
        return Ok();
    }

    [HttpDelete]
    [Route("{id}")]
    public async Task<IActionResult> DeletePost([FromRoute] int id)
    {
        return NoContent();
    }
}
