namespace DesafioProjetoHospedagem.Models
{
    public class Reserva
    {
        private List<Pessoa> Hospedes = new List<Pessoa>();
        public Suite Suite { get; set; }
        public int DiasReservados { get; set; }

        public Reserva() { }

        public Reserva(int diasReservados)
        {
            DiasReservados = diasReservados;
        }

        public void CadastrarHospedes(string nome, string sobrenome)
        {
            // TODO: Verificar se a capacidade é maior ou igual ao número de hóspedes sendo recebido
            // *IMPLEMENTE AQUI*
            if (Suite.Capacidade >= Hospedes.Count)
            {
                Pessoa hospede = new Pessoa(nome, sobrenome);
                Hospedes.Add(hospede);
                System.Console.WriteLine($"Hóspede {hospede.NomeCompleto} cadastrado com sucesso!");
            }
            else
            {
                throw new Exception("A capacidade é menor que o número de hóspedes sendo recebido.");
            }
        }

        public void CadastrarSuite(Suite suite)
        {
            Suite = suite;
        }

        public int ObterQuantidadeHospedes()
        {

            int TotalHospedes = Hospedes.Count();

            return TotalHospedes;
        }

        public decimal CalcularValorDiaria()
        {
            // TODO: Retorna o valor da diária
            // Cálculo: DiasReservados X Suite.ValorDiaria
            // *IMPLEMENTE AQUI*
            decimal valor = DiasReservados * Suite.ValorDiaria;

            // Regra: Caso os dias reservados forem maior ou igual a 10, conceder um desconto de 10%
            // *IMPLEMENTE AQUI*
            if (DiasReservados >= 10)
            {
                valor -= (valor * 0.10M);
                System.Console.WriteLine("Desconto de 10% aplicado!");
            }

            return valor;
        }
    }
}