using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Script.Serialization;

namespace Json.Models
{
    class ModelObj
    {
        public Object getModelObj(){
            
            // get url 
            string url = "http://api.icndb.com/jokes/";
            // create web client
            var client = new WebClient();
            var content = client.DownloadString(url);
            // create serializer
            var serializer = new JavaScriptSerializer();
            // deserialize content
            var jsonContent = serializer.Deserialize<Object>(content);

            // return content
            return jsonContent;
        }
    }
}