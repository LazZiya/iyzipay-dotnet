﻿using Newtonsoft.Json;
﻿using System.Diagnostics;
using Newtonsoft.Json.Serialization;
using NUnit.Framework;

namespace Iyzipay.Samples
{
    public class Sample
    {
        protected Options options;

        [SetUp]
        public void Initialize()
        {
            options = new Options();
            options.ApiKey = "your api key";
            options.SecretKey = "your secret key";
            options.BaseUrl = "https://sandbox-api.iyzipay.com";
        }

        protected void PrintResponse<T>(T resource)
        {
#if NETCORE1 || NETCORE2
            TraceListener consoleListener = new TextWriterTraceListener(System.Console.Out);
#else
            TraceListener consoleListener = new ConsoleTraceListener();
#endif

            Trace.Listeners.Add(consoleListener);
            Trace.WriteLine(JsonConvert.SerializeObject(resource, new JsonSerializerSettings()
            {
                Formatting = Formatting.Indented,
                ContractResolver = new CamelCasePropertyNamesContractResolver()
            }));
        }
    }
}
