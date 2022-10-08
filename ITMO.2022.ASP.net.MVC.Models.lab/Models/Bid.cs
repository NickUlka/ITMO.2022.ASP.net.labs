using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ITMO._2022.ASP.net.MVC.Models.lab.Models
{
    //модель данных о заявке на кредит
    public class Bid
    {
        // ID заявки
        public virtual int BidId { get; set; }
        // Имя заявителя
        public virtual string Name { get; set; }
        // Название кредита
        public virtual string CreditHead { get; set; }
        // Дата подачи заявки
        public virtual DateTime bidDate { get; set; }

    }
}