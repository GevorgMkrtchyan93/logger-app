using System;


namespace IInterfaceApp
{
    class Ship :WerehouseManeger, ICargo
    {
        bool _nonPerishableProduct;
        int _count;

        public Ship(bool nonPerishableProduct) :base(0,false)
        {
            _nonPerishableProduct = nonPerishableProduct;  
        }
        public void Divide()
        {
            if (_nonPerishableProduct)
            {
                _count++;
                Console.WriteLine($"Cargo count for Ship={_count}");
            }
            else
            {
                Console.WriteLine("Տhis cargo is inappropriate");
            }
        }
    }
}
