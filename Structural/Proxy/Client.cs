using System;

namespace DesignPatterns.Structural.Proxy
{
    public class Client
    {
        public void Main()
        {
            BreakingNewsDeliver newsDeliver = new BreakingNewsDeliver();
            BreakingNewsDeliverProxy newsDeliverProxy = new BreakingNewsDeliverProxy(newsDeliver);

            NewsFeed newsFeed = new NewsFeed(newsDeliverProxy);
            
            newsFeed.UpdateFeed();
            
            Console.WriteLine(newsFeed.GetLastNewsTitle());
            Console.WriteLine(newsFeed.GetFeedContent());
        }
    }
}
