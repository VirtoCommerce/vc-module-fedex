using System;

namespace VirtoCommerce.FedExModule.Web
{
    public static class VolumeConverter
    {
        public static double ToCubeDimension(this double volume)
        {
            return Math.Pow(volume, 1.0 / 3.0);
        }
    }
}