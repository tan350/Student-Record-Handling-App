﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VO
{
    public class UserVO
    {
        public string UserRole { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }

        public string ErrorMessage { get; set; }
    }
}
