using System;

namespace Calculator
{
    internal class calculate<Type>
    {
        private Type data1;
        private Type data2;
        private Type data3;

        public calculate(Type data1,Type data2)
        {
            this.data1 = data1;
            this.data2 = data2;
        }

        public Type add()
        {
            data3 = (dynamic)data1 + (dynamic)data2;
            return (data3);
        }

        public Type subtract()
        {
            data3 = (dynamic)data1 - (dynamic)data2;
            return (data3);
        }

        public Type multiply()
        {
            data3 = (dynamic)data1 * (dynamic)data2;
            return (data3);
        }

        public Type divide()
        {
            data3 = (dynamic)data1 / (dynamic)data2;
            return (data3);
        }
    }
}
