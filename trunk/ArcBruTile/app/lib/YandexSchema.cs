using BruTile;
using BruTile.Predefined;

namespace BrutileArcGIS.lib
{
    public class YandexSchema : GlobalSphericalMercator
    {
        public YandexSchema()
        {
            Name = "YandexMaps";
            Format = "png";
            YAxis = YAxis.OSM;
            OriginY = -OriginY;
            Srs = "EPSG:3395";
        }
    }
}
