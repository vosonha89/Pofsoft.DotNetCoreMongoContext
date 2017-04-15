using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;

namespace Pofsoft.DotNetCoreMongoContext
{
    /// <summary>
    /// Entity, the other class will inheritance to use MongoContext
    /// </summary>
    public abstract class Entity
    {
        /// <summary>
        /// _id key
        /// </summary>
        public ObjectId _id { get; set; }

        /// <summary>
        /// Constructor, _id will generate here
        /// </summary>
        public Entity()
        {
            _id = ObjectId.GenerateNewId();
        }
    }
}
