using System.Collections.Generic;

namespace DesignPatterns.Structural.Proxy
{
    public class BreakingNewsDeliverProxy : INewsDeliver
    {
        private readonly BreakingNewsDeliver _service;

        public BreakingNewsDeliverProxy(BreakingNewsDeliver service)
        {
            _service = service;
        }

        public List<News> GetLastNewsTitles()
        {
            List<News> cachedNews = PseudoCache.GetAll();
            if (cachedNews.Count > 0)
                return cachedNews;

            List<News> news = _service.GetLastNewsTitles();
            PseudoCache.AddList(news);
            return news;
        }

        public News GetNewsTitleById(int id)
        {
            News cachedNews = PseudoCache.GetById(id);
            if (cachedNews != null)
                return cachedNews;

            News news = _service.GetNewsTitleById(id);
            PseudoCache.Add(news);
            return news;
        }

        public int GetNewsCount()
        {
            return _service.GetNewsCount();
        }
    }
}
