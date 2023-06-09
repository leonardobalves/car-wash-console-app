﻿using MySqlX.XDevAPI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace car_wash_app
{
    internal class Vehicle
    {
        public int Id { get; set; }

        public static int NextId = 1;
        public string PlateNumber { get; set; }
        public string Color { get; set; }
        public string Model { get; set; }

        public bool IsBeingWashed = false;

        public int ClientId { get; set; }
        public virtual Client Client { get; set; }

        public Vehicle(string plate, string color, string model, Client client)
        {
            Id = NextId;
            NextId++;
            this.PlateNumber = plate;
            this.Color = color;
            this.Model = model;
            this.Client = client;
        }
    }
}
