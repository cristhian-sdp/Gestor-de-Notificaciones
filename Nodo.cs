namespace CasoPracticoS1
{
    public class Nodo
    {
        public int Monto { get; set; }
        public Nodo Siguiente { get; set; }

        public Nodo(int monto)
        {
            Monto = monto;
            Siguiente = null;
        }
    }
}