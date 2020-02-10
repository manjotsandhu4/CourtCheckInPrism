﻿using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace CourtCheckInPrism
{
    public class GeofenceEvent
    {
        [PrimaryKey]
        [AutoIncrement]
        public int Id { get; set; }

        public bool Entered { get; set; }
        public string Identifier { get; set; }
        public DateTime Date { get; set; }


        public string Text => this.Identifier;
        public string Detail => this.Entered
            ? $"Entered on {this.Date:MMM d 'at' h:mm tt}"
            : $"Exited on {this.Date:MMM d 'at' h:mm tt}";
    }
}
