namespace lab2
{
    internal class Programm
    {
        public static void Main(string[] args)
        {
            var size = 4; // size of return byte[] sha256. Trim sha256
            var sizeOfWord = 4; // 
            var shaXX = new ShaXx(size); // 
            var randomArray = shaXX.RandomByteGenerator(sizeOfWord);
            Algorythm.HappyBirthday(size, randomArray);
            Console.Out.WriteLine();
        }
    }
}
