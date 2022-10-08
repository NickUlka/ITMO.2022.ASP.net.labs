using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ITMO._2022.ASP.net.MVC.Models.lab.Models;

namespace ITMO._2022.ASP.net.MVC.Models.lab.Controllers
{
    public class HomeController : Controller
    {
        private CreditContext db = new CreditContext();
        public ActionResult Index()
        {
            GiveCredits();

            return View();
        }
        //метод для получения информации о существующих кредитах
        private void GiveCredits()
        {
            var allCredits = db.Credits.ToList<Credit>();
            ViewBag.Credits = allCredits;
        }
        //возвращает из БД соответствующее представление c получением всех записей о
        //кредитах и заявках

        [HttpGet]
        public ActionResult CreateBid()
        {
                GiveCredits();
                var allBids = db.Bids.ToList<Bid>();
                ViewBag.Bids = allBids;

                return View();
        }

        //        метод принимает переданную ему в запросе POST модель
        //newBid и добавляет ее в базу данных.В конце возвращается строка
        //уведомительного сообщения

        [HttpPost]
        public string CreateBid(Bid newBid)
        {
            newBid.bidDate = DateTime.Now;
            // Добавляем новую заявку в БД
            db.Bids.Add(newBid);
            // Сохраняем в БД все изменения
            db.SaveChanges();
            return "Спасибо, <b>" + newBid.Name + "</b>, за выбор нашего банка. Ваша заявка будет рассмотрена в течении 10 дней.";
        }

    }
}