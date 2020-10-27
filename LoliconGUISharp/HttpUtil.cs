using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;

namespace LoliconGUISharp
{
    public static class HttpUtil
    {
        private const string TAG = nameof(HttpUtil);

        private static bool NullableBooleanToBoolean(bool? value)
        {
            return value.Equals(true);
        }

        public static HttpWebResponse _GetResponse(string url, Dictionary<string, string> data = null)
        {
            var keyValuePairs = data?.Where(item => item.Key != null && item.Value != null);
            if (NullableBooleanToBoolean(data?.Any()))
            {
                var stringBuilder = new StringBuilder("?");
                stringBuilder.Append(string.Join("&",
                    from KeyValuePair<string, string> item in keyValuePairs select $"{item.Key}={item.Value}"));
                url += stringBuilder.ToString();
            }

            //Log.D(TAG, $"URL={url}");
            HttpWebResponse response = null;
            try
            {
                var httpWebRequest = (HttpWebRequest) WebRequest.Create(new Uri(url));
                response = (HttpWebResponse) httpWebRequest.GetResponse();
            }
            catch (WebException e)
            {
                Log.E(TAG, e.Message);
            }

            return response;
        }

        public static string Get(string url, Dictionary<string, string> data = null)
        {
            string response = null;
            using (var httpWebResponse = _GetResponse(url, data))
            {
                //Log.D(TAG, $"URL={url} HTTP {httpWebResponse?.StatusCode}");
                using (var stream = httpWebResponse?.GetResponseStream())
                {
                    using (var streamReader = new StreamReader(stream))
                    {
                        try {
                            response = streamReader.ReadToEnd();
                        }
                        catch (ArgumentException)
                        {
                        }
                }
                }
            }

            return response;
        }

        public static Image GetImage(string url, Dictionary<string, string> data = null)
        {
            Image response = null;
            using (var httpWebResponse = _GetResponse(url, data))
            {
                //Log.D(TAG, $"URL={url} HTTP {httpWebResponse?.StatusCode}");
                using (var stream = httpWebResponse?.GetResponseStream())
                {
                    try
                    {
                        response = Image.FromStream(stream);
                    }
                    catch (ArgumentException)
                    {
                    }
                    catch (IOException)
                    {
                    }
                }
            }

            return response;
        }
    }
}