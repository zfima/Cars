namespace Car
{
    public class Mercedes500 : ICar
    {
        public IEngine CurrenEngine()
        {
            return new GTR546();
        }

        public IFuel CurrentFuel()
        {
            return new Fuel96();
        }
    }

    public class MercedesActros : ICar
    {
        public IEngine CurrenEngine()
        {
            return new BGF45();
        }

        public IFuel CurrentFuel()
        {
            return new Solar();
        }
    }
}
