using System;
using System.Globalization;
using System.Net;
using System.Web.Http;

namespace SymtechProgrammingQuestion.Controllers
{
    public class DateController : ApiController
    {
        public DateTime Get()
        {
            var random = new Random();
            return new DateTime(2000, 1, 1)
                .AddYears(random.Next(20))
                .AddMonths(random.Next(12))
                .AddHours(random.Next(24))
                .AddMinutes(random.Next(60))
                .AddSeconds(random.Next(60));
        }

        public void Post([FromBody]string value)
        {
            if (!DateTime.TryParseExact(value, "yyyy-MM-dd HH:mm:ss", CultureInfo.CurrentCulture, DateTimeStyles.AssumeUniversal, out var _))
                throw new HttpResponseException(HttpStatusCode.BadRequest);

        }
    }
}
