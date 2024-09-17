using System;

class Program
{
        static void Main(string[] args)
        {
        Console.WriteLine("Quantas Marias Moles foram comidas?");
        Console.WriteLine("7");
        Console.WriteLine("Quem comeu mais?");
        int mmcomidas = 7;
        string nome;
            if (mmcomidas <= 2)
            {
                nome = "Ryan";
            }
            else if (mmcomidas > 2 && mmcomidas <= 5)
            {
                nome = "Pai";  
            }
            else if(mmcomidas > 5 && mmcomidas < 21)
            {
                nome = "Mãe";
            }
            else if (mmcomidas == 21){
              
                nome = "Fernanda";
            }
            else
            {
                nome = "tomtomm";
            } 
            var quemfoi = nome;
                switch (quemfoi)
                {
                    case "Fernanda": Console.WriteLine ("Foi a Fernanda! Ela comeu 21!"); break;
                    case "Mãe": Console.WriteLine ("Foi a Mãe que comeu entre 6 a 20"); break;
                    case "Pai": Console.WriteLine ("Foi o Pai, que comeu entre 3 e 5"); break;
                    case "Ryan": Console.WriteLine ("Não fui eu"); break;
                    default: Console.WriteLine ("Eh u tomotom"); break;
                }
        }

}