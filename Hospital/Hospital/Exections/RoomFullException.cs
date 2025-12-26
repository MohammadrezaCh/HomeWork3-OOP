using System;
using System.Collections.Generic;
using System.Text;

namespace Hospital.Exections
{
    public class RoomFullException : Exception
    {
        public RoomFullException(string message) : base(message) { }
    }
}
