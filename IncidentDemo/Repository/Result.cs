namespace IncidentDemo.Repository
{
    public class Result
    {
        public static IResult<TOutput> Success<TOutput>(TOutput output, string message)
            => new ResultObject<TOutput>
            {
                Output = output,
                Success = true,
                SystemMessage = message,
                UserMessage = message
            };

        private class ResultObject<TOutput>
        : IResult<TOutput>
        {
            public TOutput Output { get; set; }

            public bool Success { get; set; }

            public string UserMessage { get; set; }

            public string SystemMessage { get; set; }
        }
    }
    
}