using Microsoft.AspNetCore.Mvc;
using TravelMate.Api.Dtos.Comment;

namespace TravelMate.Api.Controllers;

[Route("api/comments")]
[ApiController]
public class CommentController : ControllerBase
{
    public CommentController()
    {
    }

    [HttpGet]
    public async Task<IActionResult> GetAllComments()
    {
        return Ok();
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetCommentById([FromRoute] int id)
    {
        return Ok();
    }

    [HttpPost]
    public async Task<IActionResult> AddComment([FromBody] CreateCommentDto createCommentDto)
    {

        return Ok();
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> UpdateComment([FromRoute] int id, [FromBody] UpdateCommentDto updateCommentDto)
    {
        return Ok();
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteComment([FromRoute] int id)
    {
        return Ok();
    }

}