﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public partial class AdminModel
    {
        public int admin_id { get; set; }

        public int user_id { get; set; }

        public string username { get; set; }

        public string password { get; set; }

        public string email { get; set; }

        public string full_name { get; set; }

        public string role { get; set; }
    }
}
