using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Security.Claims;
using System.Security.Policy;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using MyAvanaQuestionaire.Factory;
using MyAvanaQuestionaire.Models;
using MyAvanaQuestionaireModel;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace MyAvanaQuestionaire.Controllers
{
    public class AuthController : Controller
    {
        private readonly HttpClient _httpClient;
        private readonly IOptions<AppSettingsModel> config;
        private Uri BaseEndpoint;
        public AuthController(IOptions<AppSettingsModel> config)
        {
            this.config = config;
            _httpClient = new HttpClient();
            BaseEndpoint = new Uri(config.Value.WebApiBaseUrl);
        }

        [AllowAnonymous]
        public async Task<IActionResult> Login([FromQuery(Name = "token")] string token)
        {
            if (token != null)
            {
                _httpClient.BaseAddress = BaseEndpoint;

                MultipartFormDataContent multipartContent = new MultipartFormDataContent();

                multipartContent.Add(new StringContent(token), "Token");
                var result = _httpClient.PostAsync("Questionnaire/AuthenticateUser", multipartContent).Result;
                var data = await result.Content.ReadAsStringAsync();
                dynamic res = JObject.Parse(data);
                string userId = (((Newtonsoft.Json.Linq.JProperty)((Newtonsoft.Json.Linq.JContainer)res).Last).Value).ToString();
                if (userId != null && userId != "")
                {
                    var claims = new List<Claim>
                        {
                            new Claim(ClaimTypes.Name, userId)
                        };

                    var claimsIdentity = new ClaimsIdentity(
                      claims, CookieAuthenticationDefaults.AuthenticationScheme);
                    var authProperties = new AuthenticationProperties();

                    await HttpContext.SignInAsync("CustomerCookies",
                        new ClaimsPrincipal(claimsIdentity),
                        authProperties);

                    return RedirectToAction("start", "Questionaire", new { id = userId });
                }
                return View();
            }
            else
            {
                return View();
            }
        }

        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> Login(Authentication authentication)
        {
            if (authentication.UserName != null && authentication.Password != null)
            {
                _httpClient.BaseAddress = new Uri("https://api.myavana.com/");
                var response = _httpClient.PostAsync("Account/signin", CreateHttpContent<Authentication>(authentication)).Result;

                var data = await response.Content.ReadAsStringAsync();
                var result = JsonConvert.DeserializeObject(data);
                var value = JsonConvert.SerializeObject(((Newtonsoft.Json.Linq.JProperty)((Newtonsoft.Json.Linq.JContainer)result).Last).Value); //.ToString();
                try
                {
                    UserModel user = JsonConvert.DeserializeObject<UserModel>(value);
               
                if (user.Id != null && user.Id.ToString() != "")
                {
						HttpContext.Session.SetString("token", user.access_token);
                        HttpContext.Session.SetString("email", user.Email);
                    HttpContext.Session.SetString("id", user.Id.ToString());
                    var claims = new List<Claim>
                        {
                            new Claim(ClaimTypes.Name, user.Id.ToString()),
                        };

                            var claimsIdentity = new ClaimsIdentity(
                              claims, CookieAuthenticationDefaults.AuthenticationScheme);
                            var authProperties = new AuthenticationProperties();

                            await HttpContext.SignInAsync("CustomerCookies",
                                new ClaimsPrincipal(claimsIdentity),
                                authProperties);

                            var claimsPrincipal = new ClaimsPrincipal(claimsIdentity);
                            Thread.CurrentPrincipal = claimsPrincipal;
                            return Content(user.Id.ToString());
                }
                }
                catch
                {
                    return Content("0");
                }
                return Content("0");
            }
            return Content("0");
        }

        private HttpContent CreateHttpContent<T>(T content)
        {
            var json = JsonConvert.SerializeObject(content, MicrosoftDateFormatSettings);
            return new StringContent(json, Encoding.UTF8, "application/json");
        }

        private static JsonSerializerSettings MicrosoftDateFormatSettings
        {
            get
            {
                return new JsonSerializerSettings
                {
                    DateFormatHandling = DateFormatHandling.MicrosoftDateFormat
                };
            }
        }


        public IActionResult Signup()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Signup(Signup signup)
        {
            _httpClient.BaseAddress = new Uri("https://api.myavana.com/");
            var response = _httpClient.PostAsync("Account/WebSignup", CreateHttpContent<Signup>(signup)).Result;

            var data = await response.Content.ReadAsStringAsync();
            dynamic result = JObject.Parse(data);
            Response res = null;
            try
            {
                res = JsonConvert.DeserializeObject<Response>(Convert.ToString(result));
                if (true)
                {
                    var claims = new List<Claim>
                        {
                            new Claim(ClaimTypes.Name, res.value.item1),
                        };

                    var claimsIdentity = new ClaimsIdentity(
                      claims, CookieAuthenticationDefaults.AuthenticationScheme);
                    var authProperties = new AuthenticationProperties();

                    await HttpContext.SignInAsync("CustomerCookies",
                        new ClaimsPrincipal(claimsIdentity),
                        authProperties);

                    var claimsPrincipal = new ClaimsPrincipal(claimsIdentity);
                    Thread.CurrentPrincipal = claimsPrincipal;
                }
            }
            catch (Exception ex)
            {
                return Content("0");
            }

            if (res.value.item1 != null)
                return Content(res.value.item1);
            else
                return Content("-1");
        }

        [HttpGet]
        public async Task<bool> Logout()
        {
            Response.Cookies.Delete("CustomerCookies");
            return true;
        }

        public IActionResult ForgotPassword()
        {
            return View();
        }

        public async Task<IActionResult> CheckForgotPassword(string email)
        {
            try
            {
                var response = _httpClient.GetAsync("https://api.myavana.com/" + "Account/forgetpassword?email=" + email).Result;
                var data = await response.Content.ReadAsStringAsync();
                dynamic result = JObject.Parse(data);
                ForgotPassword res = null;
                res = JsonConvert.DeserializeObject<ForgotPassword>(Convert.ToString(result));
                if (res.statusCode.ToString() == "200")
                    return Content("1");
                else
                    return Content("0");
            }

            catch (Exception ex)
            {
                //return Content("1");
            }
            return Content("0");
        }

        public IActionResult ResetPwd(string email)
        {
            SetPassword setPassword = new SetPassword();
            if (email != "")
            {
                setPassword.Email = email;
            }
            return View(setPassword);
        }

        public async Task<IActionResult> ResetPassword(SetPassword setPassword)
        {
            try
            {
				MultipartFormDataContent multiContent = new MultipartFormDataContent();

				multiContent.Add(new StringContent(setPassword.Email.ToString()), "Email");
				multiContent.Add(new StringContent(setPassword.Code.ToString()), "Code");
				multiContent.Add(new StringContent(setPassword.Password), "Password");

				_httpClient.BaseAddress = new Uri("https://api.myavana.com/");

				var response = _httpClient.PostAsync("Account/setpass", CreateHttpContent<SetPassword>(setPassword)).Result;
				if (response.StatusCode == System.Net.HttpStatusCode.OK)
					return Content("1");
				else
					return Content("0");
            }

            catch (Exception ex)
            {
				return Content("0");
			}
        }
    }
}