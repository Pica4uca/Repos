namespace Number
{
    public class Numb
    {
        public static void Main(string[] args) {
            int expected = 0;
            Numb num = new Numb();
            int actual = 1;
            actual = num.rnd();
            Console.WriteLine(actual);
        }
        public int rnd()
        {
           Random random = new Random();
            int num = random.Next(1,9999999);            
            return num;
            
        }
        
    }
}
