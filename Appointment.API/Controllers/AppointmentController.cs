using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SeydaApp.Domain.AppointmentServices;
using SeydaApp.Domain.Models;

namespace Appointment.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AppointmentController : ControllerBase
    {
        AppointmentService appointmentService = new();

        [HttpGet]

        public Patient Add(string identycard, string patientname, string phonenumber)
        {
            return appointmentService.AddPatient(identycard, patientname, phonenumber);
        }
    }
}
