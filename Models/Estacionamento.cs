namespace DesafioFundamentos.Models
{
    public class Estacionamento
    {
        private decimal _initialPrice = 0;
        private decimal _pricePerHour = 0;
        private List<string> _veiculos = new ();

        public Estacionamento(decimal initialPrice, decimal pricePerHour)
        {
            _initialPrice = initialPrice;
            _pricePerHour = pricePerHour;
        }

        public void AdicionarVeiculo()
        {
            // TODO: Pedir para o usuário digitar uma placa (ReadLine) e adicionar na lista "veiculos"
            while (true)
            {
                Console.WriteLine("Digite a placa do veículo para estacionar:");
                var licensePlate = Console.ReadLine();

                if (licensePlate is not { Length: 8 }) continue;
                
                _veiculos.Add(licensePlate);
                break;
            }
        }

        public void RemoverVeiculo()
        {
            // TODO: Pedir para o usuário digitar a quantidade de horas que o veículo permaneceu estacionado,
            // TODO: Realizar o seguinte cálculo: "precoInicial + precoPorHora * horas" para a variável valorTotal               
            // TODO: Remover a placa digitada da lista de veículos
            
            Console.WriteLine("Digite a placa do veículo para remover:");
            string plate = "";
            plate = Console.ReadLine();
            
            if (!ExistsVehicle(plate))
                Console.WriteLine("Desculpe, esse veículo não está estacionado aqui. Confira se digitou a placa corretamente");
            else
            {
                Console.WriteLine("Informe a quantidade de horas que o veículo permaneceu estacionado:");
                var parkedTime = Convert.ToInt32(Console.ReadLine());
                
                decimal totalValue = 0; 
                totalValue = _initialPrice + (_pricePerHour * parkedTime);
                _veiculos.Remove(plate);

                Console.WriteLine($"O veículo {plate} foi removido e o preço total foi de: R$ {totalValue}");
            }
        }

        private bool ExistsVehicle(string plate)
        {
            return _veiculos.Any(x => x.Contains(plate));
        }

        public void ListarVeiculos()
        {
            // TODO: Realizar um laço de repetição, exibindo os veículos estacionados
            if (! _veiculos.Any())
                Console.WriteLine("Não há veículos estacionados.");
            
            Console.WriteLine("Os veículos estacionados são:");
            foreach (var carro in _veiculos)
            {
                Console.WriteLine(carro);
            }
        }
    }
}