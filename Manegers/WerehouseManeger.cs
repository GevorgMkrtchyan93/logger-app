using System;

namespace IInterfaceApp
{
    class WerehouseManeger:ICargo
    {
        private int _count;
        private bool _cargo;

        public WerehouseManeger(int count, bool cargo)
        {
            _count = count;
            _cargo = cargo;
        }

        public int GivCargo(int amount)
        {
            if (amount >= 1000)
            {
                amount *= _count;
            }
            if (amount <= 1000)
            {
                Console.WriteLine("Return Cargo");
            }
            return amount;
        }
        public int GetCargo(bool freeSpace)
        {
            if (freeSpace)
            {
                _count++;
            }
            else
            {
                Console.WriteLine($"There is no free space");
            }
            return _count;
        }

        public void Divide()
        {
            Console.WriteLine("Werehouse have a cargo");
        }
    }
}
