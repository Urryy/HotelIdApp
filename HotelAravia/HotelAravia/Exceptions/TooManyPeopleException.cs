using System;
using System.Collections.Generic;
using System.Text;

namespace HotelAravia.Exceptions
{
    public class TooManyPeopleException : Exception
    {
        public TooManyPeopleException(uint amount)
            : base(String.Format("Too much people for suite,that was set: {0}", amount.ToString()))
        {

        }
    }
}
