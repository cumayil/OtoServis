using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using OtoServis.DataAccess.Concrete.EntityFramework;
using OtoServis.Entities.Concrete;
using OtoServis.UI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;


namespace OtoServis.UI.Controllers
{
    public class LoginController : Controller
    {
        [Route("")]
        public ActionResult Index()
        {
            
            return View();
        }
        
        [HttpPost]
        [Route("")]
        public async Task<IActionResult> Index(User user)
        {
            user.Email = "cuma.yildirim@vsdijital.com.tr";
            user.Password = "1";
            using (OtoServisContext context = new OtoServisContext())
            {
                var login = context.Users.FirstOrDefault(x => x.Email == user.Email && x.Password == user.Password);
                if (login != null)
                {

                    var claims = new List<Claim>
                    {
                        new Claim(ClaimTypes.Email,user.Email)
                    };
                    var useridentity = new ClaimsIdentity(claims, "Login");
                    ClaimsPrincipal principal = new ClaimsPrincipal(useridentity);
                    
                    return RedirectToAction("Index", "Home");
                }
               
                return View();
            }
            
            
        }
    }
    }

