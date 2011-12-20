using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace BilllingMachine.DataClasses
{
    interface ILoadData
    {
        //DataSet LoadData();
        DataSet LoadData(string fileName);
    }
}
