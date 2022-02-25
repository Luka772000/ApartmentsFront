﻿using APARTMENTS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APARTMENTS.Dtos
{
    public class MemberDto
    {
        public int  Id {get;set;}
        public string Username { get; set; }
        public int Age { get; set; }
        public int UserRole { get; set; }


        public int PhoneNumber { get; set; }
        public CardDto Card { get; set; }
    }
}
