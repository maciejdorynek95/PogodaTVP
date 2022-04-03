using Microsoft.Extensions.Logging;
using PogodaTVP.Logic.Interfaces;
using System;
using System.Reflection;
using System.Text;

namespace PogodaTVP.Logic.Services
{
    public class QueryService : IQueryService
    {
        private readonly ILogger _logger;
        public QueryService(ILogger<QueryService> logger)
        {
            _logger = logger;
        }

        public string CreateQueryString<T>(T _object)
        {
            StringBuilder stringBuilder = new StringBuilder();
            try
            {
                foreach (var item in _object.GetType().GetProperties(BindingFlags.Public | BindingFlags.Instance))
                {
                    stringBuilder.AppendFormat("{0}={1}&", item.Name, item.GetValue(_object));
                }
                stringBuilder.Remove(stringBuilder.Length - 1, 1); // Remove last char & 
                return stringBuilder.ToString();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message + "< Uwaga wystąpił błąd: " + stringBuilder.ToString());
            }
        }


    }
}
