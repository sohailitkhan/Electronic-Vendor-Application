using Amazon.Data;
using Amazon.Models;
using Amazon.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace Amazon.Controllers
{
    public class ManufacturerController : Controller
    {
        private readonly AmazonContext _context;
        public ManufacturerController(AmazonContext context)
        {
            _context = context;
        }
        [HttpPost]
        public IActionResult CreateInventoryRequest([FromBody] ManufacturerModel manufacturerModel)
        {
            AmzManufacturer amzManufacturer = new AmzManufacturer();

            amzManufacturer.ID = Convert.ToInt32(manufacturerModel.ID);
            amzManufacturer.WAREHOUSE_NAME = manufacturerModel.Name;
            amzManufacturer.WAREHOUSE_ADDRESS = manufacturerModel.address;
            amzManufacturer.WAREHOUSE_CITY = manufacturerModel.city;
            amzManufacturer.WAREHOUSE_LOCATION = manufacturerModel.Location;
            amzManufacturer.WAREHOUSE_POSTALCODE = manufacturerModel.postalcode;
            _context.AmzManufacturer.Add(amzManufacturer);
            _context.SaveChanges();
            TempData["Message"] = "File successfully uploaded to Database";
            return RedirectToAction("Index");
        }
    }
}
