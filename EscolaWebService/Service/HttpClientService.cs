namespace EscolaWebService.Repository;

public class HttpClientService
{
    private static readonly Lazy<HttpClientService>
        lazy = new Lazy<HttpClientService>(() => new HttpClientService());
    
    private HttpClient _httpClient;
    private string _baseUrl = "http://localhost:3000/";
    
    public static HttpClientService Instance
    {
        get { return lazy.Value; }
    }

    private HttpClientService()
    {
        _httpClient = new HttpClient();
    }
    
    public async Task<string> RetrieveData(string url)
    {
        HttpResponseMessage response = await _httpClient.GetAsync(_baseUrl + url);
        response.EnsureSuccessStatusCode();
        string responseBody = await response.Content.ReadAsStringAsync();
        return responseBody;
    }
}