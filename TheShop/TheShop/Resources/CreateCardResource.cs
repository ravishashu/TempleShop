namespace TheShop.Resources
{
    public record CreateCardResource(
     string Name,
     string Number,
     string ExpiryYear,
     string ExpiryMonth,
     string Cvc);
    public record CreateCustomerResource(
    string Email,
    string Name,
    CreateCardResource Card);

    public record CreateChargeResource(
    string Currency,
    long Amount,
    string CustomerId,
    string ReceiptEmail,
    string Description);
    public record ChargeResource(
    string ChargeId,
    string Currency,
    long Amount,
    string CustomerId,
    string ReceiptEmail,
    string Description);
}
