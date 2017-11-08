using BruTile.Web;

namespace BrutileArcGIS.Lib
{
    public class ConfigHelper
    {
        public static IConfig GetTmsConfig(string url, bool overwriteUrls)
        {
            return new ConfigTms(url, overwriteUrls);
        }

        public static IConfig GetConfig(EnumBruTileLayer enumBruTileLayer, string url, bool overwriteUrls)
        {
            IConfig result;

            if (enumBruTileLayer == EnumBruTileLayer.TMS)
            {
                result = new ConfigTms(url, overwriteUrls);
            }
            else if (enumBruTileLayer == EnumBruTileLayer.InvertedTMS)
            {
                result = new ConfigInvertedTMS(url);
            }
            else
            {
                result = new ConfigOsm(OsmMapType.Default);
            }

            return result;
        }

        public static IConfig GetConfig(EnumBruTileLayer enumBruTileLayer)
        {
            IConfig result = new ConfigOsm(OsmMapType.Default);

            if (enumBruTileLayer == EnumBruTileLayer.OSM)
            {
                result = new ConfigOsm(OsmMapType.Default);
            }
            return result;
        }
    }
}
