using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.IO;

namespace MidwestGeeks.Lib
{
    public class AngleBracketEventRepo
    {
        //playing with Eventbrite Api
        public String ListEvents()
        { 
            var appKey = "SGX6PYXNUOXEGYPQJJ"; //my eventbrite app key
            var angleBracketId = "1647971612";
            var api_url = "https://www.eventbrite.com/json/organizer_list_events?app_key=" + appKey + "&id=" + angleBracketId;

            var request = WebRequest.Create(api_url);
            var response = request.GetResponse();

            var stream = response.GetResponseStream();
            var reader = new StreamReader(stream);

            return reader.ReadToEnd();
        }
    }
}
