﻿namespace lab2
{
    internal class Programm
    {
        public static void Main(string[] args)
        {
            var size = 4; //size in bytes
            var sizeOfWord = 5;
            var shaXX = new ShaXx(size);
            var randomArray = shaXX.RandomByteGenerator(sizeOfWord);
            Algorythm.HappyBirthday(size, randomArray);
            Console.Out.WriteLine();
        }
    }
};