using System.Collections.Generic;

namespace DesignPatterns.Structural.Proxy
{
    public interface INewsDeliver
    {
        public List<News> GetLastNewsTitles();
        public News GetNewsTitleById(int id);
        public int GetNewsCount();
    }
}
