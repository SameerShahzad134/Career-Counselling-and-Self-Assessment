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
        Class context = new Class();
        Student st = new Student();
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
                return View("StudentDetails");
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
        public ViewResult Home()
        {
            return View("StudentHome");
        }
        public ViewResult Settings()
		{
            StudentRepository studentRepository = new StudentRepository(context);
            st.Email = HttpContext.Request.Cookies["email"];
            st.Name = studentRepository.GetStudentName(st.Email);
            return View("StudentSettings",st);
		}
        public IActionResult Remove()
        {
            HttpContext.Response.Cookies.Delete("email");
            HttpContext.Response.Cookies.Delete("password");
            return RedirectToAction("Index","Home");
        }
        public async Task<ViewResult> addDetails(string religion, string blood,string gender)
        {
            st.Email = HttpContext.Request.Cookies["email"];
            st.Password = HttpContext.Request.Cookies["password"];
            st.Religion = religion;
            st.BloodGroup = blood;
            st.Gender = gender;
            StudentRepository studentRepository = new StudentRepository(context);
            bool isadded = await studentRepository.AddDetails(st.Email, st.Password, st);
            if (isadded)
            {
                return View("StudentHome");
            }
            else
                return View("DetailsNotadded");
        }


        public async Task<ViewResult> updateDetails(string religion, string blood, string password, string gender, string name)
        {
            st.Email = HttpContext.Request.Cookies["email"];
            st.Religion = religion;
            st.BloodGroup = blood;
            st.Name = name;
            st.Password = password;
            st.Gender = gender;
            StudentRepository studentRepository = new StudentRepository(context);
            bool isadded = await studentRepository.UpdateDetails(st.Email,st);
            if (isadded)
            {
                return View("StudentHome");
            }
            else
                return View("DetailsNotadded");
        }
    }
}
