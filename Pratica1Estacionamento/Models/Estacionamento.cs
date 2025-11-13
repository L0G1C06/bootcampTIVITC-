using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pratica1Estacionamento.Models
{
    public class Estacionamento
    {
        // qtd vagas total (usando array pois lista tem um tamanho infinito)
        // regra de custo do estacionamento por hora x tipo do veículo (moto, carro pequeno, médio ou grande)
        public List<string>? Vagas = null;

        public bool Validador(string tipo, string tamanho, string vaga)
        {
            var tamanhosValidos = new List<string> {"pequeno", "medio", "grande"};

            // verifica se o tipo é moto ou carro, se for moto, desabilita o tamanho, se for carro, obriga passar o tamanho
            if (tipo == "moto" && !string.IsNullOrEmpty(tamanho))
            {
                throw new ArgumentException("Moto não deve ter tamanho especificado");
            }
            else if (tipo == "carro")
            {
                if (string.IsNullOrEmpty(tamanho))
                {
                    throw new ArgumentException("Carro deve ter tamanho especificado");
                }
                
                if (!tamanhosValidos.Contains(tamanho))
                {
                    throw new ArgumentException($"Tamanho {tamanho} inválido");
                }
            }
            
            if (Vagas == null)
            {
                Vagas = new List<string>();
            }

            // Verifica se a vaga já está ocupada
            if (Vagas.Any(v => v.EndsWith($"-{vaga}")))
            {
                throw new InvalidOperationException($"Vaga {vaga} já está ocupada");
            }
            
            return true;
        }

        public decimal ValorPago(string veiculo, int horas)
        {
            // Lógica de valor a ser pago pelo veículo que foi removido
            
            // Moto -> 2.50/hora
            // carro -> 5.00/hora + pequeno (2.00), médio (3.00), grande (4.00)
            decimal valorTotal = 0;
            var partes = veiculo.Split('-');
            string tipo = partes[0];

            if (tipo == "moto")
            {
                valorTotal = 2.50m * horas;
            }

            else if (tipo == "carro")
            {
                decimal valorBase = 5.00m * horas;
                decimal adicionalTamanho = 0;
                if (partes.Length > 1)
                {
                    string tamanho = partes[1];
                    adicionalTamanho = tamanho switch
                    {
                        "pequeno" => 2.00m * horas,
                        "medio" => 3.00m * horas,
                        "grande" => 4.00m * horas,
                        _ => 0
                    };
                }

                valorTotal = valorBase + adicionalTamanho;
            }
            return valorTotal;
        }

        public bool AdicionarVeiculo(string tipo, string tamanho, string vaga)
        {
            try
            {
                bool valid = Validador(tipo, tamanho, vaga);
                if (!valid)
                {
                    Console.WriteLine("Dados do veículo inválidos");
                    return false;
                }
                
                string veiculo = tipo == "moto" ? $"{tipo}-{vaga}" : $"{tipo}-{tamanho}-{vaga}";
                
                if (Vagas == null)
                {
                    Vagas = new List<string>();
                }
                
                Vagas.Add(veiculo);
                Console.WriteLine("Veículo adicionado com sucesso.");
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro: {ex.Message}");
                return false;
            }
        }

        public void ListarVeiculos()
        {
            if (Vagas == null || Vagas.Count == 0)
            {
                Console.WriteLine("Nenhum veículo estacionado.");
                return;
            }

            Console.WriteLine("Veículos estacionados:");
            foreach (var veiculo in Vagas)
            {
                Console.WriteLine(veiculo);
            }
        }

        public void RemoverVeiculos(string vaga, int horas)
        {
            // Remover o veículo baseado na vaga
            if (Vagas == null || Vagas.Count == 0)
            {
                Console.WriteLine("Nenhum veículo estacionado.");
                return;
            }

            var veiculoParaRemover = Vagas.FirstOrDefault(v => v.EndsWith($"-{vaga}"));
            if (veiculoParaRemover != null)
            {
                Vagas.Remove(veiculoParaRemover);
                Console.WriteLine($"Veículo na vaga {vaga} removido com sucesso.");
                decimal valorPago = ValorPago(veiculoParaRemover, horas);
                Console.WriteLine($"Valor a ser pago pelo veículo na vaga {vaga}: R$ {valorPago}");
            }
            else
            {
                Console.WriteLine($"Nenhum veículo encontrado na vaga {vaga}.");
            }
        }
    }
}   