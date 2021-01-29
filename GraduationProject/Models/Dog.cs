using System;
using System.Collections.Generic;
using System.Text;

namespace GraduationProject.Models
{
    public class Dog
    {
        public int sealNumber { get; set; }
        public int addressId { get; set; }

        public override string ToString()
        {
            return sealNumber.ToString();
        }
    }
}
