using System;
using System.Collections.Generic;
using System.Text;

namespace KsiestwaGraniczne
{
    class DuchyCreator
    {
        public static void DuchyCreatorGen(int iNumberOfDuchies)
        {
            Random generator = new Random();
            string SizeOfSettlement="";
            string VillagesNumber="";
            int iTownCharasteristicsGen = generator.Next(2, 8);
            string[] TownCharacteristics = new string [iTownCharasteristicsGen];

            int iSizeOfSettlementGen = generator.Next(1, 4);
            int iNumberOfVillagesGen = generator.Next(1, 11);
            switch (iSizeOfSettlementGen)
            {
                case 1:
                    SizeOfSettlement = "Rozmiar księstwa: Małe";
                    switch (iNumberOfVillagesGen)
                    {
                        case int n when (n <= 3):
                            VillagesNumber = "Liczba wsi: 1";
                            break;
                        case int n when (n >= 4 && n <= 6):
                            VillagesNumber = "Liczba wsi: 2";
                            break;
                        case int n when (n >= 7 && n <= 8):
                            VillagesNumber = "Liczba wsi: 3";
                            break;
                        case int n when (n >= 9 && n <= 10):
                            VillagesNumber = "Liczba wsi: 4";
                            break;
                    }
                    break;
                case 2:
                    SizeOfSettlement = "Rozmiar księstwa: Średnie";
                    switch (iNumberOfVillagesGen)
                    {
                        case int n when (n <= 2):
                            VillagesNumber = "Liczba wsi: 1";
                            break;
                        case int n when (n >= 3 && n <= 4):
                            VillagesNumber = "Liczba wsi: 2";
                            break;
                        case int n when (n >= 5 && n <= 6):
                            VillagesNumber = "Liczba wsi: 3";
                            break;
                        case int n when (n >= 7 && n <= 8):
                            VillagesNumber = "Liczba wsi: 4";
                            break;
                        case 9:
                            VillagesNumber = "Liczba wsi: 5";
                            break;
                        case 10:
                            VillagesNumber = "Liczba wsi: 6";
                            break;
                    }
                    break;
                case 3:
                    SizeOfSettlement = "Rozmiar księstwa: Duże";
                    switch (iNumberOfVillagesGen)
                    {
                        case int n when (n == 1):
                            VillagesNumber = "Liczba wsi: 1";
                            break;
                        case int n when (n == 2):
                            VillagesNumber = "Liczba wsi: 2";
                            break;
                        case int n when (n == 3):
                            VillagesNumber = "Liczba wsi: 3";
                            break;
                        case int n when (n >= 4 && n <= 5):
                            VillagesNumber = "Liczba wsi: 4";
                            break;
                        case int n when (n >= 6 && n <= 7):
                            VillagesNumber = "Liczba wsi: 5";
                            break;
                        case 8:
                            VillagesNumber = "Liczba wsi: 6";
                            break;
                        case 9:
                            VillagesNumber = "Liczba wsi: 7";
                            break;
                        case 10:
                            VillagesNumber = "Liczba wsi: 8";
                            break;
                    }
                    break;
            }

            for(int i = 0; i < iTownCharasteristicsGen; i++)
            {
                int iCharacteristicsGen = generator.Next(1, 101);
                switch (iCharacteristicsGen)
                {
                    case int n when (n <= 6 || (n >= 11 && n <= 15) || (n >= 21 && n <= 25) || (n >= 31 && n <= 36) || (n >= 41 && n <= 45) || (n >= 51 && n <= 55) || (n >= 61 && n <= 65) || (n >= 71 && n <= 75) || (n >= 81 && n <= 84)):
                        int iResourceGen = generator.Next(1, 11);
                        switch (iResourceGen)
                        {
                            case int k when (k <= 4):
                                int iNaturalResourcesGen = generator.Next(1, 101);
                                switch (iNaturalResourcesGen)
                                {
                                    case int l when (l <= 2):
                                        TownCharacteristics[i] = "Kamienie szlachetne, Twierdza";
                                        break;
                                    case int l when (l >= 3 && l <= 14):
                                        TownCharacteristics[i] = "Kamieniołom, budulec";
                                        break;
                                    case int l when (l >= 15 && l <= 25):
                                        TownCharacteristics[i] = "Kamieniołom, glina";
                                        break;
                                    case int l when (l >= 26 && l <= 30):
                                        TownCharacteristics[i] = "Kamieniołom, marmur";
                                        break;
                                    case int l when (l >= 31 && l <= 41):
                                        TownCharacteristics[i] = "Kopalnia cyny";
                                        break;
                                    case int l when (l >= 42 && l <= 47):
                                        TownCharacteristics[i] = "Kopalnia miedzi";
                                        break;
                                    case int l when (l >= 48 && l <= 54):
                                        TownCharacteristics[i] = "Kopalnia ołowiu";
                                        break;
                                    case int l when (l >= 55 && l <= 58):
                                        TownCharacteristics[i] = "Kopalnia srebra, Twierdza";
                                        break;
                                    case int l when (l >= 59 && l <= 68):
                                        TownCharacteristics[i] = "Kopalnia węgla";
                                        break;
                                    case int l when (l >= 69 && l <= 70):
                                        TownCharacteristics[i] = "Kopalnia złota, Twierdza";
                                        break;
                                    case int l when (l >= 71 && l <= 80):
                                        TownCharacteristics[i] = "Kopalnia żelaza";
                                        break;
                                    case int l when (l >= 81 && l <= 90):
                                        TownCharacteristics[i] = "Skóry/Futra";
                                        break;
                                    case int l when (l >= 91 && l <= 100):
                                        TownCharacteristics[i] = "Zioła lecznicze";
                                        break;
                                }
                                break;
                            case int k when (k >= 5 && k <= 7):
                                int iCraftsmenGen = generator.Next(1, 101);
                                switch (iCraftsmenGen)
                                {
                                    case int m when (m <= 6):
                                        TownCharacteristics[i] = "Bednarstwo";
                                        break;
                                    case int m when (m >= 7 && m <= 16):
                                        TownCharacteristics[i] = "Garbarstwo";
                                        break;
                                    case int m when (m >= 17 && m <= 24):
                                        TownCharacteristics[i] = "Garncarstwo";
                                        break;
                                    case int m when (m == 25):
                                        TownCharacteristics[i] = "Jubilerstwo, Twierdza";
                                        break;
                                    case int m when (m >= 26 && m <= 34):
                                        TownCharacteristics[i] = "Kowalstwo";
                                        break;
                                    case int m when (m >= 35 && m <= 44):
                                        TownCharacteristics[i] = "Krawiectwo";
                                        break;
                                    case int m when (m >= 45 && m <= 52):
                                        TownCharacteristics[i] = "Piwowarstwo";
                                        break;
                                    case int m when (m >= 53 && m <= 57):
                                        TownCharacteristics[i] = "Płatnerstwo";
                                        break;
                                    case int m when (m == 58):
                                        TownCharacteristics[i] = "Rusznikarstwo";
                                        break;
                                    case int m when (m >= 59 && m <= 66):
                                        TownCharacteristics[i] = "Stolarstwo";
                                        break;
                                    case int m when (m >= 67 && m <= 73):
                                        TownCharacteristics[i] = "Szewstwo";
                                        break;
                                    case int m when (m >= 74 && m <= 84):
                                        TownCharacteristics[i] = "Winiarstwo";
                                        break;
                                    case int m when (m >= 85 && m <= 89):
                                        TownCharacteristics[i] = "Wyrób broni";
                                        break;
                                    case int m when (m >= 90 && m <= 94):
                                        TownCharacteristics[i] = "Wyrób łuków";
                                        break;
                                    case int m when (m >= 95 && m <= 98):
                                        TownCharacteristics[i] = "Wyrób świec";
                                        break;
                                    case int m when (m >= 99 && m <= 100):
                                        TownCharacteristics[i] = "Złotnictwo, Twierdza";
                                        break;
                                }
                                break;
                            case 8:
                                int iAnotherResourcesGen = generator.Next(1, 11);
                                switch (iAnotherResourcesGen)
                                {
                                    case 1:
                                        TownCharacteristics[i] = "Wyjątkowo uczicyw kupiec [skrótowy zapis. Rozwinięcie tabela 3-6, str 49]";
                                        break;
                                    case 2:
                                        TownCharacteristics[i] = "Duża sterta odchodów, którą miejscowi czcą jako boga [skrótowy zapis. Rozwinięcie tabela 3-6, str 49]";
                                        break;
                                    case 3:
                                        TownCharacteristics[i] = "Zdolny medyk [skrótowy zapis. Rozwinięcie tabela 3-6, str 49]";
                                        break;
                                    case 4:
                                        TownCharacteristics[i] = "Wejście do katakumb [skrótowy zapis. Rozwinięcie tabela 3-6, str 49]";
                                        break;
                                    case 5:
                                        TownCharacteristics[i] = "Najpiękniejsze kobiety i najbardziej zazdrośni mężczyźni [skrótowy zapis. Rozwinięcie tabela 3-6, str 49]";
                                        break;
                                    case 6:
                                        TownCharacteristics[i] = "Sklep z bronią należący do księcia [skrótowy zapis. Rozwinięcie tabela 3-6, str 49]";
                                        break;
                                    case 7:
                                        TownCharacteristics[i] = "Jedyna studnia na przestrzeni wielu kilometrów [skrótowy zapis. Rozwinięcie tabela 3-6, str 49]";
                                        break;
                                    case 8:
                                        TownCharacteristics[i] = "Placki o niesamowitym smaku [skrótowy zapis. Rozwinięcie tabela 3-6, str 49]";
                                        break;
                                    case 9:
                                        TownCharacteristics[i] = "Miejsce bitwy pomiędzy dwoma bogatymi armiami [skrótowy zapis. Rozwinięcie tabela 3-6, str 49]";
                                        break;
                                    case 10:
                                        TownCharacteristics[i] = "Gospoda posiadająca łóżka z siennikami [skrótowy zapis. Rozwinięcie tabela 3-6, str 49]";
                                        break;
                                }
                                break;
                            case int k when (k >= 9 && k <= 10):
                                TownCharacteristics[i] = "Rynek";
                                for(int y=0; y<iTownCharasteristicsGen; y++)
                                {
                                    if(TownCharacteristics[y] == "Rynek")
                                    {
                                        int iCraftsmenGen2 = generator.Next(1, 101);
                                        switch (iCraftsmenGen2)
                                        {
                                            case int m when (m <= 6):
                                                TownCharacteristics[i] = "Bednarstwo";
                                                break;
                                            case int m when (m >= 7 && m <= 16):
                                                TownCharacteristics[i] = "Garbarstwo";
                                                break;
                                            case int m when (m >= 17 && m <= 24):
                                                TownCharacteristics[i] = "Garncarstwo";
                                                break;
                                            case int m when (m == 25):
                                                TownCharacteristics[i] = "Jubilerstwo, Twierdza";
                                                break;
                                            case int m when (m >= 26 && m <= 34):
                                                TownCharacteristics[i] = "Kowalstwo";
                                                break;
                                            case int m when (m >= 35 && m <= 44):
                                                TownCharacteristics[i] = "Krawiectwo";
                                                break;
                                            case int m when (m >= 45 && m <= 52):
                                                TownCharacteristics[i] = "Piwowarstwo";
                                                break;
                                            case int m when (m >= 53 && m <= 57):
                                                TownCharacteristics[i] = "Płatnerstwo";
                                                break;
                                            case int m when (m == 58):
                                                TownCharacteristics[i] = "Rusznikarstwo";
                                                break;
                                            case int m when (m >= 59 && m <= 66):
                                                TownCharacteristics[i] = "Stolarstwo";
                                                break;
                                            case int m when (m >= 67 && m <= 73):
                                                TownCharacteristics[i] = "Szewstwo";
                                                break;
                                            case int m when (m >= 74 && m <= 84):
                                                TownCharacteristics[i] = "Winiarstwo";
                                                break;
                                            case int m when (m >= 85 && m <= 89):
                                                TownCharacteristics[i] = "Wyrób broni";
                                                break;
                                            case int m when (m >= 90 && m <= 94):
                                                TownCharacteristics[i] = "Wyrób łuków";
                                                break;
                                            case int m when (m >= 95 && m <= 98):
                                                TownCharacteristics[i] = "Wyrób świec";
                                                break;
                                            case int m when (m >= 99 && m <= 100):
                                                TownCharacteristics[i] = "Złotnictwo, Twierdza";
                                                break;
                                        }
                                    }
                                }
                                break;
                        }
                        break;
                    case int n when (n == 7 || n == 16 || n == 17 || n == 26 || n == 37 || n == 46 || n == 47 || n == 56 || n == 57 || n == 66 || n == 76 || n == 85 || n == 86):
                        TownCharacteristics[i] = "Twierdza";
                        break;
                    case int n when (n == 9 || n == 19 || n == 29 || n == 39 || n == 49 || n == 59 || n == 69 || n == 79 || n == 89):
                        TownCharacteristics[i] = "Kultyści";
                        break;
                    case int n when (n >= 91 && n < 100):
                        int iSpecialCharacteristicsGen = generator.Next(1, 11);
                        switch (iSpecialCharacteristicsGen)
                        {
                            case 1:
                                TownCharacteristics[i] = "Bestia";
                                break;
                            case 2:
                                TownCharacteristics[i] = "Czarodziej";
                                break;
                            case 3:
                                TownCharacteristics[i] = "Czarownik";
                                break;
                            case 4:
                                TownCharacteristics[i] = "Klasztor";
                                break;
                            case 5:
                                TownCharacteristics[i] = "Kultyści";
                                break;
                            case 6:
                                TownCharacteristics[i] = "Magia";
                                break;
                            case 7:
                                TownCharacteristics[i] = "Przytułek";
                                break;
                            case 8:
                                TownCharacteristics[i] = "Rycerze zakonni";
                                break;
                            case 9:
                            case 10:
                                string iResourceGen3Add ="";
                                for(int t = 0; t < 2; t++)
                                {
                                    int iResourceGen3 = generator.Next(1, 11);
                                    switch (iResourceGen3)
                                    {
                                        case int k when (k <= 4):
                                            int iNaturalResourcesGen = generator.Next(1, 101);
                                            switch (iNaturalResourcesGen)
                                            {
                                                case int l when (l <= 2):
                                                    iResourceGen3Add = iResourceGen3Add + " Kamienie szlachetne, Twierdza";
                                                    break;
                                                case int l when (l >= 3 && l <= 14):
                                                    iResourceGen3Add = iResourceGen3Add + " Kamieniołom, budulec";
                                                    break;
                                                case int l when (l >= 15 && l <= 25):
                                                    iResourceGen3Add = iResourceGen3Add + " Kamieniołom, glina";
                                                    break;
                                                case int l when (l >= 26 && l <= 30):
                                                    iResourceGen3Add = iResourceGen3Add + " Kamieniołom, marmur";
                                                    break;
                                                case int l when (l >= 31 && l <= 41):
                                                    iResourceGen3Add = iResourceGen3Add + " Kopalnia cyny";
                                                    break;
                                                case int l when (l >= 42 && l <= 47):
                                                    iResourceGen3Add = iResourceGen3Add + " Kopalnia miedzi";
                                                    break;
                                                case int l when (l >= 48 && l <= 54):
                                                    iResourceGen3Add = iResourceGen3Add + " Kopalnia ołowiu";
                                                    break;
                                                case int l when (l >= 55 && l <= 58):
                                                    iResourceGen3Add = iResourceGen3Add + " Kopalnia srebra, Twierdza";
                                                    break;
                                                case int l when (l >= 59 && l <= 68):
                                                    iResourceGen3Add = iResourceGen3Add + " Kopalnia węgla";
                                                    break;
                                                case int l when (l >= 69 && l <= 70):
                                                    iResourceGen3Add = iResourceGen3Add + " Kopalnia złota, Twierdza";
                                                    break;
                                                case int l when (l >= 71 && l <= 80):
                                                    iResourceGen3Add = iResourceGen3Add + " Kopalnia żelaza";
                                                    break;
                                                case int l when (l >= 81 && l <= 90):
                                                    iResourceGen3Add = iResourceGen3Add + " Skóry/Futra";
                                                    break;
                                                case int l when (l >= 91 && l <= 100):
                                                    iResourceGen3Add = iResourceGen3Add + " Zioła lecznicze";
                                                    break;
                                            }
                                            break;
                                        case int k when (k >= 5 && k <= 7):
                                            int iCraftsmenGen = generator.Next(1, 101);
                                            switch (iCraftsmenGen)
                                            {
                                                case int m when (m <= 6):
                                                    iResourceGen3Add = iResourceGen3Add + " Bednarstwo";
                                                    break;
                                                case int m when (m >= 7 && m <= 16):
                                                    iResourceGen3Add = iResourceGen3Add + " Garbarstwo";
                                                    break;
                                                case int m when (m >= 17 && m <= 24):
                                                    iResourceGen3Add = iResourceGen3Add + " Garncarstwo";
                                                    break;
                                                case int m when (m == 25):
                                                    iResourceGen3Add = iResourceGen3Add + " Jubilerstwo, Twierdza";
                                                    break;
                                                case int m when (m >= 26 && m <= 34):
                                                    iResourceGen3Add = iResourceGen3Add + " Kowalstwo";
                                                    break;
                                                case int m when (m >= 35 && m <= 44):
                                                    iResourceGen3Add = iResourceGen3Add + " Krawiectwo";
                                                    break;
                                                case int m when (m >= 45 && m <= 52):
                                                    iResourceGen3Add = iResourceGen3Add + " Piwowarstwo";
                                                    break;
                                                case int m when (m >= 53 && m <= 57):
                                                    iResourceGen3Add = iResourceGen3Add + " Płatnerstwo";
                                                    break;
                                                case int m when (m == 58):
                                                    iResourceGen3Add = iResourceGen3Add + " Rusznikarstwo";
                                                    break;
                                                case int m when (m >= 59 && m <= 66):
                                                    iResourceGen3Add = iResourceGen3Add + " Stolarstwo";
                                                    break;
                                                case int m when (m >= 67 && m <= 73):
                                                    iResourceGen3Add = iResourceGen3Add + " Szewstwo";
                                                    break;
                                                case int m when (m >= 74 && m <= 84):
                                                    iResourceGen3Add = iResourceGen3Add + " Winiarstwo";
                                                    break;
                                                case int m when (m >= 85 && m <= 89):
                                                    iResourceGen3Add = iResourceGen3Add + " Wyrób broni";
                                                    break;
                                                case int m when (m >= 90 && m <= 94):
                                                    iResourceGen3Add = iResourceGen3Add + " Wyrób łuków";
                                                    break;
                                                case int m when (m >= 95 && m <= 98):
                                                    iResourceGen3Add = iResourceGen3Add + " Wyrób świec";
                                                    break;
                                                case int m when (m >= 99 && m <= 100):
                                                    iResourceGen3Add = iResourceGen3Add + " Złotnictwo, Twierdza";
                                                    break;
                                            }
                                            break;
                                        case 8:
                                            int iAnotherResourcesGen = generator.Next(1, 11);
                                            switch (iAnotherResourcesGen)
                                            {
                                                case 1:
                                                    iResourceGen3Add = iResourceGen3Add + " Wyjątkowo uczicyw kupiec [skrótowy zapis. Rozwinięcie tabela 3-6, str 49]";
                                                    break;
                                                case 2:
                                                    iResourceGen3Add = iResourceGen3Add + " Duża sterta odchodów, którą miejscowi czcą jako boga [skrótowy zapis. Rozwinięcie tabela 3-6, str 49]";
                                                    break;
                                                case 3:
                                                    iResourceGen3Add = iResourceGen3Add + " Zdolny medyk [skrótowy zapis. Rozwinięcie tabela 3-6, str 49]";
                                                    break;
                                                case 4:
                                                    iResourceGen3Add = iResourceGen3Add + " Wejście do katakumb [skrótowy zapis. Rozwinięcie tabela 3-6, str 49]";
                                                    break;
                                                case 5:
                                                    iResourceGen3Add = iResourceGen3Add + " Najpiękniejsze kobiety i najbardziej zazdrośni mężczyźni [skrótowy zapis. Rozwinięcie tabela 3-6, str 49]";
                                                    break;
                                                case 6:
                                                    iResourceGen3Add = iResourceGen3Add + " Sklep z bronią należący do księcia [skrótowy zapis. Rozwinięcie tabela 3-6, str 49]";
                                                    break;
                                                case 7:
                                                    iResourceGen3Add = iResourceGen3Add + " Jedyna studnia na przestrzeni wielu kilometrów [skrótowy zapis. Rozwinięcie tabela 3-6, str 49]";
                                                    break;
                                                case 8:
                                                    iResourceGen3Add = iResourceGen3Add + " Placki o niesamowitym smaku [skrótowy zapis. Rozwinięcie tabela 3-6, str 49]";
                                                    break;
                                                case 9:
                                                    iResourceGen3Add = iResourceGen3Add + " Miejsce bitwy pomiędzy dwoma bogatymi armiami [skrótowy zapis. Rozwinięcie tabela 3-6, str 49]";
                                                    break;
                                                case 10:
                                                    iResourceGen3Add = iResourceGen3Add + " Gospoda posiadająca łóżka z siennikami [skrótowy zapis. Rozwinięcie tabela 3-6, str 49]";
                                                    break;
                                            }
                                            break;
                                        case int k when (k >= 9 && k <= 10):
                                            iResourceGen3Add = "Rynek";                                    
                                            break;
                                    }
                                }
                                TownCharacteristics[i] = iResourceGen3Add;
                                break;
                        }
                        break;
                    default:
                        TownCharacteristics[i] = "Strażnica (rzuć tutaj sobie Bartek raz z 3-2)";
                        break;
                
                }
            }

            using (System.IO.StreamWriter file = new System.IO.StreamWriter(@"C:\Ksiestwa graniczne\KsiestwaGraniczne.txt", true))
            {
                file.WriteLine("Księstwo:");
                file.WriteLine("=======");
            }

            using (System.IO.StreamWriter file = new System.IO.StreamWriter(@"C:\Ksiestwa graniczne\KsiestwaGraniczne.txt", true))
            {
                file.WriteLine(SizeOfSettlement);
                file.WriteLine(VillagesNumber);
            }

            for (int i = 0; i < iTownCharasteristicsGen; i++)
            {
                using (System.IO.StreamWriter file = new System.IO.StreamWriter(@"C:\Ksiestwa graniczne\KsiestwaGraniczne.txt", true))
                {
                    file.WriteLine(TownCharacteristics[i]);
                }
            }

            using (System.IO.StreamWriter file = new System.IO.StreamWriter(@"C:\Ksiestwa graniczne\KsiestwaGraniczne.txt", true))
            {
                file.WriteLine("-----");
                file.WriteLine(" ");
            }
        }
    }
}
