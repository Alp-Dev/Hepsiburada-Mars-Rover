using BusinessLogic.Services.Implementations;
using System;
using System.ComponentModel.DataAnnotations;
using Xunit;

namespace HepsiburadaMarsRover.Tests
{
    public class PrimeService_Execute
    {
        [Fact]
        public void Execute_ShouldArgumentNullException_WhenInputIsNull()
        {
            var marsRoverService = new MarsRoverService();
            string input = null;
            var result = Record.Exception(() => marsRoverService.Execute(input));
            Assert.IsType<ArgumentNullException>(result);

        }

        //inputParameters.Length < 3 || inputParameters.Length % 2 != 1

        [Theory, InlineData("ASD")]
        public void Execute_ShouldValidationException_WhenInputHasLessThanThreeLines(string input)
        {
            var marsRoverService = new MarsRoverService();
            var result = Record.Exception(() => marsRoverService.Execute(input));
            Assert.IsType<ValidationException>(result);
        }

        [Fact]
        public void Execute_ShouldValidationException_WhenBothPlateauParametersAreEqualToZero()
        {
            var marsRoverService = new MarsRoverService();

            var input = @"0 0
1 2 N
LMLMLMLMM";
            var result = Record.Exception(() => marsRoverService.Execute(input));

            var exception = Assert.IsType<ValidationException>(result);

            var actualMessage = exception.Message;
            const string expectedMessage = "Plateau dimensions must be >=0 and both dimensions cannot be 0 at the same time";

            Assert.Equal(expectedMessage, actualMessage);
        }
    }
}
