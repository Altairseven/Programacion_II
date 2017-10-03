﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyectores.Classes {
    public class Db_ComboItem {
        public decimal ID { get; set; }
        public string Text { get; set; }

        public Db_ComboItem() {

        }

        public Db_ComboItem(decimal _id, string _text) {
            ID = _id;
            Text = _text;
        }
    }
}
