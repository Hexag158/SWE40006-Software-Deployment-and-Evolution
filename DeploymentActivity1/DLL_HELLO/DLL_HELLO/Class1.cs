using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello
{
    public class HelloDLL
    {
        public string Hellouser(string user_name)
        {
            return "Hello user, " + user_name;
        }
    }
}