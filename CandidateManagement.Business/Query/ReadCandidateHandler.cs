using System;
using System.Collections.Generic;
using System.Text;

namespace CandidateManagement.Business.Query
{
    public class ReadCab : CommandHandler<CreateCandidate>
    {
        public CreateCandidateHandler()
        {
        }

        public override void Handle(CreateCandidate createCandidate)
        {
            using (CandidateContext context = new CandidateContext(null))
            {
                context.Candidate.Add(new CreateCandidate()
                {
                    Age = 1,
                    //Date = DateTime.Now

                });

                context.SaveChanges();
            }
        }
    }
}
