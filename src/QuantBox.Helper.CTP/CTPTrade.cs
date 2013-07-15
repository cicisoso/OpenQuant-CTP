﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using SmartQuant.Data;

using QuantBox.CSharp2CTP;
using System.Reflection;

namespace QuantBox.Helper.CTP
{
    public class CTPTrade:Trade
    {
        public CTPTrade():base()
        {
        }

        public CTPTrade(Trade trade):base(trade)
        {
        }

        public CTPTrade(DateTime datetime, double price, int size)
            : base(datetime, price, size)
        {
        }

        public CThostFtdcDepthMarketDataField DepthMarketData;
    }
}
