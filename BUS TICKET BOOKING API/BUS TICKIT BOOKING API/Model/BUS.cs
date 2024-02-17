using System.ComponentModel.DataAnnotations;

namespace BUS_TICKIT_BOOKING_API.Model
{
    public class BUS
    {
        [Key]
        public int id { get; set; }

        public string p_Name { get; set; }
        public int p_Age {  get; set; }

        public string p_Xender { get; set; }

        public string b_Name { get; set;}

        public int b_No { get; set; }   

        public string set_No { get; set; }
        public string b_Pickuppoint { get; set; }
        public string b_Dropingpoint { get; set; }
        public DateTime b_Booking_DateTime { get; set; } 
        public int price { get; set; }
    }
}
