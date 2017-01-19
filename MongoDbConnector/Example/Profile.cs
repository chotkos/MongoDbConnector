using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDbConnector;

namespace Example
{
    public class Profile:MongoEntity
    {
        public int Age { get; set; }
        public string Name { get; set; }

        public override string ToString()
        {
            return String.Format("{0}({1})", Name, Age);
        }
    }
}
