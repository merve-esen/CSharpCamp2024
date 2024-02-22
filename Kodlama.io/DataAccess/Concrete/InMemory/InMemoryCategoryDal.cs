using DataAccess.Abstract;
using Entities.Concrete;

namespace DataAccess.Concrete.InMemory;

public class InMemoryCategoryDal : ICategoryDal
{
    private List<Category> _categories;

    public InMemoryCategoryDal()
    {
        _categories = new List<Category>
    {
        new Category(){ Id = 1, Name = "Programlama" }
    };
    }
    public List<Category> GetAll()
    {
        return _categories;
    }

    public Category GetById(int id)
    {
        return _categories.Find(c => c.Id == id);
    }

    public void Add(Category category)
    {
        _categories.Add(category);
    }

    public void Update(Category category)
    {
        Category categoryToUpdate = _categories.SingleOrDefault(c => c.Id == category.Id);
        categoryToUpdate.Name = category.Name;
    }

    public void Delete(Category category)
    {
        Category categoryToDelete = _categories.SingleOrDefault(c => c.Id == category.Id);
        _categories.Remove(categoryToDelete);
    }
}
