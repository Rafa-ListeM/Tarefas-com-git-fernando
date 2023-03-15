// See https://aka.ms/new-console-template for more information
using Aula08;


Endereco e1 = new Endereco(
    "Vinicios de morais",
    "168",
    "1637932",
    "jardim",
    "Taqualitinga",
    "SP");

Cliente c1 = new Cliente(1, "Rafaeli Turci", "83994058", e1);
Cliente c2 = new Cliente(2, "Lucas novais", "35476584", e1);
Cliente c3 = new Cliente(3, "Julia ciqueira", "23434967", e1);
Cliente c4 = new Cliente(4, "Julio seila", "45334645", e1);

Console.WriteLine(c1.getEndereco().getRua());
c1.getEndereco().setRua("Prudente de Morais")