using AmbuBolt.Data;
using AmbuBolt.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AmbuBolt.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PatientController : ControllerBase
    {
        private readonly PatientContext _context;

        public PatientController(PatientContext patientContext)
        {
            _context = patientContext;
        }

        [HttpGet]
        public IActionResult GetPatients()
        {
            return Ok(_context.Patients);
        }

        [HttpPost]
        public IActionResult AddPatient(Patient patient)
        {
            _context.Patients.Add(patient);
            _context.SaveChanges();
            return StatusCode(StatusCodes.Status201Created);
        }
    }
}
