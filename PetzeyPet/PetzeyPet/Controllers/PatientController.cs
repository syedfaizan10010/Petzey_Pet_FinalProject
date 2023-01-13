using Microsoft.AspNet.OData;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PetzeyPetDomain.Entities;
using PetzeyPetDomain.Repository;

namespace PetzeyPetApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PatientController : ControllerBase
    {
        public PatientController(IPatient repo)
        {
            this.repo = repo;
        }
        private IPatient repo = null;

        [HttpPost]

        public IActionResult AddNewPet(Patient patient)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest("Invalid Data");
            }
            repo.AddNewPet(patient);
            return Ok(patient);
        }
        [HttpGet]
        [EnableQuery]
        public IActionResult GetPatient()
        {
            return Ok(repo.GetPatient().AsQueryable());
        }

        [HttpPut]
        [Route("{id:int}")]
        public IActionResult UpdatePatient(int id, Patient patient)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest("Invalid Data");
            }
            repo.UpdatePatient(patient, id);
            return Ok();
        }
        [HttpDelete]
        [Route("{id}")]

        public IActionResult DeletePatient(int id)
        {
            Patient p = repo.GetPatientById(id);
            if (p == null)
            {
                return NotFound();
            }
            else
            {
                repo.DeletePatient(id);
                return Ok(p);
            }
        }
    }
}
