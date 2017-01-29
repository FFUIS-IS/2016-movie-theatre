using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieTheater.ViewModels
{
    public class LoginResponse
    {
        public bool isValidLogin { get; set; }
        public string loginType { get; set; }
        public int userId { get; set; }
        public string username { get; set; }

    }
}
