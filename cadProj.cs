class Projeto{

  string Titulo,descri,AreaAp;
  int like;

  //public string Usuario {get{return NomeCria;} set{NomeCria = value;}}

  public string NomeProjeto {get{return Titulo;} set{Titulo = value;}}

  public string Descricao {get{return descri;} set{descri = value;}}

  public string Utilizacao {get{return AreaAp;} set{AreaAp = value;}}

  public int Votos {get{return like;} set{like = value;}}

  public Projeto (string titilo, string desc,string area, int likes){
    Titulo = titilo ;
    descri = desc  ;
    AreaAp = area ;
    like = likes;
  }

}