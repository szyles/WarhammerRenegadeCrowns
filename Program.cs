using System;
using System.IO;

namespace KsiestwaGraniczne
{
    class Program
    {
        static void Main(string[] args)
        {

            string folderName = @"C:\Ksiestwa graniczne";
            System.IO.Directory.CreateDirectory(folderName);
            Console.WriteLine("Podaj ilosc ksiestw jakie chcesz utworzyc");
            int iNumberOfDuchies = Convert.ToInt32(Console.ReadLine());
            string fileName = "KsiestwaGraniczne.txt";
            TerrainCreator.TerrainCreatorGen();
            PrinceCreator.PrinceCreatorGen(iNumberOfDuchies);
            for(int o = 0; o < iNumberOfDuchies; o++)
            {
                DuchyCreator.DuchyCreatorGen(iNumberOfDuchies);
            }
        }
    }
}