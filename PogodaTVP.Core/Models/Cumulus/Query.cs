using PogodaTVP.Core.Enums;
using System;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;

namespace PogodaTVP.Core.Models.Cumulus
{

   public class Query
    {
        

        private string _apiKey1;
        public string apiKey1
        { 
            get
            {
                return _apiKey1.ToLower();
            }
            set
            {
                using (SHA1 sha1Hash = SHA1.Create())
                {
                    var hashBytes = SHA1.Create().ComputeHash(Encoding.UTF8.GetBytes(value));
                    _apiKey1 = BitConverter.ToString(hashBytes).Replace("-",string.Empty);
                }
            }
                    
        }
        public string apiKey2 { get; protected set; }
        public string point { get; protected set; }

        public Query(Authorization authorization)
        {
            apiKey1 = authorization.ApiKey1;
            apiKey2 = authorization.ApiKey2;
        }
        public Query(Authorization authorization, QueryData queryData)
        {
            apiKey1 = authorization.ApiKey1;
            apiKey2 = authorization.ApiKey2;
            point = queryData.ToString();
            
        }


       
            


    }
}
