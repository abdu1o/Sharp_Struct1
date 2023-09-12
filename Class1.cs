using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Struct
{

    //Task 2
    //Создайте структуру «Комплексное число». 
    //Определите внутри неё необходимые поля и методы.
    //Реализуйте следующую функциональность:
    //Сложение комплексных чисел;
    //Вычитание комплексных чисел;
    //Умножение комплексных чисел;
    //Деление комплексных чисел

    struct ComplexNumber
    {
        public double Real { get; set; }
        public double Imaginary { get; set; }

        public ComplexNumber(double real, double imaginary)
        {
            Real = real;
            Imaginary = imaginary;
        }

        public ComplexNumber Add(ComplexNumber other)
        {
            double real_sum = Real + other.Real;
            double imagine_sum = Imaginary + other.Imaginary;
            return new ComplexNumber(real_sum, imagine_sum);
        }

        public ComplexNumber Subtract(ComplexNumber other)
        {
            double real_sub = Real - other.Real;
            double imagine_sub = Imaginary - other.Imaginary;
            return new ComplexNumber(real_sub, imagine_sub);
        }

        public ComplexNumber Multiply(ComplexNumber other)
        {
            double real_mult = Real * other.Real - Imaginary * other.Imaginary;
            double imagine_mult = Real * other.Imaginary + Imaginary * other.Real;
            return new ComplexNumber(real_mult, imagine_mult);
        }

        public ComplexNumber Divide(ComplexNumber other)
        {
            if (other.Real == 0 && other.Imaginary == 0)
            {
                throw new ArgumentException("Wrong number");
            }

            double denominator = other.Real * other.Real + other.Imaginary * other.Imaginary;
            double real_divide = (Real * other.Real + Imaginary * other.Imaginary) / denominator;
            double imagine_divide = (Imaginary * other.Real - Real * other.Imaginary) / denominator;
            return new ComplexNumber(real_divide, imagine_divide);
        }

        public override string ToString()
        {
            return $"{Real} + i{Imaginary}";
        }
    }
}
