using MyAvanaQuestionaireModel;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MyAvanaQuestionaireApiClient
{
    public partial class ApiClient
    {
        public async Task<Message<HairProfileCustomerModel>> GetHairProfileCustomer(HairProfileCustomerModel hairProfileModel)
        {
            var requestUrl = CreateRequestUri(string.Format(System.Globalization.CultureInfo.InvariantCulture, "HairProfile/GetHairProfileCustomer"));
            var result = await PostAsync<HairProfileCustomerModel>(requestUrl, hairProfileModel);
            return result;
        }
        public async Task<Message<QuestionaireModel>> GetQuestionaireDetails(QuestionaireModel questionaire)
        {
            var requestUrl = CreateRequestUri(string.Format(System.Globalization.CultureInfo.InvariantCulture, "HairProfile/GetQuestionaireDetails"));
            var result = await PostAsync<QuestionaireModel>(requestUrl, questionaire);
            return result;
        }
        public async Task<Message<QuestionAnswerModel>> GetCustomerQuestionaireDetails(QuestionAnswerModel questionaire)
        {
            var requestUrl = CreateRequestUri(string.Format(System.Globalization.CultureInfo.InvariantCulture, "Questionnaire/GetQuestionnaireCustomerDetails"));
            var result = await PostAsync<QuestionAnswerModel>(requestUrl, questionaire);
            return result;
        }
    }
}
