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

    double indicacao = 0;
    double totsim = 0;

    // Calculo nota para o filme 1:

    if (Ana.notas[0]!=0){
      indicacao += Ana.notas[0] * sim[0];
      totsim += sim[0];
    }

    if (Pedro.notas[0]!=0){
      indicacao += Pedro.notas[0] * sim[1];
      totsim += sim[1];
    }

    if (Claudia.notas[0]!=0){
      indicacao += Claudia.notas[0] * sim[2];
      totsim += sim[2];
    }

    Console.WriteLine("A provavel nota para o Filme Freddy x Jason eh {0}\n",indicacao/totsim);

    indicacao = 0;
    totsim = 0;

    // Calculo nota para o filme 3:

    if (Ana.notas[2]!=0){
      indicacao += Ana.notas[2] * sim[0];
      totsim += sim[0];
    }

    if (Pedro.notas[2]!=0){
      indicacao += Pedro.notas[2] * sim[1];
      totsim += sim[1];
    }

    if (Claudia.notas[2]!=0){
      indicacao += Claudia.notas[2] * sim[2];
      totsim += sim[2];
    }

    Console.WriteLine("A provavel nota para o Filme Star Trek eh {0}\n",indicacao/totsim);

        // Calculo nota para o filme 6:

    if (Ana.notas[5]!=0){
      indicacao += Ana.notas[5] * sim[0];
      totsim += sim[0];
    }

    if (Pedro.notas[5]!=0){
      indicacao += Pedro.notas[5] * sim[1];
      totsim += sim[1];
    }

    if (Claudia.notas[5]!=0){
      indicacao += Claudia.notas[5] * sim[2];
      totsim += sim[2];
    }

    Console.WriteLine("A provavel nota para o Filme Star Wars eh {0}\n",indicacao/totsim);
    


  }

  public static double Distancia(pessoa usu1, pessoa usu2 ){
    
    double dist = 0;

    for (int i = 0; i < usu1.notas.Count; i++){
      if(usu1.notas[i]!=0 && usu2.notas[i]!=0){
        dist = dist + Math.Pow((usu1.notas[i] - usu2.notas[i]), 2);;
      }
    }
    return 1/(1 + Math.Sqrt(dist));
  }



}