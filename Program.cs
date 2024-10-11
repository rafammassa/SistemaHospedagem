using DesafioSistemaHospedagem.Models;

List<Pessoa> hospedes = new List<Pessoa>();

Pessoa p1 = new Pessoa(nome: "Paloma Machado");
Pessoa p2 = new Pessoa(nome: "Eduardo Folco");

hospedes.Add(p1);
hospedes.Add(p2);

Suite suite = new Suite(tipoSuite: "Premium", capacidade: 2, valorDiaria: 400.50M);