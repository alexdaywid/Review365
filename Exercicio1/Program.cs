

//Calcular media aritimetrica

double notaDoTeste, notaDaProva, media;

Console.WriteLine("Cadastre nota do teste.");
notaDoTeste = double.Parse(Console.ReadLine());

Console.WriteLine("Cadastre nota da prova.");
notaDaProva = double.Parse(Console.ReadLine());

media = (notaDoTeste + notaDaProva) / 2;

if (media > 7)
    Console.WriteLine("Aprovado");
else
    Console.WriteLine("Reprovado");

Console.WriteLine("teste git");


Console.ReadKey();