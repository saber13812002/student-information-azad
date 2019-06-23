using System;

namespace StudentFinder.Models
{
  public class StudentsModel
  {
    public int Id { get; set; }
    public string Name { get; set; }
    public string Family { get; set; }
    public string NationalId { get; set; }
    public DateTime BirthDate { get; set; }
    public string EnteredBy { get; set; }
  }
}