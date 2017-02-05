using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieTheater.ViewModels
{
    public class Employers
    {
        public int Id { get; set; }
        public string userName { get; set; }
        public string userPassword { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public DateTime birthDate { get; set; }
        public string phone { get; set; }
        public string address { get; set; }

        public Employers(int Id, string userName, string userPassword, string firstName, string lastName, DateTime birthDate, string phone, string address)
        {
            this.Id = Id;
            this.userName = userName;
            this.userPassword = userPassword;
            this.firstName = firstName;
            this.lastName = lastName;
            this.birthDate = birthDate;
            this.phone = phone;
            this.address = address;
        }
    }
}
