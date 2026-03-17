//using (HttpClient client = new HttpClient()) 
//{

//    try 
//    {
//        string resposta = await client.GetStringAsync("https://www.cheapshark.com/api/1.0/deals");
//        Console.WriteLine(resposta);
//    } catch(Exception ex) 
//    {
//        Console.WriteLine($"Ops acontenceu algo errado: {ex.Message}");
//          //Desafio malipular essa API
//    }

//}


// Atividade 2



try
{
    Console.WriteLine("Digite um numero: ");
    decimal a = Convert.ToDecimal(Console.ReadLine()!);
    Console.WriteLine("Digite outro numero: ");
    decimal b = Convert.ToDecimal(Console.ReadLine()!);
    decimal resposta = a / b;
    Console.WriteLine(resposta);
}
catch (Exception  ex)
{
    Console.WriteLine($"Erro na divisao {ex:Message}");
}