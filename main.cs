using System;
using System.Collections.Generic;

class MainClass {
  public static void Main (string[] args) {
   
    User novoUsuario = new User("AQ","joão@123.com",1234,2000);
    Projeto novoProjeto = new Projeto("Cinemaa4d", "Batman V Superman","Cinema",0);

    List<Projeto> listaProjetos = new List<Projeto>();
    List<User> listaUsuarios = new List<User>();

    Console.WriteLine("Bem Vindo ao site de Crowdfunding");

    //Var
    string NomeU,Email,Titulo,Descricao,Area,decis = "S",Pessoas="S";
    int Senha,escolha,Likes,votar,contVotos;
    double Meta;
    
    Console.WriteLine(@"O site Funciona com um sistema de sprints,onde o
Patrocianador irá permitir um numero X de Projetos,a serem cadstrados na sprint,após o cadastro dos projetos,
uma votação aberta é realizada ao publico do site,o projeto mais votado recebe um Patrocinio para seu Projeto");
    Console.ReadLine();

    while (decis == "S"){

      contVotos = 0;
      
      Console.Write("Patrocianador Insira a quantidade de Projetos a serem cadstrados >> ");

      escolha = int.Parse(Console.ReadLine());
      
      //cadastro
      for (int x = 0; x < escolha;x++){
        Console.Write("Insira o Nome de Usuario >>");
        NomeU = Console.ReadLine();

        Console.Write("Insira Seu Email >>");
        Email= Console.ReadLine();

        Console.Write("Insira sua Senha >>");
        Senha = int.Parse(Console.ReadLine());

        /* Projeto */

        Console.Write("Insira o Titulo do projeto >>");
        Titulo = Console.ReadLine();

        Console.Write("Insira a Descrição do Projeto >>");
        Descricao= Console.ReadLine();

        Console.Write("Insira a Area do Projeto >>");
        Area = Console.ReadLine();

        Console.Write("Insira a Meta desejada  >>");
        Meta = double.Parse(Console.ReadLine());

        Console.ReadLine();

        novoUsuario = new User(NomeU,Email,Senha,Meta);
        listaUsuarios.Add(novoUsuario);

        novoProjeto = new Projeto(Titulo,Descricao,Area,0);
        listaProjetos.Add(novoProjeto);

      }
      while (Pessoas == "S"){
        Console.Clear();
        for(int x = 0;x < listaProjetos.Count;x++){
          Console.WriteLine($"Dono do Projeto >> {listaUsuarios[x].Nome}\nNome Do Projeto >>{listaProjetos[x].NomeProjeto}\nMeta do Projeto >> {listaUsuarios[x].ValorEsp}\nDescrição do Projeto >> {listaProjetos[x].Descricao}\nArea de Atuação do Projeto >>  {listaProjetos[x].Utilizacao}\nQuantidade de Votos >> {listaProjetos[x].Votos}");

          Console.Write("Deseja dar Like ? 1 - Sim/2 - Não >>");
          votar = int.Parse(Console.ReadLine());

          if (votar == 1){
            Console.WriteLine("Voto Contabilizado com Sucesso");
            Console.ReadLine();
            listaProjetos[x].Votos+=1;
            contVotos+=1;
          }
          Console.Clear();
        }

        Console.Write("Mais Pessoas Iram votar ? S - Sim // N-Não >>");
        Pessoas = Console.ReadLine();
      }

      int Maior = listaProjetos[0].Votos;
      int indiceVencedor = 0;

      for (int x = 0;x < escolha;x++ ){
        if (listaProjetos[x].Votos > Maior){
          Maior = listaProjetos[x].Votos;
          indiceVencedor = x;
        }
      }
       Console.WriteLine(@"                  Projeto Vencedor");

       Console.WriteLine($"Dono do Projeto >> {listaUsuarios[indiceVencedor].Nome}\nNome Do Projeto >>{listaProjetos[indiceVencedor].NomeProjeto}\nMeta do Projeto >> {listaUsuarios[indiceVencedor].ValorEsp}\nDescrição do Projeto >> {listaProjetos[indiceVencedor].Descricao}\nArea de Atuação do Projeto >>  {listaProjetos[indiceVencedor].Utilizacao}\nQuantidade de Votos >> {listaProjetos[indiceVencedor].Votos}");

      double valorPatrocinio = ((listaProjetos[indiceVencedor].Votos/contVotos)^2)*30000;

       Console.WriteLine($"Valor de Patrocinio >> {valorPatrocinio}");
      
      Console.Write("Realizar Novo Patrocinio ? S - Sim // N-Não >>");
      decis = Console.ReadLine();
    }
      
  }
}