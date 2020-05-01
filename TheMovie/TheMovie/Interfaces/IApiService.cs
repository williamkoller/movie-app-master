﻿using System.Collections.Generic;
using System.Threading.Tasks;
using TheMovie.Models;

namespace TheMovie.Interfaces
{
    public interface IApiService
    {
        Task<SearchMovie> SearchMoviesAsync(string searchTerm, int page);

        Task<SearchMovie> GetMoviesByCategoryAsync(int page, Enums.MovieCategory sortBy);

        Task<MovieDetail> GetMovieDetailAsync(int id);

        Task<MovieImage> GetMovieImagesAsync(int id);
       
        Task<MovieVideo> GetMovieVideosAsync(int id);

        Task<List<Genre>> GetGenresAsync();
    }
}