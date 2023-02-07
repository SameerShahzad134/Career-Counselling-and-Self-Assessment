using CCASA.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

namespace CCASA.Controllers
{
    public class CounsellorController : Controller
    {
        Class context = new Class();
        Counsellor st = new Counsellor();
        private readonly IWebHostEnvironment Environment;

        public CounsellorController(IWebHostEnvironment
            environment)
        {

            Environment = environment;
        }
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
				return View("CounsellorDetails");
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
			st.Name = txt;
			st.Email = email;
			st.Password = pswd;
			CounsellorRepository counsellorRepository = new CounsellorRepository(context);
			bool isadded = await counsellorRepository.Add(st);
			return isadded;
		}

		public ViewResult CounsellorHome()
        {
            return View("CounsellorHome");
        }
        public IActionResult Remove()
        {
            HttpContext.Response.Cookies.Delete("email");
            HttpContext.Response.Cookies.Delete("password");
            return RedirectToAction("Index","Home");
        }
        public ViewResult Settings()
        {
            CounsellorRepository counsellorRepository = new CounsellorRepository(context);
            st.Email = HttpContext.Request.Cookies["email"];
            st.Name = counsellorRepository.GetCounsellorName(st.Email);
            return View("CounselorSettings", st);
        }
        public ViewResult DashBoard()
        {
            return View("CounsellorDashboard");
        }
        public async Task<ViewResult> addDetails(string religion, string blood, string qual,string gender)
        {
            st.Email= HttpContext.Request.Cookies["email"];
            st.Password= HttpContext.Request.Cookies["password"];
            st.Religion = religion;
            st.BloodGroup = blood;
            st.Qualification = qual;
            CounsellorRepository counsellorRepository = new CounsellorRepository(context);
            bool isadded = await counsellorRepository.AddDetails(st.Email,st.Password,st);
            if (isadded)
            {
                return View("CounsellorHome");
            }
            else
                return View("DetailsNotadded");
        }
        public ViewResult Upload()
        {
            return View("CounsellorUpload");
        }

        public async Task<ViewResult> updateDetails(string religion, string blood, string password, string gender,string name)
        {
            st.Email = HttpContext.Request.Cookies["email"]; 
            st.Religion = religion;
            st.BloodGroup = blood;
            st.Name = name;
            st.Password = password;
            st.Gender = gender;
            CounsellorRepository counsellorRepository = new CounsellorRepository(context);
            bool isadded = await counsellorRepository.UpdateDetails(st.Email,st);
            if (isadded)
            {
                return View("CounsellorHome");
            }
            else
                return View("DetailsNotadded");
        }
        [HttpPost]
        public IActionResult UploadFile(List<IFormFile> postedFiles)
        {
            string wwwPath = this.Environment.WebRootPath;
            string path = Path.Combine(wwwPath, "Documents");
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }

            foreach (var file in postedFiles)
            {
                var fileName = Path.GetFileName(file.FileName);
                var pathWithFileName = Path.Combine(path, fileName);
                using (FileStream stream = new
                    FileStream(pathWithFileName,
                    FileMode.Create))
                {
                    file.CopyTo(stream);
                    ViewBag.Message = "file uploaded successfully";
                }
            }
            return View("done");
        }
    }
}
