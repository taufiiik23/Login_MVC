﻿using Login.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Login.Models
{
    public class User : BaseModel
    {
        public string Email { get; set; }
        public string Password { get; set; }
    }
}