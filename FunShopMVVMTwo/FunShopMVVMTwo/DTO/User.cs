﻿using System;
using System.Collections.Generic;
using System.Text;

namespace FunShopMVVMTwo.DTO
{
    internal class User
    {
        public int Id { get; set; }

        public string Login { get; set; }

        public string Password { get; set; }

        public string Role { get; set; }
    }
}
