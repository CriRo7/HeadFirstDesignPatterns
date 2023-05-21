using System;

namespace Strategy
{
    public class Program
    {
    }

    internal interface IDuck
    {
        public void Fly();
    }

    internal class MallardDuck : IDuck
    {
        public void Fly()
        {
            throw new NotImplementedException();
        }
    }

    internal class RoboDuck : IDuck
    {
        public void Fly()
        {
            throw new NotImplementedException();
        }
    }
} 