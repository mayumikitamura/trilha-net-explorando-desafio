using System.Security.Cryptography.X509Certificates;

namespace DesafioProjetoHospedagem.Models
{
    public class Reserva
    {
        public List<Pessoa> Hospedes { get; set; }
        public Suite Suite { get; set; }
        public int DiasReservados { get; set; }

        public Reserva() { }

        public Reserva(int diasReservados)
        {
            DiasReservados = diasReservados;
        }

        public void CadastrarHospedes(List<Pessoa> hospedes)
        {
            
            bool SuiteComporta = hospedes.Count <= Suite.Capacidade;




            if (SuiteComporta)
            {
                Hospedes = hospedes;
            }
            else
            {
               
                Console.WriteLine("A suíte não comporta a quantidade de hóspedes. Verifique outra acomodação.");
            }
        }

        public void CadastrarSuite(Suite suite)
        {
            Suite = suite;
        }

        public int ObterQuantidadeHospedes()
        {
            
        
            {
                Console.WriteLine($"QuantidadedeHospedes: {Hospedes.Count}");
            }

            return Hospedes.Count;
        }

        public decimal CalcularValorDiaria()
        {
            
        
            
            decimal valorBruto = DiasReservados * Suite.ValorDiaria;
            decimal valorFinal;
          
            if (DiasReservados >= 10)
            {
                decimal desconto = (valorBruto * 10) / 100;
                valorFinal = valorBruto - desconto;
            }

            else
            {
                valorFinal = valorBruto;
            }
        
            
            return valorFinal;
        }
    }
}