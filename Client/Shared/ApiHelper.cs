using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Client.Shared
{
    public class ApiHelper
    {
        // TO DEVELOP: DELETE ...\Client\wwwroot\_framework folder!!!

        public static string apiProjects = "https://localhost:44346/api/projects";
        public static string apiBlog = "https://localhost:44346/api/blog/";
        public static string apiSendMessage = "https://localhost:44346/api/contact";
        public static string apiPostTraffic = "https://localhost:44346/api/traffic";

        public static string apiNews = "https://newsapi.org/v2/top-headlines?country=us&apiKey=de67b2237afe4fb1b77bfbe773987fca&pageSize=5";

        //public static string apiProjects = "https://wikivox.tk/api/projects";
        //public static string apiBlog = "https://wikivox.tk/api/blog/";
        //public static string apiSendMessage = "https://wikivox.tk/api/contact";
        //public static string apiPostTraffic = "https://wikivox.tk/api/traffic";


        public static string apiGeo = "https://geolocation-db.com/json/8f12b5f0-2bc2-11eb-9444-076679b7aeb0";
    }
}
