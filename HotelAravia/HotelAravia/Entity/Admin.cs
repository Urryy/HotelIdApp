using HotelAravia.Exceptions;
using HotelAravia.Handler;
using System;
using System.Collections.Generic;
using System.Text;

namespace HotelAravia.Entity
{
    public class Admin : User
    {
        private static uint AdminIDcounter = 1;
        public Admin(string login, string password, string name)
        {
            Login = login;
            Password = password;
            Name = name;
            UserID = AdminIDcounter;
            try
            {
                BookingHandlerSingleton.Instance.TryAddAdminToDB(this);
            }
            catch (UserException exception)
            {
                throw exception;
            }
            AdminIDcounter++;
        }
    }
}
