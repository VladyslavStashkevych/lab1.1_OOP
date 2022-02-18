using System;

namespace lab1._1_OOP {
    class FloatPower {
        double first;
        double second;

        public double First {
            get => first;
            set => first = value;
            
        }
        public double Second {
            get => second;
            set => second = value;
        }

        public bool Init(double x, double y) {
            if (x != 0) {
                this.First = x;
                this.Second = y;
                return true;
            }
            Console.WriteLine("Number should not be zero!");
            return false;
        }
        public void Read() {
            Console.Write("Enter number: ");
            double num = Double.Parse(Console.ReadLine());

            Console.Write("Enter power: ");
            double power = Double.Parse(Console.ReadLine());
            if (!this.Init(num, power))
                do {
                    Console.Write("Enter another number: ");
                    num = Double.Parse(Console.ReadLine());
                } while (!this.Init(num, power));
        }
        public void Display() {
            var pow = this.Power();
            if (pow % 1 == 0)
                Console.WriteLine($"Number {this.First} raised to {this.Second} equals {pow}");
            else
                Console.WriteLine($"Number {this.First} raised to {this.Second} equals {pow:0.0000}");
        }
        public double Power() => Math.Pow(this.First, this.Second);
    }
}
