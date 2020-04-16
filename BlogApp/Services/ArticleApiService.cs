using BlogApp.Responses;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BlogApp.Services
{
    public interface IArticleApiService
    {
        ArticleResponce GetArticles();
    }
    public class ArticleApiService : IArticleApiService
    {
        private readonly RestClient _restClient;
        public ArticleApiService()
        {
            _restClient = new RestClient("http://local.blogapi");
        }

        public ArticleResponce GetArticles()
        {
            var apiURL = "api/blogposts";
            var request = new RestRequest(apiURL);
            var responceData = _restClient.Execute<ArticleResponce>(request, Method.GET).Data;
            return responceData;
        }
    }
}