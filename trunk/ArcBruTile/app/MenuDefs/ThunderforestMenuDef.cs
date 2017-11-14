using ESRI.ArcGIS.SystemUI;

namespace BrutileArcGIS.MenuDefs
{
    public class ThunderforestMenuDef : IMenuDef
    {
        public string Caption
        {
            get { return "&Thunderforest"; }
        }

        public void GetItemInfo(int pos, IItemDef itemDef)
        {
            switch (pos)
            {
                case 0:
                    itemDef.ID = "AddThunderforestOpenCycleLayerCommand";
                    itemDef.Group = false;
                    break;
                case 1:
                    itemDef.ID = "AddThunderforestTransportLayerCommand";
                    itemDef.Group = false;
                    break;
                case 2:
                    itemDef.ID = "AddThunderforestTransportDarkLayerCommand";
                    itemDef.Group = false;
                    break;
                case 3:
                    itemDef.ID = "AddThunderforestLandscapeLayerCommand";
                    itemDef.Group = false;
                    break;
                case 4:
                    itemDef.ID = "AddThunderforestSpinalLayerCommand";
                    itemDef.Group = false;
                    break;
                case 5:
                    itemDef.ID = "AddThunderforestOutdoorsLayerCommand";
                    itemDef.Group = false;
                    break;
                case 6:
                    itemDef.ID = "AddThunderforestPioneerLayerCommand";
                    itemDef.Group = false;
                    break;



            }
        }

        public int ItemCount
        {
            get { return 7; }
        }

        public string Name
        {
            get { return "BruTile"; }
        }
    }
}
