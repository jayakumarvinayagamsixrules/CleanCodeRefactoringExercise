
namespace CleanCodeRefactoringExercise.Refactor
{
    public sealed class OrderNotReadyForProcessingException : Exception
    {
        public long OrderId{ get; }
        
        public OrderNotReadyForProcessingException(long orderId) 
            : base($"The order {orderId} isn't ready to process")
        {
            OrderId = orderId;
        }
        
    }
}
