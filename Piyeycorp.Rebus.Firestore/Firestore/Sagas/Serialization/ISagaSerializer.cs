using System;
using Rebus.Sagas;

namespace Rebus.Firestore.Sagas.Serialization
{
    public interface ISagaSerializer
    {
        string SerializeToString(ISagaData obj);
        ISagaData DeserializeFromString(Type type, string str);
    }
}
