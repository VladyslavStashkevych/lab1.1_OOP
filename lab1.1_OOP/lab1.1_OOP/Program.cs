using System;

namespace lab1._1_OOP {
    static class Program {
        static void Main(string[] args) {
            FloatPower powerRD = new FloatPower();
            powerRD.Read();
            powerRD.Display();
            Console.WriteLine();

            FloatPower powerID = new FloatPower();
            powerID.Init(-0.1, 3);
            powerID.Display();
            Console.WriteLine();

            FloatPower powerMD = MakeFloatPower(4, 2.5);
            powerMD.Display();
            Console.WriteLine();
        }
        public static FloatPower MakeFloatPower(double num, double pow) {
            var result = new FloatPower();
            result.Init(num, pow);
            return result;
        }
    }
}
