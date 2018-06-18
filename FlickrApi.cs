using FlickrNet;
using System;

namespace JapaneseApp
{
    class FlickrApi
    {
        public string lastSearchString;
        Flickr flickr;
        PhotoSearchOptions options;

        public FlickrApi()
        {
            flickr = new Flickr();
            string apiKey = "74d4be226df9b29fc02d6fc089cd2349";
            string secretKey = "NotActuallyMySecretKey";

            flickr.ApiKey = apiKey;
            flickr.ApiSecret = secretKey;

            //setting up search options
            options = new PhotoSearchOptions { PerPage = 1, Page = 1 };
            options.Extras = PhotoSearchExtras.AllUrls;
            options.SortOrder = PhotoSearchSortOrder.Relevance;
            options.SafeSearch = SafetyLevel.Safe;
        }

        public string Search(string searchTags, string imageSize)
        {
            lastSearchString = searchTags;
            options.Tags = searchTags;

            PhotoCollection photos;
            try
            {
                photos = flickr.PhotosSearch(options);
            }
            catch(Exception)//the api messed up
            {
                return "noImage";
            }

            if (photos.Count == 0) return "noImage";
    
            switch (imageSize)
            {
                case "thumbnailRadioButton": return photos[0].ThumbnailUrl;
                case "smallRadioButton":  return photos[0].SmallUrl;
                case "mediumRadioButton": return photos[0].MediumUrl;
                default: throw new ArgumentException();
            }
        }
    }
}
