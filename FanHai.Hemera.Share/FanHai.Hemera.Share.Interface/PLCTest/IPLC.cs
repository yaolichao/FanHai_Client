using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace FanHai.Hemera.Share.Interface.PLCTest
{
    public interface IPLC
    {
        DataSet SaveProductJiOu(DataTable dt);
        DataSet GetProductJiOu(DataTable dt);
        DataSet GetTestConfig(DataTable dt);
    }
}
