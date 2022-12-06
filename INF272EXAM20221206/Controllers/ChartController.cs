using INF272EXAM20221206.Models;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace INF272EXAM20221206.Controllers
    {
    public class ChartController : Controller
        {
        // GET: Chart
        public ActionResult Index()
            {
            List<NumberSoldVM> NumbersSold = new List<NumberSoldVM>();

            foreach (var store in GameStoreRepository.Stores)
                {
                NumberSoldVM temp = new NumberSoldVM
                    {
                    StoreName = store.Name,
                    NumberSold = GameStoreRepository.Sales.Where(zz => zz.GameId == 4 && zz.StoreId == store.Id).Count()
                    };

                NumbersSold.Add(temp);
                };

            return View(NumbersSold);
            }

        public JsonResult TableView()
            {
            List<NumberSoldDetailedVM> numbersSoldDetailed = new List<NumberSoldDetailedVM>();

            foreach (var store in GameStoreRepository.Stores)
                {
                // get id of most sold game in sales list
                var mostSoldId = GameStoreRepository.Sales.Where(x => x.StoreId == store.Id).GroupBy(k => k.GameId).OrderByDescending(s => s.Count()).First().Key;

                // create viewmodel
                NumberSoldDetailedVM temp = new NumberSoldDetailedVM
                    {
                    storeName = store.Name,
                    numMostSold = GameStoreRepository.Sales.Count(zz => zz.GameId == mostSoldId && zz.StoreId == store.Id),
                    gameName = GameStoreRepository.Games.Where(zz => zz.Id == mostSoldId).FirstOrDefault().Title
                    };

                numbersSoldDetailed.Add(temp);
                }

            return Json(numbersSoldDetailed, JsonRequestBehavior.AllowGet);
            }
        }
    }