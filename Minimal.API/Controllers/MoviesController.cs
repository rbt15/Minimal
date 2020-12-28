using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Minimal.Core.Dtos;
using Minimal.Core.Dtos.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Minimal.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MoviesController : ControllerBase
    {
        private readonly IMediator _mediator;

        public MoviesController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        public async Task<ActionResult<string>> CreateMovieAsync([FromBody]CreateMovieRequest createMovieRequest)
        {
            BaseResponseDto<bool> createResponse = await _mediator.Send(createMovieRequest);

            if (createResponse.Data)
            {
                return Created("...", null);
            }
            else
            {
                return BadRequest(createResponse.Errors);
            }
        }

        [HttpGet("kids")]
        public async Task<ActionResult<List<MovieDto>>> GetBestMoviesForKidsAsync()
        {
            BaseResponseDto<List<MovieDto>> getBestMovieForKidsResponse = await _mediator.Send(new GetBestMoviesForKidsRequest());

            if (!getBestMovieForKidsResponse.HasError)
            {
                return Ok(getBestMovieForKidsResponse.Data);
            }
            else
            {
                return BadRequest(getBestMovieForKidsResponse.Errors);
            }
        }

        [HttpGet("movies")]
        public async Task<ActionResult<List<MovieDto>>> GetAllMoviesAsync()
        {
            BaseResponseDto<List<MovieDto>> getAllMoviesResponse = await _mediator.Send(new GetAllMoviesRequest());

            if (!getAllMoviesResponse.HasError)
            {
                return Ok(getAllMoviesResponse.Data);
            }
            else
            {
                return BadRequest(getAllMoviesResponse.Errors);
            }
        }
    }
}
