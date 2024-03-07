using Amazon.Data;
using Amazon.Models;
using Amazon.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Globalization;

namespace Amazon.Controllers
{
    public class PlaceOrderController : Controller
    {
        private readonly AmazonContext _context;
        public PlaceOrderController(AmazonContext context)
        {
            _context = context;
        }
        [HttpPost]
        public IActionResult CreateOrder([FromBody] UserPlaceOrderModel userView)
        {
            AmzPlaceOrder User = new AmzPlaceOrder();

            User.ID = Convert.ToInt32(userView.ID);
            User.UserName = userView.UserName;
            User.ShipmemtId = Convert.ToInt32(userView.ShipmentId);
            User.address = userView.address;
            User.Email = userView.UserEmail;
            User.phone = userView.phone;
            User.Date = userView.Date;
            _context.AmzPlaceOrder.Add(User);
            _context.SaveChanges();
            TempData["Message"] = "File successfully uploaded to Database";
            return RedirectToAction("Index");
        }
    }
}
