using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeydaApp.Domain.Doctor1
{
    public class Doctor
    {
        public Guid Id { get; set; }
        public string DoctorName { get; set; }

        public string HospitalLocation { get; set; }

        public string Expertise { get; set; }


    }
}
