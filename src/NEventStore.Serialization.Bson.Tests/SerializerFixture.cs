﻿// ReSharper disable CheckNamespace
namespace NEventStore.Serialization.AcceptanceTests
// ReSharper restore CheckNamespace
{
    using NEventStore.Serialization.Bson;

    public partial class SerializerFixture
    {
        public SerializerFixture()
        {
            _createSerializer = () =>
                new BsonSerializer();
        }
    }
}