using Models;

List<Pessoa> hospedes = new();
Pessoa p1 = new(nome:"Martha",sobrenome:"Rocha");
Pessoa p2 = new(nome: "Beatriz", sobrenome: "Fonseca");
Pessoa p3 = new(nome: "Beatriz", sobrenome: "Fonseca");
hospedes.Add(p1);
hospedes.Add(p2);
hospedes.Add(p3);

Suite suite = new (tipoSuite: "Simples", capacidade: 3, valorDiaria: 50M);


Reserva reserva = new(diasReservados: 10);
reserva.CadastrarSuite(suite);
reserva.CadastrarHospedes(hospedes);

Console.WriteLine($"Hóspedes: {reserva.ObterQuantidadeHospedes()}");
Console.WriteLine($"Valor diária: {reserva.CalcularValorDiaria()}");