using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Retail_Web_DFA.Models;

namespace Retail_Web_DFA.Repository
{
    public class DepartmentRepository : IDepartmentRepository
    {
        private readonly AppDbContext _context;

        public DepartmentRepository(AppDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Department> GetAll()
        {
            return _context.Departments
                .FromSqlRaw("EXEC sp_GetDepartments")
                .ToList();
        }

        public Department GetById(int id)
        {
            return _context.Departments
                .FromSqlRaw("EXEC sp_GetDepartmentById @Id",
                    new SqlParameter("@Id", id))
                .AsEnumerable()
                .FirstOrDefault();
        }

        public void Add(Department department)
        {
            _context.Database.ExecuteSqlRaw(
                "EXEC sp_AddDepartment @Name, @Description, @IsActive",
                new SqlParameter("@Name", department.Name),
                new SqlParameter("@Description", department.Description ?? (object)DBNull.Value),
                new SqlParameter("@IsActive", department.IsActive ?? (object)DBNull.Value)
            );
        }

        public void Update(Department department)
        {
            _context.Database.ExecuteSqlRaw(
                "EXEC sp_UpdateDepartment @Id, @Name, @Description, @IsActive",
                new SqlParameter("@Id", department.Id),
                new SqlParameter("@Name", department.Name),
                new SqlParameter("@Description", department.Description ?? (object)DBNull.Value),
                new SqlParameter("@IsActive", department.IsActive ?? (object)DBNull.Value)
            );
        }

        public void Delete(int id)
        {
            _context.Database.ExecuteSqlRaw(
                "EXEC sp_DeleteDepartment @Id",
                new SqlParameter("@Id", id)
            );
        }
    }
}
