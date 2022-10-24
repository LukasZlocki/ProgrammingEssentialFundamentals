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
        ProductId = productId;
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
}
