﻿using DBMovies.Domain;
using Microsoft.EntityFrameworkCore;

namespace DBMovies
{
    public class MovieContext: DbContext
    {
        public MovieContext(DbContextOptions<MovieContext> options)
        : base(options)
        {

        }
        public DbSet<Country> Countrys { get; set; }

    }
}