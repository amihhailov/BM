using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BilllingMachine.DataClasses
{
    public abstract class Factory
    {
        //Factory Method Declaration 
        public abstract ILoadData GetDataSource(); 
    }
}
