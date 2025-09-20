using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
    public enum UserTypeEnum
    {
        [Description("Admin")]
        Admin,
        [Description("Customer")]
        Customer,
        [Description("Support")]
        Support
    }
}