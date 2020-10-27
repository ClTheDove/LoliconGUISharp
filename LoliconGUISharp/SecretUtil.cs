using Newtonsoft.Json;

namespace LoliconGUISharp
{
    public struct Manifest
    {
        public string apikey;
    }

    public struct ManifestRequest
    {
        public string version;
        public Manifest? data;
    }

    public static class SecretUtil
    {
        private const string TAG = nameof(SecretUtil);
        private const string SPLIT_CHAR = @"■";
        private const string MANIFEST_URL = @"https://h6w4os97yb.wodemo.net/entry/533772";
        private static ManifestRequest? manifestRequest;

        private static string _MiddleString(string content, string start, string end)
        {
            var index = content.IndexOf(start) + 1;
            return content.Substring(index, content.LastIndexOf(end) - index);
        }

        private static ManifestRequest? GetManifest()
        {
            return JsonConvert.DeserializeObject<ManifestRequest?>
                (_MiddleString(HttpUtil.Get(MANIFEST_URL), SPLIT_CHAR, SPLIT_CHAR));
        }

        public static void GetAndSetLoliconApiKey()
        {
            if (manifestRequest == null) manifestRequest = GetManifest();
            LoliconApi.SetApiKey(manifestRequest?.data?.apikey);
        }
    }
}