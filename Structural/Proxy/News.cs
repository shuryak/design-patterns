namespace DesignPatterns.Structural.Proxy
{
    public class News
    {
        public News(int id, string title)
        {
            Id = id;
            Title = title;
        }
        
        public int Id { get; private set; }
        public string Title { get; private set; }
    }
}
