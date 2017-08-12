using AutoMapper;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Vidly.Dtos;
using Vidly.Models;

namespace Vidly.Controllers.Api
{
    public class MoviesController : ApiController
    {
        private ApplicationDbContext _context;

        public MoviesController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        // GET api/movies
        [HttpGet]
        public IHttpActionResult GetMovies()
        {
            var movieDtos = _context.Movies
                .Include(m => m.Genre)
                .ToList()
                .Select(Mapper.Map<Movie, MovieDto>);

            return Ok(movieDtos);
        }

        // GET api/movies/{movie_id}
        [HttpGet]
        public IHttpActionResult GetMovie(int id)
        {
            var movie = _context.Movies.SingleOrDefault(m => m.Id == id);

            if (movie == null)
                return NotFound();

            return Ok(Mapper.Map<Movie, MovieDto>(movie));
        }

        // POST api/
        [HttpPost]
        public IHttpActionResult CreateMovie(MovieDto movieDto)
        {
            movieDto.DateAdded = DateTime.Now;

            if (!ModelState.IsValid)
                return BadRequest();

            var movie = Mapper.Map<MovieDto, Movie>(movieDto);
            _context.Movies.Add(movie);
            _context.SaveChanges();

            movieDto.Id = movie.Id;

            return Created(new Uri(Request.RequestUri + "/" + movie.Id), movieDto);
        }

        // PUT api/movies/{movie_id}
        [HttpPut]
        public IHttpActionResult UpdateMovie(int id, MovieDto movieDto)
        {
            var movie = _context.Movies.SingleOrDefault(m => m.Id == id);

            if (movie == null)
                return NotFound();

            Mapper.Map(movieDto, movie);
            _context.SaveChanges();

            return Ok();
        }

        // DELETE api/movies/{movie_id}
        [HttpDelete]
        public IHttpActionResult DeleteMovie(int id)
        {
            var movie = _context.Movies.SingleOrDefault(m => m.Id == id);

            if (movie == null)
                return NotFound();

            _context.Movies.Remove(movie);
            _context.SaveChanges();

            return Ok();
        }


    }


}
