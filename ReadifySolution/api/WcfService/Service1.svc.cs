using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WcfService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        public long Fibonacci(int valueOfN)
        {
            long iReturnValue = 0;
            long i = 0;
            long j = 1;

            for (int iStartIndex = 0; iStartIndex <= valueOfN; iStartIndex++)
            {
                iReturnValue = i;
                i = j;
                j = iReturnValue + j;

            }
            return iReturnValue;
        }

        public string GetStringReverse(string strInputValue)
        {
            string strReverse = string.Empty;
            for (int i = strInputValue.ToCharArray().Length - 1; i >= 0; i--)
            {
                strReverse = strReverse + strInputValue[i];
            }
            return strReverse;
        }
    }
}
