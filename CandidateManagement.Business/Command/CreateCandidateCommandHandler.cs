using CandidateManagement.Data;
using CandidateManagement.Data.Entities;

namespace CandidateManagement.Business.Command
{
    public class CreateCandidateCommandHandler 
    {
        public CreateCandidateCommandHandler()
        {
        }
        public void Handle(CreateCandidateCommand command) {

            Candidate candidate = new Candidate()
            {
                Age = command.Age,
                DateFirstTakeIn = command.DateFirstTakeIn,
                DateJobApplication = command.DateJobApplication,
                Email = command.Email,
                Gender = command.Gender,
                HasDriverLicense = command.HasDriverLicense,
                LastName = command.LastName,
                MobilePhone = command.MobilePhone,
                Phone = command.Phone,
                SurName = command.SurName
            };

            using (CandidateContext context = new CandidateContext(null))
            {
                context.Candidate.Add(candidate);
                context.SaveChanges();
            }
        }
    }
}
