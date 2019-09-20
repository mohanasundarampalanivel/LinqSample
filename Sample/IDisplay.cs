using System;
using System.Collections.Generic;
using System.Text;

namespace Sample
{
    interface IDisplay
    {
        void DisplayResultData(IEnumerable<ResultData> data);
    }
}
