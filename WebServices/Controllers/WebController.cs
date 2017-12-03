using System.Collections.Generic;
using System.Web.Http;
using WebServices.Models;

namespace WebServices.Controllers
{
    public class WebController : ApiController
    {
        private ReservationRespository repo = ReservationRespository.Current;
        public IEnumerable<Reservation> GetAllReservations()
        {
            System.Diagnostics.Debug.WriteLine("GetAllReservations");
            return repo.GetAll();
        }
        public Reservation GetReservation(int id)
        {
            System.Diagnostics.Debug.WriteLine("GetReservation");
            return repo.Get(id);
        }

        [HttpPost]
        public Reservation CreateReservation(Reservation item)
        {
            System.Diagnostics.Debug.WriteLine("CreateReservation");
            return repo.Add(item);
        }

        [HttpPut]
        public bool UpdateReservation(Reservation item)
        {
            System.Diagnostics.Debug.WriteLine("UpdateReservation");
            return repo.Update(item);
        }
        public void DeleteReservation(int id)
        {
            System.Diagnostics.Debug.WriteLine("DeleteReservation");
            repo.Remove(id);
        }
    }
}