using System;


namespace NigeriaZipCodeChecker
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write($"Enter Your Name: ");
            string name = Console.ReadLine();

            Console.WriteLine($"Welcome {name}");

            Console.Write($"Enter name of City in Lagos: ");
            string cityName = Console.ReadLine();
            Console.Clear();

            if (cityName == "Ajeromi Ifelodun" || cityName == "ajeromi ifelodun")
            {
                AjeromiIfelodunLGA();
            }

            //else if ()
            //{

            //}
        }

        public static void AjeromiIfelodunLGA()
        {
            Console.WriteLine("District Name: District: Ajeromi" +
                "\r\nLocal Government Area: Ajeromi Ifelodun L.G.A" +
                "\r\nState: Lagos State" +

                "\r\nAssociated Zip Code: 102103" +
                "\r\nAiyetoro Ajeromi 102103" +
                "\r\nAraromi Ajeromi 102103" +
                "\r\nAshafa 102103" +
                "\r\nAwodi 102103" +
                "\r\nCardoso 102103" +
                "\r\nLayeni 102103" +
                "\r\nOnibaba 102103" +
                "\r\nOrodu 102103" +
                "\r\nTemidire 102103" +
                "\r\nTolu 102103");
        }
    }

}
