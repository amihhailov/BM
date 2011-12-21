using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BilllingMachine.Data
{
    class FactoryCountry : Factory
    {
        // Factory Method Implementation 
        public override ILoadData GetDataSource() 
        {
            return new LoadCountry();
        } 
    }
}
