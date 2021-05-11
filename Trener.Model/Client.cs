using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trener.Model
{
    public class Client
    {
        public string Oib { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; }
        public string PhoneNumber { get; set; }
        public DateTime DateOfJoining { get; }
        public FitnessLevel FitnessLevel { get; set; }
        public string Notes { get; set; }
        public List<TrainingGroup> InTrainingGroups { get; set; }

        public Client(string oib, string firstName, string lastName, DateTime dateOfBirth, string phoneNumber, DateTime dateOfJoining,
                        FitnessLevel fitnessLevel, string notes, List<TrainingGroup> inTrainingGroups)
        {
            if (!string.IsNullOrEmpty(oib) && !string.IsNullOrEmpty(firstName)
                && !string.IsNullOrEmpty(lastName) && !string.IsNullOrEmpty(phoneNumber)
                && dateOfBirth != null && dateOfJoining != null
                && inTrainingGroups.Count > 0)
            {
                Oib = oib;
                FirstName = firstName;
                LastName = lastName;
                DateOfBirth = dateOfBirth;
                PhoneNumber = phoneNumber;
                DateOfJoining = dateOfJoining;
                FitnessLevel = fitnessLevel;
                Notes = notes;
                InTrainingGroups = inTrainingGroups;
            }
            else
            {
                throw new IncompleteDataException();
            }
        }
    }
}