using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BilllingMachine.DataClasses
{
    class LoadRatesFactory : Factory
    {
        //Factory Method Implementation 
        public override ILoadData GetDataSource()
        {
            return new LoadRates();
        } 
    }
}
