using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Struct
{

    //Task 1 
    //Создайте структуру «Дробь». 
    //Она должна иметь поля для хранения числителя и знаменателя.
    //Реализуйте следующую функциональность:
    //Сложение дробей;
    //Вычитание дробей;
    //Умножение дробей;
    //Деление дробей


    internal class Program
    {
        struct Fraction
        {
            public double Numerator { get; set; } 
            public double Denominator { get; set; }

            public Fraction(double numerator, double denominator)
            {
                if (denominator == 0)
                {
                    Console.WriteLine("Wrong number!");
                }
                    
                Numerator = numerator;
                Denominator = denominator;
            }

            public Fraction Add(Fraction other)
            {
                double multiplier;

                if(Denominator > other.Denominator) 
                {
                    multiplier = Denominator / other.Denominator;
                    double numerator_sum = Numerator + other.Numerator * multiplier;
                    double denominator_sum = Denominator;

                    return new Fraction(numerator_sum, denominator_sum);
                }
                else if(Denominator < other.Denominator) 
                { 
                    multiplier = other.Denominator / Denominator;
                    double numerator_sum = other.Numerator + Numerator * multiplier;
                    double denominator_sum = other.Denominator;

                    return new Fraction(numerator_sum, denominator_sum);
                }
                else
                {
                    double numerator_sum = other.Numerator + Numerator;
                    double denominator_sum = Denominator;

                    return new Fraction(numerator_sum, denominator_sum);
                }
            }

            public Fraction Subtract(Fraction other) 
            {
                double multiplier;

                if (Denominator > other.Denominator)
                {
                    multiplier = Denominator / other.Denominator;
                    double numerator_sub = Numerator - other.Numerator * multiplier;
                    double denominator_sub = Denominator;

                    return new Fraction(numerator_sub, denominator_sub);
                }
                else if (Denominator < other.Denominator)
                {
                    multiplier = other.Denominator / Denominator;
                    double numerator_sub = Numerator * multiplier - other.Numerator;
                    double denominator_sub = other.Denominator;

                    return new Fraction(numerator_sub, denominator_sub);
                }
                else
                {
                    double numerator_sub = Numerator - other.Numerator;
                    double denominator_sub = Denominator;

                    return new Fraction(numerator_sub, denominator_sub);
                }
            }

            public Fraction Multiply(Fraction other) 
            {
                return new Fraction(Numerator * other.Numerator, Denominator * other.Denominator);
            }

            public Fraction Divide(Fraction other)
            {
                if (other.Numerator == 0)
                {
                    throw new ArgumentException("Wrong number");
                }
                    
                return new Fraction(Numerator * other.Denominator, Denominator * other.Numerator);
            }

            public override string ToString()
            {
                return $"{Numerator}/{Denominator}";
            }
        }


        static void Main(string[] args)
        {
            //Task1
            Fraction frac1 = new Fraction(2, 6);
            Fraction frac2 = new Fraction(1, 4);

            Fraction sum = frac1.Add(frac2);
            Console.WriteLine($"Sum: {sum}");

            Fraction diff = frac1.Subtract(frac2);
            Console.WriteLine($"Difference: {diff}");

            Fraction mult = frac1.Multiply(frac2);
            Console.WriteLine($"Multiply: {mult}");

            Fraction divide = frac1.Divide(frac2);
            Console.WriteLine($"Divivde: {divide}");

            //Task2
            ComplexNumber complex1 = new ComplexNumber(2, 6);
            ComplexNumber complex2 = new ComplexNumber(1, 4);

            ComplexNumber sum_complex = complex1.Add(complex2);
            Console.WriteLine($"\nSum complex: {sum_complex}");

            ComplexNumber diff_complex = complex1.Subtract(complex2);
            Console.WriteLine($"Diff complex: {diff_complex}");

            ComplexNumber mult_complex = complex1.Multiply(complex2);
            Console.WriteLine($"Mult complex: {mult_complex}");

            ComplexNumber divide_complex = complex1.Divide(complex2);
            Console.WriteLine($"Divide complex: {divide_complex}");
        }
    }
}
