using System;
class Program{
    static void Main(string[] args){
        MyMatrix matriz = new MyMatrix(2,2);

        matriz.InsertNumbers();
        matriz.PrintMatrix();

        matriz.Permute(1, 2);
        Console.WriteLine("Matriz invertida:");
        matriz.PrintMatrix();

        matriz.Multiply(2, 3);
        Console.WriteLine("Linha 2 multiplicada por 3:");
        matriz.PrintMatrix();

        matriz.MultiplyAndSum(1, 2, 2);
        Console.WriteLine("Resultado da linha 1 somada pela linha 2 dobrada:");
        matriz.PrintMatrix();
    }
}