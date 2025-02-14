using MediatR;
using Microsoft.AspNetCore.Mvc;
using TravelMate.Api.Dtos.Post;

namespace TravelMate.Api.Controllers;

[Route("api/posts")]
[ApiController]
public class PostController : ControllerBase
{
    private readonly ISender _mediator;
    public PostController(ISender mediator)
    {
        _mediator = mediator;
    }

    [HttpGet]
    public async Task<ActionResult<List<PostResponseDto>>> GetAllPosts()
    {
        return Ok();
    }


    [HttpGet("{id}")]
    public async Task<ActionResult<PostResponseDto>> GetOnePostById([FromRoute] int id)
    {
        return Ok();
    }

    [HttpPost]
    public async Task<ActionResult<PostResponseDto>> AddPost([FromBody] CreatePostDto createPostDto)
    {
        return Ok();
    }

    [HttpPut]
    [Route("{id}")]
    public async Task<ActionResult<PostResponseDto>> UpdatePost([FromRoute] int id, [FromBody] UpdatePostDto updatePostDto)
    {
        return Ok();
    }

    [HttpDelete]
    [Route("{id}")]
    public async Task<ActionResult> DeletePost([FromRoute] int id)
    {
        return NoContent();
    }
}
