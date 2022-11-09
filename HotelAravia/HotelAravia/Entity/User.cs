using System;
using System.Collections.Generic;
using System.Text;

namespace HotelAravia.Entity
{
    public abstract class User
    {
        public string Login { get; protected set; }
        public string Password { get; protected set; }
        public string Name { get; protected set; }
        protected static uint ID;
        public uint UserID { get; protected set; }
    }
}
