using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyAvanaQuestionaire.Models
{
    public class Signup
    {
        public string Email { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNo { get; set; }
        public int CountryCode { get; set; }
    }

    public class Response
    {
        public string contentType { get; set; }
        public string serializerSettings { get; set; }
        public int statusCode { get; set; }
        public ResponseItem value { get; set; }
    }

    public class ResponseItem
    {
        public string item1 { get; set; }
        public string item2 { get; set; }
    }
}
