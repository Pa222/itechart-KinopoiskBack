﻿using System.Collections.Generic;
using System.Threading.Tasks;
using KinopoiskAPI.Dto;

namespace KinopoiskAPI.Services.Interfaces
{
    public interface IMovieService
    {
        public Task<MoviePageDto> GetPage(MoviePageDto info);

        public Task<MovieInfoDto> Get(int id);

        public Task<List<MovieInfoDto>> GetMoviesByTitle(string title);
    }
}