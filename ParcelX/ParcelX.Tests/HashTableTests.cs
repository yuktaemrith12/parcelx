
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PostalCW.DataStructures;  // Make sure this matches your namespace

namespace PostalCW.Tests
{
    [TestClass]
    public class HashTableTests
    {
        #region Add Tests
        [TestMethod]
        public void HashTable_AddItem_ShouldAddSuccessfully()
        {
            var hashTable = new CustomHashTable();
            string key = "TestUser";
            string value = "Name=John,Age=25";

            hashTable.Add(key, value);

            Assert.IsTrue(hashTable.ContainsKey(key), "Item should be added successfully to the hash table.");
        }
        #endregion

        #region Search Tests
        [TestMethod]
        public void HashTable_SearchItem_ShouldReturnCorrectValue()
        {
            var hashTable = new CustomHashTable();
            string key = "TestUser";
            string expectedValue = "Name=John,Age=25";

            hashTable.Add(key, expectedValue);
            var retrievedValue = hashTable.Search(key);

            Assert.AreEqual(expectedValue, retrievedValue, "Retrieved value should match the inserted value.");
        }
        #endregion

        #region Remove Tests
        [TestMethod]
        public void HashTable_RemoveItem_ShouldRemoveSuccessfully()
        {
            var hashTable = new CustomHashTable();
            string key = "TestUser";
            string value = "Name=John,Age=25";

            hashTable.Add(key, value);
            hashTable.Remove(key);
            bool exists = hashTable.ContainsKey(key);

            Assert.IsFalse(exists, "Item should be removed from the hash table.");
        }
        #endregion

        #region Contains Key Tests
        [TestMethod]
        public void HashTable_ContainsKey_ShouldReturnTrue()
        {
            var hashTable = new CustomHashTable();
            string key = "TestUser";
            string value = "Name=John,Age=25";

            hashTable.Add(key, value);
            bool exists = hashTable.ContainsKey(key);

            Assert.IsTrue(exists, "Hash table should confirm the key exists.");
        }
        #endregion
    }
}
