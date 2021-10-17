using System.Collections.Generic;

class pessoa{
  
  public string nome{get; protected set;}

  protected List<double> notas = new List<double>();

  public pessoa(string n){
    nome = n;
  }

  public void Nota(double nota0,double nota1,double  nota2,double nota3,double nota4,double nota5) {
    this.notas[0] = nota0;
    this.notas[1] = nota1;
    this.notas[2] = nota2;
    this.notas[3] = nota3;
    this.notas[4] = nota4;
    this.notas[5] = nota5;
  }
  

}
