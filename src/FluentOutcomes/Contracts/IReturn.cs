namespace FluentOutcomes.Contracts
{
    public interface IReturn
    {
        IOutcome Return();
    }

    public interface IReturn<T>
    {
        IOutcome<T> Return(T value);
    }
}
