using AmbuBolt.Data;
using AmbuBolt.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

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
        public async Task<IEnumerable<Patient>> GetPatients()
        {
            return await _context.GetPatientsAsync();
        }

        [HttpPost]
        public async Task<ActionResult<Patient>> AddPatient(Patient p)
        {
            var createdPatient = await _context.CreateArticleAsync(p);
            return CreatedAtAction(nameof(GetPatients), new { id = createdPatient.Id }, createdPatient);
        }
    }
}
