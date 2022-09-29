using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using MyAvanaQuestionaire.Factory;
using MyAvanaQuestionaire.Models;
using MyAvanaQuestionaire.Utility;
using MyAvanaQuestionaireModel;
using Microsoft.AspNetCore.Authorization;
using System.Security.Claims;
using System.IO;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;

namespace MyAvanaQuestionaire.Controllers
{
    [Authorize(AuthenticationSchemes = "CustomerCookies")]
    public class HairProfileController : Controller
    {
        private readonly AppSettingsModel apiSettings;
        public HairProfileController(IOptions<AppSettingsModel> app)
        {
            ApplicationSettings.WebApiUrl = "https://api.myavana.com/"; // app.Value.WebApiBaseUrl 
        }
        public async Task<IActionResult> CustomerHair()
        {
            var claimsIdentity1 = (ClaimsIdentity)User.Identity;
            string userId = (claimsIdentity1.Claims).Select(x => x.Value).FirstOrDefault();

            HairProfileCustomerModel hairProfileModel = new HairProfileCustomerModel();
            hairProfileModel.UserId = userId;

            QuestionaireModel questionaire = new QuestionaireModel();
            questionaire.Userid = userId;

            var result = await MyavanaCustomerApiClientFactory.Instance.GetQuestionaireDetails(questionaire);
            if (result.Data.IsExist == true)
            {
                ViewBag.IsExist = true;
            }
            else
            {
                ViewBag.IsExist = false;
                //return RedirectToAction("start", "Questionaire", new { id = userId });
            }

            if (hairProfileModel != null)
            {
                var response = await MyavanaCustomerApiClientFactory.Instance.GetHairProfileCustomer(hairProfileModel);
                if (!String.IsNullOrEmpty(response.Data.AIResult))
                {
                    var result1 = JsonConvert.DeserializeObject<dynamic>(response.Data.AIResult.ToString());
                    var pn = (object)result1["item2"];
                    response.Data.AIResultDecoded = (JObject)pn;
                }
                return View(response.Data);
            }
            return Content("0");
        }       
    }
}