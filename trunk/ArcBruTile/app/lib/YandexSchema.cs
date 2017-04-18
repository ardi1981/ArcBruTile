using BruTile;
using BruTile.Predefined;

namespace BrutileArcGIS.lib
{
    public class YandexSchema : SphericalMercatorWorldSchema
    {
        public YandexSchema()
        {
            Name = "YandexMaps";
            Format = "png";
            Axis = AxisDirection.InvertedY;
            OriginY = -OriginY;
            Srs = "EPSG:3395";
        }
    }
}
