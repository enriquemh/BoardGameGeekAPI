using System;
using System.ComponentModel.Composition;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading;
using System.Web;
using System.Xml;
using System.Xml.Serialization;
using BoardGameGeekAPI.BGGObjects;
using BoardGameGeekAPI.BGGObjects.Game;
using Items = BoardGameGeekAPI.BGGObjects.Items;

namespace BoardGameGeekAPI
{
    [Export]
    public class BoardGameGeekConnector
    {
        internal const string BOARDGAMEGEEK_URL = "https://www.boardgamegeek.com/xmlapi2/";

        private const string RECIBED_MESSAGE = "<?xml version=\"1.0\" encoding=\"utf-8\" standalone=\"yes\"?>\n<message>\n	Your request for this collection has been accepted and will be processed.  Please try again later for access.\n</message>";

        private static readonly HttpClient HttpClient = new HttpClient
        {
            BaseAddress = new Uri(BOARDGAMEGEEK_URL),
            DefaultRequestHeaders = 
            {
                Accept = { new MediaTypeWithQualityHeaderValue("text/xml"), }
            }
        };

        public Items GetUserCollection(string username, bool rated = true, bool stats = true, bool own = true)
        {
            var formattedText = $"collection?username={username}" + 
                                (stats ? "&stats=1" : string.Empty) +
                                (!own ? "&own=0" : string.Empty) +
                                (rated ? "&rated=1" : string.Empty);

            if (!TryGetRetryElement(formattedText, out string xml))
                return null;

            var validXml = xml.Where(XmlConvert.IsXmlChar).ToArray();

            using (var stream = new MemoryStream(Encoding.UTF8.GetBytes(validXml)))
            {
                try
                {
                    return (Items) new XmlSerializer(typeof(Items)).Deserialize(stream);
                }
                catch (Exception)
                {
                    // I have seen some with deleted users.
                    return new Items();
                }
            }
        }

        public User GetUserInformation(string username, bool buddies = true)
        {
            var formattedText = $"user?name={username}" +
                                (buddies ? "&buddies=1" : string.Empty);

            if (!TryGetElement(formattedText, out string xml))
                return null;

            using (var stream = new MemoryStream(Encoding.UTF8.GetBytes(xml)))
            {
                return (User)new XmlSerializer(typeof(User)).Deserialize(stream);
            }
        }
        
        public Game GetGame(int metadataGameId, bool stats = true)
        {
            // https://boardgamegeek.com/xmlapi2/thing?id=15&stats=1
            var formattedText = $"thing?id={metadataGameId}" +
                                (stats ? "&stats=1" : string.Empty);

            if (!TryGetRetryElement(formattedText, out string xml))
                return null;

            using (var stream = new MemoryStream(Encoding.UTF8.GetBytes(xml)))
            {
                return (Game)new XmlSerializer(typeof(Game)).Deserialize(stream);
            }
        }

        private bool TryGetElement(string query, out string element)
        {
            return TryGetMethod(() => GetElement(query), out element);
        }

        private string GetElement(string query)
        {
            var response = HttpClient.GetAsync(query, HttpCompletionOption.ResponseContentRead).Result;

            var httpResponseMessage = response.EnsureSuccessStatusCode();

            if (httpResponseMessage.StatusCode == HttpStatusCode.OK)
            {
                return Encoding.UTF8.GetString(httpResponseMessage.Content.ReadAsByteArrayAsync().Result);
            }

            throw new HttpException($"Status code from query {query} returned {httpResponseMessage}.");
        }


        private bool TryGetRetryElement(string query, out string element)
        {
            return TryGetMethod(() => GetRetryElement(query), out element);
        }

        private string GetRetryElement(string query)
        {
            var response = HttpClient.GetAsync(query, HttpCompletionOption.ResponseContentRead).Result;

            var httpResponseMessage = response.EnsureSuccessStatusCode();

            if (httpResponseMessage.StatusCode == HttpStatusCode.Accepted)
            {
                string message = null;

                foreach (var tryrun in Enumerable.Range(0, 10))
                {
                    Thread.Sleep(2000);

                    response = HttpClient.GetAsync(query, HttpCompletionOption.ResponseContentRead).Result;
                    response.EnsureSuccessStatusCode();

                    if (CheckResponse(response, out message))
                        break;
                }

                if (!string.IsNullOrEmpty(message))
                    return message;
                
            }

            if (CheckResponse(response, out string m))
                return m;

            throw new Exception("Not Accepted");
        }

        private bool CheckResponse(HttpResponseMessage httpResponseMessage, out string message)
        {
            if (httpResponseMessage.StatusCode == HttpStatusCode.OK)
            {
                message = Encoding.UTF8.GetString(httpResponseMessage.Content.ReadAsByteArrayAsync().Result);

                return !string.Equals(message, RECIBED_MESSAGE);
            }

            message = string.Empty;

            return false;
        }

        private bool TryGetMethod(Func<string> queryFunction, out string element)
        {
            try
            {
                element = queryFunction.Invoke();
                return true;
            }
            catch
            {
                element = null;
                return false;
            }
        }
    }
}
