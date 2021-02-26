using BusinessLogic.Builders.Implementations;
using BusinessLogic.Validators.Implementations;
using DataModel.Enums;
using DataModel.Extensions;
using DataModel.Models;
using DataModel.Models.Implementations;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BusinessLogic.Services.Implementations
{
    public class MarsRoverService : IMarsRoverService
    {
        public string Execute(string input)
        {
            var inputValidator = new InputValidator();
            if (!inputValidator.Validate(input, out string exceptionMessage))
            {
                throw new ArgumentNullException(paramName: "input", message: exceptionMessage);
            }
            string[] inputParameters = input.Split(Environment.NewLine);

            var inputParametersValidator = new InputParametersValidator();
            if (!inputParametersValidator.Validate(inputParameters, out exceptionMessage))
            {
                throw new ValidationException(message: exceptionMessage);
            }

            var plateauParameters = inputParameters[0];


            var plateauParametersValidator = new PlateauParametersValidator();
            if (!plateauParametersValidator.Validate(plateauParameters, out exceptionMessage))
            {
                throw new ValidationException(message: exceptionMessage);
            }

            ITwoDimensionalPoint plateauBuilderInput = new TwoDimensionalPoint(new Point(int.Parse(plateauParameters[0].ToString())), new Point(int.Parse(plateauParameters[2].ToString())));

            var plateauBuilder = new PlateauBuilder();

            IRectangle plateau = plateauBuilder.Build(plateauBuilderInput);

            var lengthOfRoverParameters = inputParameters.Length - 1;
            var roverParameters = new string[lengthOfRoverParameters];
            Array.Copy(inputParameters, 1, roverParameters, 0, lengthOfRoverParameters);

            //TODO - RoverParametersValidatior
            List<IRover> rovers = new List<IRover>();

            for (int i = 0; i < lengthOfRoverParameters; i += 2)
            {
                string roverDefinitions = roverParameters[i];
                //TODO - RoverDefinitionsValidator, compare with Plateau Dimensions
                var rover = new Rover(new Point(int.Parse(roverDefinitions[0].ToString())), new Point(int.Parse(roverDefinitions[2].ToString())), (CardinalDirectionEnumeration)Enum.Parse(typeof(CardinalDirectionEnumeration), roverDefinitions[4].ToString()));
                string roverCommands = roverParameters[i + 1];
                //TODO - RoverCommands Validator, compare with Plateau Dimensions
                foreach (var roverCommand in roverCommands)
                {
                    var roverCommandAsString = roverCommand.ToString();
                    switch (roverCommandAsString)
                    {
                        case "L":
                            rover.Turn(DirectionEnumeration.L);
                            break;
                        case "R":
                            rover.Turn(DirectionEnumeration.R);
                            break;
                        case "M":
                            rover.Move();
                            break;
                        default:
                            break;
                    }
                }

                rovers.Add(rover);
            }

            return rovers.FormatRoversInformationAsString();
        }
    }
}
