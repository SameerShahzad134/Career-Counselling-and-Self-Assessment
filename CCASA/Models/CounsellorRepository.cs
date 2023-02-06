using System.Linq;
using System.Threading.Tasks;
using System;
using Microsoft.EntityFrameworkCore;

namespace CCASA.Models
{
	public class CounsellorRepository
	{
		private readonly Class _context;
		public CounsellorRepository(Class context)
		{
			_context = context;
		}
		public async Task<bool> Add(Counsellor counsellor)
		{
			try
			{
				_context.Counsellors.Add(counsellor);
				await _context.SaveChangesAsync();
				return true;
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex);
				return false;
			}

		}
        public async Task<bool> AddDetails(string email, string password, Counsellor counsellor)
        {
			try
			{
                var existingCounsellor = await _context.Counsellors.FirstOrDefaultAsync(c => c.Email == email && c.Password == password);

                if (existingCounsellor != null)
                {
                    existingCounsellor.BloodGroup = counsellor.BloodGroup;
                    existingCounsellor.Qualification = counsellor.Qualification;
                    existingCounsellor.Religion = counsellor.Religion;
                    await _context.SaveChangesAsync();
					return true;
                }
				return false;
            }
			catch(Exception ex)
			{
                Console.WriteLine(ex);
                return false;
            }
        }


        public async Task<bool> UpdateDetails(string email, Counsellor counsellor)
        {
            try
            {
                var existingCounsellor = await _context.Counsellors.FirstOrDefaultAsync(c => c.Email == email);

                if (existingCounsellor != null)
                {
                    existingCounsellor.BloodGroup = counsellor.BloodGroup;
                    existingCounsellor.Qualification = counsellor.Qualification;
                    existingCounsellor.Religion = counsellor.Religion;
                    existingCounsellor.Gender = counsellor.Gender;
                    existingCounsellor.Password = counsellor.Password;
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

        public async void Remove(Counsellor counsellor)
		{
			if (counsellor != null)
			{
				_context.Counsellors.Remove(counsellor);
				await _context.SaveChangesAsync();
			}

		}

		public async void Update(Counsellor counsellor)
		{
			if (counsellor != null)
			{
				await _context.SaveChangesAsync();
			}

		}

		public Counsellor? GetCounsellor(string email, string password)
		{
			var counsellor = _context.Counsellors
		.Where(x => x.Email == email && x.Password == password)
		.SingleOrDefault();
			return counsellor;
		}

        public string GetCounsellorName(string email)
        {
            var counsellor = _context.Counsellors
                .Where(x => x.Email == email)
                .SingleOrDefault();
            if (counsellor != null)
            {
                return counsellor.Name;
            }
            else
            {
                return null;
            }
        }
    }
}
