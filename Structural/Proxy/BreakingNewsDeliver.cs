using System.Collections.Generic;

namespace DesignPatterns.Structural.Proxy
{
    public class BreakingNewsDeliver : INewsDeliver
    {
        private List<News> _news => new List<News>
        {
            new News(1, "First"),
            new News(2, "Second"),
            new News(3, "Third")
        };

        public List<News> GetLastNewsTitles()
        {
            return _news;
        }

        public News GetNewsTitleById(int id)
        {
            if (id >= _news.Count)
                return null;
            return _news[id];
        }

        public int GetNewsCount()
        {
            return _news.Count;
        }
    }
}
