using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace KsiestwaGraniczne
{
    public class AncientRuinCreator
    {
        public static void AncientRuinCreatorGen()
        {
            Random generator = new Random();
            int iNumberOfRuinsGen = 0;
            iNumberOfRuinsGen = generator.Next(1, 11);
            string[] RuinType = new string[iNumberOfRuinsGen];
            string[] TypeOfThreat = new string[iNumberOfRuinsGen];
            string[] OriginalPurposeOfRuins = new string[iNumberOfRuinsGen];
            string[] ReasonOfRuins = new string[iNumberOfRuinsGen];
            string[] AgeOfRuins = new string[iNumberOfRuinsGen];
            int iRuinTypeValue = 0;

            for(int i = 0; i < iNumberOfRuinsGen; i++)
            {
                int iRuinTypeGen = generator.Next(1, 101);
                switch (iRuinTypeGen)
                {
                    case int n when (n <= 20):
                        RuinType[i] = "Typ swiatyni: Arabska";
                        iRuinTypeValue = 1;
                        break;
                    case int n when (n >= 21 && n <= 30):
                        RuinType[i] = "Typ swiatyni: Chaos";
                        iRuinTypeValue = 2;
                        break;
                    case int n when (n >= 31 && n <= 50):
                        RuinType[i] = "Typ swiatyni: Khmeryjska";
                        iRuinTypeValue = 3;
                        break;
                    case int n when (n >= 51 && n <= 65):
                        RuinType[i] = "Typ swiatyni: Krasnoludzka";
                        iRuinTypeValue = 4;
                        break;
                    case int n when (n >= 66 && n <= 90):
                        RuinType[i] = "Typ swiatyni: Ludzka";
                        iRuinTypeValue = 5;
                        break;
                    case int n when (n >= 91 && n <= 100):
                        RuinType[i] = "Typ swiatyni: Inne";
                        iRuinTypeValue = 6;
                        break;
                }

                int iTypeOfThreatGen = generator.Next(1, 101);
                switch (iRuinTypeValue)
                {
                    case 1:
                        switch (iTypeOfThreatGen)
                        {
                            case int n when (n >= 1 && n <= 5):
                                TypeOfThreat[i] = "Zagrożenie: Brak";
                                break;
                            case int n when (n >= 6 && n <= 30):
                                TypeOfThreat[i] = "Zagrożenie: Demon";
                                break;
                            case int n when (n >= 31 && n <= 40):
                                TypeOfThreat[i] = "Zagrożenie: Ożywieńcy";
                                break;
                            case int n when (n >= 41 && n <= 50):
                                TypeOfThreat[i] = "Zagrożenie: Rój";
                                break;
                            case int n when (n >= 51 && n <= 80):
                                TypeOfThreat[i] = "Zagrożenie: Tubylcy";
                                break;
                            case int n when (n >= 81 && n <= 100):
                                TypeOfThreat[i] = "Zagrożenie: Zaraza";
                                break;
                        }
                        break;
                    case 2:
                        switch (iTypeOfThreatGen)
                        {
                            case int n when (n >= 1 && n <= 5):
                                TypeOfThreat[i] = "Zagrożenie: Brak";
                                break;
                            case int n when (n >= 6 && n <= 25):
                                TypeOfThreat[i] = "Zagrożenie: Demon";
                                break;
                            case int n when (n >= 26 && n <= 35):
                                TypeOfThreat[i] = "Zagrożenie: Golem";
                                break;
                            case int n when (n >= 36 && n <= 45):
                                TypeOfThreat[i] = "Zagrożenie: Oręż";
                                break;
                            case int n when (n >= 46 && n <= 65):
                                TypeOfThreat[i] = "Zagrożenie: Ożywieńcy";
                                break;
                            case int n when (n >= 66 && n <= 80):
                                TypeOfThreat[i] = "Zagrożenie: Rój";
                                break;
                            case int n when (n >= 81 && n <= 85):
                                TypeOfThreat[i] = "Zagrożenie: Tubylcy";
                                break;
                            case int n when (n >= 86 && n <= 100):
                                TypeOfThreat[i] = "Zagrożenie: Zaraza";
                                break;
                        }
                        break;
                    case 3:
                        switch (iTypeOfThreatGen)
                        {
                            case int n when (n >= 1 && n <= 5):
                                TypeOfThreat[i] = "Zagrożenie: Brak";
                                break;
                            case int n when (n >= 6 && n <= 20):
                                TypeOfThreat[i] = "Zagrożenie: Demon";
                                break;
                            case int n when (n >= 21 && n <= 30):
                                TypeOfThreat[i] = "Zagrożenie: Oręż";
                                break;
                            case int n when (n >= 31 && n <= 55):
                                TypeOfThreat[i] = "Zagrożenie: Ożywieńcy";
                                break;
                            case int n when (n >= 56 && n <= 65):
                                TypeOfThreat[i] = "Zagrożenie: Rój";
                                break;
                            case int n when (n >= 66 && n <= 90):
                                TypeOfThreat[i] = "Zagrożenie: Tubylcy";
                                break;
                            case int n when (n >= 91 && n <= 100):
                                TypeOfThreat[i] = "Zagrożenie: Zaraza";
                                break;
                        }
                        break;
                    case 4:
                        switch (iTypeOfThreatGen)
                        {
                            case int n when (n >= 1 && n <= 5):
                                TypeOfThreat[i] = "Zagrożenie: Brak";
                                break;
                            case int n when (n >= 6 && n <= 10):
                                TypeOfThreat[i] = "Zagrożenie: Demon";
                                break;
                            case int n when (n >= 11 && n <= 35):
                                TypeOfThreat[i] = "Zagrożenie: Golem";
                                break;
                            case int n when (n >= 36 && n <= 55):
                                TypeOfThreat[i] = "Zagrożenie: Oręż";
                                break;
                            case int n when (n >= 56 && n <= 75):
                                TypeOfThreat[i] = "Zagrożenie: Rój";
                                break;
                            case int n when (n >= 76 && n <= 100):
                                TypeOfThreat[i] = "Zagrożenie: Zaraza";
                                break;
                        }
                        break;
                    case 5:
                        switch (iTypeOfThreatGen)
                        {
                            case int n when (n >= 1 && n <= 5):
                                TypeOfThreat[i] = "Zagrożenie: Brak";
                                break;
                            case int n when (n >= 6 && n <= 20):
                                TypeOfThreat[i] = "Zagrożenie: Demon";
                                break;
                            case int n when (n >= 21 && n <= 30):
                                TypeOfThreat[i] = "Zagrożenie: Oręż";
                                break;
                            case int n when (n >= 31 && n <= 45):
                                TypeOfThreat[i] = "Zagrożenie: Ożywieńcy";
                                break;
                            case int n when (n >= 46 && n <= 55):
                                TypeOfThreat[i] = "Zagrożenie: Rój";
                                break;
                            case int n when (n >= 56 && n <= 80):
                                TypeOfThreat[i] = "Zagrożenie: Tubylcy";
                                break;
                            case int n when (n >= 81 && n <= 100):
                                TypeOfThreat[i] = "Zagrożenie: Zaraza";
                                break;
                        }
                        break;
                    case 6:
                        switch (iTypeOfThreatGen)
                        {
                            case int n when (n >= 1 && n <= 5):
                                TypeOfThreat[i] = "Zagrożenie: Brak";
                                break;
                            case int n when (n >= 6 && n <= 20):
                                TypeOfThreat[i] = "Zagrożenie: Demon";
                                break;
                            case int n when (n >= 21 && n <= 35):
                                TypeOfThreat[i] = "Zagrożenie: Golem";
                                break;
                            case int n when (n >= 36 && n <= 50):
                                TypeOfThreat[i] = "Zagrożenie: Oręż";
                                break;
                            case int n when (n >= 51 && n <= 55):
                                TypeOfThreat[i] = "Zagrożenie: Ożywieńcy";
                                break;
                            case int n when (n >= 56 && n <= 70):
                                TypeOfThreat[i] = "Zagrożenie: Rój";
                                break;
                            case int n when (n >= 71 && n <= 85):
                                TypeOfThreat[i] = "Zagrożenie: Tubylcy";
                                break;
                            case int n when (n >= 86 && n <= 100):
                                TypeOfThreat[i] = "Zagrożenie: Zaraza";
                                break;
                        }
                        break;
                }

                int iAgeOfRuinsGen = 0;
                switch (iRuinTypeValue)
                {
                    case 1:
                        iAgeOfRuinsGen = generator.Next(100, 3000);
                        AgeOfRuins[i] = "Wiek ruin: " + Convert.ToString(iAgeOfRuinsGen);
                        break;
                    case 2:
                        iAgeOfRuinsGen = generator.Next(0, 3000);
                        AgeOfRuins[i] = "Wiek ruin: " + Convert.ToString(iAgeOfRuinsGen);
                        break;
                    case 3:
                        iAgeOfRuinsGen = generator.Next(300, 3000);
                        AgeOfRuins[i] = "Wiek ruin: " + Convert.ToString(iAgeOfRuinsGen);
                        break;
                    case 4:
                        iAgeOfRuinsGen = generator.Next(100, 3000);
                        AgeOfRuins[i] = "Wiek ruin: " + Convert.ToString(iAgeOfRuinsGen);
                        break;
                    case 5:
                        iAgeOfRuinsGen = generator.Next(0, 300);
                        AgeOfRuins[i] = "Wiek ruin: " + Convert.ToString(iAgeOfRuinsGen);
                        break;
                    case 6:
                        iAgeOfRuinsGen = generator.Next(0, 5000);
                        AgeOfRuins[i] = "Wiek ruin: " + Convert.ToString(iAgeOfRuinsGen);
                        break;
                }

                int iOriginalPurposeOfRuinsGen = generator.Next(1, 101);
                switch (iRuinTypeValue)
                {
                    case 1:
                        switch (iOriginalPurposeOfRuinsGen)
                        {
                            case int n when (n <= 30):
                                OriginalPurposeOfRuins[i] = "Poczatkowe przeznaczenie ruiny: Fort";
                                break;
                            case int n when (n >= 31 && n <= 40):
                                OriginalPurposeOfRuins[i] = "Poczatkowe przeznaczenie ruiny: Grobowiec";
                                break;
                            case int n when (n >= 41 && n <= 50):
                                OriginalPurposeOfRuins[i] = "Poczatkowe przeznaczenie ruiny: Osada";
                                break;
                            case int n when (n >= 51 && n <= 80):
                                OriginalPurposeOfRuins[i] = "Poczatkowe przeznaczenie ruiny: Stanica";
                                break;
                            case int n when (n >= 81 && n <= 100):
                                OriginalPurposeOfRuins[i] = "Poczatkowe przeznaczenie ruiny: Świątynia";
                                break;
                        }
                        break;
                    case 2:
                        switch (iOriginalPurposeOfRuinsGen)
                        {
                            case int n when (n <= 20):
                                OriginalPurposeOfRuins[i] = "Poczatkowe przeznaczenie ruiny: Fort";
                                break;
                            case int n when (n >= 21 && n <= 40):
                                OriginalPurposeOfRuins[i] = "Poczatkowe przeznaczenie ruiny: Grobowiec";
                                break;
                            case int n when (n >= 41 && n <= 45):
                                OriginalPurposeOfRuins[i] = "Poczatkowe przeznaczenie ruiny: Osada";
                                break;
                            case int n when (n >= 46 && n <= 50):
                                OriginalPurposeOfRuins[i] = "Poczatkowe przeznaczenie ruiny: Stanica";
                                break;
                            case int n when (n >= 51 && n <= 100):
                                OriginalPurposeOfRuins[i] = "Poczatkowe przeznaczenie ruiny: Świątynia";
                                break;
                        }
                        break;
                    case 3:
                        switch (iOriginalPurposeOfRuinsGen)
                        {
                            case int n when (n <= 20):
                                OriginalPurposeOfRuins[i] = "Poczatkowe przeznaczenie ruiny: Fort";
                                break;
                            case int n when (n >= 21 && n <= 50):
                                OriginalPurposeOfRuins[i] = "Poczatkowe przeznaczenie ruiny: Grobowiec";
                                break;
                            case int n when (n >= 51 && n <= 60):
                                OriginalPurposeOfRuins[i] = "Poczatkowe przeznaczenie ruiny: Osada";
                                break;
                            case int n when (n >= 61 && n <= 90):
                                OriginalPurposeOfRuins[i] = "Poczatkowe przeznaczenie ruiny: Stanica";
                                break;
                            case int n when (n >= 91 && n <= 100):
                                OriginalPurposeOfRuins[i] = "Poczatkowe przeznaczenie ruiny: Świątynia";
                                break;
                        }
                        break;
                    case 4:
                        switch (iOriginalPurposeOfRuinsGen)
                        {
                            case int n when (n <= 25):
                                OriginalPurposeOfRuins[i] = "Poczatkowe przeznaczenie ruiny: Fort";
                                break;
                            case int n when (n >= 26 && n <= 35):
                                OriginalPurposeOfRuins[i] = "Poczatkowe przeznaczenie ruiny: Grobowiec";
                                break;
                            case int n when (n >= 36 && n <= 55):
                                OriginalPurposeOfRuins[i] = "Poczatkowe przeznaczenie ruiny: Osada";
                                break;
                            case int n when (n >= 56 && n <= 90):
                                OriginalPurposeOfRuins[i] = "Poczatkowe przeznaczenie ruiny: Stanica";
                                break;
                            case int n when (n >= 91 && n <= 100):
                                OriginalPurposeOfRuins[i] = "Poczatkowe przeznaczenie ruiny: Świątynia";
                                break;
                        }
                        break;
                    case 5:
                        switch (iOriginalPurposeOfRuinsGen)
                        {
                            case int n when (n <= 20):
                                OriginalPurposeOfRuins[i] = "Poczatkowe przeznaczenie ruiny: Fort";
                                break;
                            case int n when (n >= 21 && n <= 30):
                                OriginalPurposeOfRuins[i] = "Poczatkowe przeznaczenie ruiny: Grobowiec";
                                break;
                            case int n when (n >= 31 && n <= 55):
                                OriginalPurposeOfRuins[i] = "Poczatkowe przeznaczenie ruiny: Osada";
                                break;
                            case int n when (n >= 56 && n <= 85):
                                OriginalPurposeOfRuins[i] = "Poczatkowe przeznaczenie ruiny: Stanica";
                                break;
                            case int n when (n >= 86 && n <= 100):
                                OriginalPurposeOfRuins[i] = "Poczatkowe przeznaczenie ruiny: Świątynia";
                                break;
                        }
                        break;
                    default:
                        OriginalPurposeOfRuins[i] = "Poczatkowe przeznaczenie ruiny: Inne";
                        break;
                }

                int iReasonOfRuinsGen = generator.Next(1, 11);
                switch (iReasonOfRuinsGen)
                {
                    case 1:
                        ReasonOfRuins[i] = "Przyczyna upadku: Czynniki naturalne";
                        break;
                    case 2:
                        ReasonOfRuins[i] = "Przyczyna upadku: Głód";
                        break;
                    case 3:
                        ReasonOfRuins[i] = "Przyczyna upadku: Klęska żywiołowa";
                        break;
                    case 4:
                        ReasonOfRuins[i] = "Przyczyna upadku: Magia";
                        break;
                    case 5:
                        ReasonOfRuins[i] = "Przyczyna upadku: Nieznana";
                        break;
                    case 6:
                        ReasonOfRuins[i] = "Przyczyna upadku: Ucieczka";
                        break;
                    case 7:
                        ReasonOfRuins[i] = "Przyczyna upadku: Wojna domowa";
                        break;
                    case 8:
                        ReasonOfRuins[i] = "Przyczyna upadku: Wyczerpanie zasobów";
                        break;
                    case 9:
                        ReasonOfRuins[i] = "Przyczyna upadku: Zaraza";
                        break;
                    case 10:
                        ReasonOfRuins[i] = "Przyczyna upadku: Zbrojny atak";
                        break;
                }
           
            }

            using (System.IO.StreamWriter file = new System.IO.StreamWriter(@"C:\Ksiestwa graniczne\KsiestwaGraniczne.txt", true))
            {
                file.WriteLine("Ruiny w księstwie");
                file.WriteLine("=======");
            }

            for (int i = 0; i < iNumberOfRuinsGen; i++)
            {
                using (System.IO.StreamWriter file = new System.IO.StreamWriter(@"C:\Ksiestwa graniczne\KsiestwaGraniczne.txt", true))
                {
                    file.WriteLine(RuinType[i]);
                    file.WriteLine(TypeOfThreat[i]);
                    file.WriteLine(AgeOfRuins[i]);
                    file.WriteLine(OriginalPurposeOfRuins[i]);
                    file.WriteLine(ReasonOfRuins[i]);
                    file.WriteLine("---");
                    file.WriteLine(" ");
                }
            }
        }
    }
}
