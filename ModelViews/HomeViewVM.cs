﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebGoMarkets.Models;

namespace WebGoMarkets.ModelViews
{
    public class HomeViewVM
    {
        public List<TinDang> TinTucs { get; set; }
        public List<ProductHomeVM> Products { get; set; }
        public QuangCao quangcao { get; set; }
    }
}
