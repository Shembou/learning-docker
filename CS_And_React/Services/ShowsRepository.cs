using AutoMapper;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.EntityFrameworkCore;
using Site_Api.DbContexts;
using Site_Api.Entities;
using Site_Api.enums;
using Site_Api.Models;

namespace Site_Api.Services
{
    public class ShowsRepository : IShowsRepository
    {
        private readonly ApplicationDbContext _context;
        private readonly IMapper _mapper;
        public ShowsRepository(ApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<IList<Show>?> GetShows(string? type, string? searchQuery)
        {
            var result = new List<Show>();
            if (type != null)
            {
                result = await FilterShowsByType(type);
            }
            if (searchQuery != null)
            {
                result = await FilterShowsBySearchQuery(searchQuery);
            }
            if (result?.Count == 0)
            {
                result = await _context.Shows.ToListAsync();
            }
            return result;
        }
        public async Task<Show?> GetShow(int showId)
        {
            var result = await _context.Shows.FirstOrDefaultAsync(x => x.ShowId == showId);
            if (result == null)
            {
                return null;
            }
            return result;
        }
        public async Task<Show?> AddShow(MinifiedShow show)
        {
            var mappedShow = _mapper.Map<Show>(show);
            await _context.Shows.AddAsync(mappedShow);
            await _context.SaveChangesAsync();
            return mappedShow;
        }

        public async Task<Show?> UpdateShow(int showId, MinifiedShow show)
        {
            var selectedShow = await _context.Shows.FirstOrDefaultAsync(x => x.ShowId == showId);
            if (selectedShow == null)
            {
                return null;
            }
            _mapper.Map(show, selectedShow);
            await _context.SaveChangesAsync();
            return selectedShow;
        }

        public async Task<Show?> PartiallyUpdateShow(int showId, JsonPatchDocument<Show> patchDocument, ModelStateDictionary ModelState)
        {
            var selectedShow = await _context.Shows.FirstOrDefaultAsync(x => x.ShowId == showId);
            if (selectedShow == null)
            {
                return null;
            }
            patchDocument.ApplyTo(selectedShow, (error) =>
            {
                var affectedObject = error.AffectedObject?.ToString() ?? "Unknown";
                ModelState.AddModelError(affectedObject, error.ErrorMessage);
            });
            if (!ModelState.IsValid)
            {
                return null;
            }
            await _context.SaveChangesAsync();
            return selectedShow;
        }
        public async Task<Show?> DeleteShow(int showId)
        {
            var selectedShow = _context.Shows.FirstOrDefault(x => x.ShowId == showId);
            if (selectedShow != null)
            {
                _context.Shows.Remove(selectedShow);
                await _context.SaveChangesAsync();
                return selectedShow;
            }
            return null;
        }

        public async Task<bool> DoesShowExist(int showId)
        {
            return await _context.Shows.AnyAsync(x => x.ShowId == showId);
        }

        private async Task<List<Show>?> FilterShowsByType(string type)
        {
            var parsedEnum = Enum.TryParse(type, out ShowType showType);
            if (parsedEnum == false)
            {
                return null;
            }
            var filteredShows = await _context.Shows.Where(x => x.Type == showType).ToListAsync();
            if (filteredShows.Count == 0)
            {
                return null;
            }
            return filteredShows;
        }
        private async Task<List<Show>?> FilterShowsBySearchQuery(string searchQuery)
        {

            var searchedShows = await _context.Shows.Where(x =>
            x.Title.Contains(searchQuery) ||
            x.Writer!.Contains(searchQuery) ||
            x.Year.Contains(searchQuery) ||
            x.Actors!.Contains(searchQuery) ||
            x.Director!.Contains(searchQuery) ||
            x.Genre!.Contains(searchQuery) ||
            x.Language!.Contains(searchQuery)).ToListAsync();
            if (searchedShows.Count == 0)
            {
                return await _context.Shows.ToListAsync();
            }
            return searchedShows;
        }
    }
}
