using System.Collections.Generic;
using System;

class euclidiana{

  public static List<double> sim = new List<double>();
  // funcao de similaridades.

  public static void Similaridades(pessoa Ana, pessoa Pedro, pessoa Claudia, pessoa Leonardo){

    //similaridade Ana e Leonardo
    sim.Add(Distancia(Leonardo,Ana));
    //similaridade Ana e Pedro
    sim.Add(Distancia(Leonardo,Pedro));
    //similaridade Ana e Claudia
    sim.Add(Distancia(Leonardo,Claudia));



    Console.WriteLine("Similaridade entre {0} e {1} eh : {2}\n",Leonardo.nome,Ana.nome,sim[0]);
    Console.WriteLine("Similaridade entre {0} e {1} eh : {2}\n",Leonardo.nome,Pedro.nome,sim[1]);
    Console.WriteLine("Similaridade entre {0} e {1} eh : {2}\n",Leonardo.nome,Claudia.nome,sim[2]);



    


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