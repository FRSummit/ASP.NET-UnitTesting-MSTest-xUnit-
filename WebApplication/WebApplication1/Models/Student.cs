using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class Student
    {
        public int Id { get; set; }
        public String Name { get; set; }
        public String Address { get; set; }
        public String Email { get; set; }
        public String Phone { get; set; }

        public Student() { }
        public Student(int id, String name, String address, String email, String phone) {
            id = this.Id;
            name = this.Name;
            address = this.Address;
            email = this.Email;
            phone = this.Phone;
        }
    }
}
