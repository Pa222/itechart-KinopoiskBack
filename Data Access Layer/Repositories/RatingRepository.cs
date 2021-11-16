﻿using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Data_Access_Layer.Entity;
using Data_Access_Layer.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Data_Access_Layer.Repositories
{
    public class RatingRepository : GenericRepository<Rating>, IRatingRepository
    {
        public RatingRepository(AppDbContext db) : base(db)
        {
        }

        public async Task<Rating> GetByMovieAndUser(int movieId, int userId)
        {
            return await Db.Ratings.AsNoTracking()
                //.Include(r => r.User)
                //.Include(r => r.Movie)
                .Where(r => r.MovieId == movieId && r.UserId == userId).FirstOrDefaultAsync(); ;
        }
    }
}