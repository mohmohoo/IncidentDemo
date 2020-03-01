namespace IncidentDemo.Repository
{
    public interface IResult<TOutput>
    {
        TOutput Output { get; }

        bool Success { get; }

        string UserMessage { get; }

        string SystemMessage { get; }
    }
}