using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete;

public class InstructorManager : IInstructorService
{
    private IInstructorDal _instructorDal;

    public InstructorManager(IInstructorDal instructorDal)
    {
        _instructorDal = instructorDal;
    }

    public List<Instructor> GetAll()
    {
        return _instructorDal.GetAll();
    }

    public Instructor GetById(int id)
    {
        return _instructorDal.GetById(id);
    }

    public void Add(Instructor instructor)
    {
        _instructorDal.Add(instructor);
    }

    public void Update(Instructor instructor)
    {
        _instructorDal.Update(instructor);
    }

    public void Delete(Instructor instructor)
    {
        _instructorDal.Delete(instructor);
    }
}
