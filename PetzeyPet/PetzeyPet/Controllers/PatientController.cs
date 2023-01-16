using AutoMapper;
using Microsoft.AspNet.OData;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PetzeyPetDomain.Entities;
using PetzeyPetDomain.Repository;
using PetzeyPetDTO.ProfileView;
using System.Collections.Generic;

namespace PetzeyPetApi.Controllers
{
    //[EnableCors({"My Profile"})]
    [Route("api/[controller]")]
    [ApiController]
    public class PatientController : ControllerBase
    {
        private IPatient repo ;
        private IMapper mapper;

        public PatientController(IPatient repo , IMapper mapper)
        {
            this.repo = repo;
            this.mapper = mapper;
        }

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
                var patients = repo.GetPatient().AsQueryable();
                var cardViewPatient = mapper.Map<IEnumerable<ListView>>(patients);
                // return Ok(mapper.Map<IEnumerable<CardView>>(patients));
                // return Ok(repo.GetPatientByCardView().AsQueryable());
                return Ok(cardViewPatient);
                //var patients = repo.GetPatient().AsQueryable();
                //var cardView= mapper.Map<IEnumerable<CardView>>(patients);
               // return Ok(repo.GetPatient().AsQueryable());
            
            
        }

        //[HttpGet]
        //[EnableQuery]
        //[Route("{id:int}")]
        //public IActionResult GetPatientById(int id)
        //{
        //    var patient = repo.GetPatientById(id);
        //    //if (patient == null)
        //    //    return NotFound();

        //    return Ok(mapper.Map<Patient, CardView>(patient));
        //    //return Ok(patient);
        //}

        //[HttpGet]
        //[EnableQuery]
        //public IActionResult GetPatientByCardView()
        //{
        //    var patients = repo.GetPatientByCardView().AsQueryable();
        //    var cardViewPatient = mapper.Map<IEnumerable<CardView >>(patients);
        //    // return Ok(mapper.Map<IEnumerable<CardView>>(patients));
        //    // return Ok(repo.GetPatientByCardView().AsQueryable());
        //    return Ok(cardViewPatient);
        //}




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
