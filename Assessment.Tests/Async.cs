using System;
using System.IO;
using System.Net;
using System.Runtime.InteropServices.ComTypes;
using System.Threading.Tasks;
using Assessment.Models;
using Newtonsoft.Json;
using Xunit;

namespace Assessment.Tests
{
    public class AsyncTests
    {
        [Fact]
        // This method should reach out to https://jsonplaceholder.typicode.com/posts/6, asynchronously retrieve the contents there, and return the result as a string
        public async void Should_Retrive_JSON_Object_As_String_Asynchronously()
        {
            var async = new Async();
            var result = await async.GetRemoteDataAsStringAsynchronously("https://jsonplaceholder.typicode.com/posts/6");

            var expectedResultObject = new Post()
            {
                id = 6,
                userId = 1,
                title = "dolorem eum magni eos aperiam quia",
                body = "ut aspernatur corporis harum nihil quis provident sequi\nmollitia nobis aliquid molestiae\nperspiciatis et ea nemo ab reprehenderit accusantium quas\nvoluptate dolores velit et doloremque molestiae"
            };
            var expectedResult = JsonConvert.SerializeObject(expectedResultObject, Formatting.Indented).Replace(Environment.NewLine, "\n");
            Assert.Equal(expectedResult, result);
        }

        [Fact]
        // This method should reach out to https://jsonplaceholder.typicode.com/posts/7, asynchronously retrieve the contents there, and return the typed result
        public async void Should_Retrive_JSON_Object_As_Post_Type_Asynchronously()
        {
            var async = new Async();
            var result = await async.GetRemoteDataAsPostObjectAsynchronously("https://jsonplaceholder.typicode.com/posts/6");
            var expectedResult = new Post()
            {
                id = 6,
                userId = 1,
                title = "dolorem eum magni eos aperiam quia",
                body = "ut aspernatur corporis harum nihil quis provident sequi\nmollitia nobis aliquid molestiae\nperspiciatis et ea nemo ab reprehenderit accusantium quas\nvoluptate dolores velit et doloremque molestiae"
            };

            Assert.Equal(expectedResult, result);
        }
    }
}
