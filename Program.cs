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
        // {
        //     // Func<int,int,string> ser = Atividade.multiplicar;
        //     // Console.WriteLine(ser(10,5));
        // }
        // 
        // static int soma(int v1, int v2){ 
        //     return v1+v2;
        //     }
       

        // /*{
        //     Action<int,int> res = soma;
        //     res(20,30);//action é usado quando não há retorno.
        // }
        // static void soma(int v1, int v2){ 
        //      Console.WriteLine(v1+v2);
        //   }*/
        
        
        /*{
        //     Predicate<int> res = Par;// predicate sempre retorna verdadeiro ou falso (bool)
        //     Console.WriteLine(res(33));
        // }
        //     }
        // static bool Par(int valor){ // usado para o predicate
        //     return valor%2 == 0;
        // } */


        // {
        //     Data dt = delegate(string msg){ //vide data
        //         return msg + " hoje é " +DateTime.Now.ToShortDateString();
        //     };
        //     Console.WriteLine(dt("Oba!"));
        // }
                   
        
        /* delegate string Data(string mensagem); //vide data
        // {
        //     int[] valores = {40,56,1,23,9,11,22};
        //     foreach(int i in valores)
        //     if (Par(i))
        //     Console.WriteLine(i);
        // }
        // static bool Par (int v){
        //     return v% 2 == 0;
         }  */
        

       //modo anonimo      
        /*{
             int[] valores = {40,56,1,23,9,11,22};
             
             Func<int,bool> rs = delegate(int x)
             {
                 return x % 2 == 0;
             };

             foreach(int i in valores)
             if (rs(i))
             Console.WriteLine(i);
        }*/
        
        
        //exemplo expressão lambida igual ao exercicio anterior
        /*{
             int[] valores = {40,56,1,23,9,11,22};
             
             Func<int,bool> rs = x => x % 2 == 0;

             foreach(int i in valores)
             if (rs(i))
             Console.WriteLine(i);
        }*/

          
       /*{
           Func<double,double,double> calculo = (x,y) => x/y;
           Console.WriteLine(calculo(23,5));
       }*/

       


    }
}
