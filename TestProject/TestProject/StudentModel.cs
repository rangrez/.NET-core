using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TestProject
{
  public class StudentModel
  {
    [Key]
    public int StudentId { get; set; }
    public string StudentName { get; set; }
    public bool isTeacherAssigned { get; set; }
  }
}
