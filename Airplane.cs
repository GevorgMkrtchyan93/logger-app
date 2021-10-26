using System;


namespace IInterfaceApp
{
    class Airplane :WerehouseManeger, ICargo
    {
       private bool _fast;
       private int _count;
        public Airplane(bool fast):base(0,false)
        {
            _fast = fast;
        }
        public void Divide()
        {
            if (_fast)
            {
                _count++;
                Console.WriteLine($"Cargo count for Airplane={_count}");
            }
        }
    }
}
