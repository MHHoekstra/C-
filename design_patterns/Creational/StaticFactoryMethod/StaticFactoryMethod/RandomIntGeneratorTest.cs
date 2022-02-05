using Xunit;

namespace StaticFactoryMethod;

[Trait("Category", "Unit")]
public class RandomIntGeneratorTests
{
    [Trait("Category", "RandomIntGenerator.Between")]
    public class Between
    {
        [Fact(DisplayName = "should create a valid RandomIntGenerator")]
        public void ShouldCreateValidRandomIntGeneratorBetween()
        {
            var generator = RandomIntGenerator.Between(10, 20);
            Assert.Equal(10, generator.Min);
            Assert.Equal(20, generator.Max);
        }
    }
    
    [Trait("Category", "RandomIntGenerator.GreaterThan")]
    public class GreaterThan
    {
        [Fact(DisplayName = "should create a valid RandomIntGenerator")]
        public void GreaterThanShouldCreateValidRandomIntGenerator()
        {
            var generator = RandomIntGenerator.GreaterThan(10);
            Assert.Equal(10, generator.Min);
            Assert.Equal(int.MaxValue, generator.Max);
        }
    }

    public class SmallerThan
    {
        [Fact(DisplayName = "should create a valid RandomIntGenerator")]
        public void GreaterThanShouldCreateValidRandomIntGenerator()
        {
            var generator = RandomIntGenerator.SmallerThan(30);
            Assert.Equal(int.MinValue, generator.Min);
            Assert.Equal(30, generator.Max);
        }
    }

}