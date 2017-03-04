namespace Builder
{
    public class Engineer
    {
        private readonly IPlant _plant;
        public Engineer(IPlant plant)
        {
            _plant = plant;
        }

        public Product Construct()
        {
            return _plant.Construct();
        }
    }
}