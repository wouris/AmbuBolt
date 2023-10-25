using AmbuBolt.Models;
using Microsoft.AspNetCore.Mvc;
using AmbuBolt.Services;

namespace AmbuBolt.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PatientController : ControllerBase
    {
        private readonly PatientService _service;

        public PatientController(PatientService patientService)
        {
            _service = patientService;
        }

        [HttpGet]
        public async Task<IEnumerable<Patient>> GetPatients()
        {
            return await _service.GetPatientsAsync();
        }

        [HttpPost]
        public async Task<ActionResult<Patient>> AddPatient(Patient p)
        {
            var createdPatient = await _service.CreateArticleAsync(p);
            return CreatedAtAction(nameof(GetPatients), new { id = createdPatient.Id }, createdPatient);
        }
    }
}
