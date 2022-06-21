
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace WebUI.Controllers
{
    public class AuthController : Controller
    {
        public AuthController()
        {
        }

        public IActionResult Login()
        {
            return View();
        }


        [HttpPost]
        public async Task<IActionResult> Login(string email, string password)
        {
            object data = new { Email = email, Password = password };
            //data = new { id = 1 };
            var content = new StringContent(JsonConvert.SerializeObject(data), Encoding.UTF8, "application/json");
            object result="{}";
            string url = "https://localhost:44302/api/Auth/login";
            try
            {
                using (var httpClient = new HttpClient())
                {
                    using (var request = new HttpRequestMessage(new HttpMethod("POST"), url))
                    {
                        request.Headers.TryAddWithoutValidation("Accept", "application/json");
                        request.Content = content;
                        request.Content.Headers.ContentType =
                           MediaTypeHeaderValue.Parse("application/json; charset=utf-8");
                        var response =  httpClient.PostAsync(url,content);

                        result =await response;
                    }
                }
            }
            catch (Exception ex)
            {


            }
            return  Json(result);


        }



        [HttpPost]
        public IActionResult Login2(string email, string password)
        {
            object data = new { Email = email, Password = password };
             data = new { id =1};
            var content = new StringContent(JsonConvert.SerializeObject(data), Encoding.UTF8, "application/json");
            object result;
            string url = "https://localhost:44302/api/Brands/getbyid";
            using (var httpClient = new HttpClient())
            {
                using (var request = new HttpRequestMessage(new HttpMethod("POST"), url))
                {
                    request.Headers.TryAddWithoutValidation("Accept", "application/json");
                    request.Content = content;
                    request.Content.Headers.ContentType =
                       MediaTypeHeaderValue.Parse("application/json; charset=utf-8");
                    var response = httpClient.PostAsync(url,content);

                    result = response;
                }
            }
            return Json(result);


        }




        //[HttpPost]
        //public IActionResult Register(UserForRegisterDto entity)
        //{
        //    var userExists = _authService.UserExist(entity.Email);
        //    if (!userExists.Success)
        //    {
        //        return Json(new ErrorResult(userExists.ErrorMessage));
        //    }
        //    var registerResult = _authService.Register(entity, entity.Password);
        //    //_authService.CreateAccessToken(registerResult.Data);
        //   return Json(registerResult);


        //}
    }
}
