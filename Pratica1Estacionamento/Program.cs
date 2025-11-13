using Pratica1Estacionamento.Models;

Estacionamento estacionamento = new Estacionamento();
estacionamento.AdicionarVeiculo(tipo: "carro", tamanho: "pequeno", vaga: "A1");
estacionamento.AdicionarVeiculo(tipo: "carro", tamanho: "pequeno", vaga: "A1");
estacionamento.ListarVeiculos();
estacionamento.RemoverVeiculos("A1", 2);
estacionamento.ListarVeiculos();