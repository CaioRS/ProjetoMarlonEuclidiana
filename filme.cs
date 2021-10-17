using System;

class filme:atracao{

  public filme (string n) : base(n){}

  
  public override void start(){
    Console.WriteLine("Video Reproduzindo!");
  }
  public override void pause(){
    Console.WriteLine("Video Pausado!");
  }






}