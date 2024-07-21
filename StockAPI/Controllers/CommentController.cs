using Microsoft.AspNetCore.Mvc;
using StockAPI.Interfaces;
using StockAPI.Mappers;
using System.Runtime.InteropServices;

namespace StockAPI.Controllers
{
    [Route("api/comment")]
    [ApiController]
    public class CommentController:ControllerBase
    {
        private readonly ICommentRepository _commentRepository;
        public CommentController(ICommentRepository commentRepo)
        {
            _commentRepository = commentRepo; 
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        { 
            var comments = await _commentRepository.GetAllAsync();

            var commentDto = comments.Select(s => s.ToCommentDto());

            return Ok(commentDto);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById([FromRoute] int id) 
        {
            var comment = await _commentRepository.GetByIdAsync(id);

            if (comment == null) 
            {
                return NotFound();
            }

            return Ok(comment.ToCommentDto());
        }
    }
}
