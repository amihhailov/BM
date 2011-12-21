using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace BilllingMachine.Data
{
    // Interface method declaration
    public interface ILoadData
    {
        DataSet LoadData(string fileName);
    }
}
