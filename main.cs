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

    //for (int i = 0; i < atracoes.Count; i++){      
      //Console.WriteLine(atracoes[i].nome + "\n");
    //}

    // instanciacao usuarios

    pessoa Ana = new pessoa("Ana");
    pessoa Pedro = new pessoa("Pedro");
    pessoa Claudia = new pessoa("Claudia");
    pessoa Leonardo = new pessoa("Leonardo");


    // inclusao das notas dos filmes



    Ana.Nota(2.5 , 3.5 , 3.0, 3.5 , 2.5 , 3.0 );
    Pedro.Nota(2.5 , 3.0 , 0 , 3.5, 0, 4);
    Claudia.Nota(0 , 3.5 , 3 , 4 , 2.5 , 4.5);
    Leonardo.Nota(0 , 4.5 , 0, 4, 1 , 0); // Esse usuario sera nosso ponto de analise em especifico

    // teste de notas nos usuarios
    
    //for (int i = 0; i < Ana.notas.Count; i++){      
      //Console.WriteLine(Leonardo.notas[i] + "\n");
    //}

  }
}