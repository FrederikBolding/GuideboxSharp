using GuideboxSharp.Objects;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace GuideboxSharp
{
    public class GuideboxClient
    {
        private const string baseURL = "api-public.guidebox.com";
        private const string version = "v1.43";
        private string apiKey;
        private bool useSSL;
        private string region = "US";

        public GuideboxClient(string apiKey, bool useSSL)
        {
            this.apiKey = apiKey;
            this.useSSL = useSSL;
        }

        public async Task<SearchShow> SearchShowByExternalID(ExternalType type, string id)
        {
            SearchShow show = await Request<SearchShow>("search/id/" + type.ToString().ToLower() + "/" + id).ConfigureAwait(false);
            return show;
        }

        public async Task<Show> GetShowByID(int id)
        {
            Show show = await Request<Show>("show/" + id).ConfigureAwait(false);
            return show;
        }

        public async Task<AvailableContent> GetShowAvailableContent(string id)
        {
            AvailableContent content = await Request<AvailableContent>("show/" + id + "/available_content").ConfigureAwait(false);
            return content;
        }

        public async Task<SearchMovie> SearchMovieByExternalID(ExternalType type, string id)
        {
            SearchMovie movie = await Request<SearchMovie>("search/movie/id/" + type.ToString().ToLower() + "/" + id).ConfigureAwait(false);
            return movie;
        }

        public async Task<Movie> GetMovieByID(int id)
        {
            Movie movie = await Request<Movie>("movie/" + id).ConfigureAwait(false);
            return movie;
        }

        private async Task<T> Request<T>(string query)
        {
            using (var client = new HttpClient())
            {
                //client.BaseAddress = new Uri(baseURL);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                HttpResponseMessage response = await client.GetAsync(BuildURL(query)).ConfigureAwait(false);
                if (response.IsSuccessStatusCode)
                {
                    string json = await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                    return (T)JsonConvert.DeserializeObject<T>(json, new JsonSerializerSettings()
                    {
                        Error = HandleDeserializationError
                    });
                }
                else
                {
                    return default(T);
                }
            }
        }

        public void HandleDeserializationError(object sender, ErrorEventArgs errorArgs)
        {
            var currentError = errorArgs.ErrorContext.Error.Message;
            errorArgs.ErrorContext.Handled = true;
        }

        private string BuildURL(string query)
        {
            string protocol;
            if (useSSL)
            {
                protocol = "https://";
            }
            else
            {
                protocol = "http://";
            }
            return protocol + baseURL + "/" + version + "/" + region + "/" + apiKey + "/" + query;
        }
    }
}