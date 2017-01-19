using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace MongoDbConnector
{
    public abstract class MongoEntity
    {
        public Oid Id { get;  set; }
    }
}
