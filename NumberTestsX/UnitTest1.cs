namespace NumberTestsX
{
    public class NumbersTests
    {
        [Fact]
        public void NumbersTests_Add()
        {
            //Arranage

            NumberOperations.BasicOperations basicOperations = new NumberOperations.BasicOperations();

            //Act

            int result = basicOperations.AddNumber(2, 4);

            // Assert

            Assert.Equal(6, result);
        }

        [Theory]
        [InlineData(2, 4, 6)]
        [InlineData(12, 14, 26)]
        [InlineData(1, 1, 2)]
        public void NumbersTests_Add_Theory(int number1, int number2, int expacted)
        {
            //Arrange

            NumberOperations.BasicOperations basicOperations = new NumberOperations.BasicOperations();

            //Act

            int result = basicOperations.AddNumber(number1, number2);
            //Assert

            Assert.Equal(expacted, result);

        }

    } // end of class
}