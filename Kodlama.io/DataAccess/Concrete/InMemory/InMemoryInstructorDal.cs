using DataAccess.Abstract;
using Entities.Concrete;

namespace DataAccess.Concrete.InMemory;

public class InMemoryInstructorDal : IInstructorDal
{
    private List<Instructor> _instructors;

    public InMemoryInstructorDal()
    {
        _instructors = new List<Instructor>
        {
            new Instructor(){ Id = 1, FirstName = "Engin", LastName = "Demiroğ" },
            new Instructor(){ Id = 2, FirstName = "Halit Enes", LastName = "Kalaycı" }
        };
    }

    public List<Instructor> GetAll()
    {
        return _instructors;
    }

    public Instructor GetById(int id)
    {
        return _instructors.Find(t => t.Id == id);
    }

    public void Add(Instructor instructor)
    {
        _instructors.Add(instructor);
    }

    public void Update(Instructor instructor)
    {
        Instructor instructorToUpdate = _instructors.SingleOrDefault(t => t.Id == instructor.Id);
        instructorToUpdate.FirstName = instructor.FirstName;
        instructorToUpdate.LastName = instructor.LastName;
    }

    public void Delete(Instructor instructor)
    {
        Instructor instructorToDelete = _instructors.SingleOrDefault(t => t.Id == instructor.Id);
        _instructors.Remove(instructorToDelete);
    }
}
