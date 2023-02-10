using Rebus.Tests.Contracts.Sagas;

namespace Rebus.Firestore.Tests.Sagas;

[TestFixture, Category(FirestoreTestHelper.TestCategory)]
public class FirestoreBasicLoadAndSaveAndFindOperations : BasicLoadAndSaveAndFindOperations<FirestoreSagaStorageFactory> { }