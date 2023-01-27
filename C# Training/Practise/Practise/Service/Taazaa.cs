using Practise.Models;
using System;

namespace Practise.Service
{
    public class Taazaa
    {
        public TaazaaDetails Details()
        {
            TaazaaDetails obj = new TaazaaDetails();
            obj.emphno = 1234;
            obj.empemail = "singh@gmail.com";
            obj.empname = "pragya";
            return obj;
        }


    }

}
