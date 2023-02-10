using System;
using Google.Cloud.Firestore;

namespace Rebus.Config.Converters
{
    public class FirestoreGuidConverter : IFirestoreConverter<Guid>
    {
        public object ToFirestore(Guid value) => value.ToString("N");

        public Guid FromFirestore(object value)
        {
            switch (value)
            {
                case string guid: return Guid.ParseExact(guid, "N");
                case null: throw new ArgumentNullException(nameof(value));
                default: throw new ArgumentException($"Unexpected data: {value.GetType()}");
            }
        }
    }
}
