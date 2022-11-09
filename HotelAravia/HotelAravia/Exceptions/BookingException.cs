using HotelAravia.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace HotelAravia.Exceptions
{
    public class BookingException : Exception
    {
        public BookingException(Booking booking)
            : base(String.Format("The suite is booked on these dates: {0}", booking.ID.ToString()))
        {

        }
    }
}
