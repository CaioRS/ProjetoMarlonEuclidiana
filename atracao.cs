using System;
// criamos a classe atracao pois poderiamos ter alem de filmes, series ou documentarios.... todas elas herdariam desta classe
class atracao{
  public string nome {get; protected set;}
 
  public atracao(string n){
    nome = n;

  }

  public virtual void start(){

  }

  public virtual void pause(){

  }
}