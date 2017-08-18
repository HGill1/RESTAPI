using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RESTAPITest.JsonClasses
{
    class OnePensionResponse
    {

        public class Rootobject
        {
            public string id { get; set; }
            public Session session { get; set; }
            public string outputSpeech { get; set; }
            public object[] reprompts { get; set; }
            public bool shouldEndSession { get; set; }
            public Context context { get; set; }
            public object card { get; set; }
        }

        public class Session
        {
            public string id { get; set; }
            public bool isNew { get; set; }
        }

        public class Context
        {
            public Attributes attributes { get; set; }
        }

        public class Attributes
        {
        }
    }
}
