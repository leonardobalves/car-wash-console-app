﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace car_wash_console_app
{
    internal class WashServices
    {
        public WashType Type { get; set; }

        public WashServices(WashType type)
        {
            this.Type = type;
        }

        public enum WashType
        {
            Fast,
            Long,
            Especial
        }

        public void StartWash(Employee employee)
        {
            employee.WorkingNow = true;
        }

    }
}
