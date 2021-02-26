namespace BusinessLogic.Builders
{
    public interface IBuilder<in TInput, out TOutput>
    {
        public TOutput Build(TInput input);
    }
}
