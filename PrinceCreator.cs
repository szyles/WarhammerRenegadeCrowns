using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace KsiestwaGraniczne
{
    public class PrinceCreator
    {
        public static void PrinceCreatorGen(int iNumberOfDuchies)
        {
            Random generator = new Random();
            string[] TypeOfPrince = new string[iNumberOfDuchies];
            string[] PrinceSex = new string[iNumberOfDuchies];
            string[] RaceOfPrince = new string[iNumberOfDuchies];
            string[] CurrentPrinceCareer = new string[iNumberOfDuchies];
            string[] CurrentPrinceCareerStage = new string[iNumberOfDuchies];
            string[] PrinceGoals = new string[iNumberOfDuchies];
            string[] PrinceRules = new string[iNumberOfDuchies];
            string[] PrinceStyle = new string[iNumberOfDuchies];
            string[] PrinceSecret = new string[iNumberOfDuchies];
            string[] PrinceQuirk = new string[iNumberOfDuchies];
            string[] NumberOfAdvisors = new string[iNumberOfDuchies];
            string[] PrinceTitle = new string[iNumberOfDuchies];
            for (int i = 0; i < iNumberOfDuchies; i++)
            {
                int iTypeOfPrinceGen = generator.Next(1, 101);
                switch (iTypeOfPrinceGen)
                {
                    case int n when (n <= 30):
                        TypeOfPrince[i] = "Typ księcia: Bandyta";
                        break;
                    case int n when (n >= 31 && n <= 50):
                        TypeOfPrince[i] = "Typ księcia: Rycerz";
                        break;
                    case int n when (n >= 51 && n <= 85):
                        TypeOfPrince[i] = "Typ księcia: Najemnik";
                        break;
                    case int n when (n >= 86 && n <= 90):
                        TypeOfPrince[i] = "Typ księcia: Kupiec";
                        break;
                    case int n when (n >= 91 && n <= 94):
                        TypeOfPrince[i] = "Typ księcia: Polityk";
                        break;
                    case int n when (n >= 95 && n <= 98):
                        TypeOfPrince[i] = "Typ księcia: Kapłan";
                        break;
                    case int n when (n >= 99 && n <= 100):
                        TypeOfPrince[i] = "Typ księcia: Mag";
                        break;
                    default:
                        TypeOfPrince[i] = "test";
                        break;
                }

                int iPrinceSexGen = generator.Next(1, 3);
                switch (iPrinceSexGen)
                {
                    case 1:
                        PrinceSex[i] = "Płeć: Mężczyzna";
                        break;
                    case 2:
                        PrinceSex[i] = "Płeć: Kobieta";
                        break;
                    default:
                        PrinceSex[i] = "test";
                        break;
                }

                int iRaceOfPrinceGen = generator.Next(1, 101);
                switch (iRaceOfPrinceGen)
                {
                    case int n when (n <= 8):
                        RaceOfPrince[i] = "Rasa księcia: Krasnolud";
                        break;
                    case int n when (n == 9):
                        RaceOfPrince[i] = "Rasa księcia: Elf";
                        break;
                    case int n when (n == 10):
                        RaceOfPrince[i] = "Rasa księcia: Niziołek";
                        break;
                    case int n when (n >= 11 && n <= 40):
                        RaceOfPrince[i] = "Rasa księcia: Człowiek - księstwa graniczne";
                        break;
                    case int n when (n >= 41 && n <= 55):
                        RaceOfPrince[i] = "Rasa księcia: Człowiek - bretończyk";
                        break;
                    case int n when (n >= 56 && n <= 70):
                        RaceOfPrince[i] = "Rasa księcia: Człowiek - imperialny";
                        break;
                    case int n when (n >= 71 && n <= 85):
                        RaceOfPrince[i] = "Rasa księcia: Człowiek - tileańczyk";
                        break;
                    case int n when (n >= 86 && n <= 100):
                        RaceOfPrince[i] = "Rasa księcia: Człowiek - inna rasa";
                        break;
                    default:
                        RaceOfPrince[i] = "test";
                        break;
                }

                int iCurrentPrinceCareerGen = generator.Next(1, 101);
                switch (iCurrentPrinceCareerGen)
                {
                    case int n when (n <= 5):
                        CurrentPrinceCareer[i] = "Obecna profesja: Pierwsza";
                        break;
                    case int n when (n >= 6 && n <= 15):
                        CurrentPrinceCareer[i] = "Obecna profesja: Druga";
                        break;
                    case int n when (n >= 16 && n <= 60):
                        CurrentPrinceCareer[i] = "Obecna profesja: Trzecia";
                        break;
                    case int n when (n >= 61 && n <= 90):
                        CurrentPrinceCareer[i] = "Obecna profesja: Czwarta";
                        break;
                    case int n when (n >= 91 && n <= 97):
                        CurrentPrinceCareer[i] = "Obecna profesja: Piątek";
                        break;
                    case int n when (n >= 98 && n <= 100):
                        CurrentPrinceCareer[i] = "Obecna profesja: Druga";
                        break;
                    default:
                        CurrentPrinceCareer[i] = "test";
                        break;
                }

                int iCurrentPrinceCareerStageGen = generator.Next(1, 11);
                switch (iCurrentPrinceCareerStageGen)
                {
                    case 1:
                        CurrentPrinceCareerStage[i] = "Etap profesji: Rozpoczęta";
                        break;
                    case int n when (n >= 2 && n <= 5):
                        CurrentPrinceCareerStage[i] = "Etap profesji: Ukończona w 1/3";
                        break;
                    case int n when (n >= 6 && n <= 9):
                        CurrentPrinceCareerStage[i] = "Etap profesji: Ukończona w 2/3";
                        break;
                    case 10:
                        CurrentPrinceCareerStage[i] = "Etap profesji: Ukończona";
                        break;
                    default:
                        CurrentPrinceCareerStage[i] = "test";
                        break;
                }

                int iPrinceGoalsGen = generator.Next(1, 11);
                switch (iPrinceGoalsGen)
                {
                    case 1:
                        PrinceGoals[i] = "Cele księcią: Ja tu rządzę!";
                        break;
                    case int n when (n == 2 || n == 3):
                        PrinceGoals[i] = "Cele księcią: Moje imperium!";
                        break;
                    case 4:
                        PrinceGoals[i] = "Cele księcią: Pieniądzę dają szczęście!";
                        break;
                    case int n when (n == 5 || n == 6):
                        PrinceGoals[i] = "Cele księcią: Po mnie choćby potop!";
                        break;
                    case 7:
                        PrinceGoals[i] = "Cele księcią: Przetrwać za wszelką cenę!";
                        break;
                    case 8:
                        PrinceGoals[i] = "Cele księcią: Radujcie się sławą swego władcy!";
                        break;
                    case 9:
                        PrinceGoals[i] = "Cele księcią: To dla mojego syna!";
                        break;
                    case 10:
                        PrinceGoals[i] = "Cele księcią: Wolność ponad wszystko!";
                        break;
                    default:
                        PrinceGoals[i] = "test";
                        break;
                }

                int iPrinceRulesGen = generator.Next(1, 11);
                switch (iPrinceRulesGen)
                {
                    case 1:
                        PrinceRules[i] = "Zasada księcia: Moje słowo to świętość";
                        break;
                    case 2:
                        PrinceRules[i] = "Zasada księcia: Prawdziwe szlachectwo";
                        break;
                    case int n when (n == 3 || n == 4):
                        PrinceRules[i] = "Zasada księcia: Spalić mutantów!";
                        break;
                    case int n when (n == 5 || n == 6):
                        PrinceRules[i] = "Zasada księcia: Smierć potworom!";
                        break;
                    case 7:
                        PrinceRules[i] = "Zasada księcia: W obronie niewinnych";
                        break;
                    case int n when (n >= 8 && n <= 10):
                        PrinceRules[i] = "Zasada księcia: Zasady są dla mięczaków";
                        break;
                    default:
                        PrinceRules[i] = "test";
                        break;
                }

                int iPrinceStyleGen = generator.Next(1, 11);
                switch (iPrinceStyleGen)
                {
                    case int n when (n == 1 || n == 2):
                        PrinceStyle[i] = "Styl księcia: I tak byś nie zrozumiał";
                        break;
                    case int n when (n == 3 || n == 4):
                        PrinceStyle[i] = "Styl księcia: Masz moje pozwolenie, aby powstać";
                        break;
                    case 5:
                        PrinceStyle[i] = "Styl księcia: Nawet upośledzony snotling jest mądrzejszy niż ty";
                        break;
                    case int n when (n == 6 || n == 7):
                        PrinceStyle[i] = "Styl księcia: Przejdźmy do rzeczy";
                        break;
                    case int n when (n == 8 || n == 9):
                        PrinceStyle[i] = "Styl księcia: Słuchajcie rozkazów";
                        break;
                    case 10:
                        PrinceStyle[i] = "Styl księcia: Wszyscy jesteśmy przyjaciółmi";
                        break;
                    default:
                        PrinceStyle[i] = "test";
                        break;
                }

                int iPrinceSecretGen = generator.Next(1, 11);
                switch (iPrinceSecretGen)
                {
                    case 1:
                        PrinceSecret[i] = "Sekret księcia: Czarna owca";
                        break;
                    case 2:
                        PrinceSecret[i] = "Sekret księcia: Czciciel Chaosu";
                        break;
                    case 3:
                        PrinceSecret[i] = "Sekret księcia: Nietypowe hobby";
                        break;
                    case 4:
                        PrinceSecret[i] = "Sekret księcia: Okrutny morderca";
                        break;
                    case 5:
                        PrinceSecret[i] = "Sekret księcia: Otwarta księga";
                        break;
                    case 6:
                        PrinceSecret[i] = "Sekret księcia: Poszukiwany żywy lub martwy";
                        break;
                    case 7:
                        PrinceSecret[i] = "Sekret księcia: Szlachetny czyn";
                        break;
                    case 8:
                        PrinceSecret[i] = "Sekret księcia: Tajny agent";
                        break;
                    case 9:
                        PrinceSecret[i] = "Sekret księcia: Wyjątkowo tajemnicza osoba";
                        break;
                    case 10:
                        PrinceSecret[i] = "Sekret księcia: Zdrajca";
                        break;
                    default:
                        PrinceSecret[i] = "test";
                        break;
                }

                int iPrinceQuirkGen = generator.Next(1, 11);
                switch (iPrinceQuirkGen)
                {
                    case 1:
                        PrinceQuirk[i] = "Dziwactwo księcia: Ekscentryk";
                        break;
                    case 2:
                        PrinceQuirk[i] = "Dziwactwo księcia: Fanatyk religijny";
                        break;
                    case 3:
                        PrinceQuirk[i] = "Dziwactwo księcia: Fobia";
                        break;
                    case 4:
                        PrinceQuirk[i] = "Dziwactwo księcia: Irracjonalna nienawiść";
                        break;
                    case 5:
                        PrinceQuirk[i] = "Dziwactwo księcia: Irracjonalny gniew";
                        break;
                    case 6:
                        PrinceQuirk[i] = "Dziwactwo księcia: Pedantyzm";
                        break;
                    case 7:
                        PrinceQuirk[i] = "Dziwactwo księcia: Powiedzonko";
                        break;
                    case 8:
                        PrinceQuirk[i] = "Dziwactwo księcia: Urojenie";
                        break;
                    case 9:
                        PrinceQuirk[i] = "Dziwactwo księcia: Wilczy apetyt";
                        break;
                    case 10:
                        PrinceQuirk[i] = "Dziwactwo księcia: Żelazna zasada";
                        break;
                    default:
                        PrinceQuirk[i] = "test";
                        break;
                }

                int iNumberOfAdvisorsGen = generator.Next(1, 11);
                switch (iNumberOfAdvisorsGen)
                {
                    case int n when ( n == 1 || n == 2):
                        NumberOfAdvisors[i] = "Liczebność świty: 0";
                        break;
                    case 3:
                        NumberOfAdvisors[i] = "Liczebność świty: 1";
                        break;
                    case 4:
                        NumberOfAdvisors[i] = "Liczebność świty: 3";
                        break;
                    case 5:
                        NumberOfAdvisors[i] = "Liczebność świty: 4";
                        break;
                    case 6:
                        NumberOfAdvisors[i] = "Liczebność świty: 6";
                        break;
                    case 7:
                        NumberOfAdvisors[i] = "Liczebność świty: 8";
                        break;
                    case 8:
                        NumberOfAdvisors[i] = "Liczebność świty: 10";
                        break;
                    case 9:
                        NumberOfAdvisors[i] = "Liczebność świty: 12";
                        break;
                    case 10:
                        NumberOfAdvisors[i] = "Liczebność świty: 15";
                        break;
                    default:
                        NumberOfAdvisors[i] = "test";
                        break;
                }

                int iPrinceTitleGen = generator.Next(1, 101);
                switch (iPrinceTitleGen)
                {
                    case int n when (n <= 5):
                        if (iRaceOfPrinceGen == 1)
                        {
                            PrinceTitle[i] = "Tytuł: Baron";
                        }
                        else
                        {
                            PrinceTitle[i] = "Tytuł: Baronessa";
                        }
                        break;
                    case int n when (n >= 6 && n <= 10):
                        if (iRaceOfPrinceGen == 1)
                        {
                            PrinceTitle[i] = "Tytuł: Baronet";
                        }
                        else
                        {
                            PrinceTitle[i] = "Tytuł: Baronetessa";
                        }
                        break;
                    case int n when (n >= 11 && n <= 15):
                        if (iRaceOfPrinceGen == 1)
                        {
                            PrinceTitle[i] = "Tytuł: Car";
                        }
                        else
                        {
                            PrinceTitle[i] = "Tytuł: Caryca";
                        }
                        break;
                    case int n when (n >= 16 && n <= 20):
                        if (iRaceOfPrinceGen == 1)
                        {
                            PrinceTitle[i] = "Tytuł: Cesarz";
                        }
                        else
                        {
                            PrinceTitle[i] = "Tytuł: Cesarzowa";
                        }
                        break;
                    case int n when (n >= 21 && n <= 25):
                        if (iRaceOfPrinceGen == 1)
                        {
                            PrinceTitle[i] = "Tytuł: Diuk";
                        }
                        else
                        {
                            PrinceTitle[i] = "Tytuł: Diuszesa";
                        }
                        break;
                    case int n when (n >= 26 && n <= 30):
                        PrinceTitle[i] = "Tytuł: Ekscelencja";
                        break;
                    case int n when (n >= 31 && n <= 35):
                        if (iRaceOfPrinceGen == 1)
                        {
                            PrinceTitle[i] = "Tytuł: Graf";
                        }
                        else
                        {
                            PrinceTitle[i] = "Tytuł: Grafini";
                        }
                        break;
                    case int n when (n >= 36 && n <= 40):
                        if (iRaceOfPrinceGen == 1)
                        {
                            PrinceTitle[i] = "Tytuł: Hrabia";
                        }
                        else
                        {
                            PrinceTitle[i] = "Tytuł: Hrabina";
                        }
                        break;
                    case int n when (n >= 41 && n <= 45):
                        if (iRaceOfPrinceGen == 1)
                        {
                            PrinceTitle[i] = "Tytuł: Imperator";
                        }
                        else
                        {
                            PrinceTitle[i] = "Tytuł: Imperatorka";
                        }
                        break;
                    case int n when (n >= 46 && n <= 50):
                        PrinceTitle[i] = "Tytuł: Kapitan";
                        break;
                    case int n when (n >= 51 && n <= 55):
                        if (iRaceOfPrinceGen == 1)
                        {
                            PrinceTitle[i] = "Tytuł: Król";
                        }
                        else
                        {
                            PrinceTitle[i] = "Tytuł: Królowa";
                        }
                        break;
                    case int n when (n >= 56 && n <= 60):
                        if (iRaceOfPrinceGen == 1)
                        {
                            PrinceTitle[i] = "Tytuł: Książe";
                        }
                        else
                        {
                            PrinceTitle[i] = "Tytuł: Księżna";
                        }
                        break;
                    case int n when (n >= 61 && n <= 65):
                        if (iRaceOfPrinceGen == 1)
                        {
                            PrinceTitle[i] = "Tytuł: Lord Protektor";
                        }
                        else
                        {
                            PrinceTitle[i] = "Tytuł: Lady Protektor";
                        }
                        break;
                    case int n when (n >= 66 && n <= 70):
                        if (iRaceOfPrinceGen == 1)
                        {
                            PrinceTitle[i] = "Tytuł: Margrabia";
                        }
                        else
                        {
                            PrinceTitle[i] = "Tytuł: Margrabini";
                        }
                        break;
                    case int n when (n >= 71 && n <= 75):
                        PrinceTitle[i] = "Tytuł: Marszałek";
                        break;
                    case int n when (n >= 76 && n <= 80):
                        if (iRaceOfPrinceGen == 1)
                        {
                            PrinceTitle[i] = "Tytuł: Mistrz gildii";
                        }
                        else
                        {
                            PrinceTitle[i] = "Tytuł: Mistrzyni gildii";
                        }
                        break;
                    case int n when (n >= 81 && n <= 85):
                        if (iRaceOfPrinceGen == 1)
                        {
                            PrinceTitle[i] = "Tytuł: Ojciec Święty";
                        }
                        else
                        {
                            PrinceTitle[i] = "Tytuł: Matka Święta";
                        }
                        break;
                    case int n when (n >= 86 && n <= 90):
                        if (iRaceOfPrinceGen == 1)
                        {
                            PrinceTitle[i] = "Tytuł: Wicehrabia";
                        }
                        else
                        {
                            PrinceTitle[i] = "Tytuł: Wicehrabina";
                        }
                        break;
                    case int n when (n >= 91 && n <= 95):
                        PrinceTitle[i] = "Tytuł: Wódz";
                        break;
                    case int n when (n >= 96 && n <= 100):
                        if (iRaceOfPrinceGen == 1)
                        {
                            PrinceTitle[i] = "Tytuł: Wywyższony";
                        }
                        else
                        {
                            PrinceTitle[i] = "Tytuł: Wywyższona";
                        }
                        break;
                    default:
                        PrinceTitle[i] = "test";
                        break;
                }
            }

            using (System.IO.StreamWriter file = new System.IO.StreamWriter(@"C:\Ksiestwa graniczne\KsiestwaGraniczne.txt", true))
            {
                file.WriteLine("Książęta");
                file.WriteLine("=======");
            }

            for(int i=0; i < iNumberOfDuchies; i++)
            {
                using (System.IO.StreamWriter file = new System.IO.StreamWriter(@"C:\Ksiestwa graniczne\KsiestwaGraniczne.txt", true))
                {
                    file.WriteLine(TypeOfPrince[i]);
                    file.WriteLine(PrinceSex[i]);
                    file.WriteLine(RaceOfPrince[i]);
                    file.WriteLine(CurrentPrinceCareer[i]);
                    file.WriteLine(CurrentPrinceCareerStage[i]);
                    file.WriteLine(PrinceGoals[i]);
                    file.WriteLine(PrinceRules[i]);
                    file.WriteLine(PrinceStyle[i]);
                    file.WriteLine(PrinceSecret[i]);
                    file.WriteLine(PrinceQuirk[i]);
                    file.WriteLine(NumberOfAdvisors[i]);
                    file.WriteLine(PrinceTitle[i]);
                    file.WriteLine("-----");
                    file.WriteLine(" ");
                }
                PrinceRelations.PrinceRelationsGen(iNumberOfDuchies);
            }

        }
    }
}
