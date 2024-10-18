using CodeFirstBasic.Context;
using CodeFirstBasic.Data.Entities;
using Microsoft.AspNetCore.Mvc;

namespace CodeFirstBasic.Controllers
{
    public class GameController : Controller
    {
        // veritabanındaki listenin kopyasını oluşturduk _context ile
        private readonly PatikaFirstDbContext _context; // _context içi boş bir değişken

        // DbContext ten context i Dependency Injection ile alıyoruz
        public GameController(PatikaFirstDbContext context)
        {
            // buraya her istek atıldığında db örneği istiyoruz.
            _context = context; 
            
        }

        public IActionResult List()
        {
            return View();
        }

        public IActionResult Add()
        {
            var newGame1 = new Game
            {
                Name = "The Last of Us",
                Platform = "PlayStation",
                Rating = 9.8m
            };

            var newGame2 = new Game
            {
                Name = "Cyberpunk 2077",
                Platform = "PC",
                Rating = 7.5m
            };

            Game newGame3 = new Game
            {
                Name = "Halo Infinite",
                Platform = "Xbox",
                Rating = 8.5m 
            };

            // eğer m koymazsak varsayılan olarak double kabul edeceği için hata verebilir bundan dolayı sayının sonuna m, M eklenir

            _context.Games.Add(newGame1);
            _context.Games.Add(newGame2);
            _context.Games.Add(newGame3); // Yapılan işlemler kopyasında yapıldı
            _context.SaveChanges(); // Gerçek veritabanına aktarılır.


            return Ok(); 
        }       

        public IActionResult Edit()
        {
            return View();
        }


        public IActionResult Delete()
        {
            return View();
        }

    }
}
