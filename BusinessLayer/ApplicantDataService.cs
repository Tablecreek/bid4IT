using BusinessLayer.Models.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class ApplicantDataService : Rest.DataClient
    {
        List<Person> persons = new List<Person>();

        public ApplicantDataService()
        {
            Person person1 = new Person();
            person1.FirstName = "Alain";
            person1.LastName = "Tellenbach";
            person1.Email = "alain.tellenbach@outlook.com";

            PersonType person1Type = new PersonType();
            person1Type.Type = "Chef";
            person1Type.AdditionalInfos = "Zuständig fürs Universums";
            person1.PersonType = person1Type;

            person1.DateOfBirth = new DateTime(1997, 3, 17);

            Job person1Job = new Job();
            person1Job.Name = "Informatiker Applikationsentwickler";
            person1Job.Applicant = true;
            person1.Job = person1Job;



            Person person2 = new Person();
            person2.FirstName = "Nichtalain";
            person2.LastName = "Nichttellenbach";
            person2.Email = "nichtalain.nichttellenbach@nicht.com";

            PersonType person2Type = new PersonType();
            person2Type.Type = "Nicht Chef";
            person2Type.AdditionalInfos = "Nicht zuständig fürs Universums";
            person2.PersonType = person2Type;

            person2.DateOfBirth = new DateTime(1997, 3, 17);

            Job person2Job = new Job();
            person2Job.Name = "Informatiker Nichtapplikationsentwickler";
            person2Job.Applicant = true;
            person2.Job = person2Job;

            persons.Add(person1);
            persons.Add(person2);
        }

        public List<Person> GetAllApplicants()
        {
            var applicants = new List<Person>();
            foreach(var person in persons)
            {
                if (person.Job.Applicant)
                {
                    applicants.Add(person);
                }
            }
            return applicants;
        }

        public Person GetApplicant(int id)
        {
            var applicants = new List<Person>();
            foreach (var person in persons)
            {
                if (person.PersonId == id)
                {
                    if (person.Job.Applicant)
                    {
                        return person;
                    }
                }
            }
            return null;
        }
    }
}
