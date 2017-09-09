using System;

namespace Day04
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    class Car
    {
        Door[] doors;
        Price price;
        Engine engine;

        void Drive()
        {
            doors = new Door[2];
            doors[0].Lock();
            doors[1].Lock();
        }
    }

    class Door
    {
        int windowsCount = 2;

        void Open()
        {
        }

        void Close()
        {
        }

        public void Lock()
        {
        }

        void UnLock()
        {
        }
    }

    class Price
    {

    }

    class Engine
    {

    }
}
