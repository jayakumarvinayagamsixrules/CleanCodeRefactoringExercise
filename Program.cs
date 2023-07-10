// See https://aka.ms/new-console-template for more information
using CleanCodeRefactoringExercise.Refactor;

Order order = new Order(){
    Id = 1002323,
    IsProcessed = false,
    IsVerified = true,
    Items = new List<LineItem>(){
        new LineItem(){},
        new LineItem(){},
        new LineItem(){},
        new LineItem(){},
        new LineItem(){},
        new LineItem(){},
        new LineItem(){},
        new LineItem(){},
        new LineItem(){},
        new LineItem(){},
        new LineItem(){},
        new LineItem(){},
        new LineItem(){},
        new LineItem(){},
        
    },
    Status = OrderStatus.ReadyToProcess
};


OrderProcessor orderProcessor = new OrderProcessor();
Order? orderNull = null;
System.Console.WriteLine(orderProcessor.RefactorProcess(orderNull));

System.Console.WriteLine(orderProcessor.RefactorProcess(order));


