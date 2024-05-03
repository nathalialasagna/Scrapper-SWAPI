namespace Scrapper_SWAPI.Extension;

public static class MyExtensions
{
    public static int GetIdFromUrl(this string url)
    {
        int id = Int32.Parse(url.TrimEnd('/').Split('/').Last());
        return id;
    }
}
