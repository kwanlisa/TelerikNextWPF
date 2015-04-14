﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06RadChartViewDrillDown.ChartUtilities
{
    public class DrillDownHelper
    {
        public DrillDownHelper(IEnumerable data, string catBinding, string valBinding, string seriesType, string friendlyName)
        {
            this.Data = data;
            this.CatBinding = catBinding;
            this.ValBinding = valBinding;
            this.SeriesType = seriesType;
            this.FriendlyName = friendlyName;
        }

        public IEnumerable Data { get; private set; }
        public string CatBinding { get; private set; }
        public string ValBinding { get; private set; }
        public string SeriesType { get; private set; }
        internal string FriendlyName { get; private set; }
    }
}
