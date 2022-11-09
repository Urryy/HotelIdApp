using HotelAravia.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace HotelAravia.Exceptions
{
    public class SuiteException : Exception
    {
        public SuiteException(Suite suite)
            : base(String.Format("An error occured while managing suites ID: {0}", suite.RoomID.ToString()))
        {

        }
    }
}
