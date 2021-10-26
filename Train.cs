using System;

namespace IInterfaceApp
{
    class Train : WerehouseManeger, ICargo
    {
        private bool _cargo;
        private int _count;
        private bool _freeSpace;
        public Train(bool cargo,bool freeSpace):base(0,false)
        {
            _cargo=cargo;
            _freeSpace = freeSpace;
        }
        public void Divide()
        {
            if (_cargo && _freeSpace)
            {
                _count++;
                Console.WriteLine($"Cargo count for Train={_count}");
            }
            if (_cargo && !_freeSpace )
            {
                Console.WriteLine("No Free Space");
            }
            if (!_cargo && _freeSpace)
            {
                Console.WriteLine("No cargo");
            }
            if (!_cargo && !_freeSpace)
            {
                Console.WriteLine("No Train");
            }
        }
    }
}
