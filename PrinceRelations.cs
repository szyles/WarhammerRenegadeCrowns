using System;
using System.Collections.Generic;
using System.Text;

namespace KsiestwaGraniczne
{
    class PrinceRelations
    {
        public static void PrinceRelationsGen(int iNumberOfDuchies)
        {
            Random generator = new Random();
            string[,] PrinceRelations = new string[3,iNumberOfDuchies];
            int iNumberOfDuchies2 = iNumberOfDuchies - 1;

            for(int i = 0; i < iNumberOfDuchies2; i++)
            {
                int iRelationTypeGen = generator.Next(1, 11);
                int iRelationTypeGen2 = generator.Next(1, 11);
                int iRelationTypeGen3 = generator.Next(1, 11);
                switch (iRelationTypeGen)
                {
                    case 1:
                        PrinceRelations[1, i] = "Typ relacji: Gorycz";
                        switch (iRelationTypeGen2)
                        {
                            case 1: case 2:
                                PrinceRelations[2, i] = "Przyczyna: Niechciane dziecko";
                                break;
                            case 3: case 4:
                                PrinceRelations[2, i] = "Przyczyna: Niekorzystna umowa";
                                break;
                            case 5: case 6:
                                PrinceRelations[2, i] = "Przyczyna: Odrzucona miłość";
                                break;
                            case 7: case 8:
                                PrinceRelations[2, i] = "Przyczyna: Skradzione dziedzictwo";
                                break;
                            case 9: case 10:
                                PrinceRelations[2, i] = "Przyczyna: Zdrada";
                                break;
                        }
                        break;
                    case 2:
                        PrinceRelations[1, i] = "Typ relacji: Nienawiść";
                        switch (iRelationTypeGen2)
                        {
                            case 1:
                            case 2:
                                PrinceRelations[2, i] = "Przyczyna: Religia";
                                break;
                            case 3:
                            case 4:
                                PrinceRelations[2, i] = "Przyczyna: Upokorzenie";
                                break;
                            case 5:
                            case 6:
                                PrinceRelations[2, i] = "Przyczyna: Uprzedzenia";
                                break;
                            case 7:
                            case 8:
                                PrinceRelations[2, i] = "Przyczyna: Utracona przyjaźń";
                                break;
                            case 9:
                            case 10:
                                PrinceRelations[2, i] = "Przyczyna: Zdrada";
                                break;
                        }
                        break;
                    case 3:
                        PrinceRelations[1, i] = "Typ relacji: Pogarda";
                        switch (iRelationTypeGen2)
                        {
                            case 1:
                            case 2:
                                PrinceRelations[2, i] = "Przyczyna: Brak doświadczenia";
                                break;
                            case 3:
                            case 4:
                                PrinceRelations[2, i] = "Przyczyna: Dekadencja";
                                break;
                            case 5:
                            case 6:
                                PrinceRelations[2, i] = "Przyczyna: Porażka militarna";
                                break;
                            case 7:
                            case 8:
                                PrinceRelations[2, i] = "Przyczyna: Prawość";
                                break;
                            case 9:
                            case 10:
                                PrinceRelations[2, i] = "Przyczyna: Słabość";
                                break;
                        }
                        break;
                    case 4:
                        PrinceRelations[1, i] = "Typ relacji: Rywalizacja";
                        PrinceRelations[2, i] = "Przyczyna: ---";
                        break;
                    case 5:
                        PrinceRelations[1, i] = "Typ relacji: Sojusz";
                        switch (iRelationTypeGen2)
                        {
                            case 1:
                                PrinceRelations[2, i] = "Przyczyna: Dawna przyjaźń";
                                break;
                            case 2:
                                PrinceRelations[2, i] = "Przyczyna: Dyplomacja";
                                break;
                            case 3:
                                PrinceRelations[2, i] = "Przyczyna: Miłość";
                                break;
                            case 4:
                                PrinceRelations[2, i] = "Przyczyna: Nieoczekiwane wsparcie";
                                break;
                            case 5:
                                PrinceRelations[2, i] = "Przyczyna: Pokrewieństwo";
                                break;
                            case 6:
                                PrinceRelations[2, i] = "Przyczyna: Przepowiednia";
                                break;
                            case 7:
                                PrinceRelations[2, i] = "Przyczyna: Sytuacja patowa";
                                break;
                            case 8:
                                PrinceRelations[2, i] = "Przyczyna: Towarzysze broni";
                                break;
                            case 9:
                                PrinceRelations[2, i] = "Przyczyna: Własny biznes";
                                break;
                            case 10:
                                PrinceRelations[2, i] = "Przyczyna: Wspólny wróg";
                                break;
                        }
                        break;
                    case 6:
                        PrinceRelations[1, i] = "Typ relacji: Strach";
                        switch (iRelationTypeGen2)
                        {
                            case 1:
                            case 2:
                                PrinceRelations[2, i] = "Przyczyna: Agresja";
                                break;
                            case 3:
                            case 4:
                                PrinceRelations[2, i] = "Przyczyna: Bestialstwo";
                                break;
                            case 5:
                            case 6:
                                PrinceRelations[2, i] = "Przyczyna: Miażdzące zwycięstwo";
                                break;
                            case 7:
                            case 8:
                                PrinceRelations[2, i] = "Przyczyna: Potęga";
                                break;
                            case 9:
                            case 10:
                                PrinceRelations[2, i] = "Przyczyna: Wiedza";
                                break;
                        }
                        break;
                    case 7:
                        PrinceRelations[1, i] = "Typ relacji: Szacunek";
                        switch (iRelationTypeGen2)
                        {
                            case 1:
                            case 2:
                                PrinceRelations[2, i] = "Przyczyna: Pochodzenie";
                                break;
                            case 3:
                            case 4:
                                PrinceRelations[2, i] = "Przyczyna: Potęga";
                                break;
                            case 5:
                            case 6:
                                PrinceRelations[2, i] = "Przyczyna: Prawość";
                                break;
                            case 7:
                            case 8:
                                PrinceRelations[2, i] = "Przyczyna: Przetrwanie";
                                break;
                            case 9:
                            case 10:
                                PrinceRelations[2, i] = "Przyczyna: Spryt";
                                break;
                        }
                        break;
                    case 8:
                        PrinceRelations[1, i] = "Typ relacji: Wojna";
                        switch (iRelationTypeGen2)
                        {
                            case 1:
                            case 2:
                                switch (iRelationTypeGen3)
                                {
                                    case 1:
                                    case 2:
                                        PrinceRelations[2, i] = "Przyczyna: Nienawiść - Religia";
                                        break;
                                    case 3:
                                    case 4:
                                        PrinceRelations[2, i] = "Przyczyna: Nienawiść - Upokorzenie";
                                        break;
                                    case 5:
                                    case 6:
                                        PrinceRelations[2, i] = "Przyczyna: Nienawiść - Uprzedzenia";
                                        break;
                                    case 7:
                                    case 8:
                                        PrinceRelations[2, i] = "Przyczyna: Nienawiść - Utracona przyjaźń";
                                        break;
                                    case 9:
                                    case 10:
                                        PrinceRelations[2, i] = "Przyczyna: Nienawiść - Zdrada";
                                        break;
                                }
                                break;
                            case 3:
                            case 4:
                                PrinceRelations[2, i] = "Przyczyna: Podbój";
                                break;
                            case 5:
                            case 6:
                                switch (iRelationTypeGen3)
                                {
                                    case 1:
                                    case 2:
                                        PrinceRelations[2, i] = "Przyczyna: Strach - Agresja";
                                        break;
                                    case 3:
                                    case 4:
                                        PrinceRelations[2, i] = "Przyczyna: Strach - Bestialstwo";
                                        break;
                                    case 5:
                                    case 6:
                                        PrinceRelations[2, i] = "Przyczyna: Strach - Miażdzące zwycięstwo";
                                        break;
                                    case 7:
                                    case 8:
                                        PrinceRelations[2, i] = "Przyczyna: Strach - Potęga";
                                        break;
                                    case 9:
                                    case 10:
                                        PrinceRelations[2, i] = "Przyczyna: Strach - Wiedza";
                                        break;
                                }
                                break;
                            case 7:
                            case 8:
                                switch (iRelationTypeGen3)
                                {
                                    case 1:
                                    case 2:
                                        PrinceRelations[2, i] = "Przyczyna: Zawiść - Bogactwo";
                                        break;
                                    case 3:
                                    case 4:
                                        PrinceRelations[2, i] = "Przyczyna: Zawiść - Księstwo";
                                        break;
                                    case 5:
                                    case 6:
                                        PrinceRelations[2, i] = "Przyczyna: Zawiść - Reputacja";
                                        break;
                                    case 7:
                                    case 8:
                                        PrinceRelations[2, i] = "Przyczyna: Zawiść - Urodziwa małżonka";
                                        break;
                                    case 9:
                                    case 10:
                                        PrinceRelations[2, i] = "Przyczyna: Zawiść - Władza";
                                        break;
                                }
                                break;
                            case 9:
                            case 10:
                                switch (iRelationTypeGen3)
                                {
                                    case 1:
                                    case 2:
                                        PrinceRelations[2, i] = "Przyczyna: Zemsta - Bestialstwo";
                                        break;
                                    case 3:
                                    case 4:
                                        PrinceRelations[2, i] = "Przyczyna: Zemsta - Obraza";
                                        break;
                                    case 5:
                                    case 6:
                                        PrinceRelations[2, i] = "Przyczyna: Zemsta - Porażka";
                                        break;
                                    case 7:
                                    case 8:
                                        PrinceRelations[2, i] = "Przyczyna: Zemsta - Upokorzenie";
                                        break;
                                    case 9:
                                    case 10:
                                        PrinceRelations[2, i] = "Przyczyna: Zemsta - Zdrada";
                                        break;
                                }
                                break;
                        }
                        break;
                    case 9:
                        PrinceRelations[1, i] = "Typ relacji: Zawiść";
                        switch (iRelationTypeGen2)
                        {
                            case 1:
                            case 2:
                                PrinceRelations[2, i] = "Przyczyna: Bogactwo";
                                break;
                            case 3:
                            case 4:
                                PrinceRelations[2, i] = "Przyczyna: Księstwo";
                                break;
                            case 5:
                            case 6:
                                PrinceRelations[2, i] = "Przyczyna: Reputacja";
                                break;
                            case 7:
                            case 8:
                                PrinceRelations[2, i] = "Przyczyna: Urodziwa małżonka";
                                break;
                            case 9:
                            case 10:
                                PrinceRelations[2, i] = "Przyczyna: Władza";
                                break;
                        }
                        break;
                    case 10:
                        PrinceRelations[1, i] = "Typ relacji: Zemsta";
                        switch (iRelationTypeGen2)
                        {
                            case 1:
                            case 2:
                                PrinceRelations[2, i] = "Przyczyna: Bestialstwo";
                                break;
                            case 3:
                            case 4:
                                PrinceRelations[2, i] = "Przyczyna: Obraza";
                                break;
                            case 5:
                            case 6:
                                PrinceRelations[2, i] = "Przyczyna: Porażka";
                                break;
                            case 7:
                            case 8:
                                PrinceRelations[2, i] = "Przyczyna: Upokorzenie";
                                break;
                            case 9:
                            case 10:
                                PrinceRelations[2, i] = "Przyczyna: Zdrada";
                                break;
                        }
                        break;
                }

                int iRelationDurationGen = generator.Next(1, 101);
                switch (iRelationDurationGen)
                {
                    case int n when (n <= 10):
                        PrinceRelations[0, i] = "Czas trwania: 6 miesięcy";
                        break;
                    case int n when (n >= 11 && n <= 30):
                        PrinceRelations[0, i] = "Czas trwania: 1 rok";
                        break;
                    case int n when (n >= 31 && n <= 60):
                        PrinceRelations[0, i] = "Czas trwania: 2 lata";
                        break;
                    case int n when (n >= 61 && n <= 75):
                        PrinceRelations[0, i] = "Czas trwania: 5 lat";
                        break;
                    case int n when (n >= 76 && n <= 85):
                        PrinceRelations[0, i] = "Czas trwania: 10 lat";
                        break;
                    case int n when (n >= 86 && n <= 90):
                        PrinceRelations[0, i] = "Czas trwania: 15 lat";
                        break;
                    case int n when (n >= 91 && n <= 94):
                        PrinceRelations[0, i] = "Czas trwania: 20 lat";
                        break;
                    case int n when (n >= 95 && n <= 97):
                        PrinceRelations[0, i] = "Czas trwania: 25 lat";
                        break;
                    case int n when (n == 98):
                        PrinceRelations[0, i] = "Czas trwania: 30 lat";
                        break;
                    case int n when (n == 99):
                        PrinceRelations[0, i] = "Czas trwania: 40 lat";
                        break;
                    case int n when (n == 100):
                        PrinceRelations[0, i] = "Czas trwania: 50 lat";
                        break;
                }

            }

            using (System.IO.StreamWriter file = new System.IO.StreamWriter(@"C:\Ksiestwa graniczne\KsiestwaGraniczne.txt", true))
            {
                file.WriteLine("Relacje");
                file.WriteLine("=======");
            }

            for (int i = 0; i < iNumberOfDuchies2; i++)
            {
                using (System.IO.StreamWriter file = new System.IO.StreamWriter(@"C:\Ksiestwa graniczne\KsiestwaGraniczne.txt", true))
                {
                    file.WriteLine(PrinceRelations[1, i]);
                    file.WriteLine(PrinceRelations[2, i]);
                    file.WriteLine(PrinceRelations[0, i]);
                    file.WriteLine("-----");
                    file.WriteLine(" ");
                }
            }

        }
    }
}
