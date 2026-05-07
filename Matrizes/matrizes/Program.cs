using System;
using System.Numerics;
using System.Threading;

Console.OutputEncoding = System.Text.Encoding.UTF8;

/*

*/

int[,] matriz1 = {
    {1, 2, 3},
    {4, 5, 6},
    {7, 8, 9}
};

int[,] matriz2 = {
    {9, 8, 7},
    {6, 5, 4},
    {3, 2, 1}
};

int[,] matriz3 = new int[3, 3];

Console.WriteLine("MATRIZES MASSAS, UAAAAAAAAAAAAAAAAAAAAAU\n\n");

Console.WriteLine(@"

                                        ..  mm##            
                                  ..++  ::mm..::--mm        
                                ::--..----mm::mm--++..      
                            ..::--::mmMM++mm++@@::--::      
                          ....--..--::--MM##MM++++MM++      
                        ::----::++++mmMMMMMM++++++MM::--    
                    ::..MM::  MMmm::++::++##@@::MM++++      
              ..::++::++MMmmMMmm::@@mmMMmm++MM@@MM@@::      
              mm++--..MMmm######@@mm++##::##++@@mmmm++      
          ....--##----++mm++::MMMM@@MMMM@@++MM++mmmm        
      mm++mm::::##mm::  --mmMMMM--mmMM@@mm##::MMmm::        
        ++..  @@--++mm++mmmm::MMMMMM@@++MMmm++MM            
                --..--####mmmm##::@@@@mmmm::mm              
                  ..mm++::@@--++MMmmMMMMMM..                
                          ..--::--..                        

");

for (int i = 0; i < matriz1.GetLength(0); i++)
{
    for (int j = 0; j < matriz1.GetLength(1); j++)
    {
        int soma = 0;
        
        for (int k = 0; k < matriz1.GetLength(1); k++)
        {
            soma += matriz1[i, k] * matriz2[k, j];
        }
        matriz3[i, j] = soma;
    }
}

int count = 0;
foreach (var item in matriz3)
{
    Console.Write($"{item}\t");

    if (count == 2)
    {
        Console.Write("\n");
        await Task.Delay(1000);
        count = 0;
    }
    else
    {
        count++;
    }
}