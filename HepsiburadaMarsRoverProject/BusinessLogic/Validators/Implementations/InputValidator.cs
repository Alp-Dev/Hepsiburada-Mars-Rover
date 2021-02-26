namespace BusinessLogic.Validators.Implementations
{
    public class InputValidator : BaseValidator<string>
    {
        public override bool Validate(string input, out string exceptionMessage)
        {
            if (string.IsNullOrEmpty(input))
            {
                exceptionMessage = "Input cannot be empty";
                return false;
            }
            exceptionMessage = "";
            return true;
        }
    }
}
