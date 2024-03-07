using Amazon.Data;
using Amazon.Models;
using Amazon.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace Amazon.Controllers
{
    public class StoreController : Controller
    {
        private readonly AmazonContext _context;
        public StoreController(AmazonContext context)
        {
            _context = context;
        }
        [HttpPost]
        public IActionResult StoreInfo([FromBody] StoreModel storeView)
        {
            AmzStore store = new AmzStore();

            store.ID = Convert.ToInt32(storeView.ID);
            store.STORE_NAME = storeView.StoreName;
            store.STORE_POSTALCODE = storeView.postalcode;
            store.STORE_LOCATION = storeView.StoreLocation;
            store.STORE_CITY = storeView.city;
            store.STORE_ADDRESS = storeView.address;
            _context.AmzStore.Add(store);
            _context.SaveChanges();
            TempData["Message"] = "File successfully uploaded to Database";
            return RedirectToAction("Index");
        }
    }
}
