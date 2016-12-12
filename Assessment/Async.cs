using System.IO;
using System.Net;
using System.Threading.Tasks;
using Assessment.Models;
using Newtonsoft.Json;

public class Async
{
  public async Task<string> GetRemoteDataAsStringAsynchronously(string url)
  {
        var req = WebRequest.Create(url);
        var response = await req.GetResponseAsync();
        using (var reader = new StreamReader(response.GetResponseStream()))
        {
            var responseString = reader.ReadToEnd();
            return responseString;
        }
    }

    public async Task<Post> GetRemoteDataAsPostObjectAsynchronously(string url)
    {
        var req = WebRequest.Create(url);
        var response = await req.GetResponseAsync();
        using (var reader = new StreamReader(response.GetResponseStream()))
        {
            var responseString = reader.ReadToEnd();
            var postSeven = JsonConvert.DeserializeObject<Post>(responseString);
            return postSeven;
        }
    }
}