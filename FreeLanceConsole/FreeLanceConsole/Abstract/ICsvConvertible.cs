using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FreeLanceConsole.Abstract
{
    internal interface ICsvConvertible
    {
        public string GetValuesCSV();

        void SetValuesCSV(string csv);
    }
}
