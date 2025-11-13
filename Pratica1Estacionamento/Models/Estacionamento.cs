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

            if (!tamanhosValidos.Contains(tamanho))
            {
                throw new ArgumentException($"Tamanho {tamanho} inválido");
            }

            // verifica se o tipo é moto ou carro, se for moto, desabilita o tamanho, se for carro, obriga passar o tamanho
            if (tipo == "moto" && tamanho != null)
            {
                throw new ArgumentException("Moto não deve ter tamanho especificado");
            }
            else if (tipo == "carro" && tamanho == null)
            {
                throw new ArgumentException("Carro deve ter tamanho especificado");
            }
            // adicionar veículo em Vagas
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
    }
}   