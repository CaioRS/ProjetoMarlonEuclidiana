using System.Collections.Generic;
using System;

class euclidiana{

  public List<double> sim = new List<double>();
  // funcao de similaridades.

  public static void Similaridades(pessoa Ana, pessoa Pedro, pessoa Claudia, pessoa Leonardo){

    //similaridade Ana e Leonardo
    Console.WriteLine(Distancia(Leonardo,Ana));


  }

  public static double Distancia(pessoa usu1, pessoa usu2 ){
    
    double dist = 0;

    for (int i = 0; i < usu1.notas.Count; i++){
      if(usu1.notas[i]!=0 && usu2.notas[i]!=0){
        dist = dist + Math.Pow((usu1.notas[i] - usu2.notas[i]), 2);;
      }
    }
    return 1/Math.Sqrt(dist);
  }



}