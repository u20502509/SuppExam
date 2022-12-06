using INF272EXAM20221206.OOP_Models;
using System;
using System.Collections.Generic;
using System.Web.Mvc;

namespace INF272EXAM20221206.Controllers
    {
    public class EnemyController : Controller
        {
        // GET: Enemy
        public ActionResult Index()
            {
            List<Enemy> enemies = new List<Enemy>();

            Vampire vampire1 = new Vampire(1.2, 80, 40, true);
            Vampire vampire2 = new Vampire(1.5, 50, 80, true);
            Vampire vampire3 = new Vampire(1.1, 100, 70, true);
            Vampire vampire4 = new Vampire(1.7, 40, 50, true);

            Werewolf werewolf1 = new Werewolf(1.2, 100, 40, DateTime.Now.AddDays(1).Date);
            Werewolf werewolf2 = new Werewolf(1.3, 50, 80, DateTime.Now.AddDays(2).Date);
            Werewolf werewolf3 = new Werewolf(1.6, 20, 90, DateTime.Now.AddDays(6).Date);
            Werewolf werewolf4 = new Werewolf(1.8, 70, 70, DateTime.Now.Date);

            enemies.Add(vampire1);
            enemies.Add(werewolf2);
            enemies.Add(vampire2);
            enemies.Add(werewolf4);
            enemies.Add(vampire4);
            enemies.Add(werewolf1);
            enemies.Add(werewolf3);
            enemies.Add(vampire3);

            return View(enemies);
            }
        }
    }