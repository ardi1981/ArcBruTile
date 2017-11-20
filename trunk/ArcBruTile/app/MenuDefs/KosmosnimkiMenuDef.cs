using ESRI.ArcGIS.SystemUI;

namespace BrutileArcGIS.MenuDefs
{
    public class KosmosnimkiMenuDef : IMenuDef
    {
        public string Caption
        {
            get { return "&Kosmosnimki"; }
        }
        public void GetItemInfo(int pos, IItemDef itemDef)
        {
            switch (pos)
            {
                case 0:
                    itemDef.ID = "AddKosmosnimkiStreetsLayerCommand";
                    itemDef.Group = false;
                    break;
            }

        }

        public int ItemCount
        {
            get { return 1; }
        }

        public string Name
        {
            get { return "BruTile"; }
        }
    }
}

