// Section: 37 "DRY principles"


// Example #2:

var order1 = new Order("cust1", "prod1");
var order2 = new Order("", "prod1");

Commit.Validate(order2.CustomerId, nameof(order2.CustomerId));
Commit.Validate(order2.CustomerId, nameof(order2.CustomerId));

class Order
{
    public string? CustomerId { get; set; }
    public string? ProductId { get; set; }
    public Order(string customerId, string productId)
    {
        CustomerId = customerId;
        ProductId = ProductId;
    }
}
static class Commit
{
    // Solution:
    public static void Validate(string idToBeValidated, string propertyName)
    {
        if (string.IsNullOrEmpty(idToBeValidated))
        {
            throw new Exception($"The {propertyName} must not be empty");
        };
    }

    /* // duplicate function of methods DRY(!)
    public void CommitOrder(Order order){
        if (string.IsNullOrEmpty(order.CustomerId)){
            throw new Exception($"The CustomerId must not be empty");
        }
        if (string.IsNullOrEmpty(order.ProductId)){
            throw new Exception($"The ProductId must not be empty");
        }  
    }
    */
}

// Example #1:
class OnlineStore 
{
    public const int DaysForReturn = 30;

public DateTime ReturnDateDeadline(DateTime purchaseDate)
{
    // return purchaseDate.AddDays(30); // <<- 1st place were we define 30 days
    return purchaseDate.AddDays(DaysForReturn); 
}

public bool IsAfterPossibleReturnDate(DateTime purchaseDate){
    // return (DateTime.Now - purchaseDate).TotalDays > 30; // <<- 2nd place were we define 30 days
    return (DateTime.Now - purchaseDate).TotalDays > DaysForReturn;
}

}
