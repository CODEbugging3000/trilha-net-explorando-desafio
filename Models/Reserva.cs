using System.Linq.Expressions;

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
            // DONE
            if (Suite.Capacidade >= hospedes.Count)
            {
                Hospedes = hospedes;
            }
            else
            {
                // DONE
                throw new Exception("Ocorreu algo inesperado, A quantidade de hospedes cadastrados é maior que a capacidade da suíte");
            }
        }

        public void CadastrarSuite(Suite suite)
        {
            Suite = suite;
        }

        public int ObterQuantidadeHospedes()
        {
            // DONE
            return Hospedes.Count;
        }

        public decimal CalcularValorDiaria()
        {
            // DONE
            decimal valor = Suite.ValorDiaria * DiasReservados;

            // DONE
            if (DiasReservados >= 10)
            {
                valor -= valor * 0.1M;
            }
            return valor;
        }
    }
}