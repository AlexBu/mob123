using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;

namespace mob123
{
    class Program
    {
        static void Main(string[] args)
        {
            HttpWebRequest req = (HttpWebRequest)WebRequest.Create("https://mobile.12306.cn");
        }
    }
}
