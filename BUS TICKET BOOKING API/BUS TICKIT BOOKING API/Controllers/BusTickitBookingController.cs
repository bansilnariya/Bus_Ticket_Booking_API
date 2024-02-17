using BUS_TICKIT_BOOKING_API.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Query.Internal;

namespace BUS_TICKIT_BOOKING_API.Controllers
{
    [Route("BUS")]
    [ApiController]
    public class BusTickitBookingController : ControllerBase
    {
        private readonly BusDBContext db;

        public BusTickitBookingController(BusDBContext context)
        {
            this.db = context;

        }

        //[HttpGet]
        //[Route("GetByIdData")]
        //public IEnumerable<BUS> Get([FromQuery] int id)
        //{

        //    var res = db.bustickitbooking.Where(X => X.Id == id);
        //    db.SaveChanges();
        //    return res;

        //}

        //getall data
        [HttpGet]
        
        public IEnumerable<BUS> getalldata()
        {
                        
                return db.bustickitbooking.ToList();
             
        }



            
        [HttpPost]
        public IActionResult Post([FromBody] BUS bus)
        {
            if (bus == null)
            {
                return Ok(ErrorCode.INVALID_DATA);
            }
            else
            {
                try
                {
                    db.bustickitbooking.Add(bus);
                    db.SaveChanges();
                    return Ok(ErrorCode.INSERT_DATA);

                }
                catch (Exception)
                {
                    return Ok(ErrorCode.ERROR);
                }
            }
        }
        [HttpPut]
        public IActionResult Put(int id, [FromBody] BUS bus)
        {
            if (bus == null)
            {
                return Ok(ErrorCode.INVALID_DATA);
            }
            else
            {
                try
                {
                    var updatebustickit = db.bustickitbooking.Find(id);
                    if (updatebustickit == null)
                    {
                        return Ok(ErrorCode.INVALID_DATA);
                    }
                    updatebustickit.p_Name = bus.p_Name;
                    updatebustickit.p_Age = bus.p_Age;
                    updatebustickit.p_Xender = bus.p_Xender;
                    updatebustickit.b_Name = bus.b_Name;
                    updatebustickit.b_No = bus.b_No;
                    updatebustickit.set_No = bus.set_No;
                    updatebustickit.b_Pickuppoint = bus.b_Pickuppoint;
                    updatebustickit.b_Dropingpoint = bus.b_Dropingpoint;
                    updatebustickit.b_Booking_DateTime = bus.b_Booking_DateTime;
                    updatebustickit.price = bus.price;
                    db.SaveChanges();
                    return Ok(ErrorCode.UPDATE_DATA);


                }
                catch (Exception)
                {
                    return Ok(ErrorCode.ERROR);
                }
            }
        }

        [HttpDelete]
        public IActionResult Delete(int id)
        {
            try
            {
                var deletebustickit = db.bustickitbooking.Find(id);
                if (deletebustickit == null)
                {
                    return Ok(ErrorCode.INVALID_DATA);
                }
                db.bustickitbooking.Remove(deletebustickit);
                db.SaveChanges();
                return Ok(ErrorCode.DELETE_DATA);


            }
            catch (Exception)
            {
                return Ok(ErrorCode.ERROR);
            }

        }
    }
}