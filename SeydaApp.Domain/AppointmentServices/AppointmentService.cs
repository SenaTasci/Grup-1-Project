using SeydaApp.Domain.Doctor1;
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


        public static List<Doctor> doctors = new List<Doctor>();
        
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

        public Doctor AddDoctor(Guid id, string doctorName, string hospitallocation, string expertise)
        {
            Doctor doctor = new Doctor
            {
                Id = Guid.NewGuid(),
                DoctorName = doctorName,
                HospitalLocation = hospitallocation,
                Expertise = expertise

            };

            doctors.Add(doctor);

            return doctor;
        }
    }
        

        
    
}



