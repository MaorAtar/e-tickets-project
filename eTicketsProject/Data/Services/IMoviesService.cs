﻿using eTicketsProject.Data.Base;
using eTicketsProject.Data.ViewModels;
using eTicketsProject.Models;

namespace eTicketsProject.Data.Services
{
    public interface IMoviesService : IEntityBaseRepository<Movie>
    {
        Task<Movie> GetMovieByIdAsync(int id);
        Task<NewMovieDropdownsVM> GetNewMovieDropdownsValues();
        Task AddNewMovieAsync(NewMovieVM data);
    }
}
