using PetzeyPetDomain.Entities;
using PetzeyPetDomain.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetzeyPetData
{
    public class PatientRepository : IPatient
    {
        private readonly PatientDbContext db = new PatientDbContext();
        public void AddNewPet(Patient patient)
        {
            db.Patients.Add(patient);
            db.SaveChanges();
        }

        public void DeActivate(int id)
        {
            var deActivate = db.Patients.Find(id);
            db.Patients.Update(deActivate);
            db.SaveChanges();
        }

        public void DeletePatient(int id)
        {
            var patientToDel = db.Patients.Find(id);
            db.Patients.Remove(patientToDel);
            db.SaveChanges();
        }

        public List<Patient> GetPatient()
        {
            return db.Patients.ToList();
        }

        

        public Patient GetPatientById(int id)
        {
           //return db.Patients.Find(id);
            return db.Patients.Where(x => x.PetId == id).First();
        }

        public void UpdatePatient(Patient patient, int petId)
        {
            
            var PatienttoUpdate = db.Patients.FirstOrDefault(x => x.PetId == petId);
            if (PatienttoUpdate != null)
            {
                PatienttoUpdate.OwnerFirstName = patient.OwnerFirstName;
                PatienttoUpdate.OwnerLastName = patient.OwnerLastName;
                PatienttoUpdate.PetAge = patient.PetAge;
                PatienttoUpdate.Gender = patient.Gender;
                PatienttoUpdate.Address = patient.Address;
                PatienttoUpdate.OwnerEmail = patient.OwnerEmail;
                PatienttoUpdate.OwnerPhoneNo = patient.OwnerPhoneNo;
                PatienttoUpdate.Avatar = patient.Avatar;
                PatienttoUpdate.Status = patient.Status;
                db.SaveChanges();

            }
        }
    }
}
