using System.Linq;
using System.Threading.Tasks;
using System;
using Microsoft.EntityFrameworkCore;

namespace CCASA.Models
{
    public class StudentRepository
    {
        private readonly Class _context;
        public StudentRepository(Class context)
        {
            _context = context;
        }
        public async Task<bool> AddDetails(string email, string password, Student student)
        {
            try
            {
                var existingStudent = await _context.Students.FirstOrDefaultAsync(c => c.Email == email && c.Password == password);

                if (existingStudent != null)
                {
                    existingStudent.BloodGroup = student.BloodGroup;
                    existingStudent.Gender = student.Gender;
                    existingStudent.Religion = student.Religion;
                    await _context.SaveChangesAsync();
                    return true;
                }
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return false;
            }
        }
        public async Task<bool> UpdateDetails(string email,Student student)
        {
            try
            {
                var existingStudent = await _context.Students.FirstOrDefaultAsync(c => c.Email == email);

                if (existingStudent != null)
                {
                    existingStudent.BloodGroup = student.BloodGroup;
                    existingStudent.Gender = student.Gender;
                    existingStudent.Religion = student.Religion;
                    existingStudent.Password = student.Password;
                    await _context.SaveChangesAsync();
                    return true;
                }
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return false;
            }
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
        public string GetStudentName(string email)
        {
            var student = _context.Students
                .Where(x => x.Email == email)
                .SingleOrDefault();
            if (student != null)
            {
                return student.Name;
            }
            else
            {
                return null;
            }
        }


    }
}
