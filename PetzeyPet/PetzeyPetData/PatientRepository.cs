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
            return db.Patients.Find(id);
        }

        public void UpdatePatient(Patient patient, int petId)
        {

            var PatienttoUpdate = db.Patients.FirstOrDefault(x => x.petId == petId);
            if (PatienttoUpdate != null)
            {
                PatienttoUpdate.firstName = patient.firstName;
                PatienttoUpdate.lastName = patient.lastName;
                PatienttoUpdate.age = patient.age;
                PatienttoUpdate.gender = patient.gender;
                PatienttoUpdate.address = patient.address;
                PatienttoUpdate.ownerEmail = patient.ownerEmail;
                PatienttoUpdate.ownerPhoneNo = patient.ownerPhoneNo;
                PatienttoUpdate.avatar = patient.avatar;
                PatienttoUpdate.status = patient.status;
                db.SaveChanges();

            }
        }
    }
}
