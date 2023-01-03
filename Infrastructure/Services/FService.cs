using AutoMapper;
using Domain.Dtos;
using Domain.Filters;
using Domain.Wrapper;
using Infrastructure.Context;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Services;

public class FService
{
    private readonly DataContext _context;
    private readonly IMapper _mapper;
    public FService(DataContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    public async Task<PaginationResponse<List<GetMovieDto>>> GetMovies(MovieFilter filter)
    {
        var query = _context.Movies.AsQueryable();
        
            if(filter.Name == null) query = query.Where(x=>x.Title != null);
            if(filter.Name != null) query = query.Where(x => x.Title.Contains(filter.Name));
            if(filter.Category != null) query = query.Where(x => x.CategoryId == filter.Category);
            var filtered = await query.Skip((filter.PageNumber - 1) * filter.PageSize)
            .Take(filter.PageSize).ToListAsync();


        var list = _mapper.Map<List<GetMovieDto>>(filtered);
        var totalRecords = await _context.Movies.CountAsync();

        return new PaginationResponse<List<GetMovieDto>>(list, totalRecords, filter.PageSize, filter.PageNumber);
    }
    // ------------------------------------------------------------------------------------------------------------------
    public async Task<Response<List<GetActorDto>>> GetActors()
    {
        var list = _mapper.Map<List<GetActorDto>>(await _context.Actors.ToListAsync());
        return new Response<List<GetActorDto>>(list);
    }

    public async Task<Response<List<GetCategoryDto>>> GetCategories()
    {
        var list = _mapper.Map<List<GetCategoryDto>>(await _context.Categories.ToListAsync());
        return new Response<List<GetCategoryDto>>(list);
    }
}
