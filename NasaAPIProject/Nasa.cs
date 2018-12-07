using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;
using RestSharp;

namespace NasaAPIProject
{
    class Nasa
    {
        public Nasa()
        {

        }

        public string GetTest()
        {
            try
            {
                var api_key = "DqOLnNdvyAucOxwwvjDQ4XQGd2Wl7jtB368Q61rX";
                var client = new RestClient("https://api.nasa.gov/planetary/apod?api_key="+api_key);
                var request = new RestRequest();
                request.Method = Method.GET;
              
                var response = client.Execute(request);
                var content = response.Content; // raw content as string  
                return content;
            }
            catch (Exception e)
            {
                return e.Message;
              
            }
        }

    }
}
