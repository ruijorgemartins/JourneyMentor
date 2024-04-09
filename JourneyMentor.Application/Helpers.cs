using System.Net.Http.Headers;

namespace JourneyMentor.Application
{
    public static class Helpers
    {
        public static HttpClient ApiClient { get; set; }

        public static void InitializeClient()
        {
            ApiClient = new HttpClient
            {
                BaseAddress = new Uri(ApplicationResources.BaseUri)
            };

            ApiClient.DefaultRequestHeaders.Accept.Clear();
            ApiClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }
    }   
}
