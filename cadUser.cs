class User{
  string nome,email;
  int senha;
  double Meta;

  public string Nome {get{return nome;} set{nome = value;}}

  public string Email {get{return email;} set{email = value;}}

  public int Senha {get{return senha;} set{senha = value;}}

  public double ValorEsp {get{return Meta;} set{Meta = value;}}

  public User (string N, string Em,int Pass,double Meta){
    nome = N;
    email = Em;
    Senha = Pass;

  }
}