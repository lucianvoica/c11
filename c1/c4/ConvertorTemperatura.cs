using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c4
{
    public static class ConvertorTemperatura
    {
        private const int kelvinFactor = 273;
        private const float fToCFactor1 = 1.8F;
        private const float fToCFactor2 = 32;

        public static float ConvertCelsiusToKelvin(float tempC)
        {
            return tempC + kelvinFactor;
        }
        public static float ConvertCToF(float tempC)
        {
            return tempC * fToCFactor1 + fToCFactor2;
        }

        public static float ConvertKToC(float tempK)
        {
            return tempK - kelvinFactor;
        }
    }
}
