﻿using HotelAravia.Entity;
using System;

namespace HotelAravia.Exceptions
{
    public class UserException : Exception
    {
        public UserException(User user)
            : base(String.Format("A problem occured, while adding User to DataBase(Login/passport ID is already in DB): {0}", user.UserID.ToString()))
        {

        }
    }
}
