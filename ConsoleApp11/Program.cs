namespace ConsoleApp11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double radio = 5;
            Procesos pr = new Procesos();
            Console.WriteLine(pr.AreaCirculo(radio));

            Circulo elCirculo = new Circulo(radio);
            Console.WriteLine(elCirculo.AreaCirculo());


        }
    }

    public class Procesos
    {
        public double AreaCirculo(double radio)
        {
            return Math.PI * Math.Pow(radio,2);
        }
    }

    public class Circulo
    {
        private double radio;
        public Circulo(double elRadio)
        {
            radio = elRadio;
        }
        public double AreaCirculo()
        {
            return Math.PI * Math.Pow(radio, 2);
        }
    }
}