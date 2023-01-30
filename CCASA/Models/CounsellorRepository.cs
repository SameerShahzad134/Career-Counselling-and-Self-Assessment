using System.Linq;
using System.Threading.Tasks;
using System;

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
	}
}
