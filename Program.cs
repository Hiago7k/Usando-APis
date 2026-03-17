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

// Manipulando APi GOT

using System;

using (HttpClient client = new HttpClient())    
{
    try 
    {
        string resposta = await client.GetStringAsync("https://anapioficeandfire.com/api/characters/542");
        Console.WriteLine(resposta);
    }catch (Exception ex)
    {
        Console.WriteLine($"Erro na busca {ex:message}");
    }
}