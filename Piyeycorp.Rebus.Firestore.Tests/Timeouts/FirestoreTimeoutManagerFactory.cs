using Google.Cloud.Firestore;

namespace Rebus.Firestore.Tests.Timeouts;

//public class FirestoreTimeoutManagerFactory
//{
//    readonly FirestoreDb db;
//    readonly string _collectionName = $"Timeouts";
//    readonly FakeRebusTime _fakeRebusTime = new FakeRebusTime();

//    public MongoDbTimeoutManagerFactory()
//    {
//        _mongoDatabase = MongoTestHelper.GetMongoDatabase();
//        DropCollection(_collectionName);
//    }

//    public ITimeoutManager Create()
//    {
//        return new MongoDbTimeoutManager(_fakeRebusTime, _mongoDatabase, _collectionName, new ConsoleLoggerFactory(false));
//    }

//    public void Cleanup()
//    {
//        DropCollection(_collectionName);
//    }

//    public string GetDebugInfo()
//    {
//        var docStrings = _mongoDatabase
//            .GetCollection<BsonDocument>(_collectionName)
//            .FindAsync(d => true)
//            .Result
//            .ToListAsync()
//            .Result
//            .Select(FormatDocument);

//        return string.Join(Environment.NewLine, docStrings);
//    }

//    public void FakeIt(DateTimeOffset fakeTime)
//    {
//        _fakeRebusTime.SetTime(fakeTime);
//    }

//    static string FormatDocument(BsonDocument document)
//    {
//        return document.ToString();
//    }

//    void DropCollection(string collectionName)
//    {
//        _mongoDatabase.DropCollectionAsync(collectionName).Wait();
//    }
//}