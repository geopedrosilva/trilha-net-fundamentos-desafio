using System;
using System.Collections.Generic;

namespace DesafioFundamentos.Models
{
    public class Estacionamento
    {
        private decimal precoInicial;
        private decimal precoPorHora;
        private List<string> veiculos = new List<string>();

        public Estacionamento(decimal precoInicial, decimal precoPorHora)
        {
            this.precoInicial = precoInicial;
            this.precoPorHora = precoPorHora;
        }

        public void AdicionarVeiculo()
        {
            Console.WriteLine("Digite a placa do veículo:");
            string placa = Console.ReadLine();

            veiculos.Add(placa);

            Console.WriteLine("Veículo cadastrado com sucesso!");
        }

        public void RemoverVeiculo()
        {
            Console.WriteLine("Digite a placa do veículo:");
            string placa = Console.ReadLine();

            if (veiculos.Contains(placa))
            {
                Console.WriteLine("Quantas horas o veículo ficou estacionado?");
                int horas = int.Parse(Console.ReadLine());

                decimal valor = precoInicial + precoPorHora * horas;

                Console.WriteLine("O valor cobrado foi de {0} reais", valor);

                veiculos.Remove(placa);
            }
            else
            {
                Console.WriteLine("Veículo não encontrado");
            }
        }

        public void ListarVeiculos()
        {
            if (veiculos.Count == 0)
            {
                Console.WriteLine("Não há veículos estacionados");
            }
            else
            {
                foreach (string placa in veiculos)
                {
                    Console.WriteLine(placa);
                }
            }
        }
    }
}
