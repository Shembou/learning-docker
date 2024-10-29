using AutoMapper;
using Site_Api.Entities;
using Site_Api.enums;
using Site_Api.Models;

namespace Site_Api.Profiles
{
    public class ShowProfile : Profile
    {
        public ShowProfile()
        {
            CreateMap<ShowDto, Show>()
                .ForMember(dest => dest.ShowId, opt => opt.MapFrom(src => Int32.Parse(src.ShowId)))
                .ForMember(dest => dest.Poster, opt => opt.MapFrom(src => new Uri(src.Poster)))
                .ForMember(dest => dest.Metascore, opt => opt.MapFrom(src => ParseScore(src.Metascore)))
                .ForMember(dest => dest.ImdbRating, opt => opt.MapFrom(src => ParseImdbRating(src.ImdbRating)))
                .ForMember(dest => dest.ImdbVotes, opt => opt.MapFrom(src => ParseScore(src.ImdbVotes.Replace(",", ""))))
                .ForMember(dest => dest.Images, opt => opt.MapFrom(src => MapToImagesList(src.Images)))
                .ForMember(dest => dest.Type, opt => opt.MapFrom(src => MapToShowType(src.Type)))
                .ForMember(dest => dest.Genre, opt => opt.MapFrom(src => MapToList(src.Genre)))
                .ForMember(dest => dest.Actors, opt => opt.MapFrom(src => MapToList(src.Actors)));

            CreateMap<MinifiedShow, Show>();
        }
        private static IList<string> MapToList(string stringToConvert)
        {
            return stringToConvert
                .Split(',', StringSplitOptions.RemoveEmptyEntries)
                .Select(s => s.Trim()).ToList();
        }
        private static ShowType MapToShowType(string? typeString)
        {
            return typeString?.ToLower() switch
            {
                "movie" => ShowType.movie,
                "series" => ShowType.series,
                _ => ShowType.unknown, // Default value if mapping fails
            };
        }
        private static List<Uri> MapToImagesList(List<string?> imagesList)
        {
            var mappedList = new List<Uri>();
            foreach (var image in imagesList)
            {
                mappedList.Add(new Uri(image));
            }
            return mappedList;
        }

        private static int ParseScore(string? scoreString)
        {
            if (string.IsNullOrWhiteSpace(scoreString) || scoreString == "N/A")
            {
                return 0;
            }

            if (int.TryParse(scoreString, out int result))
            {
                return result;
            }

            return 0;
        }
        private static float ParseImdbRating(string? imdbRatingString)
        {
            if (string.IsNullOrWhiteSpace(imdbRatingString) || imdbRatingString == "N/A")
            {
                return 0;
            }

            if (float.TryParse(imdbRatingString.Replace(",", ""), out float result))
            {
                return result;
            }

            return 0;
        }
    }

}