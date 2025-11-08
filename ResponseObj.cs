using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace APIVerve
{
    /// <summary>
    /// Favicons data
    /// </summary>
    public class Favicons
    {
        [JsonProperty("rel")]
        public string Rel { get; set; }

        [JsonProperty("href")]
        public string Href { get; set; }

    }
    /// <summary>
    /// Founder data
    /// </summary>
    public class Founder
    {
        [JsonProperty("@type")]
        public string Type { get; set; }

        [JsonProperty("@id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

    }
    /// <summary>
    /// AvailableLanguage data
    /// </summary>
    public class AvailableLanguage
    {
        [JsonProperty("@type")]
        public string Type { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("alternateName")]
        public string AlternateName { get; set; }

    }
    /// <summary>
    /// ContactPoint data
    /// </summary>
    public class ContactPoint
    {
        [JsonProperty("@type")]
        public string Type { get; set; }

        [JsonProperty("availableLanguage")]
        public AvailableLanguage[] AvailableLanguage { get; set; }

        [JsonProperty("contactOption")]
        public string ContactOption { get; set; }

        [JsonProperty("contactType")]
        public string ContactType { get; set; }

        [JsonProperty("telephone")]
        public string Telephone { get; set; }

    }
    /// <summary>
    /// Author data
    /// </summary>
    public class Author
    {
        [JsonProperty("@type")]
        public string Type { get; set; }

        [JsonProperty("@id")]
        public string Id { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("logo")]
        public string Logo { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("founder")]
        public Founder Founder { get; set; }

        [JsonProperty("foundingDate")]
        public string FoundingDate { get; set; }

        [JsonProperty("foundingLocation")]
        public string FoundingLocation { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("legalName")]
        public string LegalName { get; set; }

        [JsonProperty("contactPoint")]
        public ContactPoint ContactPoint { get; set; }

    }
    /// <summary>
    /// PotentialAction data
    /// </summary>
    public class PotentialAction
    {
        [JsonProperty("@type")]
        public string Type { get; set; }

        [JsonProperty("target")]
        public string Target { get; set; }

        [JsonProperty("query-input")]
        public string Queryinput { get; set; }

    }
    /// <summary>
    /// IsPartOf data
    /// </summary>
    public class IsPartOf
    {
        [JsonProperty("@type")]
        public string Type { get; set; }

        [JsonProperty("@id")]
        public string Id { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("potentialAction")]
        public PotentialAction PotentialAction { get; set; }

    }
    /// <summary>
    /// Jsonld data
    /// </summary>
    public class Jsonld
    {
        [JsonProperty("@context")]
        public string Context { get; set; }

        [JsonProperty("@type")]
        public string Type { get; set; }

        [JsonProperty("@id")]
        public string Id { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("author")]
        public Author Author { get; set; }

        [JsonProperty("isPartOf")]
        public IsPartOf IsPartOf { get; set; }

        [JsonProperty("inLanguage")]
        public string InLanguage { get; set; }

        [JsonProperty("sameAs")]
        public string[] SameAs { get; set; }

    }
    /// <summary>
    /// Headings data
    /// </summary>
    public class Headings
    {
        [JsonProperty("level")]
        public string Level { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }

    }
    /// <summary>
    /// ImgTags data
    /// </summary>
    public class ImgTags
    {
        [JsonProperty("src")]
        public string Src { get; set; }

        [JsonProperty("alt")]
        public string Alt { get; set; }

    }
    /// <summary>
    /// Data data
    /// </summary>
    public class Data
    {
        [JsonProperty("requestUrl")]
        public string RequestUrl { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("canonical")]
        public string Canonical { get; set; }

        [JsonProperty("lang")]
        public string Lang { get; set; }

        [JsonProperty("charset")]
        public string Charset { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("image")]
        public string Image { get; set; }

        [JsonProperty("favicons")]
        public Favicons[] Favicons { get; set; }

        [JsonProperty("author")]
        public string Author { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("keywords")]
        public string Keywords { get; set; }

        [JsonProperty("source")]
        public string Source { get; set; }

        [JsonProperty("price")]
        public string Price { get; set; }

        [JsonProperty("priceCurrency")]
        public string PriceCurrency { get; set; }

        [JsonProperty("availability")]
        public string Availability { get; set; }

        [JsonProperty("robots")]
        public string Robots { get; set; }

        [JsonProperty("jsonld")]
        public Jsonld[] Jsonld { get; set; }

        [JsonProperty("og:url")]
        public string Ogurl { get; set; }

        [JsonProperty("og:locale")]
        public string Oglocale { get; set; }

        [JsonProperty("og:locale:alternate")]
        public string Oglocalealternate { get; set; }

        [JsonProperty("og:title")]
        public string Ogtitle { get; set; }

        [JsonProperty("og:type")]
        public string Ogtype { get; set; }

        [JsonProperty("og:description")]
        public string Ogdescription { get; set; }

        [JsonProperty("og:determiner")]
        public string Ogdeterminer { get; set; }

        [JsonProperty("og:site_name")]
        public string Ogsitename { get; set; }

        [JsonProperty("og:image")]
        public string Ogimage { get; set; }

        [JsonProperty("og:image:secure_url")]
        public string Ogimagesecureurl { get; set; }

        [JsonProperty("og:image:type")]
        public string Ogimagetype { get; set; }

        [JsonProperty("og:image:width")]
        public string Ogimagewidth { get; set; }

        [JsonProperty("og:image:height")]
        public string Ogimageheight { get; set; }

        [JsonProperty("twitter:title")]
        public string Twittertitle { get; set; }

        [JsonProperty("twitter:description")]
        public string Twitterdescription { get; set; }

        [JsonProperty("twitter:image")]
        public string Twitterimage { get; set; }

        [JsonProperty("twitter:image:alt")]
        public string Twitterimagealt { get; set; }

        [JsonProperty("twitter:card")]
        public string Twittercard { get; set; }

        [JsonProperty("twitter:site")]
        public string Twittersite { get; set; }

        [JsonProperty("twitter:site:id")]
        public string Twittersiteid { get; set; }

        [JsonProperty("twitter:url")]
        public string Twitterurl { get; set; }

        [JsonProperty("twitter:account_id")]
        public string Twitteraccountid { get; set; }

        [JsonProperty("twitter:creator")]
        public string Twittercreator { get; set; }

        [JsonProperty("twitter:creator:id")]
        public string Twittercreatorid { get; set; }

        [JsonProperty("twitter:player")]
        public string Twitterplayer { get; set; }

        [JsonProperty("twitter:player:width")]
        public string Twitterplayerwidth { get; set; }

        [JsonProperty("twitter:player:height")]
        public string Twitterplayerheight { get; set; }

        [JsonProperty("twitter:player:stream")]
        public string Twitterplayerstream { get; set; }

        [JsonProperty("twitter:app:name:iphone")]
        public string Twitterappnameiphone { get; set; }

        [JsonProperty("twitter:app:id:iphone")]
        public string Twitterappidiphone { get; set; }

        [JsonProperty("twitter:app:url:iphone")]
        public string Twitterappurliphone { get; set; }

        [JsonProperty("twitter:app:name:ipad")]
        public string Twitterappnameipad { get; set; }

        [JsonProperty("twitter:app:id:ipad")]
        public string Twitterappidipad { get; set; }

        [JsonProperty("twitter:app:url:ipad")]
        public string Twitterappurlipad { get; set; }

        [JsonProperty("twitter:app:name:googleplay")]
        public string Twitterappnamegoogleplay { get; set; }

        [JsonProperty("twitter:app:id:googleplay")]
        public string Twitterappidgoogleplay { get; set; }

        [JsonProperty("twitter:app:url:googleplay")]
        public string Twitterappurlgoogleplay { get; set; }

        [JsonProperty("headings")]
        public Headings[] Headings { get; set; }

        [JsonProperty("imgTags")]
        public ImgTags[] ImgTags { get; set; }

        [JsonProperty("responseBody")]
        public string ResponseBody { get; set; }

        [JsonProperty("viewport")]
        public string Viewport { get; set; }

        [JsonProperty("X-UA-Compatible")]
        public string XUACompatible { get; set; }

        [JsonProperty("360-site-verification")]
        public string 360siteverification { get; set; }

        [JsonProperty("fb:app_id")]
        public string Fbappid { get; set; }

        [JsonProperty("msvalidate.01")]
        public string Msvalidate01 { get; set; }

        [JsonProperty("referrer")]
        public string Referrer { get; set; }

        [JsonProperty("y_key")]
        public string Ykey { get; set; }

        [JsonProperty("google-site-verification")]
        public string Googlesiteverification { get; set; }

        [JsonProperty("google-adsense-account")]
        public string Googleadsenseaccount { get; set; }

        [JsonProperty("yandex-verification")]
        public string Yandexverification { get; set; }

    }
    /// <summary>
    /// API Response object
    /// </summary>
    public class ResponseObj
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("error")]
        public object Error { get; set; }

        [JsonProperty("data")]
        public Data Data { get; set; }

    }
}
