using Collections;
using NUnit.Framework;


namespace Collection
{
    public class Tests
    {
        
        [Test]
        public void Test1()
        {
            var nums = new Collection<int>(); 

            Assert.That(nums.ToString(), Is.EqualTo("[]"));
        }
    }

 }