using System.Security.Cryptography.X509Certificates;

namespace Практическая1
{
    internal class Program
    {
       
        
        static void Main(string[] args)
        {
          
        }
    }
    public class Inventory
    {
        public float MaxWeight { get; }
        List<InventoryItem> _items = new List<InventoryItem>();
        public Inventory(int maxWeight)
        {
            MaxWeight = maxWeight;
            _items = new List<InventoryItem>();
        }
        public float GetCurrentWeight()
        {
            float itemsweight = 0f;
            foreach (InventoryItem item in _items)
            {

                itemsweight = item.Weight + itemsweight;

            }
            return itemsweight;
        }
        public bool TryAdd(InventoryItem item)
        {
            if (item.Weight + GetCurrentWeight() < MaxWeight)
            {
                _items.Add(item);
                return true;
            }
            return false;
        }
    }
    public class InventoryItem
    {
        public float Weight { get; }
        public InventoryItem(int weight)
        {
            Weight = weight;
        }
    }


  





}
