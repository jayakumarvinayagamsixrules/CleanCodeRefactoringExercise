
namespace CleanCodeRefactoringExercise.Refactor
{
    public record ProcessOrderResult
    {
        private ProcessOrderResult(long orderId, string message)
        {
            OrderId = orderId;
            Message = message;
        }
        
        public long OrderId { get; init; }
        
        public string Message { get; init; }
        
        public static ProcessOrderResult NoProcessable() 
            => new (default, $"The order is not processable");
        
        public static ProcessOrderResult NotReadyForProcessing(long orderId)
            => new (orderId, $"The order {orderId} is not processable");
        
        public static ProcessOrderResult HasTooManyLineItems(long orderId)
            => new (orderId, $"The order {orderId} has to many items");
        
        public static ProcessOrderResult Successfully(long orderId)
            => new(orderId, $"The order {orderId} was successfully processed");
    }
}