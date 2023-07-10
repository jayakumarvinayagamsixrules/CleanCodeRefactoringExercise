
namespace CleanCodeRefactoringExercise.Refactor
{
    public sealed class ToManyLineItemsException : Exception
    {
        public long OrderId{ get; }

        public ToManyLineItemsException(long orderId)
            : base($"The order {orderId} has to many items")
        {   
            OrderId = orderId;
        }
    }
}
