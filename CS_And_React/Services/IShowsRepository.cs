using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Site_Api.Entities;
using Site_Api.Models;

namespace Site_Api.Services
{
    public interface IShowsRepository
    {
        public Task<IList<Show>?> GetShows(string? type, string? search);

        public Task<Show?> GetShow(int showId);
        public Task<Show?> AddShow(MinifiedShow show);
        public Task<Show?> UpdateShow(int showId, MinifiedShow show);
        public Task<Show?> PartiallyUpdateShow(int showId, JsonPatchDocument<Show> patchDocument, ModelStateDictionary modelState);
        public Task<Show?> DeleteShow(int showId);
        public Task<bool> DoesShowExist(int showId);
    }
}
