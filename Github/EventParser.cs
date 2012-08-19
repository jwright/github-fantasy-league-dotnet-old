using System;
using System.Collections.Generic;
using System.Linq;
using RestSharp;
using Newtonsoft.Json;

namespace Github
{
    public class EventParser
    {
        private readonly string _username;

        public EventParser(string username)
        {
            _username = username;
        }

        public IEnumerable<Event> Get()
        {
            var client = new RestClient(@"https://github.com");
            var request = new RestRequest(string.Format("{0}.json", _username));
            var response = client.Execute(request);
            return JsonConvert.DeserializeObject<IList<Event>>(response.Content);
        }
    }
}
