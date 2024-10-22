using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter04_01
{
    class Rent
    {
        private string rentDate;
        private string customerId;
        private string videoId;
        public Rent (string date , string customer , string video)
        {
            rentDate = date;
            customerId = customer;
            videoId = video;
        }
        public string GetRentDate()
        {
            return rentDate;
        }
        public string GetCustomerId()
        {
            return customerId;
        }
        public string GetVideoId()
        {
            return videoId;
        }
    }
}
