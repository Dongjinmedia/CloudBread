﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CloudBread.Models
{
    public class SelSendEmailToMemberInputParams
    {
        public string memberID { get; set; }
        public string token { get; set; }
    }
}