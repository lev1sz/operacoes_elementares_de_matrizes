using System;
class Program{
    static void Main(){
        Program program = new Program();
        program.InitialMenu();
    }
    public void InitialMenu()
    {
        while(true)
        {
            Console.WriteLine("1 - Calcular nova matriz.");
            Console.WriteLine("0 - Sair do programa.");
            int choice = int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    Console.Write($"Digite o número de linhas: ");
                    int rows = int.Parse(Console.ReadLine());
                    Console.Write($"Digite o número de colunas: ");
                    int cols = int.Parse(Console.ReadLine());
                    int returnToMenu = ManipulateMenu(rows, cols);
                    if (returnToMenu == 0)
                    {
                        continue;
                    }
                    else
                    {
                        break;
                    }
                case 0:
                    Console.WriteLine("Fim do programa.");
                    return;
            }
        }
    }
    public int ManipulateMenu(int rows, int cols)
    {
        MyMatrix matriz = new MyMatrix(rows, cols);
        Console.WriteLine("Insira os valores na matriz.");
        matriz.InsertNumbers();
        matriz.PrintMatrix();
        int i, j;
        float alpha;
        while(true)
        {
            Console.WriteLine("Escolha uma operacao:");
            Console.WriteLine("1 - Permutar linhas.");
            Console.WriteLine("2 - Multiplicar linha.");
            Console.WriteLine("3 - Multiplicar e somar.");
            Console.WriteLine("0 - Voltar ao menu inicial.");
            int choice = int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 0:
                    return 0;
                case 1:
                    Console.Write("Insira a primeira linha: ");
                    i = int.Parse(Console.ReadLine());
                    Console.Write("Insira a segunda linha: ");
                    j = int.Parse(Console.ReadLine());
                    matriz.Permute(i, j);
                    matriz.PrintMatrix();
                    break;
                case 2:
                    Console.Write("Insira a linha a ser multiplicada: ");
                    i = int.Parse(Console.ReadLine());
                    Console.Write("Insira o multiplicador: ");
                    alpha = float.Parse(Console.ReadLine());
                    matriz.Multiply(i, alpha);
                    matriz.PrintMatrix();
                    break;
                case 3:
                    Console.Write("Insira a linha a ser somada: ");
                    i = int.Parse(Console.ReadLine());
                    Console.Write("Insira a linha a ser multiplicada: ");
                    j = int.Parse(Console.ReadLine());
                    Console.Write("Insira o multiplicador: ");
                    alpha = int.Parse(Console.ReadLine());
                    matriz.MultiplyAndSum(i, j, alpha);
                    matriz.PrintMatrix();
                    break;
            }
        }
    }

}