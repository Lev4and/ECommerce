namespace ECommerce.HttpClients.Ozon
{
    public class OzonHeaders
    {
        public static Dictionary<string, string> HtmlHeaders => new Dictionary<string, string>()
        {
            { "Host", OzonRoutes.Domain },
            { "Connection", "keep-alive" },
            { "Cache-Control", "max-age=0" },
            { "sec-ch-ua", "\"Chromium\";v=\"94\", \"Yandex\";v=\"21\", \"; \"Not A Brand\";v=\"99\"" },
            { "sec-ch-ua-mobile", "?0" },
            { "sec-ch-ua-platform", "\"Windows\"" },
            { "Upgrade-Insecure-Requests", "1" },
            { "User-Agent", "Mozilla/5.0 (Windows NT 10.0; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) " +
                "Chrome/94.0.4606.85 YaBrowser/21.11.4.730 Yowser/2.5 Safari/537.36" },
            { "Accept", "text/html,application/xhtml+xml,application/xml;q=0.9," +
                "image/avif,image/webp,image/apng,*/*;q=0.8,application/signed-exchange;v=b3;q=0.9" },
            { "Sec-Fetch-Site", "same-origin" },
            { "Sec-Fetch-Mode", "navigate" },
            { "Sec-Fetch-User", "?1" },
            { "Sec-Fetch-Dest", "document" },
            { "Accept-Encoding", "gzip, deflate, br" },
            { "Accept-Language", "ru,en;q=0.9" },
        };

        public static Dictionary<string, string> JsonHeaders => new Dictionary<string, string>()
        {
            { "Host", OzonRoutes.Domain },
            { "Connection", "keep-alive" },
            { "sec-ch-ua", "\"Chromium\";v=\"94\", \"Yandex\";v=\"21\", \"; \"Not A Brand\";v=\"99\"" },
            { "x-o3-app-name", "dweb_client" },
            { "sec-ch-ua-mobile", "?0" },
            { "User-Agent", "Mozilla/5.0 (Windows NT 10.0; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) " +
                "Chrome/94.0.4606.85 YaBrowser/21.11.4.730 Yowser/2.5 Safari/537.36" },
            //{ "Content-Type", "application/json" },
            { "Accept", "application/json" },
            { "x-o3-app-version", "release_12-0'-'2022_0decd125" },
            { "sec-ch-ua-platform", "\"Windows\"" },
            { "Sec-Fetch-Site", "same-origin" },
            { "Sec-Fetch-Mode", "cors" },
            { "Sec-Fetch-Dest", "empty" },
            { "Accept-Encoding", "gzip, deflate, br" },
            { "Accept-Language", "ru,en;q=0.9" },
        };
    }
}
