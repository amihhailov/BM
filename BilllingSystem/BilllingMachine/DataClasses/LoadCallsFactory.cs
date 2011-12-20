﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BilllingMachine.DataClasses
{
    class LoadCallsFactory : Factory
    {
        //Factory Method Implementation 
        public override ILoadData GetDataSource() 
        {
            return new LoadCalls();
        } 
    }
}
