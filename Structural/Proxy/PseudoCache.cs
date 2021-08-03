using System;
using System.Collections.Generic;

namespace DesignPatterns.Structural.Proxy
{
    public static class PseudoCache
    {
        private static readonly List<Tuple<int, News>> _storage = new List<Tuple<int, News>>();
        
        public static void Add(News data)
        {
            _storage.Add(new Tuple<int, News>(data.Id, data));
        }
        
        public static void AddList(IEnumerable<News> data)
        {
            foreach (News news in data)
            {
                _storage.Add(new Tuple<int, News>(news.Id, news));   
            }
        }

        public static News GetById(int id)
        {
            return _storage.Find(p => p.Item1 == id)?.Item2;
        }

        public static List<News> GetAll()
        {
            List<News> newsList = new List<News>();
            
            _storage.ForEach(p => newsList.Add(p.Item2));

            return newsList;
        }
    }
}
