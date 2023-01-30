using System.Linq;
using System.Threading.Tasks;
using System;

namespace CCASA.Models
{
    public class StudentRepository
    {
        private readonly Class _context;
        public StudentRepository(Class context)
        {
            _context = context;
        }
        public async Task<bool> Add(Student student)
        {
            try
            {
                _context.Students.Add(student);
                await _context.SaveChangesAsync();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return false;
            }

        }
        public async void Remove(Student student)
        {
            if (student != null)
            {
                _context.Students.Remove(student);
                await _context.SaveChangesAsync();
            }

        }

        public async void Update(Student student)
        {
            if (student != null)
            {
                await _context.SaveChangesAsync();
            }

        }

        public Student? GetStudent(string email, string password)
        {
            var student = _context.Students
        .Where(x => x.Email == email && x.Password == password)
        .SingleOrDefault();
            return student;
        }
    }
}
