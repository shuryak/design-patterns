using System;

namespace DesignPatterns.Structural.Proxy
{
    public class Client
    {
        /*
         * Pattern Proxy is a wrapper object that is being called by the client to access the real serving object
         * behind the scenes
         *
         * Proxy object controls access to the real object
         */
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
