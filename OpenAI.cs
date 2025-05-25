using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using RestSharp;

namespace InterviewCode
{
    public class OpenAI
    {
        private const string ApiKey = "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";
        private const string Endpoint = "https://api.openai.com/v1/completions";


        public static void CallOpenAI()
        {
            var client = new RestClient(Endpoint);
            var request = new RestRequest(Endpoint,Method.Post);
            request.AddHeader("Authorization", $"Bearer {ApiKey}");
            request.AddJsonBody(new
            {
                model = "gpt-4o",
                prompt = "Hello, how are you?",
                max_tokens = 50
            });

            var response = client.Execute(request);
            var responseObject = response.Content;
            Console.WriteLine(responseObject.ToString());
        }
        //public static void Main(string[] args)
        //{
        //    var client = new RestClient(Endpoint);
        //    var request = new RestRequest(Method.Post);
        //    request.AddHeader("Authorization", $"Bearer {ApiKey}");
        //    request.AddJsonBody(new
        //    {
        //        model = "text-davinci-003",
        //        prompt = "Hello, how are you?",
        //        max_tokens = 50
        //    });

        //    var response = client.Execute(request);
        //    var responseObject = JObject.Parse(response.Content);
        //    Console.WriteLine(responseObject["choices"][0]["text"].ToString());
        //}
    }
}
