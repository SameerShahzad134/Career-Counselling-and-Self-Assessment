using CCASA.Models;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace CCASA.Controllers
{
    public class CounsellorController : Controller
    {
        public ViewResult Index()
        {
            return View("LoginSignUp");
        }
		public async Task<ViewResult> SignUp(string txt, string email, string pswd)
		{
			bool isAdded = await AddNewCounsellor(txt, email, pswd);
			if (isAdded == true)
			{
				HttpContext.Response.Cookies.Append("email", email);
				HttpContext.Response.Cookies.Append("password", pswd);
				return View("CounsellorHome");
			}
			else
			{

				ViewData["Message"] = "Unable to add counsellor";
				return View("Index");
			}
		}
		[HttpPost]
		public async Task<bool> AddNewCounsellor(string txt, string email, string pswd)
		{
			Class context = new Class();
			Counsellor st = new Counsellor();
			st.Name = txt;
			st.Email = email;
			st.Password = pswd;
			CounsellorRepository counsellorRepository = new CounsellorRepository(context);
			bool isadded = await counsellorRepository.Add(st);
			return isadded;
		}

		public ViewResult DashBoard()
        {
            return View("StudentDashboard");
        }
    }
}
