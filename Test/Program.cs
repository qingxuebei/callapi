using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CallAPI;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            //get
            String url = "http://10.1.1.243:9980/eagle/metric/list";
            //get 1
            String result1= RequestUtility.HttpGet(url);
            Console.WriteLine(result1);
            System.Threading.Thread.Sleep(1000);
            //get 2
            String result2 = RequestUtility.HttpGetTimeOut(url);
            Console.WriteLine(result2);
            System.Threading.Thread.Sleep(1000);
        }
    }
}
