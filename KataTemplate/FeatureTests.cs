using NFluent;
using NUnit.Framework;

namespace KataTemplate
{
    public class FeatureTests
    {
        [Test]
        public void Should_be_true()
        {
            Check.That(false).IsTrue();
        }
    }
}