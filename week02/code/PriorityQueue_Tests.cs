using Microsoft.VisualStudio.TestTools.UnitTesting;

// TODO Problem 2 - Write and run test cases and fix the code to match requirements.

[TestClass]
public class PriorityQueueTests
{
    [TestMethod]
    // Scenario: Add three items with different priorities and dequeue them
    // Expected Result: Items come out from highest to lowest priority
    // Defect(s) Found: 
    public void TestPriorityQueue_1()
    {
        var pq = new PriorityQueue();
        pq.Enqueue("Low", 1);
        pq.Enqueue("High", 5);
        pq.Enqueue("Medium", 3);

        Assert.AreEqual("High", pq.Dequeue());
        Assert.AreEqual("Medium", pq.Dequeue());
        Assert.AreEqual("Low", pq.Dequeue());
    }

    [TestMethod]
    // Scenario: Add multiple items with same priority and check FIFO for equal priority
    // Expected Result: Items with same priority come out in the order they were added
    // Defect(s) Found: 
    public void TestPriorityQueue_2()
    {
        var pq = new PriorityQueue();
        pq.Enqueue("First", 2);
        pq.Enqueue("Second", 2);
        pq.Enqueue("Third", 2);

        Assert.AreEqual("First", pq.Dequeue());
        Assert.AreEqual("Second", pq.Dequeue());
        Assert.AreEqual("Third", pq.Dequeue());
    }

    [TestMethod]
    // Scenario: Dequeue from empty queue
    // Expected Result: Exception thrown
    // Defect(s) Found: 
    public void TestPriorityQueue_Empty()
    {
        var pq = new PriorityQueue();

        try
        {
            pq.Dequeue();
            Assert.Fail("Exception should have been thrown.");
        }
        catch (InvalidOperationException ex)
        {
            Assert.AreEqual("The queue is empty.", ex.Message);
        }
    }

    [TestMethod]
    // Scenario: Add items with mixed priorities and same priorities
    // Expected Result: Highest priority first, FIFO for ties
    // Defect(s) Found: 
    public void TestPriorityQueue_Mixed()
    {
        var pq = new PriorityQueue();
        pq.Enqueue("A", 3);
        pq.Enqueue("B", 5);
        pq.Enqueue("C", 5);
        pq.Enqueue("D", 1);

        Assert.AreEqual("B", pq.Dequeue());
        Assert.AreEqual("C", pq.Dequeue());
        Assert.AreEqual("A", pq.Dequeue());
        Assert.AreEqual("D", pq.Dequeue());
    }
}
