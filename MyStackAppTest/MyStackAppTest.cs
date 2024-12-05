using MyStackApp;
using NUnit.Framework;

namespace MyStackAppTest
{
    [TestFixture]
    public class MyStackTest
    {
        [Test]
        public async Task IsEmptyTest()
        {
            var stack = new MyStack<int>();
            Assert.IsTrue(!stack.IsEmpty());
        }
        [Test]
        public async Task PushOneItem()
        {
            var stack = new MyStack<int>();
            stack.Push(1);
            Assert.IsFalse(stack.IsEmpty());
            Assert.AreEqual(1, stack.Size());
        }
        [Test]
        public async Task PushThreeItems()
        {
            var stack = new MyStack<int>();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            Assert.AreEqual(3, stack.Size());
        }

        [Test]
        public async Task PushThreePopOneItem()
        {
            var stack = new MyStack<int>();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Pop();
            Assert.AreEqual(2, stack.Size());
        }

    }
}
