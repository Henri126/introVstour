namespace HindrekoBB
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            int käimsolevAasta = 2025;
            int olenNiiVana = 18;
            int tehteTulemus = käimsolevAasta + olenNiiVana;

            //float pikkus = 2.3f;

            string sõnum = "Teie vanus on: ";


            //bool miskion = false;
            // CTRL K C
            //Console.WriteLine(sõnum+tehteTulemus);
            //Console.WriteLine(sõnum);
            //Console.WriteLine("oooooo");
            //Console.WriteLine(sõnum);
            //Console.WriteLine(sõnum);
            */

            int arv1 = 0;
            int arv2 = 0;
            Console.WriteLine("Tere, palun sisesta esimene arv: ");
            arv1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Tere, palun sisesta esimene arv: ");
            arv2 = int.Parse(Console.ReadLine());
            int liitmine = arv1 + arv2;
            Console.WriteLine("Missugune tehet soovid teha? Kirjuta kas: + - / * ^");
            string tehtetüüp = Console.ReadLine();
            int tehe = 0;




            if ( tehtetüüp == "+")
            {
                tehe = arv1 + arv2;
               
            }

            if (tehtetüüp == "-")
            {
                tehe = arv1 - arv2;
            }

            if (tehtetüüp == "/")
            {
                tehe = arv1 / arv2;
            }

            if (tehtetüüp == "*")
            {
                tehe = arv1 * arv2;
            }

            if (tehtetüüp == "^")
            {
                tehe = (int)Math.Pow(arv1,arv2);
            }

            


            Console.WriteLine($"{tehtetüüp} tehte tulemus: {tehe}");


            //int lahutav1 = 0;
            //int lahutav2 = 0;
            //Console.WriteLine("Tere, palun sisesta esimene lauhutav: ");
            //lahutav1 = int.Parse(Console.ReadLine());
            //Console.WriteLine("Tere, palun sisesta esimene lauhutav: ");
            //lahutav2 = int.Parse(Console.ReadLine());
            //int lahutamine = lahutav1 - lahutav2;
            //Console.WriteLine($"tehte tulemus: {lahutamine}");

            //int jagatav1 = 0;
            //int jagatav2 = 0;
            //Console.WriteLine("Tere, palun sisesta esimene jagatis: ");
            //jagatav1 = int.Parse(Console.ReadLine());
            //Console.WriteLine("Tere, palun sisesta esimene jagatis: ");
            //jagatav2 = int.Parse(Console.ReadLine());
            //int jagamine = jagatav1 / jagatav2;
            //Console.WriteLine($"tehte tulemus: {jagamine}");

            //int Korrutis1 = 0;
            //int korrutis2 = 0;
            //Console.WriteLine("Tere, palum sisesta esimene korrutis:");
            //Korrutis1 = int.Parse(Console.ReadLine());
            //Console.WriteLine("Tere, palun sisesta esimene jagatis: ");
            //korrutis2 = int.Parse(Console.ReadLine());
            //int korrutamine = Korrutis1 * korrutis2;
            //Console.WriteLine($"tehte tulemus: {korrutamine}");





            // + liitame 
            // - lahutamine 
            // / jagamine 
            // * korrutamine 

        }
    }
}
