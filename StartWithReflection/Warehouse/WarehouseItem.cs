using System;

namespace Warehouse
{
    public class WarehouseItem
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Count { get; set; }

        private void Display()
        {
            Console.WriteLine($"Id :{Id}, Name: {Name}, Count: {Count}");
        }
        public string GetDisplayText()
        {
            return $"Id :{Id}, Name: {Name}, Count: {Count}";
        }
        protected string GetIdAndName()
        {
            return $"Id :{Id}, Name: {Name}";
        }
    }
}
