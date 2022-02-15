using katas_csharp._02KarateChop;
using Shouldly;
using System;
using Xunit;

namespace katas_csharp.Tests._02KarateChop
{
    public class ChopTests
    {
        private readonly Chop _sut;

        public ChopTests()
        {
            _sut = new();
        }

        [Fact]
        public void ShouldReturnMinus1IfTheArrayIsEmpty()
        {
            var target = 10;
            var sortedArray = Array.Empty<int>();
            var result = _sut.Run(target, sortedArray);

            result.ShouldBe(-1);
        }

        [Fact]
        public void ShouldReturnMinus1IfIsNotInTheArray()
        {
            var target = 10;
            var sortedArray = new int[] { 5 };
            var result = _sut.Run(target, sortedArray);

            result.ShouldBe(-1);
        }

        [Fact]
        public void ShouldReturnTheNumberIfArrayHasJustOne()
        {
            var target = 1;
            var sortedArray = new int[] { 1 };
            var result = _sut.Run(target, sortedArray);

            result.ShouldBe(1);
        }
    }
}
