namespace movietheater
{
    public interface IPurchasable
    {
        string Name { get; set; }
        float Cost { get; set; }
        int Inventory { get; set; }

        int Quantity {get; set;}

        bool Purchase(int quantity);

    }
}