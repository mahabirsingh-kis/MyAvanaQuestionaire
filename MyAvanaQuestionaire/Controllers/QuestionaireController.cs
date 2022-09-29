using System;
using System.Collections.Generic;
using System.IO;
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
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Options;
using MyAvanaQuestionaire.Factory;
using MyAvanaQuestionaire.Models;
using MyAvanaQuestionaireModel;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace MyAvanaQuestionaire.Controllers
{
    [Authorize(AuthenticationSchemes = "CustomerCookies")]

    public class QuestionaireController : Controller
    {
        private readonly HttpClient _httpClient;
        private readonly IOptions<AppSettingsModel> config;
        private Uri BaseEndpoint;
        public QuestionaireController(IOptions<AppSettingsModel> config)
        {
            this.config = config;
            _httpClient = new HttpClient();
            BaseEndpoint = new Uri(config.Value.WebApiBaseUrl);
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

        public IActionResult start(string id)
        {
            if (id != null)
            {
                ViewBag.token = id;
            }
            else
            {
                var claimsIdentity1 = (ClaimsIdentity)User.Identity;
                string userId = (claimsIdentity1.Claims).Select(x => x.Value).FirstOrDefault();
                ViewBag.Token = userId;
            }
            return View();
        }
            public IActionResult Questionaire(string id, string userId)
        {
            ViewBag.Token = userId;
            ViewBag.Check = id;
            return View();
        }
        public async Task<IActionResult> EditQuestionaire(string id, string qa, string userId)
        {
            ViewBag.Token = userId;
            ViewBag.Check = id;
            if (!string.IsNullOrEmpty(qa)){
                var claimsIdentity1 = (ClaimsIdentity)User.Identity;

                MyAvanaQuestionaireModel.QuestionAnswerModel questionaireModel = new MyAvanaQuestionaireModel.QuestionAnswerModel();
                questionaireModel.UserId = userId;
                questionaireModel.QA = Convert.ToInt32(qa);

                var resp = await MyavanaCustomerApiClientFactory.Instance.GetCustomerQuestionaireDetails(questionaireModel);
                return View(resp.Data);
            }
            return View();
        }

        public async Task<QuestionAnswerModel> GetUserQuestionaire()
        {
            var claimsIdentity1 = (ClaimsIdentity)User.Identity;
            string userId = (claimsIdentity1.Claims).Select(x => x.Value).FirstOrDefault();

            var requestUrl = _httpClient.GetAsync("https://api.myavana.com/" + "Questionnaire/GetQuestionnaireCustomer?id=" + userId).Result;

            var data = await requestUrl.Content.ReadAsStringAsync();
            dynamic result = JObject.Parse(data);
            QuestionAnswerModel questionaire = JsonConvert.DeserializeObject<QuestionAnswerModel>(Convert.ToString(result.data));
            foreach (var item in questionaire.questionModel)
            {
                if (item.AnswerList.Count() == 2)
                {
                    item.AnswerList = item.AnswerList.Where(x => x.QA == 2).ToList();
                }
                else
                {
                    item.AnswerList = item.AnswerList.Where(x => x.QA == 1).ToList();
                }
            }
            return questionaire;

        }

        public IActionResult update()
        {
            var claimsIdentity1 = (ClaimsIdentity)User.Identity;
            string userId = (claimsIdentity1.Claims).Select(x => x.Value).FirstOrDefault();
            return RedirectToRoute(new { controller = "Questionaire", action = "Questionaire", id = userId });
        }
        private Uri CreateRequestUri(string relativePath, string queryString = "")
        {
            var endpoint = new Uri(BaseEndpoint, relativePath);
            var uriBuilder = new UriBuilder(endpoint);
            uriBuilder.Query = queryString;
            return uriBuilder.Uri;
        }

        private void addHeaders()
        {
            _httpClient.DefaultRequestHeaders.Remove("userIP");
            _httpClient.DefaultRequestHeaders.Add("userIP", "192.168.1.1");
        }

        public class QuestionaireModel
        {
            public string questionaire { get; set; }
            public IFormFile File { get; set; }
        }

        [HttpPost]
        public async Task<IActionResult> SaveQuestionaire([FromBody] IEnumerable<Questionaire> questionaire)
        {
            try
            {
                using (var client = new HttpClient())
                {
                    client.BaseAddress = BaseEndpoint;
                    if (questionaire.Count() != 0)
                    {
                        questionaire.FirstOrDefault().UserId = HttpContext.Session.GetString("id");
                        var requestUrl = CreateRequestUri(string.Format(System.Globalization.CultureInfo.InvariantCulture, "Questionnaire/SaveSurvey"));
                        addHeaders();
                        var response = await client.PostAsync(requestUrl.ToString(), CreateHttpContent<IEnumerable<Questionaire>>(questionaire));

                        if (response.StatusCode.ToString() == "OK")
                            return Content("1");
                        else
                            return Content("0");
                    }
                    else
                    {
                        return Content("0");
                    }
                }
            }
            catch (Exception ex)
            {
                return StatusCode(500);
            }
        }

        [HttpPost]
        public async Task<IActionResult> EditQuestionaire([FromBody] IEnumerable<Questionaire> questionaire)
        {
            try
            {
                using (var client = new HttpClient())
                {
                    client.BaseAddress = BaseEndpoint;
                    if (questionaire.Count() != 0)
                    {
                        questionaire.FirstOrDefault().UserId = HttpContext.Session.GetString("id");
                        var requestUrl = CreateRequestUri(string.Format(System.Globalization.CultureInfo.InvariantCulture, "Questionnaire/EditSurvey"));
                        addHeaders();
                        var response = await client.PostAsync(requestUrl.ToString(), CreateHttpContent<IEnumerable<Questionaire>>(questionaire));

                        if (response.StatusCode.ToString() == "OK")
                            return Content("1");
                        else
                            return Content("0");
                    }
                    else
                    {
                        return Content("0");
                    }
                }
            }
            catch (Exception ex)
            {
                return StatusCode(500);
            }
        }
        [HttpPost]
        public async Task<IActionResult> SaveImage(IFormFile file)
        {
            try
            {
                if (file != null)
                {
                    string fileName = RandomNumbers() + ".jpg"; // file.FileName;
                    if (!Directory.Exists(Path.Combine(Directory.GetCurrentDirectory(), "questionnaireFile")))
                    {
                        Directory.CreateDirectory(Path.Combine(Environment.CurrentDirectory, "questionnaireFile"));
                    }
                    var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "questionnaireFile", fileName);
                    using (var stream = new FileStream(path, FileMode.Create))
                    {
                        await file.CopyToAsync(stream);
                    }

                    return Content(fileName);
                }
                else
                    return Content("0");
            }
            catch (Exception ex)
            {
                return StatusCode(500);
            }
        }

        Random _random = new Random();
        public int RandomNumber(int min, int max)
        {
            return _random.Next(min, max);
        }
        public string RandomString(int size, bool lowerCase = false)
        {
            var builder = new StringBuilder(size);
            char offset = lowerCase ? 'a' : 'A';
            const int lettersOffset = 26; // A...Z or a..z: length=26  

            for (var i = 0; i < size; i++)
            {
                var @char = (char)_random.Next(offset, offset + lettersOffset);
                builder.Append(@char);
            }

            return lowerCase ? builder.ToString().ToLower() : builder.ToString();
        }

        public string RandomNumbers()
        {
            var passwordBuilder = new StringBuilder();

            // 4-Letters lower case   
            passwordBuilder.Append(RandomString(4, true));

            // 4-Digits between 1000 and 9999  
            passwordBuilder.Append(RandomNumber(1000, 9999));

            // 2-Letters upper case  
            passwordBuilder.Append(RandomString(2));
            return passwordBuilder.ToString();
        }

        QuestionAnswerModel globalQuestionaire = new QuestionAnswerModel();
        public IActionResult RefreshQuestionaire(string typeOfQA)
        {
            QuestionAnswerModel questionaire = HttpContext.Session.GetObjectFromJson<QuestionAnswerModel>("questionaires");
            List<SelectListItem> qas = new List<SelectListItem>();
            var ddList = questionaire.questionModel.Select(x => x.QAType).Distinct().ToList();
            int index = 0;
            foreach (var dd in ddList)
            {
                index++;
                if (typeOfQA == index.ToString())
                    qas.Add(new SelectListItem() { Text = "QA" + dd, Value = index.ToString(), Selected = true });
                else
                    qas.Add(new SelectListItem() { Text = "QA" + dd, Value = index.ToString() });
            }

            ViewBag.qas = qas;
            questionaire.questionModel = questionaire.questionModel.Where(x => x.QAType == typeOfQA).ToList();
            //return View(questionaire);
            return View("Questionnaire", questionaire);
        }
        public async Task<IActionResult> Questionnaire(string qa)
        {
            var claimsIdentity1 = (ClaimsIdentity)User.Identity;
            string userId = (claimsIdentity1.Claims).Select(x => x.Value).LastOrDefault();

            MyAvanaQuestionaireModel.QuestionaireModel questionaireModel = new MyAvanaQuestionaireModel.QuestionaireModel();
            questionaireModel.Userid = userId;

            var resp = await MyavanaCustomerApiClientFactory.Instance.GetQuestionaireDetails(questionaireModel);
            if (resp.Data.IsExist == true)
            {

                ViewBag.IsExist = true;
            }
            else
            {
                ViewBag.IsExist = false;
                //return RedirectToAction("start", "Questionaire", new { id = userId });
            }
            ViewBag.UserId = userId.ToString();
            var requestUrl = _httpClient.GetAsync("https://api.myavana.com/" + "Questionnaire/GetQuestionnaireCustomer?id=" + userId).Result;

            var data = await requestUrl.Content.ReadAsStringAsync();
            dynamic result = JObject.Parse(data);
            QuestionAnswerModel questionaire = JsonConvert.DeserializeObject<QuestionAnswerModel>(Convert.ToString(result.data));


            List<SelectListItem> qas = new List<SelectListItem>();

            List<QuestionModels> questionAnswerModels = new List<QuestionModels>();
            foreach (var quest in questionaire.questionModel)
            {
                int count = quest.AnswerList.Select(x => x.QA).Distinct().Count();
                for (int i = 1; i <= count; i++)
                {
                    QuestionModels questionModels = new QuestionModels();
                    questionModels.SerialNo = quest.SerialNo;
                    questionModels.QuestionId = quest.QuestionId;
                    questionModels.Question = quest.Question;
                    questionModels.QAType = i.ToString();
                    questionModels.QA = quest.AnswerList.Select(x => x.QA).Distinct().FirstOrDefault();
                    questionModels.AnswerList = quest.AnswerList.Where(x => x.QA == i).ToList();
                    questionAnswerModels.Add(questionModels);
                }

            }
            questionaire.questionModel = questionAnswerModels;

           
            var ddList = questionaire.questionModel.Select(x => x.QA).Distinct().ToList();
            int index = 0;
            foreach (var dd in ddList)
            {
                index++;
                if(index == 1)
                    qas.Add(new SelectListItem() { Text = "QA" + dd, Value = dd.ToString(), Selected = true });
                else
                    qas.Add(new SelectListItem() { Text = "QA" + dd, Value = dd.ToString() });
            }

            ViewBag.qas = qas;
            HttpContext.Session.SetObjectAsJson("questionaires", questionaire);
            globalQuestionaire = questionaire;
            questionaire.questionModel = questionAnswerModels.Where(x => x.QAType == index.ToString()).ToList();
            return View(questionaire);
        }

        [HttpGet]
        public async Task<bool> Logout()
        {
            Response.Cookies.Delete("CustomerCookies");
            return true;
        }
    }

    public static class SessionExtensions
    {
        public static void SetObjectAsJson(this ISession session, string key, object value)
        {
            session.SetString(key, JsonConvert.SerializeObject(value));
        }

        public static T GetObjectFromJson<T>(this ISession session, string key)
        {
            var value = session.GetString(key);
            return value == null ? default(T) : JsonConvert.DeserializeObject<T>(value);
        }
    }
}