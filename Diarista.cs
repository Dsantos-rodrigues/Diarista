public class Diarista
{
  private string nome;
  private int horaentrada;
  private int horasaida;
  private int horastrabalhadas;
  private int horastrabalhadasadicionais;
  private double valorreceber;
  private double valorreceberadicional;
  
  public Diarista (string nome, int horaentrada, int horasaida)
  {
    this.nome = nome;
    this.horaentrada = horaentrada;
    this.horasaida = horasaida;
  }

  public void setNome(string nome)
  {
    this.nome = nome;
  }

  public string getNome()
  {
    return this.nome;
  }

  public void setHoraEntrada(int horaentrada)
  {
    this.horaentrada = horaentrada;
  }

  public int getHoraEntrada()
  {
    return this.horaentrada;
  }
  
  public void setHoraSaida(int horasaida)
  {
    this.horasaida = horasaida;
  }

  public int getHoraSaida()
  {
    return this.horasaida;
  }    

  public void calcularHorasTrabalhadas(int horaalmoco)
  {
    this.horastrabalhadas = (this.horasaida - this.horaentrada) - horaalmoco;
  }

  public int getHorasTrabalhadas()
  {
    return this.horastrabalhadas;
  }

  public void calcularHorasTrabalhadasAdicionais(int horatrabalho)
  {
    this.horastrabalhadasadicionais = this.horastrabalhadas - horatrabalho;
    if (this.horastrabalhadasadicionais < 0)
    {
      this.horastrabalhadasadicionais = 0;
    }
  }

  public int getHorasTrabalhadasAdicionais()
  {
    return this.horastrabalhadasadicionais;
  }

  public void calcularValorReceberAdicional(double valorhoraadicional)
  {
    this.valorreceberadicional = this.horastrabalhadasadicionais * valorhoraadicional;
  }

  public double getValorReceberAdicional()
  {
    return this.valorreceberadicional;
  }  

  public void calcularValorReceber(double valorhora)
  {
    this.valorreceber = ((this.horastrabalhadas - this.horastrabalhadasadicionais) * valorhora) + this.valorreceberadicional;
  }

  public double getValorReceber()
  {
    return this.valorreceber;
  }

}