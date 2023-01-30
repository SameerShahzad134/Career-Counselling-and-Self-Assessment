using CCASA.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CCASA.Controllers
{
    public class HomeController : Controller
    {
        public ViewResult Index()
        {
            return View("Index");
        }
        public IActionResult Check(string userType)
        {
            if (userType == "counselor")
            {
                return RedirectToAction("Index", "Counsellor");
            }
            else
            {
                return RedirectToAction("Index", "Student");
            }
        }
		public IActionResult Login(string email, string password)
		{

			bool isStudentLoggedIn = getStudent(email, password);
			bool isCounsellorLoggedIn = getCounsellor(email, password);
			return View("error", isStudentLoggedIn);
			if (isStudentLoggedIn)
			{
				HttpContext.Response.Cookies.Append("email", email);
				HttpContext.Response.Cookies.Append("password", password);
				return RedirectToAction("StudentHome", "Student");
			}
			else if (isCounsellorLoggedIn)
			{
				HttpContext.Response.Cookies.Append("email", email);
				HttpContext.Response.Cookies.Append("password", password);
				return RedirectToAction("CounsellorHome", "Counsellor");
			}
			else
			{
				ViewData["Message"] = "Unable to login";
				return View("Index");
			} 

		}
		public bool getStudent(string email, string password)
		{
			Class context = new Class();
			Student? st = new Student();
			StudentRepository studentRepository = new StudentRepository(context);
			st = studentRepository.GetStudent(email, password);
			if (st != null)
			{
				return true;
			}
			else
			{
				return false;
			}

		}
		public bool getCounsellor(string email, string password)
		{
			Class context = new Class();
			Models.Counsellor? counsellor = new Models.Counsellor();
			CounsellorRepository counsellorRepository = new CounsellorRepository(context);
			counsellor = counsellorRepository.GetCounsellor(email, password);
			if (counsellor != null)
			{
				return true;
			}
			else
			{
				return false;
			}

		}

	}
}
