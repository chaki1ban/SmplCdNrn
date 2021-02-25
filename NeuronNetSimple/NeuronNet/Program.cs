using System;

namespace NeuronNet
{
    class Program
    {
        public class Neuron
        {
            private decimal weight = 0.5m;

            // ошибки
            public decimal LastError { get; private set; }
            // сглаживание корректироваки
            public decimal Smoothing { get; private set; } = 0.00001m;

            // конвератция
            public decimal ProcessInputData(decimal input)
            {
                return input * weight;
            }

            // инвертация
            public decimal RestoreInputData(decimal output)
            {
                return output / weight;
            }

            // пример/обучение для нейрона
            public void Train(decimal input, decimal expectedResult)
            {
                var actualResult = input * weight;
                LastError = expectedResult - actualResult;
                var correction = LastError / actualResult;
                weight += correction;
            }
        }

        static void Main(string[] args)
        {
            
        }
    }
}
