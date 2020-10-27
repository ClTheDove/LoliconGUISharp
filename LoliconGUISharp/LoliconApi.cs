using System.Collections.Generic;
using System.Drawing;
using Newtonsoft.Json;

namespace LoliconGUISharp
{
    public class Setu
    {
        public string author;
        public int? height;
        public Image image;
        public int? p;
        public int? pid;
        public bool? r18;
        public string[] tags;
        public string title;
        public int? uid;
        public string url;
        public int? width;

        public void QueryImage()
        {
            while (image == null)
            {
                image = HttpUtil.GetImage(url);
            }
        }
    }

    public class SetuRequest
    {
        public int? code;
        public int? count;
        public List<Setu> data;
        public string msg;
        public int? quota;
        public int? quota_min_ttl;

        public IEnumerator<Setu> GetEnumerator()
        {
            return data.GetEnumerator();
        }
    }

    public class LoliconApi
    {
        private const string TAG = nameof(LoliconApi);
        public const string API_URL = @"https://api.lolicon.app/setu";
        public const int NON_R18 = 0;
        public const int R18_ONLY = 1;
        public const int MIXED = 2;
        public const string REVERSER_PROXY = "i.pixiv.cat";
        public const string ORIGINAL_URL = "disable";
        public const string TRUE = "true";
        public const string FALSE = "false";
        public const int INTERNAL_ERROR = -1;
        public const int SUCCESS = 0;
        public const int API_KEY_INVALID = 401;
        public const int BANED = 403;
        public const int KEYWORD_NOT_FOUND = 404;
        public const int REACHED_LIMIT = 429;
        public const string KEY_APIKEY = "apikey";
        public const string KEY_R18 = "r18";
        public const string KEY_KEYWORD = "keyword";
        public const string KEY_NUM = "num";
        public const string KEY_PROXY = "proxy";
        public const string KEY_SIZE1200 = "size1200";
        public const string KEY_CODE = "code";
        public const string KEY_MSG = "msg";
        public const string KEY_QUOTA = "quota";
        public const string KEY_QUOTA_MIN_TTL = "quota_min_ttl";
        public const string KEY_COUNT = "count";
        public const string KEY_DATA = "data";
        public const string KEY_PID = "pid";
        public const string KEY_P = "p";
        public const string KEY_UID = "uid";
        public const string KEY_TITLE = "title";
        public const string KEY_AUTHOR = "author";
        public const string KEY_URL = "url";
        public const string KEY_WIDTH = "width";
        public const string KEY_HEIGHT = "height";
        public const string KEY_TAGS = "tags";
        private static string ApiKey;

        public static void SetApiKey(string value)
        {
            ApiKey = value;
        }

        private static string _NullableBooleanToString(bool? value)
        {
            return value.Equals(true) ? TRUE : value.Equals(false) ? FALSE : null;
        }

        public static SetuRequest ParseFromJson(string jsonString)
        {
            return JsonConvert.DeserializeObject<SetuRequest>(jsonString);
        }

        private static SetuRequest _Query(Dictionary<string, string> data = null)
        {
            return ParseFromJson(HttpUtil.Get(API_URL, data));
        }

        public static SetuRequest QuerySetu(int? r18 = null, string keyword = null, int? num = null,
            string proxy = null, bool? size1200 = null)
        {
            return _Query(new Dictionary<string, string>
            {
                [KEY_APIKEY] = ApiKey,
                [KEY_R18] = r18?.ToString(),
                [KEY_KEYWORD] = keyword,
                [KEY_NUM] = num?.ToString(),
                [KEY_PROXY] = proxy,
                [KEY_SIZE1200] = _NullableBooleanToString(size1200)
            });
        }
    }

    public interface QueryListener
    {
        void OnQueryStart();
        void OnQueryFinish();
    }
}