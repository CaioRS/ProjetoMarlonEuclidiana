using System.Collections.Generic;

class pessoa{
  
  public string nome{get; protected set;}

  public List<double> notas = new List<double>();

  public pessoa(string n){
    nome = n;
  }

  public void Nota(double nota1,double nota2,double nota3,double nota4,double nota5,double nota6) {
   notas.Add(nota1);
   notas.Add(nota2);
   notas.Add(nota3);
   notas.Add(nota4);
   notas.Add(nota5);
   notas.Add(nota6);
  }
  

}
