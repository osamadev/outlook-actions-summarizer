using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TasksFollowupAPI;

[Route("api/[controller]")]
[ApiController]
public class SubjectsController : ControllerBase
{
    private readonly ApplicationDbContext _context;

    public SubjectsController(ApplicationDbContext context)
    {
        _context = context;
    }

    // POST: api/Subjects
    [HttpPost]
    public async Task<ActionResult<Subject>> PostSubject(Subject subject)
    {
        _context.Subjects.Add(subject);
        await _context.SaveChangesAsync();

        return CreatedAtAction("GetSubject", new { id = subject.Id }, subject);
    }

    // GET: api/Subjects/5
    [HttpGet("{id}")]
    public async Task<ActionResult<Subject>> GetSubject(int id)
    {
        var subject = await _context.Subjects
            .Include(s => s.Tasks) // Include Tasks in the response
            .Include(s => s.Attachments) // Include Attachments in the response
            .FirstOrDefaultAsync(s => s.Id == id);

        if (subject == null)
        {
            return NotFound();
        }

        return subject;
    }


    // Other actions (GET, PUT, DELETE) as needed
}

