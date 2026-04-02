using Retail_Web_DFA.Models;
using Retail_Web_DFA.Repository;

namespace Retail_Web_DFA.Service
{
    public class DepartmentService
    {
        private readonly IDepartmentRepository _repository;

        public DepartmentService(IDepartmentRepository repository)
        {
            _repository = repository;
        }

        public IEnumerable<Department> GetDepartments()
        {
            return _repository.GetAll();
        }

        public Department GetDepartment(int id)
        {
            return _repository.GetById(id);
        }

        public void CreateDepartment(Department department)
        {
            _repository.Add(department);
        }

        public void UpdateDepartment(Department department)
        {
            _repository.Update(department);
        }

        public void DeleteDepartment(int id)
        {
            _repository.Delete(id);
        }
    }
}
