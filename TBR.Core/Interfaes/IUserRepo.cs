using System;
using System.Collections.Generic;
using System.Text;

namespace TBR.Core.Interfaes
{
    public interface IUserRepo
    {
        public User AddUser { get; set; }
        public User UpdateUser { get; set; }

        public int DeleteUser { get; set; }

    }
}
