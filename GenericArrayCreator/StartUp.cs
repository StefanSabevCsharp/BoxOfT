namespace GenericArrayCreator
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            
            string[] strings = ArrayCreator<string>.Create(5, "Pesho");
            int[] integers = ArrayCreator<int>.Create(10, 33);

            Console.WriteLine(string.Join(" ",strings));
            Console.WriteLine(string.Join(" ", integers));


        }
    }
}