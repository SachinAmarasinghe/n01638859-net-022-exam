using Net_022_FinalTest_SachinAmarasinghe;

class Program
{
    static void Main()
    {
        // Example usage
        GenericClass<int> intCollection = new GenericClass<int>();
        intCollection.AddItem(5);
        intCollection.AddItem(3);
        intCollection.AddItem(8);

        Console.WriteLine("Original List:");
        foreach (var item in intCollection.GetSortedDescending())
        {
            Console.WriteLine(item);
        }

        int itemAtIndex = intCollection.GetItem(1);
        Console.WriteLine($"Item at index 1: {itemAtIndex}");
    }
}