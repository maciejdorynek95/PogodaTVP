using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using PogodaTVP.Logic.Interfaces;
using System;
using System.IO;
using System.Net;
using System.Text;

namespace PogodaTVP.Logic.Services
{
    public class WeatherRequest : IWeatherRequest
    {
        private readonly ILogger<WeatherRequest> _logger;
        private readonly IConfiguration _configuration;

        public WeatherRequest(IConfiguration configuration, ILogger<WeatherRequest> logger)
        {
            _configuration = configuration;
            _logger = logger;
        }

        public HttpWebRequest CreateRequestPOST(string queryString)
        {
            if (string.IsNullOrWhiteSpace(queryString))
            {
                throw new ArgumentNullException("queryString is NULL");
            }

            HttpWebRequest request = null;

            try
            {
                
                Uri uri = new Uri(_configuration.GetSection("CulumbusUriString").Value);
                request = (HttpWebRequest)WebRequest.Create(uri);
                request.Method = "POST";

                request.ContentType = "application/x-www-form-urlencoded";
                UTF8Encoding encoding = new UTF8Encoding();
                request.ContentLength = encoding.GetBytes(queryString).Length;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                throw;

            }
            return request;

        }


        public HttpWebResponse SendRequest(HttpWebRequest request, string queryString)
        {
            HttpWebResponse response = null;

            if (request == null)
            {
                throw new ArgumentNullException(nameof(request));
            }

            if (string.IsNullOrWhiteSpace(queryString))
            {
                throw new ArgumentNullException(nameof(queryString));
            }

            using (StreamWriter swrite = new StreamWriter(request.GetRequestStream()))
            {
                swrite.Write(queryString);
            }
            response = (HttpWebResponse)request.GetResponse();


            return response.StatusCode != HttpStatusCode.OK ? throw new Exception($"Błąd podczas wysyłania Requestu : {queryString}") : response;



        }

    }
}
