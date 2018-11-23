using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CandidateManagement.Application.Dtos;
using CandidateManagement.Business.Command;
using CandidateManagement.Data.Entities;
using Microsoft.AspNetCore.Mvc;

namespace CandidateManagement.Application.Controllers
{
    [ApiController]
    public class CandidateController : ControllerBase
    {
        List<CandidateDto> _candidates;
        public CandidateController()
        {
            _candidates = new List<CandidateDto>();
        }
        // GET api/values
        [HttpGet]
        [Route("api/[controller]/GetCandidates")]
        public ActionResult<IEnumerable<CandidateDto>> GetCandidates()
        {
            _candidates.Add(
            new CandidateDto()
            {
                SurName = "Mieke",
                LastName = "De Cock",
                Email = "mieke.decock@gmail.com",
                Phone = "09/25.52.75",
                MobilePhone = "0495/87.36.90",
                Age = 30,
                //DateFirstTakeIn = DateTime.Now,
                //DateJobApplication = DateTime.Now,
                Gender = "Female",
                HasDriverLicense = true
            });
            _candidates.Add(
             new CandidateDto()
             {
                 SurName = "Mieke",
                 LastName = "De Cock",
                 Email = "mieke.decock@gmail.com",
                 Phone = "09/25.52.75",
                 MobilePhone = "0495/87.36.90",
                 Age = 30,
                 //DateFirstTakeIn = DateTime.Now,
                 //DateJobApplication = DateTime.Now,
                 Gender = "Female",
                 HasDriverLicense = true
             });

            return _candidates;
        }

        // GET api/values
        [HttpPost]
        [Route("api/[controller]/Create")]
        public ActionResult Create([FromBody] CandidateDto candidateDto)
        {
            CreateCandidateCommandHandler handler = new CreateCandidateCommandHandler();
            var command = new CreateCandidateCommand()
            {
                Age = candidateDto.Age,
                Email = candidateDto.Email,
                Gender = candidateDto.Gender,
                DateFirstTakeIn = DateTime.Now,
                DateJobApplication = DateTime.Now,
                HasDriverLicense = candidateDto.HasDriverLicense,
                LastName = candidateDto.LastName,
                MobilePhone = candidateDto.MobilePhone,
                Phone = candidateDto.Phone,
                SurName = candidateDto.SurName
            };


            handler.Handle(command);


            return Ok();
        }

        //private CandidateDto ConvertToDto(Candidate candidate)
        //{
        //    return new CandidateDto()
        //    {

        //    };
        //}
    }
}
