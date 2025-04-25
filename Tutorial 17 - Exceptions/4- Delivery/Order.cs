class Order
{
    public int id { get; set; }
    public string CustomerName { get; set; }
    public string Address { get; set; }
    public DeliveryStatus status { get; set; }

    public override string ToString()
    {
        return $"{{\n   id : {id}\n   Customer Name : {CustomerName}\n   Address : {Address}\n   status : {status}\n}}";
    }
}
