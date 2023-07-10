namespace CleanCodeRefactoringExercise.Refactor
{
    public class OrderProcessor
    {
        private const int ProcessableNumberOfLineItems = 15;

        public void Process(Order? order)
        {
            if(order != null)
            {
                if(order.IsVerified)
                {
                    if(order.Items.Count > 0)
                    {
                        if(order.Items.Count > 15)
                        {
                            throw new Exception("The order" + order.Id + "has too many items");
                        }

                        // if(order.Status != "ReadyToProcess")
                        // {
                        //     throw new Exception("The order" + order.Id + "isn't ready to process");
                        // }
                        order.IsProcessed = true;
                    }
                }
            }
        }

        public ProcessOrderResult RefactorProcess(Order? order)
        {
            //Early return principle
            if (!IsOrderProcessable(order))
                return ProcessOrderResult.NoProcessable();

            if (order!.Items.Count > ProcessableNumberOfLineItems)
                return ProcessOrderResult.HasTooManyLineItems(order.Id);

            if (order.Status != OrderStatus.ReadyToProcess)
                return ProcessOrderResult.NotReadyForProcessing(order.Id);
            
            order.IsProcessed = true;
            return ProcessOrderResult.Successfully(order.Id);
        }

        private static bool IsOrderProcessable(Order? order)
        {
            return order is not null && order.IsVerified && order.Items.Any();
        }
    }    
}