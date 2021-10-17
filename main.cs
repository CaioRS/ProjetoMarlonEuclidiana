using System.Collections.Generic;
using System;

class Program {
  public static void Main (string[] args) {

    //instanciação dos filmes
    filme FreddyxJason = new filme("Freddy x Jason");
    filme UltimatoBourne = new filme("Ultimato Bourne");
    filme StarTrek = new filme("Star Trek");
    filme ExterminadordoFuturo = new filme("Exterminador do Futuro");
    filme Norbit = new filme("Norbit");
    filme StarWars = new filme("Star Wars");

    //lista para ordenação das notas dos usuarios
    List<atracao> atracoes = new List<atracao>();

    //acrescimo na lista
    atracoes.Add(FreddyxJason);
    atracoes.Add(UltimatoBourne);
    atracoes.Add(StarTrek);
    atracoes.Add(ExterminadordoFuturo);
    atracoes.Add(Norbit);
    atracoes.Add(StarWars);

    for (int i = 0; i < atracoes.Count; i++){      
      Console.WriteLine(atracoes[i].nome + "\n");
    }



  }
}