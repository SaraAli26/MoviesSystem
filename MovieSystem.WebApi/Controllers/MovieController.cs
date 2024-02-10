using MovieSystem.Application.Feature.Movies.Commands.Models;
using MovieSystem.Application.Feature.Movies.Queries.Models;
using Microsoft.AspNetCore.Mvc;
using MovieSystem.WebApi.Controllers;
using MediatR;
using MovieSystem.API.Controllers;

namespace MovieSystem.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class MovieController : ApiBaseController
    {


        //query
        [HttpGet("GetAllMovies")]
        public async Task<IActionResult> GetAllExperiences()
        {
            var result = await Mediator.Send(new GetAllMoviesQuery());
            return NewResult(result);
        }

        [HttpGet("GetMovieById")]
        public async Task<IActionResult> GetMovieById([FromQuery] GetMovieByIdQuery query)
        {
            var result = await Mediator.Send(query);

            return NewResult(result);
        }

        //Commands
        [HttpPost("AddMovie")]
        public async Task<IActionResult> AddExperience(AddMovieCommand command)
        {
            var result = await Mediator.Send(command);
            return NewResult(result);
        }

        [HttpPut("UpdateMovie")]
        public async Task<IActionResult> UpdateExperience(UpdateMovieCommand command)
        {
            var result = await Mediator.Send(command);
            return NewResult(result);
        }

        [HttpDelete("RemoveMovie")]
        public async Task<IActionResult> RemoveExperience(DeleteMovieCommand command)
        {
            var result = await Mediator.Send(command);
            return NewResult(result);
        }

    }
}