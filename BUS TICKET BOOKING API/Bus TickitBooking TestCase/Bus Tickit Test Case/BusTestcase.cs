using BUS_TICKIT_BOOKING_API.Controllers;
using BUS_TICKIT_BOOKING_API.Model;
using Microsoft.EntityFrameworkCore;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bus_TickitBooking_TestCase.Bus_Tickit_Test_Case
{
    public class BusTestcase
    {
       
        public readonly DbContextOptions<BusDBContext> _options;
        public BusDBContext db;
        public BusTickitBookingController controller;

        public BusTestcase()
        {
            _options = new DbContextOptionsBuilder<BusDBContext>().UseInMemoryDatabase(databaseName: "BusTickitBookingDatabase").Options;
            db = new BusDBContext(_options);
            controller = new BusTickitBookingController(db);


        }

        private static BUS insertbustickitdata()
        {
            return new BUS()
            {
                id = 10,
                p_Name = "Mr.Test",
                p_Age = 20,
                p_Xender = "Male",
                b_Name = "Apple",
                b_No = 2520,
                set_No = "U-12",
                b_Pickuppoint = "JAMNAGAR",
                b_Dropingpoint = "SURAT",
                b_Booking_DateTime = DateTime.Now.AddDays(-1),
                price = 1200
            };

        }
        //get data
        [Fact]
        public void getbustickitdata()
        {
            //Setup
            var bustickitdata=insertbustickitdata();
            db.bustickitbooking.Add(bustickitdata);
            db.SaveChanges();

            //Exicute
            var res = controller.getalldata();

            //Assert
            Assert.NotNull(res);
            Assert.Equal("Mr.Test",res.FirstOrDefault().p_Name);   
        }


        //Insert Data

        [Fact]
        public void Insert_BusTickit_Data()
        {
            //Setup
            var bustickit = insertbustickitdata();

            //Exicute
            var result= controller.Post(bustickit);
            var data = db.bustickitbooking.FirstOrDefault(X=>X.id == bustickit.id);
            db.SaveChanges();

            //Assert
            Assert.NotNull(result); 

        }

        //Updte Data
        [Fact]
        public void Update_BusTickitdata()
        {
            var upatebustickitdata = insertbustickitdata(); 
            db.bustickitbooking.Add(upatebustickitdata);
            db.SaveChanges();

            //Exicute
            var updatebustickit = new BUS()
            {
                id = 10,
                p_Name = "Mr.BANSIL",
                p_Age = 21,
                p_Xender = "Male",
                b_Name = "SHREEJI",
                b_No = 5090,
                set_No = "L-5",
                b_Pickuppoint = "JAMNAGAR",
                b_Dropingpoint = "RAJKOT",
                b_Booking_DateTime = DateTime.Now.AddDays(-1),
                price = 1200
            };

            //Exicute
            var res = controller.Put(updatebustickit.id,updatebustickit);
            var result= db.bustickitbooking.FirstOrDefault();

            //Assert
            Assert.Equal("Mr.BANSIL", result.p_Name);
            Assert.NotNull(result);


        }
        
        [Fact]
        public void Delete_BusTickitdata()
        {
            //Setup
            var deletedata = insertbustickitdata();

            //Exicute
            var res =controller.Delete(deletedata.id);
            var result= db.bustickitbooking.FirstOrDefault(x=>x.id==deletedata.id);
            //Assert
            Assert.Null(result);

        }

    }
}
