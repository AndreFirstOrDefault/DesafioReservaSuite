namespace Models
{
    
    public class Reserva
    {
        public List<Pessoa> Hospedes { get; set; }

        public Suite Suite;
        public int DiasReservados{ get; set; }  

        public Reserva(int diasReservados)
        {
            DiasReservados = diasReservados; 
        }
        public void CadastrarHospedes(List<Pessoa> hospedes)
        {
            if(hospedes.Count > Suite.Capacidade)
            {
                throw new Exception("A quantidade de hospedes não pode ser maior do que a capacidade da suite.");
            }
            Hospedes = new List<Pessoa>(hospedes);           
        }

        public void CadastrarSuite(Suite suite)
        {
            Suite  = new Suite(suite.TipoSuite, suite.Capacidade, suite.ValorDiaria);
        }

        public int ObterQuantidadeHospedes()
        {
            return Hospedes.Count;
        }

        public decimal CalcularValorDiaria()
        {
            if(DiasReservados >= 10)
            {
                return DiasReservados * Suite.ValorDiaria * 0.9M ;
            }
            else
            {
                return DiasReservados * Suite.ValorDiaria ;
            }
        }
    }
}