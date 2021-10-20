using System;

class MainClass {
  public static void Main (string[] args) {
    Diarista minhadiarista;
    string nomeDiarista;
    int horaentrada, horasaida;
    const int horaalmoco = 2;
    const int horatrabalho = 8;
    const double valorhora = 20;
    const double valorhoraadicional = 25; 

    //Entrada de Dados
    Console.WriteLine("Informe o nome da Diarista:");
    nomeDiarista = Console.ReadLine();
    Console.WriteLine("Informe a hora de entrada:");
    horaentrada = int.Parse(Console.ReadLine());
    Console.WriteLine("Informe a hora de saída:");
    horasaida = int.Parse(Console.ReadLine());    
    
    //Criar meu objeto
    minhadiarista = new Diarista(nomeDiarista,horaentrada,horasaida);
    minhadiarista.calcularHorasTrabalhadas(horaalmoco);
    minhadiarista.calcularHorasTrabalhadasAdicionais(horatrabalho);
    minhadiarista.calcularValorReceberAdicional(valorhoraadicional);
    minhadiarista.calcularValorReceber(valorhora);

    Console.WriteLine ("Nome da Diarista:{0}",minhadiarista.getNome());
    Console.WriteLine ("Hora de Entrada:{0}",minhadiarista.getHoraEntrada());
    Console.WriteLine ("Hora de Saida:{0}",minhadiarista.getHoraSaida());
    Console.WriteLine ("Horas Trabalhadas:{0}",minhadiarista.getHorasTrabalhadas());
    Console.WriteLine ("Horas Trabalhadas Adicionais:{0}",minhadiarista.getHorasTrabalhadasAdicionais());
    Console.WriteLine ("Valor a receber:{0}",minhadiarista.getValorReceber());
    Console.WriteLine ("Valor a receber adicional:{0}",minhadiarista.getValorReceberAdicional());
  }
}