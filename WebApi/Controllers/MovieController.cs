using Domain.Dtos;
using Domain.Entities;
using Domain.Filters;
using Domain.Wrapper;
using Infrastructure.Services;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers;

[Route("api/[controller]")]
[ApiController]
public class MovieController
{
    private readonly FService _service;
    public MovieController(FService service)
    {
        _service = service;
    }

    [HttpGet("GetMovie")]
    public async Task<PaginationResponse<List<GetMovieDto>>> GetMovies([FromQuery]MovieFilter filter)
    {
        return await _service.GetMovies(filter);
    }

    [HttpGet("GetActor")]
    public async Task<Response<List<GetActorDto>>> GetActors()
    {
        return await _service.GetActors();
    }
    
    [HttpGet("GetCategory")]
    public async Task<Response<List<GetCategoryDto>>> GetCategories()
    {
        return await _service.GetCategories();
    }
}
