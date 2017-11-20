using ESRI.ArcGIS.SystemUI;

namespace BrutileArcGIS.MenuDefs
{
    public class GaodeMenuDef : IMenuDef
    {
        public string Caption
        {
            get { return "&Gaode"; }
        }
        public void GetItemInfo(int pos, IItemDef itemDef)
        {
            switch (pos)
            {
                case 0:
                    itemDef.ID = "AddGaodeStreetsLayerCommand";
                    itemDef.Group = false;
                    break;
                case 1:
                    itemDef.ID = "AddGaodeSatelliteLayerCommand";
                    itemDef.Group = false;
                    break;
            }
        }

        public int ItemCount
        {
            get { return 2; }
        }

        public string Name
        {
            get { return "BruTile"; }
        }
    }
}
