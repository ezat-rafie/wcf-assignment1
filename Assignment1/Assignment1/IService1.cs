﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace Assignment1
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {

        [OperationContract]
        string CheckPrimeNumber(int primeNumber);

        [OperationContract]
        int SumOfDigits(int digits);

        [OperationContract]
        string ReverseString(string value);

        [OperationContract]
        string PrintTag(string tag, string data);

        [OperationContract]
        int[] SortNumbers(string sortType, int[] data);
    }
}
