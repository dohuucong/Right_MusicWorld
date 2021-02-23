using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MusicWorld.Models;
using MusicWorld.Models.ViewModel;

namespace MusicWorld.Controllers
{
    public class AlbumsController : Controller
    {
        private IMusicReposity repository;

        public AlbumsController(IMusicReposity repo)
        {
            repository = repo;
        }

        public IActionResult Rap() => View(
            new ProductListViewModel
            {

                Songs = repository.Songs
                .Where(p => p.Category == "Rap")
                .OrderBy(p => p.Id)
                .Take(6),
                Events = repository.Events
                .OrderBy(p => p.Id)
                .Take(5),
                Albums = repository.Albums
                .OrderBy(p => p.Id)
                .Take(12),
                Artists = repository.Artists
                .OrderBy(p => p.Id)
                .Take(6)
            });

        public IActionResult Rock() => View(
            new ProductListViewModel
            {

                Songs = repository.Songs
                .Where(p => p.Category == "Rock")
                .OrderBy(p => p.Id)
                .Take(6),
                Events = repository.Events
                .OrderBy(p => p.Id)
                .Take(5),
                Albums = repository.Albums
                .OrderBy(p => p.Id)
                .Take(12),
                Artists = repository.Artists
                .OrderBy(p => p.Id)
                .Take(6)
            });

        public IActionResult Pop() => View(
            new ProductListViewModel
            {

                Songs = repository.Songs
                .Where(p => p.Category == "Pop")
                .OrderBy(p => p.Id)
                .Take(6),
                Events = repository.Events
                .OrderBy(p => p.Id)
                .Take(5),
                Albums = repository.Albums
                .OrderBy(p => p.Id)
                .Take(12),
                Artists = repository.Artists
                .OrderBy(p => p.Id)
                .Take(6)

            });

        public IActionResult Jazz() => View(
            new ProductListViewModel
            {

                Songs = repository.Songs
                .Where(p => p.Category == "Jazz")
                .OrderBy(p => p.Id)
                .Take(6),
                Events = repository.Events
                .OrderBy(p => p.Id)
                .Take(5),
                Albums = repository.Albums
                .OrderBy(p => p.Id)
                .Take(12),
                Artists = repository.Artists
                .OrderBy(p => p.Id)
                .Take(6)
            });

        public IActionResult Classsical() => View(
            new ProductListViewModel
            {

                Songs = repository.Songs
                .Where(p => p.Category == "Classical")
                .OrderBy(p => p.Id)
                .Take(6),
                Events = repository.Events
                .OrderBy(p => p.Id)
                .Take(5),
                Albums = repository.Albums
                .OrderBy(p => p.Id)
                .Take(12),
                Artists = repository.Artists
                .OrderBy(p => p.Id)
                .Take(6)
            });

        public IActionResult Ballad() => View(
            new ProductListViewModel
            {

                Songs = repository.Songs
                .Where(p=> p.Category == "Ballad")
                .OrderBy(p => p.Id)
                .Take(6),
                Events = repository.Events
                .OrderBy(p => p.Id)
                .Take(5),
                Albums = repository.Albums
                .OrderBy(p => p.Id)
                .Take(12),
                Artists = repository.Artists
                .OrderBy(p => p.Id)
                .Take(6)
            });
    }
}
