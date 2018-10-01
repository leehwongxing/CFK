using Jil;
using Microsoft.AspNetCore.Mvc.Formatters;
using Microsoft.Net.Http.Headers;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace CFK_API.Compute
{
    public class Output : OutputFormatter
    {
        public Output()
        {
            SupportedMediaTypes.Add(MediaTypeHeaderValue.Parse("application/json"));
        }

        public override Task WriteResponseBodyAsync(OutputFormatterWriteContext context)
        {
            var response = context.HttpContext.Response;

            using (var Writer = new StreamWriter(response.Body, Encoding.UTF8, 10240))
            {
                Writer.WriteAsync(JSON.Serialize(context.Object, Options.ISO8601IncludeInherited)); /// REF: Nancy's Jil Serializer
            }

            return Task.FromResult(response);
        }
    }
}