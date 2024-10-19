char sexo;
double altura, peso;

Console.Clear();


Console.WriteLine("Voce é [M] = masculino ou [F] = feminino:...");
sexo = Convert.ToChar(Console.ReadLine().ToUpper());
Console.Write("Coloque aqui sua altura......");
altura = Convert.ToDouble(Console.ReadLine());

if (sexo != 'M' && sexo != 'F')
{
    Console.WriteLine("Precisa ser Masculino ou Feminino!");
}
else 
{
    if(sexo == 'M')
    {
        peso = altura * 72.7 - 58.0;
    }
    else
    {
        peso = altura * 62.1 - 44.7;
    }
    Console.WriteLine($"Seu peso é {peso:N1}!");
}

