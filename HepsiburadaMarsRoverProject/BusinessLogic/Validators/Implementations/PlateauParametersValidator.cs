namespace BusinessLogic.Validators.Implementations
{
    public class PlateauParametersValidator : BaseValidator<string>
    {
        public override bool Validate(string plateauParameters, out string exceptionMessage)
        {
            if (string.IsNullOrWhiteSpace(plateauParameters) || plateauParameters.Length != 3)
            {
                exceptionMessage = "Plateau parameters must consist of exactly 3 characters";
                return false;
            }
            // TODO Regex
            if (!int.TryParse(plateauParameters[0].ToString(), out int xDimension) || !int.TryParse(plateauParameters[2].ToString(), out int yDimension) || plateauParameters[1] != ' ')
            {
                exceptionMessage = "Plateau parameters must be exactly in this format 'Number Number'";
                return false;
            }
            if (xDimension < 0 || yDimension < 0 || (xDimension == 0 && yDimension == 0))
            {
                exceptionMessage = "Plateau dimensions must be >=0 and both dimensions cannot be 0 at the same time";
                return false;
            }
            exceptionMessage = "";
            return true;
        }
    }
}
