using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace KsiestwaGraniczne
{
    public class TerrainCreator
    {
        public static void TerrainCreatorGen()
        {
            Random generator = new Random();
            int iGeneratedNumber = generator.Next(0, 11);
            int iActualNumberOfProvinces = 0;
            int iAccumulatedBonusFromProvinces = 0;
            int iMaxNumberOfProvinces = 500;
            string[] GeneratedTerrainArray = new string[iGeneratedNumber];
            int iStorageForProvinceNumber;
            for (int i = 0; i < iGeneratedNumber; i++)
            {
                int iTerrainCreatorGenNumber = generator.Next(100);
                int iNumberOfProvincesGenerator = generator.Next(1, 100);
                int iNumberOfProvincesGenerator2 = generator.Next(1, 10);
                int iCurrentResult = iTerrainCreatorGenNumber + iAccumulatedBonusFromProvinces;
                int iTesting = iMaxNumberOfProvinces;

                if (iCurrentResult < 100)
                {
                    if (iActualNumberOfProvinces < iMaxNumberOfProvinces)
                    {
                        switch (iCurrentResult)
                        {
                            case 0:
                            case 10:
                            case 20:
                            case 30:
                            case 40:
                            case 50:
                            case 60:
                            case 70:
                            case 80:
                            case 90:
                                iAccumulatedBonusFromProvinces += 10;
                                GeneratedTerrainArray[i] = "Rzeka";
                                break;
                            case 1:
                            case 11:
                            case 21:
                            case 31:
                            case 41:
                            case 51:
                            case 61:
                            case 71:
                                iAccumulatedBonusFromProvinces += 10;
                                iActualNumberOfProvinces += iNumberOfProvincesGenerator;
                                iStorageForProvinceNumber = iActualNumberOfProvinces;
                                if (iActualNumberOfProvinces > iMaxNumberOfProvinces)
                                {
                                    int iStorage = iActualNumberOfProvinces;
                                    iActualNumberOfProvinces = iTesting;
                                    iNumberOfProvincesGenerator2 = iActualNumberOfProvinces - iStorageForProvinceNumber;
                                }
                                GeneratedTerrainArray[i] = Convert.ToString(iNumberOfProvincesGenerator) + " - Rowniny, jalowe";
                                break;
                            case 2:
                            case 12:
                            case 22:
                            case 32:
                            case 42:
                            case 52:
                            case 62:
                            case 72:
                                iAccumulatedBonusFromProvinces += 10;
                                iStorageForProvinceNumber = iActualNumberOfProvinces;
                                iActualNumberOfProvinces += (iNumberOfProvincesGenerator);
                                if (iActualNumberOfProvinces > iMaxNumberOfProvinces)
                                {
                                    int iStorage = iActualNumberOfProvinces;
                                    iActualNumberOfProvinces = iTesting;
                                    iNumberOfProvincesGenerator = iActualNumberOfProvinces - iStorageForProvinceNumber;
                                }
                                GeneratedTerrainArray[i] = Convert.ToString(iNumberOfProvincesGenerator) + " - Rowniny, krzaki";
                                break;
                            case 3:
                            case 23:
                            case 43:
                            case 63:
                                iAccumulatedBonusFromProvinces += 10;
                                iStorageForProvinceNumber = iActualNumberOfProvinces;
                                iActualNumberOfProvinces += (iNumberOfProvincesGenerator);
                                if (iActualNumberOfProvinces > iMaxNumberOfProvinces)
                                {
                                    int iStorage = iActualNumberOfProvinces;
                                    iActualNumberOfProvinces = iTesting;
                                    iNumberOfProvincesGenerator = iActualNumberOfProvinces - iStorageForProvinceNumber;
                                }
                                GeneratedTerrainArray[i] = Convert.ToString(iNumberOfProvincesGenerator) + " - Rowniny, las";
                                break;
                            case 4:
                            case 14:
                            case 24:
                            case 34:
                            case 44:
                            case 54:
                            case 64:
                            case 74:
                                iAccumulatedBonusFromProvinces += 10;
                                iStorageForProvinceNumber = iActualNumberOfProvinces;
                                iActualNumberOfProvinces += (iNumberOfProvincesGenerator);
                                if (iActualNumberOfProvinces > iMaxNumberOfProvinces)
                                {
                                    int iStorage = iActualNumberOfProvinces;
                                    iActualNumberOfProvinces = iTesting;
                                    iNumberOfProvincesGenerator = iActualNumberOfProvinces - iStorageForProvinceNumber;
                                }
                                GeneratedTerrainArray[i] = Convert.ToString(iNumberOfProvincesGenerator) + " - Wzgorza, jalowe";
                                break;
                            case 5:
                            case 15:
                            case 25:
                            case 35:
                            case 45:
                            case 55:
                            case 65:
                            case 75:
                                iAccumulatedBonusFromProvinces += 10;
                                iStorageForProvinceNumber = iActualNumberOfProvinces;
                                iActualNumberOfProvinces += (iNumberOfProvincesGenerator);
                                if (iActualNumberOfProvinces > iMaxNumberOfProvinces)
                                {
                                    int iStorage = iActualNumberOfProvinces;
                                    iActualNumberOfProvinces = iTesting;
                                    iNumberOfProvincesGenerator = iActualNumberOfProvinces - iStorageForProvinceNumber;
                                }
                                GeneratedTerrainArray[i] = Convert.ToString(iNumberOfProvincesGenerator) + " - Wzgorza, krzaki";
                                break;
                            case 6:
                            case 26:
                            case 46:
                            case 66:
                                iAccumulatedBonusFromProvinces += 10;
                                iStorageForProvinceNumber = iActualNumberOfProvinces;
                                iActualNumberOfProvinces += (iNumberOfProvincesGenerator);
                                if (iActualNumberOfProvinces > iMaxNumberOfProvinces)
                                {
                                    int iStorage = iActualNumberOfProvinces;
                                    iActualNumberOfProvinces = iTesting;
                                    iNumberOfProvincesGenerator = iActualNumberOfProvinces - iStorageForProvinceNumber;
                                }
                                GeneratedTerrainArray[i] = Convert.ToString(iNumberOfProvincesGenerator) + " - Wzgorza, trawa";
                                break;
                            case 7:
                            case 37:
                            case 67:
                                iAccumulatedBonusFromProvinces += 10;
                                iStorageForProvinceNumber = iActualNumberOfProvinces;
                                iActualNumberOfProvinces += (iNumberOfProvincesGenerator);
                                if (iActualNumberOfProvinces > iMaxNumberOfProvinces)
                                {
                                    int iStorage = iActualNumberOfProvinces;
                                    iActualNumberOfProvinces = iTesting;
                                    iNumberOfProvincesGenerator = iActualNumberOfProvinces - iStorageForProvinceNumber;
                                }
                                GeneratedTerrainArray[i] = Convert.ToString(iNumberOfProvincesGenerator) + " - Gory, jalowe";
                                break;
                            case 8:
                            case 38:
                            case 68:
                                iAccumulatedBonusFromProvinces += 10;
                                iStorageForProvinceNumber = iActualNumberOfProvinces;
                                iActualNumberOfProvinces += (iNumberOfProvincesGenerator);
                                if (iActualNumberOfProvinces > iMaxNumberOfProvinces)
                                {
                                    int iStorage = iActualNumberOfProvinces;
                                    iActualNumberOfProvinces = iTesting;
                                    iNumberOfProvincesGenerator = iActualNumberOfProvinces - iStorageForProvinceNumber;
                                }
                                GeneratedTerrainArray[i] = Convert.ToString(iNumberOfProvincesGenerator) + " - Bagna, jalowe";
                                break;
                            case 9:
                            case 39:
                            case 69:
                                iAccumulatedBonusFromProvinces += 10;
                                iStorageForProvinceNumber = iActualNumberOfProvinces;
                                iActualNumberOfProvinces += (iNumberOfProvincesGenerator);
                                if (iActualNumberOfProvinces > iMaxNumberOfProvinces)
                                {
                                    int iStorage = iActualNumberOfProvinces;
                                    iActualNumberOfProvinces = iTesting;
                                    iNumberOfProvincesGenerator = iActualNumberOfProvinces - iStorageForProvinceNumber;
                                }
                                GeneratedTerrainArray[i] = Convert.ToString(iNumberOfProvincesGenerator) + " - Pustkowia, jalowe";
                                break;
                            case 13:
                            case 33:
                            case 53:
                            case 73:
                                iAccumulatedBonusFromProvinces += 10;
                                iStorageForProvinceNumber = iActualNumberOfProvinces;
                                iActualNumberOfProvinces += (iNumberOfProvincesGenerator);
                                if (iActualNumberOfProvinces > iMaxNumberOfProvinces)
                                {
                                    int iStorage = iActualNumberOfProvinces;
                                    iActualNumberOfProvinces = iTesting;
                                    iNumberOfProvincesGenerator = iActualNumberOfProvinces - iStorageForProvinceNumber;
                                }
                                GeneratedTerrainArray[i] = Convert.ToString(iNumberOfProvincesGenerator) + " - Rowniny, trawa";
                                break;
                            case 16:
                            case 36:
                            case 56:
                            case 76:
                                iAccumulatedBonusFromProvinces += 10;
                                iStorageForProvinceNumber = iActualNumberOfProvinces;
                                iActualNumberOfProvinces += (iNumberOfProvincesGenerator);
                                if (iActualNumberOfProvinces > iMaxNumberOfProvinces)
                                {
                                    int iStorage = iActualNumberOfProvinces;
                                    iActualNumberOfProvinces = iTesting;
                                    iNumberOfProvincesGenerator = iActualNumberOfProvinces - iStorageForProvinceNumber;
                                }
                                GeneratedTerrainArray[i] = Convert.ToString(iNumberOfProvincesGenerator) + " - Wzgorza, las";
                                break;
                            case 17:
                            case 47:
                                iAccumulatedBonusFromProvinces += 10;
                                iStorageForProvinceNumber = iActualNumberOfProvinces;
                                iActualNumberOfProvinces += (iNumberOfProvincesGenerator);
                                if (iActualNumberOfProvinces > iMaxNumberOfProvinces)
                                {
                                    int iStorage = iActualNumberOfProvinces;
                                    iActualNumberOfProvinces = iTesting;
                                    iNumberOfProvincesGenerator = iActualNumberOfProvinces - iStorageForProvinceNumber;
                                }
                                GeneratedTerrainArray[i] = Convert.ToString(iNumberOfProvincesGenerator) + " - Gory, krzaki";
                                break;
                            case 18:
                            case 48:
                                iAccumulatedBonusFromProvinces += 10;
                                iStorageForProvinceNumber = iActualNumberOfProvinces;
                                iActualNumberOfProvinces += (iNumberOfProvincesGenerator);
                                if (iActualNumberOfProvinces > iMaxNumberOfProvinces)
                                {
                                    int iStorage = iActualNumberOfProvinces;
                                    iActualNumberOfProvinces = iTesting;
                                    iNumberOfProvincesGenerator = iActualNumberOfProvinces - iStorageForProvinceNumber;
                                }
                                GeneratedTerrainArray[i] = Convert.ToString(iNumberOfProvincesGenerator) + " - Bagna, krzaki";
                                break;
                            case 19:
                            case 49:
                                iAccumulatedBonusFromProvinces += 10;
                                iStorageForProvinceNumber = iActualNumberOfProvinces;
                                iActualNumberOfProvinces += (iNumberOfProvincesGenerator);
                                if (iActualNumberOfProvinces > iMaxNumberOfProvinces)
                                {
                                    int iStorage = iActualNumberOfProvinces;
                                    iActualNumberOfProvinces = iTesting;
                                    iNumberOfProvincesGenerator = iActualNumberOfProvinces - iStorageForProvinceNumber;
                                }
                                GeneratedTerrainArray[i] = Convert.ToString(iNumberOfProvincesGenerator) + " - Pustkowia, krzaki";
                                break;
                            case 27:
                            case 57:
                                iAccumulatedBonusFromProvinces += 10;
                                iStorageForProvinceNumber = iActualNumberOfProvinces;
                                iActualNumberOfProvinces += (iNumberOfProvincesGenerator);
                                if (iActualNumberOfProvinces > iMaxNumberOfProvinces)
                                {
                                    int iStorage = iActualNumberOfProvinces;
                                    iActualNumberOfProvinces = iTesting;
                                    iNumberOfProvincesGenerator = iActualNumberOfProvinces - iStorageForProvinceNumber;
                                }
                                GeneratedTerrainArray[i] = Convert.ToString(iNumberOfProvincesGenerator) + " - Gory, las";
                                break;
                            case 28:
                            case 58:
                                iAccumulatedBonusFromProvinces += 10;
                                iStorageForProvinceNumber = iActualNumberOfProvinces;
                                iActualNumberOfProvinces += (iNumberOfProvincesGenerator);
                                if (iActualNumberOfProvinces > iMaxNumberOfProvinces)
                                {
                                    int iStorage = iActualNumberOfProvinces;
                                    iActualNumberOfProvinces = iTesting;
                                    iNumberOfProvincesGenerator = iActualNumberOfProvinces - iStorageForProvinceNumber;
                                }
                                GeneratedTerrainArray[i] = Convert.ToString(iNumberOfProvincesGenerator) + " - Bagna, trawa";
                                break;
                            case 29:
                            case 59:
                                iAccumulatedBonusFromProvinces += 10;
                                iStorageForProvinceNumber = iActualNumberOfProvinces;
                                iActualNumberOfProvinces += (iNumberOfProvincesGenerator);
                                if (iActualNumberOfProvinces > iMaxNumberOfProvinces)
                                {
                                    int iStorage = iActualNumberOfProvinces;
                                    iActualNumberOfProvinces = iTesting;
                                    iNumberOfProvincesGenerator = iActualNumberOfProvinces - iStorageForProvinceNumber;
                                }
                                GeneratedTerrainArray[i] = Convert.ToString(iNumberOfProvincesGenerator) + " - Pustkowia, trawa";
                                break;
                            case 77:
                                iAccumulatedBonusFromProvinces += 10;
                                iStorageForProvinceNumber = iActualNumberOfProvinces;
                                iActualNumberOfProvinces += (iNumberOfProvincesGenerator);
                                if (iActualNumberOfProvinces > iMaxNumberOfProvinces)
                                {
                                    int iStorage = iActualNumberOfProvinces;
                                    iActualNumberOfProvinces = iTesting;
                                    iNumberOfProvincesGenerator = iActualNumberOfProvinces - iStorageForProvinceNumber;
                                }
                                GeneratedTerrainArray[i] = Convert.ToString(iNumberOfProvincesGenerator) + " - Gory, trawa";
                                break;
                            case 78:
                                iAccumulatedBonusFromProvinces += 10;
                                iStorageForProvinceNumber = iActualNumberOfProvinces;
                                iActualNumberOfProvinces += (iNumberOfProvincesGenerator);
                                if (iActualNumberOfProvinces > iMaxNumberOfProvinces)
                                {
                                    int iStorage = iActualNumberOfProvinces;
                                    iActualNumberOfProvinces = iTesting;
                                    iNumberOfProvincesGenerator = iActualNumberOfProvinces - iStorageForProvinceNumber;
                                }
                                GeneratedTerrainArray[i] = Convert.ToString(iNumberOfProvincesGenerator) + " - Bagna, las";
                                break;
                            case 79:
                                iAccumulatedBonusFromProvinces += 10;
                                iStorageForProvinceNumber = iActualNumberOfProvinces;
                                iActualNumberOfProvinces += (iNumberOfProvincesGenerator);
                                if (iActualNumberOfProvinces > iMaxNumberOfProvinces)
                                {
                                    int iStorage = iActualNumberOfProvinces;
                                    iActualNumberOfProvinces = iTesting;
                                    iNumberOfProvincesGenerator = iActualNumberOfProvinces - iStorageForProvinceNumber;
                                }
                                GeneratedTerrainArray[i] = Convert.ToString(iNumberOfProvincesGenerator) + " - Pustkowia, las";
                                break;
                            case 81:
                                iNumberOfProvincesGenerator2 *= 20;
                                iAccumulatedBonusFromProvinces += 10;
                                iStorageForProvinceNumber = iActualNumberOfProvinces;
                                iActualNumberOfProvinces += (iNumberOfProvincesGenerator2);
                                if (iActualNumberOfProvinces > iMaxNumberOfProvinces)
                                {
                                    int iStorage = iActualNumberOfProvinces;
                                    iActualNumberOfProvinces = iTesting;
                                    iNumberOfProvincesGenerator2 = iActualNumberOfProvinces - iStorageForProvinceNumber;
                                }
                                GeneratedTerrainArray[i] = Convert.ToString(iNumberOfProvincesGenerator2) + " - Rowniny, las";
                                break;
                            case 82:
                                iNumberOfProvincesGenerator2 *= 20;
                                iAccumulatedBonusFromProvinces += 10;
                                iStorageForProvinceNumber = iActualNumberOfProvinces;
                                iActualNumberOfProvinces += (iNumberOfProvincesGenerator2);
                                if (iActualNumberOfProvinces > iMaxNumberOfProvinces)
                                {
                                    int iStorage = iActualNumberOfProvinces;
                                    iActualNumberOfProvinces = iTesting;
                                    iNumberOfProvincesGenerator2 = iActualNumberOfProvinces - iStorageForProvinceNumber;
                                }
                                GeneratedTerrainArray[i] = Convert.ToString(iNumberOfProvincesGenerator2) + " - Rowniny, krzaki";
                                break;
                            case 83:
                                iNumberOfProvincesGenerator2 *= 20;
                                iAccumulatedBonusFromProvinces += 10;
                                iStorageForProvinceNumber = iActualNumberOfProvinces;
                                iActualNumberOfProvinces += (iNumberOfProvincesGenerator2);
                                if (iActualNumberOfProvinces > iMaxNumberOfProvinces)
                                {
                                    int iStorage = iActualNumberOfProvinces;
                                    iActualNumberOfProvinces = iTesting;
                                    iNumberOfProvincesGenerator2 = iActualNumberOfProvinces - iStorageForProvinceNumber;
                                }
                                GeneratedTerrainArray[i] = Convert.ToString(iNumberOfProvincesGenerator2) + " - Rowniny, jalowe";
                                break;
                            case 84:
                                iNumberOfProvincesGenerator2 *= 20;
                                iAccumulatedBonusFromProvinces += 10;
                                iStorageForProvinceNumber = iActualNumberOfProvinces;
                                iActualNumberOfProvinces += (iNumberOfProvincesGenerator2);
                                if (iActualNumberOfProvinces > iMaxNumberOfProvinces)
                                {
                                    int iStorage = iActualNumberOfProvinces;
                                    iActualNumberOfProvinces = iTesting;
                                    iNumberOfProvincesGenerator2 = iActualNumberOfProvinces - iStorageForProvinceNumber;
                                }
                                GeneratedTerrainArray[i] = Convert.ToString(iNumberOfProvincesGenerator2) + " - Wzgorza, trawa";
                                break;
                            case 85:
                                iNumberOfProvincesGenerator2 *= 20;
                                iAccumulatedBonusFromProvinces += 10;
                                iStorageForProvinceNumber = iActualNumberOfProvinces;
                                iActualNumberOfProvinces += (iNumberOfProvincesGenerator2);
                                if (iActualNumberOfProvinces > iMaxNumberOfProvinces)
                                {
                                    int iStorage = iActualNumberOfProvinces;
                                    iActualNumberOfProvinces = iTesting;
                                    iNumberOfProvincesGenerator2 = iActualNumberOfProvinces - iStorageForProvinceNumber;
                                }
                                GeneratedTerrainArray[i] = Convert.ToString(iNumberOfProvincesGenerator2) + " - Wzgorza, krzaki";
                                break;
                            case 86:
                                iNumberOfProvincesGenerator2 *= 20;
                                iAccumulatedBonusFromProvinces += 10;
                                iStorageForProvinceNumber = iActualNumberOfProvinces;
                                iActualNumberOfProvinces += (iNumberOfProvincesGenerator2);
                                if (iActualNumberOfProvinces > iMaxNumberOfProvinces)
                                {
                                    int iStorage = iActualNumberOfProvinces;
                                    iActualNumberOfProvinces = iTesting;
                                    iNumberOfProvincesGenerator2 = iActualNumberOfProvinces - iStorageForProvinceNumber;
                                }
                                GeneratedTerrainArray[i] = Convert.ToString(iNumberOfProvincesGenerator2) + " - Wzgorza, jalowe";
                                break;
                            case 87:
                                iNumberOfProvincesGenerator2 *= 20;
                                iAccumulatedBonusFromProvinces += 10;
                                iStorageForProvinceNumber = iActualNumberOfProvinces;
                                iActualNumberOfProvinces += (iNumberOfProvincesGenerator2);
                                if (iActualNumberOfProvinces > iMaxNumberOfProvinces)
                                {
                                    int iStorage = iActualNumberOfProvinces;
                                    iActualNumberOfProvinces = iTesting;
                                    iNumberOfProvincesGenerator2 = iActualNumberOfProvinces - iStorageForProvinceNumber;
                                }
                                GeneratedTerrainArray[i] = Convert.ToString(iNumberOfProvincesGenerator2) + " - Gory, krzaki";
                                break;
                            case 88:
                                iNumberOfProvincesGenerator2 *= 20;
                                iAccumulatedBonusFromProvinces += 10;
                                iStorageForProvinceNumber = iActualNumberOfProvinces;
                                iActualNumberOfProvinces += (iNumberOfProvincesGenerator2);
                                if (iActualNumberOfProvinces > iMaxNumberOfProvinces)
                                {
                                    int iStorage = iActualNumberOfProvinces;
                                    iActualNumberOfProvinces = iTesting;
                                    iNumberOfProvincesGenerator2 = iActualNumberOfProvinces - iStorageForProvinceNumber;
                                }
                                GeneratedTerrainArray[i] = Convert.ToString(iNumberOfProvincesGenerator2) + " - Bagna, krzaki";
                                break;
                            case 89:
                                iNumberOfProvincesGenerator2 *= 20;
                                iAccumulatedBonusFromProvinces += 10;
                                iStorageForProvinceNumber = iActualNumberOfProvinces;
                                iActualNumberOfProvinces += (iNumberOfProvincesGenerator2);
                                if (iActualNumberOfProvinces > iMaxNumberOfProvinces)
                                {
                                    int iStorage = iActualNumberOfProvinces;
                                    iActualNumberOfProvinces = iTesting;
                                    iNumberOfProvincesGenerator2 = iActualNumberOfProvinces - iStorageForProvinceNumber;
                                }
                                GeneratedTerrainArray[i] = Convert.ToString(iNumberOfProvincesGenerator2) + " - Pustkowia, krzaki";
                                break;
                            case 91:
                                iNumberOfProvincesGenerator2 *= 50;
                                iAccumulatedBonusFromProvinces += 10;
                                iStorageForProvinceNumber = iActualNumberOfProvinces;
                                iActualNumberOfProvinces += (iNumberOfProvincesGenerator2);
                                if (iActualNumberOfProvinces > iMaxNumberOfProvinces)
                                {
                                    int iStorage = iActualNumberOfProvinces;
                                    iActualNumberOfProvinces = iTesting;
                                    iNumberOfProvincesGenerator2 = iActualNumberOfProvinces - iStorageForProvinceNumber;
                                }
                                GeneratedTerrainArray[i] = Convert.ToString(iNumberOfProvincesGenerator2) + " - Rowniny, las";
                                break;
                            case 92:
                                iNumberOfProvincesGenerator2 *= 50;
                                iAccumulatedBonusFromProvinces += 10;
                                iStorageForProvinceNumber = iActualNumberOfProvinces;
                                iActualNumberOfProvinces += (iNumberOfProvincesGenerator2);
                                if (iActualNumberOfProvinces > iMaxNumberOfProvinces)
                                {
                                    int iStorage = iActualNumberOfProvinces;
                                    iActualNumberOfProvinces = iTesting;
                                    iNumberOfProvincesGenerator2 = iActualNumberOfProvinces - iStorageForProvinceNumber;
                                }
                                GeneratedTerrainArray[i] = Convert.ToString(iNumberOfProvincesGenerator2) + " - Rowniny, krzaki";
                                break;
                            case 93:
                                iNumberOfProvincesGenerator2 *= 50;
                                iAccumulatedBonusFromProvinces += 10;
                                iStorageForProvinceNumber = iActualNumberOfProvinces;
                                iActualNumberOfProvinces += (iNumberOfProvincesGenerator2);
                                if (iActualNumberOfProvinces > iMaxNumberOfProvinces)
                                {
                                    int iStorage = iActualNumberOfProvinces;
                                    iActualNumberOfProvinces = iTesting;
                                    iNumberOfProvincesGenerator2 = iActualNumberOfProvinces - iStorageForProvinceNumber;
                                }
                                GeneratedTerrainArray[i] = Convert.ToString(iNumberOfProvincesGenerator2) + " - Rowniny, jalowe";
                                break;
                            case 94:
                                iNumberOfProvincesGenerator2 *= 50;
                                iAccumulatedBonusFromProvinces += 10;
                                iStorageForProvinceNumber = iActualNumberOfProvinces;
                                iActualNumberOfProvinces += (iNumberOfProvincesGenerator2);
                                if (iActualNumberOfProvinces > iMaxNumberOfProvinces)
                                {
                                    int iStorage = iActualNumberOfProvinces;
                                    iActualNumberOfProvinces = iTesting;
                                    iNumberOfProvincesGenerator2 = iActualNumberOfProvinces - iStorageForProvinceNumber;
                                }
                                GeneratedTerrainArray[i] = Convert.ToString(iNumberOfProvincesGenerator2) + " - Wzgorza, las";
                                break;
                            case 95:
                                iNumberOfProvincesGenerator2 *= 50;
                                iAccumulatedBonusFromProvinces += 10;
                                iStorageForProvinceNumber = iActualNumberOfProvinces;
                                iActualNumberOfProvinces += (iNumberOfProvincesGenerator2);
                                if (iActualNumberOfProvinces > iMaxNumberOfProvinces)
                                {
                                    int iStorage = iActualNumberOfProvinces;
                                    iActualNumberOfProvinces = iTesting;
                                    iNumberOfProvincesGenerator2 = iActualNumberOfProvinces - iStorageForProvinceNumber;
                                }
                                GeneratedTerrainArray[i] = Convert.ToString(iNumberOfProvincesGenerator2) + " - Wzgorza, krzaki";
                                break;
                            case 96:
                                iNumberOfProvincesGenerator2 *= 50;
                                iAccumulatedBonusFromProvinces += 10;
                                iStorageForProvinceNumber = iActualNumberOfProvinces;
                                iActualNumberOfProvinces += (iNumberOfProvincesGenerator2);
                                if (iActualNumberOfProvinces > iMaxNumberOfProvinces)
                                {
                                    int iStorage = iActualNumberOfProvinces;
                                    iActualNumberOfProvinces = iTesting;
                                    iNumberOfProvincesGenerator2 = iActualNumberOfProvinces - iStorageForProvinceNumber;
                                }
                                GeneratedTerrainArray[i] = Convert.ToString(iNumberOfProvincesGenerator2) + " - Wzgorza, jalowe";
                                break;
                            case 97:
                                iNumberOfProvincesGenerator2 *= 50;
                                iAccumulatedBonusFromProvinces += 10;
                                iStorageForProvinceNumber = iActualNumberOfProvinces;
                                iActualNumberOfProvinces += (iNumberOfProvincesGenerator2);
                                if (iActualNumberOfProvinces > iMaxNumberOfProvinces)
                                {
                                    int iStorage = iActualNumberOfProvinces;
                                    iActualNumberOfProvinces = iTesting;
                                    iNumberOfProvincesGenerator2 = iActualNumberOfProvinces - iStorageForProvinceNumber;
                                }
                                GeneratedTerrainArray[i] = Convert.ToString(iNumberOfProvincesGenerator2) + " - Gory, jalowe";
                                break;
                            case 98:
                                iNumberOfProvincesGenerator2 *= 50;
                                iAccumulatedBonusFromProvinces += 10;
                                iStorageForProvinceNumber = iActualNumberOfProvinces;
                                iActualNumberOfProvinces += (iNumberOfProvincesGenerator2);
                                if (iActualNumberOfProvinces > iMaxNumberOfProvinces)
                                {
                                    int iStorage = iActualNumberOfProvinces;
                                    iActualNumberOfProvinces = iTesting;
                                    iNumberOfProvincesGenerator2 = iActualNumberOfProvinces - iStorageForProvinceNumber;
                                }
                                GeneratedTerrainArray[i] = Convert.ToString(iNumberOfProvincesGenerator2) + " - Bagna, krzaki";
                                break;
                            case 99:
                                iNumberOfProvincesGenerator2 *= 50;
                                iAccumulatedBonusFromProvinces += 10;
                                iStorageForProvinceNumber = iActualNumberOfProvinces;
                                iActualNumberOfProvinces += (iNumberOfProvincesGenerator2);
                                if (iActualNumberOfProvinces > iMaxNumberOfProvinces)
                                {
                                    int iStorage = iActualNumberOfProvinces;
                                    iActualNumberOfProvinces = iTesting;
                                    iNumberOfProvincesGenerator2 = iActualNumberOfProvinces - iStorageForProvinceNumber;
                                }
                                GeneratedTerrainArray[i] = Convert.ToString(iNumberOfProvincesGenerator2) + " - Pustkowia, jalowe";
                                break;
                            default:
                                GeneratedTerrainArray[i] = "test";
                                break;
                        }
                    }

                    else
                    {
                        iAccumulatedBonusFromProvinces += 10;
                    }
                }
                if (iCurrentResult >= 100)
                {
                    switch (iCurrentResult)
                    {
                        case 100:
                            GeneratedTerrainArray[i] = "Gejzer";
                            iAccumulatedBonusFromProvinces = 0;
                            break;
                        case 101:
                            int iCavesGenerator = generator.Next(1, 100);
                            iAccumulatedBonusFromProvinces = 0;
                            GeneratedTerrainArray[i] = Convert.ToString(iCavesGenerator) + " - Jaskinie";
                            break;
                        case 102:
                            GeneratedTerrainArray[i] = "Jezioro";
                            iAccumulatedBonusFromProvinces = 0;
                            break;
                        case 103:
                            GeneratedTerrainArray[i] = "Pagórek";
                            iAccumulatedBonusFromProvinces = 0;
                            break;
                        case 104:
                            GeneratedTerrainArray[i] = "Samotna góra";
                            iAccumulatedBonusFromProvinces = 0;
                            break;
                        case 105:
                            GeneratedTerrainArray[i] = "Skarpa";
                            iAccumulatedBonusFromProvinces = 0;
                            break;
                        case 106:
                            GeneratedTerrainArray[i] = "Wir";
                            iAccumulatedBonusFromProvinces = 0;
                            break;
                        case 107:
                            GeneratedTerrainArray[i] = "Wodospad";
                            iAccumulatedBonusFromProvinces = 0;
                            break;
                        case 108:
                            GeneratedTerrainArray[i] = "Wulkan";
                            iAccumulatedBonusFromProvinces = 0;
                            break;
                        default:
                            GeneratedTerrainArray[i] = "Żyzna dolina";
                            iAccumulatedBonusFromProvinces = 0;
                            break;
                    }
                }
            }


            using (System.IO.StreamWriter file = new System.IO.StreamWriter(@"C:\Ksiestwa graniczne\KsiestwaGraniczne.txt", true))
            {
                file.WriteLine("Ilość pól oraz ich typ");
                file.WriteLine("=======");
            }

            for (int i = 0; i < iGeneratedNumber; i++)
            {
                using (System.IO.StreamWriter file = new System.IO.StreamWriter(@"C:\Ksiestwa graniczne\KsiestwaGraniczne.txt", true))
                {
                    file.WriteLine(GeneratedTerrainArray[i]);
                }
            }
            using (System.IO.StreamWriter file = new System.IO.StreamWriter(@"C:\Ksiestwa graniczne\KsiestwaGraniczne.txt", true))
            {
                file.WriteLine("=======");
            }
            AncientRuinCreator.AncientRuinCreatorGen();
        }
    }
}
