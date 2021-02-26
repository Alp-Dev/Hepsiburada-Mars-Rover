namespace BusinessLogic.Validators.Implementations
{
    public class InputParametersValidator : BaseValidator<string[]>
    {
        public override bool Validate(string[] inputParameters, out string exceptionMessage)
        {
            if (inputParameters.Length < 3 || inputParameters.Length % 2 != 1)
            {
                exceptionMessage = "At least one pleatue and one rover information must be provided";
                return false;
            }
            exceptionMessage = "";
            return true;
        }
    }
}
