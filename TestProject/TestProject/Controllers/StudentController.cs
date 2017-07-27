using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace TestProject.Controllers
{
  [Produces("application/json")]
  [Route("api/Student")]
  public class StudentController : Controller
  {
    private readonly DatabaseContext _context;
    public StudentController(DatabaseContext context)
    {
      _context = context;
    }
    // GET: api/Student
    [HttpGet]
    public IEnumerable<StudentModel> Get()
    {
      return _context.StudentTable;
    }

    // GET: api/Student/5
    [HttpGet("{id}", Name = "Get")]
    public string Get(int id)
    {
      return "value";
    }

    // POST: api/Student
    [HttpPost]
    public bool Post([FromBody]StudentModel requestObj)
    {
      bool status = false;
      try
      {
        _context.StudentTable.Add(requestObj);
        _context.SaveChanges();
        status = true;
      }
      catch (Exception e) { throw e; }
      return status;
    }

    // PUT: api/Student/5
    [HttpPut("{id}")]
    public void Put(int id, [FromBody]string value)
    {
    }

    // DELETE: api/ApiWithActions/5
    [HttpDelete("{id}")]
    public void Delete(int id)
    {
    }
  }
}
