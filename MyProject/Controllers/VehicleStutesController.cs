using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyProject.Controllers
{
    public class VehicleStutesController : Controller
    {
        Models.MyDBContext db = new Models.MyDBContext();
        // GET: VehicleStutes
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult getVehicleStutes(int cus = 0 ,int ves = 0)
        {
            if (cus != 0 && ves == 0)
            {
                var statuses = (from vs in db.VehicleStatuses where vs.Vehicle.Customer.Id == cus select new { vs.Id, vs.Status, vs.Vehicle.Customer.Address, vs.Vehicle.Model, vs.Vehicle.Number }).Take(1000);
                return Json(statuses.ToList(), JsonRequestBehavior.AllowGet);
            }
            else if (ves != 0)
            {
                var statuses = (from vs in db.VehicleStatuses where vs.Vehicle.Id == ves select new { vs.Id, vs.Status, vs.Vehicle.Customer.Address, vs.Vehicle.Model, vs.Vehicle.Number }).Take(1000);
                return Json(statuses.ToList(), JsonRequestBehavior.AllowGet);
            }
            else
            {
                var statuses = (from vs in db.VehicleStatuses select new { vs.Id, vs.Status, vs.Vehicle.Customer.Address, vs.Vehicle.Model, vs.Vehicle.Number }).Take(1000);
                return Json(statuses.ToList(), JsonRequestBehavior.AllowGet);
            }
        }
        public ActionResult getAllCutomarse()
        {
            var customar = from cu in db.Customers select new { cu.Id, cu.Address };
            return Json(customar.ToList(), JsonRequestBehavior.AllowGet);
        }
        public ActionResult getAllVehicles(int cus = 0)
        {
            if (cus != 0)
            {
                var vehicles = from ve in db.Vehicles where ve.Customer.Id == cus select new { ve.Id, ve.Number };
                int x = vehicles.Count();
                return Json(vehicles.ToList(), JsonRequestBehavior.AllowGet);
            }
            else
            {
                var vehicles = from ve in db.Vehicles select new { ve.Id, ve.Number };
                int x = vehicles.Count();
                return Json(vehicles.ToList(), JsonRequestBehavior.AllowGet);
            }
        }
    }
}