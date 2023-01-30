using CCASA.Models; 
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace CCASA.Controllers
{
    public class StudentController : Controller
    {
        public ViewResult Index()
        {
            return View("LoginSignUp");
        }
        public async Task<ViewResult> SignUp(string txt, string email, string pswd)
        {
            bool isAdded = await AddNewStudent(txt, email, pswd);
            if (isAdded == true)
            {
                HttpContext.Response.Cookies.Append("email", email);
                HttpContext.Response.Cookies.Append("password", pswd);
                return View("StudentHome");
			}
            else
            {

                ViewData["Message"] = "Unable to add student";
                return View("Index");
            }
        }
        [HttpPost]
        public async Task<bool> AddNewStudent(string txt, string email, string pswd)
        {
            Class context = new Class();
            Student st = new Student();
            st.Name = txt;
            st.Email = email;
            st.Password = pswd;
            StudentRepository studentRepository = new StudentRepository(context);
            bool isadded = await studentRepository.Add(st);
            return isadded;
        }
        public ViewResult DashBoard()
        {
            return View("StudentDashboard");
        }
		public ViewResult Settings()
		{
			return View("StudentSettings");
		}
	}
}
