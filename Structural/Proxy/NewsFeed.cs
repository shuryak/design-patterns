using System;

namespace DesignPatterns.Structural.Proxy
{
    public class NewsFeed
    {
        private readonly INewsDeliver _service;
        private string _feedContent = "";

        public NewsFeed(INewsDeliver service)
        {
            _service = service;
        }

        public void UpdateFeed()
        {
            int i = 0;
            
            foreach (News news in _service.GetLastNewsTitles())
            {
                _feedContent += $"{++i}. {news.Title}\n";
            }

            _feedContent = _feedContent.Remove(_feedContent.Length - 1);
        }

        public string GetFeedContent()
        {
            return _feedContent;
        }
        
        public string GetLastNewsTitle()
        {
            return _service.GetNewsTitleById(_service.GetNewsCount()).Title;
        }
    }
}
