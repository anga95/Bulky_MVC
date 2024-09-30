using bulky.DataAccess.Repository.IRepository;
using Bulky.Models;
using Bulky.Utility;
using Microsoft.AspNetCore.Mvc;


namespace BulkyWeb.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class OrderController : Controller
    {

        private readonly IUnitOfWork _unitOfWork;

        public OrderController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }



        public IActionResult Index()
        {
            return View();
        }

        #region Api Calls

        [HttpGet]
        public IActionResult GetAll(string status)
        {
            IEnumerable<OrderHeader> objOrderHeaders = _unitOfWork.OrderHeader.GetAll(includeProperties: "ApplicationUser").ToList();

            switch (status)
            {
                case SD.FilterPending:
                    objOrderHeaders = objOrderHeaders.Where(o => o.PaymentStatus == SD.PaymentStatusDelayedPayment);
                    break;
                case SD.FilterInProcess:
                    objOrderHeaders = objOrderHeaders.Where(o => o.OrderStatus == SD.StatusInProcess);
                    break;
                case SD.FilterCompleted:
                    objOrderHeaders = objOrderHeaders.Where(o => o.OrderStatus == SD.StatusShipped);
                    break;
                case SD.FilterApproved:
                    objOrderHeaders = objOrderHeaders.Where(o => o.OrderStatus == SD.StatusApproved);
                    break;
                default:
                    break;
            }

            return Json(new { data = objOrderHeaders });
        }

        #endregion
    }
}
