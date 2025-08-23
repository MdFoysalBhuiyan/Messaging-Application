using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
//using Newtonsoft.Json;

namespace Messaging_Application
{
    public class User
    {
        //string path = AppDomain.CurrentDomain.BaseDirectory + ""
        public string Username { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string Image { get; set; }

    }
}
