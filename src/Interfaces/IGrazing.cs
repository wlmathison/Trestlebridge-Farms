namespace Trestlebridge.Interfaces
{
    public interface IGrazing
    {
        double FeedPerDay { get; set; }
        string Type { get; }
        void Graze();

    }
}