namespace BusinessLogic.Validators
{
    public abstract class BaseValidator<TInput>
    {
        public abstract bool Validate(TInput input, out string exceptionMessage);
    }
}
