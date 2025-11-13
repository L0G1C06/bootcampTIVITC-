using Xunit;
using Pratica1Estacionamento.Models;

namespace Pratica1Estacionamento.Tests
{
    public class EstacionamentoTests
    {
        // Teste 1: Adicionar veículo com sucesso
        [Fact]
        public void AdicionarVeiculo_CarroPequeno_DeveAdicionarComSucesso()
        {
            // Arrange
            var estacionamento = new Estacionamento();
            
            // Act
            var resultado = estacionamento.AdicionarVeiculo("carro", "pequeno", "A1");
            
            // Assert
            Assert.True(resultado);
            Assert.Single(estacionamento.Vagas);
        }

        // Teste 2: Adicionar moto com sucesso
        [Fact]
        public void AdicionarVeiculo_Moto_DeveAdicionarComSucesso()
        {
            // Arrange
            var estacionamento = new Estacionamento();
            
            // Act
            var resultado = estacionamento.AdicionarVeiculo("moto", string.Empty, "B1");
            
            // Assert
            Assert.True(resultado);
            Assert.NotNull(estacionamento.Vagas);
            Assert.Single(estacionamento.Vagas);
        }

        // Teste 3: Tentar adicionar veículo em vaga ocupada
        [Fact]
        public void AdicionarVeiculo_VagaOcupada_DeveRetornarFalse()
        {
            // Arrange
            var estacionamento = new Estacionamento();
            estacionamento.AdicionarVeiculo("carro", "medio", "C1");
            
            // Act
            var resultado = estacionamento.AdicionarVeiculo("carro", "pequeno", "C1");
            
            // Assert
            Assert.False(resultado);
        }

        // Teste 4: Adicionar moto com tamanho (deve falhar)
        [Fact]
        public void AdicionarVeiculo_MotoComTamanho_DeveRetornarFalse()
        {
            // Arrange
            var estacionamento = new Estacionamento();
            
            // Act
            var resultado = estacionamento.AdicionarVeiculo("moto", "pequeno", "D1");
            
            // Assert
            Assert.False(resultado);
        }

        // Teste 5: Adicionar carro sem tamanho (deve falhar)
        [Fact]
        public void AdicionarVeiculo_CarroSemTamanho_DeveRetornarFalse()
        {
            // Arrange
            var estacionamento = new Estacionamento();
            
            // Act
            var resultado = estacionamento.AdicionarVeiculo("carro", string.Empty, "E1");
            
            // Assert
            Assert.False(resultado);
        }

        // Teste 6: Calcular valor para moto
        [Theory]
        [InlineData(1, 2.50)]
        [InlineData(2, 5.00)]
        [InlineData(5, 12.50)]
        public void ValorPago_Moto_DeveCalcularCorretamente(int horas, decimal valorEsperado)
        {
            // Arrange
            var estacionamento = new Estacionamento();
            
            // Act
            var valor = estacionamento.ValorPago("moto-A1", horas);
            
            // Assert
            Assert.Equal(valorEsperado, valor);
        }

        // Teste 7: Calcular valor para carro pequeno
        [Theory]
        [InlineData(1, 7.00)]  // 5.00 + 2.00
        [InlineData(2, 14.00)] // 10.00 + 4.00
        public void ValorPago_CarroPequeno_DeveCalcularCorretamente(int horas, decimal valorEsperado)
        {
            // Arrange
            var estacionamento = new Estacionamento();
            
            // Act
            var valor = estacionamento.ValorPago("carro-pequeno-A1", horas);
            
            // Assert
            Assert.Equal(valorEsperado, valor);
        }

        // Teste 8: Calcular valor para carro médio
        [Theory]
        [InlineData(1, 8.00)]  // 5.00 + 3.00
        [InlineData(3, 24.00)] // 15.00 + 9.00
        public void ValorPago_CarroMedio_DeveCalcularCorretamente(int horas, decimal valorEsperado)
        {
            // Arrange
            var estacionamento = new Estacionamento();
            
            // Act
            var valor = estacionamento.ValorPago("carro-medio-B1", horas);
            
            // Assert
            Assert.Equal(valorEsperado, valor);
        }

        // Teste 9: Calcular valor para carro grande
        [Theory]
        [InlineData(1, 9.00)]  // 5.00 + 4.00
        [InlineData(4, 36.00)] // 20.00 + 16.00
        public void ValorPago_CarroGrande_DeveCalcularCorretamente(int horas, decimal valorEsperado)
        {
            // Arrange
            var estacionamento = new Estacionamento();
            
            // Act
            var valor = estacionamento.ValorPago("carro-grande-C1", horas);
            
            // Assert
            Assert.Equal(valorEsperado, valor);
        }

        // Teste 10: Remover veículo com sucesso
        [Fact]
        public void RemoverVeiculo_VagaExistente_DeveRemoverComSucesso()
        {
            // Arrange
            var estacionamento = new Estacionamento();
            estacionamento.AdicionarVeiculo("carro", "pequeno", "F1");
            
            // Act
            estacionamento.RemoverVeiculos("F1", 2);
            
            // Assert
            Assert.Empty(estacionamento.Vagas);
        }

        // Teste 11: Tentar remover veículo de vaga vazia
        [Fact]
        public void RemoverVeiculo_VagaVazia_NaoDeveFalhar()
        {
            // Arrange
            var estacionamento = new Estacionamento();
            
            // Act & Assert (não deve lançar exceção)
            estacionamento.RemoverVeiculos("G1", 1);
        }

        // Teste 12: Listar veículos quando não há nenhum
        [Fact]
        public void ListarVeiculos_EstacionamentoVazio_NaoDeveFalhar()
        {
            // Arrange
            var estacionamento = new Estacionamento();
            
            // Act & Assert (não deve lançar exceção)
            estacionamento.ListarVeiculos();
        }

        // Teste 13: Listar múltiplos veículos
        [Fact]
        public void ListarVeiculos_MultiplosVeiculos_DeveListarTodos()
        {
            // Arrange
            var estacionamento = new Estacionamento();
            estacionamento.AdicionarVeiculo("carro", "pequeno", "H1");
            estacionamento.AdicionarVeiculo("moto", string.Empty, "H2");
            estacionamento.AdicionarVeiculo("carro", "grande", "H3");
            
            // Act & Assert
            Assert.NotNull(estacionamento.Vagas);
            Assert.Equal(3, estacionamento.Vagas.Count);
        }

        // Teste 14: Adicionar tamanho inválido
        [Fact]
        public void AdicionarVeiculo_TamanhoInvalido_DeveRetornarFalse()
        {
            // Arrange
            var estacionamento = new Estacionamento();
            
            // Act
            var resultado = estacionamento.AdicionarVeiculo("carro", "gigante", "I1");
            
            // Assert
            Assert.False(resultado);
        }
    }
}