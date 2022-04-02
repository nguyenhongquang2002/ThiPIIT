using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ThiPIIT.Data;
using ThiPIIT.Models;

namespace ThiPIIT.Controllers
{
    public class AdminController : Controller
    {
        MyDBContext db = new MyDBContext();
        // GET: Admin
        public ActionResult Market()
        {
            var result = db.makets.ToList();
            return View(result); ;
        }
        public ActionResult AddMarket()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult AddMarket([Bind(Include = "Name,Description,Status")] Market market)
        {
            if (ModelState.IsValid)
            {
                Market marketModel = new Market()
                {
                    name = market.name,
                    description = market.description,
                    createdAt = DateTime.Now,
                    updatedAd = DateTime.Now,
                    status = market.status
                };
                db.makets.Add(marketModel);
                db.SaveChanges();
                return RedirectToAction("Market");
            }

            return View(market);
        }
        public ActionResult Coin()
        {
            var result = db.coins.ToList();
            return View(result);
        }
        public ActionResult AddCoin()
        {

            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult AddCoin([Bind(Include = "Name,BaseAsset,QuoteAsset,LastPrice,Volumn24h,MarketId,Status")] Coin coin)
        {
            if (ModelState.IsValid)
            {
                Coin coinModel = new Coin()
                {
                    name = coin.name,
                    baseAsset = coin.baseAsset,
                    quoteAsset = coin.quoteAsset,
                    lastPrice = coin.lastPrice,
                    volumn24h = coin.volumn24h,
                    MarketId = coin.MarketId,
                    createdAt = DateTime.Now,
                    updatedAd = DateTime.Now,
                    status = coin.status
                };
                db.coins.Add(coinModel);
                db.SaveChanges();
                return RedirectToAction("Market");
            }

            return View(coin);
        }
    }
}