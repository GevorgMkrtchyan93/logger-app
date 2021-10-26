using System;


namespace IInterfaceApp
{
    class Truck : WerehouseManeger, ICargo
    {
        int _count;
        bool _slow;
        public Truck(bool slow):base(0,false)
        {
            _slow = slow;
        }
        public void Divide()
        {
            if (_slow)
            {
                _count++;
                Console.WriteLine($"Cargo count for Truck={_count}");
            }
        }
    }
}
