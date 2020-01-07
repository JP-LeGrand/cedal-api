using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using cedal_backend.Data;
using cedal_backend.Dto;
using cedal_backend.Interfaces;
using cedal_backend.Models;
using Microsoft.AspNetCore.Http;

namespace cedal_backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ApplicantsController : ControllerBase
    {
        private readonly CedalContext _context;
        private readonly IApplicantService _applicantService;
        public ApplicantsController(CedalContext context, IApplicantService applicantService)
        {
            _context = context;
            _applicantService = applicantService;
        }

        // GET: api/Applicants
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Applicant>>> GetApplicants()
        {
            return await _context.Applicants.ToListAsync();
        }

        [HttpGet]
        [Route("ListOfApplicants")]
        [ProducesResponseType(typeof(IEnumerable<ApplicantDto>), StatusCodes.Status200OK)]
        public async Task<ActionResult<IEnumerable<ApplicantDto>>> GetListOfApplicants()
        {
            var applicants = await GetApplicants();
            return Ok(await _applicantService.ListOfApplicantAsync(applicants.Value));
        }

        [HttpGet]
        [Route("NumberOfApplicants")]
        [ProducesResponseType(typeof(int), StatusCodes.Status200OK)]
        public async Task<ActionResult<int>> GetNumberOfApplicants()
        {
            var applicants = await GetApplicants();
            return Ok(await _applicantService.NumberOfApplicantAsync(applicants.Value));
        }

        // GET: api/Applicants/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Applicant>> GetApplicant(string id)
        {
            var applicant = await _context.Applicants.FindAsync(id);

            if (applicant == null)
            {
                return NotFound();
            }

            return applicant;
        }

        // POST: api/Applicants
        [HttpPost]
        [ProducesResponseType(typeof(Applicant), StatusCodes.Status201Created)]
        public async Task<ActionResult<Applicant>> PostApplicant(Applicant applicant)
        {
            _context.Applicants.Add(applicant);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetApplicant", new { id = applicant.Id }, applicant);
        }

        // DELETE: api/Applicants/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Applicant>> DeleteApplicant(string id)
        {
            var applicant = await _context.Applicants.FindAsync(id);
            if (applicant == null)
            {
                return NotFound();
            }

            _context.Applicants.Remove(applicant);
            await _context.SaveChangesAsync();

            return applicant;
        }

        private bool ApplicantExists(Guid? id)
        {
            return _context.Applicants.Any(e => e.Id == id);
        }
    }
}
