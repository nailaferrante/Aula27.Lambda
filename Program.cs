using System;

namespace Lambda
{
    class Program
    {
        static void Main(string[] args)
        // {
        //     Func<int,int,int> rs = soma;// o rs se apropriou das propriedades do método soma
        //     Console.WriteLine(rs(10,5));
        // }
        // {
        //     Func<int,int,double> res = Atividade.subtrair;
        //     Console.WriteLine(res(10,5));
        // }
        {
            Func<int,int,string> ser = Atividade.multiplicar;
            Console.WriteLine(ser(10,5));
        }
        static int soma(int v1, int v2){
            return v1+v2;
            }
    }
}
