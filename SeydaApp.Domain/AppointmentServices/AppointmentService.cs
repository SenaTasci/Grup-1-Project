using SeydaApp.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeydaApp.Domain.AppointmentServices
{
    public class AppointmentService
    {

        public static List<Patient> patients = new List<Patient>();

        
        public Patient AddPatient(string identycard, string patientname, string phonenumber)
        { 

        Patient patient = new Patient
        {
            IdentyCard = identycard,
            PatientName = patientname,
            PhoneNumber = phonenumber

        };
            patients.Add(patient);

            return patient;

        }
    }
        

        
    
}



