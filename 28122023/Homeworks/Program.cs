using System;

namespace Homeworks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Calc(10, 20, '/');
            Calc(10d, 20d, '/');

            var powerNum = CalcPow(4, 3);
            Console.WriteLine(powerNum);

            int[] nums = { 34, -65, -8 };

            MakePositive(nums);

            for (int i = 0; i < nums.Length; i++)
            {
                Console.WriteLine(nums[i]);
            }

            Console.WriteLine(nums);

            Console.WriteLine("yazi daxil edin");
            string text = Console.ReadLine();
            string reversedText = Reverse(text);
            Console.WriteLine(reversedText);


            string str = "   salam  necesen?  ";
            string newStr = RemoveStartAndEndSpaces(str);
            Console.WriteLine(newStr);

            Console.WriteLine(CountWords("salam"));

            Console.WriteLine(CountWordsByElmar("     salam     necesen      "));   

        }

        //Verilmiş iki ədəd üzərində verilmiş operator simvoluna əsasən riyazi əməliyyat aparıb nəticəsini console-da göstərən metod.
        static void Calc(int num1,int num2,char mathOperator)
        {
            switch (mathOperator)
            {
                case '+':
                    Console.WriteLine(num1 + num2);
                    break;
                case '-':
                    Console.WriteLine(num1 - num2);
                    break;
                case '*':
                    Console.WriteLine(num1 * num2);
                    break;
                case '/':
                    if (num2 == 0) Console.WriteLine("0-a bolme yoxdur");
                    else Console.WriteLine(num1 / num2);
                    break;
                default:
                    Console.WriteLine("operator yanlisdir");
                    break;
            }
        }

        static void Calc(double num1, double num2, char mathOperator)
        {
            switch (mathOperator)
            {
                case '+':
                    Console.WriteLine(num1 + num2);
                    break;
                case '-':
                    Console.WriteLine(num1 - num2);
                    break;
                case '*':
                    Console.WriteLine(num1 * num2);
                    break;
                case '/':
                    if (num2 == 0) Console.WriteLine("0-a bolme yoxdur");
                    else Console.WriteLine(num1 / num2);
                    break;
                default:
                    Console.WriteLine("operator yanlisdir");
                    break;
            }
        }

        //Verilmişdədin rəqəmləri cəmini qaytaran metod
        static int CalcDigitsOfNum(int num)
        {
            int sum = 0;

            if (num < 0) num *= -1;

            while (num!=0)
            {
                var digit = num % 10;
                sum += digit;
                num /= 10;
                //num=(num-digit)/10
            }

            return sum;
        }

        //Verilmiş ədədi verilmiş qüvvətə yüksəldib nəticəsini qaytaran metod
        static int CalcPow(int n,int pow)
        {
            int result = 1;

            for (int i = 0; i < pow; i++)
            {
                result *= n;
            }

            return result;
        }

        //Verilmiş ədədlər siyahısının bütün elementlərini  müsbət şəkildə qaytaran metod.
        //Misalçün  metoda {1,-4,9,-8} dəyərləri olan array göndərilsə metod bizə {1,4,9,8} dəyərləri olan array qaytarmalıdır.
        static int[] MakePositive(int[] arr)
        {

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < 0) arr[i] *= -1;
            }

            return arr;
        }

        //salam
        //Verilmiş yazını tərs formada qaytaran metod (Misalçün "salam" göndərilsə metoddan "malas" return ediləcək)
        static string Reverse(string str)
        {
            string newStr = "";
           


            for (int i = str.Length-1;  i>=0; i--)
            {
                newStr += str[i];
            }

            return newStr;

        }

        //Verilmiş yazıdaki sözlərin sayını qaytaran metod (söz dedikdə boşluqlarla ayrılmış bütün yazılar nəzərdə tutulur)
        static int CountWords(string str)
        {
            str = RemoveStartAndEndSpaces(str);
            if (str.Length == 0) return 0;

            int count = 0;

            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == ' ' && str[i - 1] != ' ') count++;
            }

            count++;
            return count;
        }



        //Verilmis yazinin evvelinde ve sonundaki bosluqlari silib qaytaran metod
        static string RemoveStartAndEndSpaces(string str)
        {
            string newStr = "";
            int startIndex = FindFirstNonSpaceIndex(str);
            int endIndex = FindLastNonSpaceIndex(str);

            if(startIndex==-1) return newStr;

            for (int i = startIndex; i <= endIndex; i++)
            {
                newStr+= str[i];
            }

            return newStr;
        }
       
        static int FindFirstNonSpaceIndex(string str)
        {
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] != ' ') return i;
            }
            return -1;
        }

        static int FindLastNonSpaceIndex(string str)
        {
            for (int i = str.Length-1; i >=0; i--)
            {
                if (str[i] != ' ') return i;
            }

            return -1;
        }
        // "  salam    necesen   ?  salam"
        static int CountWordsByElmar(string str)
        {
            int count = 0;
            bool sozvarmi=false;
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i]==' ')
                {
                    if (sozvarmi)
                    {
                        count++;
                        sozvarmi=false;
                    }
                }
                else
                {
                    sozvarmi = true;
                }

            }
            if (sozvarmi)
            {
                count++;
            }
            return count;
        }


    }
}
