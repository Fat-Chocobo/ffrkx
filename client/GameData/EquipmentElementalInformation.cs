using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FFRKInspector.GameData
{
    static class EquipmentElementalInformation
    {
        private static Dictionary<uint, SchemaConstants.ElementID> mElementalEquipment = new Dictionary<uint, SchemaConstants.ElementID>() {
            {21001069, SchemaConstants.ElementID.Fire},
            {21001086, SchemaConstants.ElementID.Fire},
            {21002013, SchemaConstants.ElementID.Fire},
            {21002071, SchemaConstants.ElementID.Fire},
            {21006036, SchemaConstants.ElementID.Fire},
            {21007032, SchemaConstants.ElementID.Fire},
            {21008005, SchemaConstants.ElementID.Fire},
            {21008048, SchemaConstants.ElementID.Fire},
            {21009013, SchemaConstants.ElementID.Fire},
            {21010004, SchemaConstants.ElementID.Fire},
            {22051031, SchemaConstants.ElementID.Fire},
            {22056044, SchemaConstants.ElementID.Fire},
            {21002019, SchemaConstants.ElementID.Ice},
            {21002072, SchemaConstants.ElementID.Ice},
            {21002097, SchemaConstants.ElementID.Ice},
            {21006010, SchemaConstants.ElementID.Ice},
            {21008017, SchemaConstants.ElementID.Ice},
            {21008003, SchemaConstants.ElementID.Ice},
            {21008078, SchemaConstants.ElementID.Ice},
            {21008026, SchemaConstants.ElementID.Ice},
            {21009012, SchemaConstants.ElementID.Ice},
            {21009035, SchemaConstants.ElementID.Ice},
            {21010005, SchemaConstants.ElementID.Ice},
            {21012003, SchemaConstants.ElementID.Ice},
            {21001090, SchemaConstants.ElementID.Lightning},
            {21002005, SchemaConstants.ElementID.Lightning},
            {21002079, SchemaConstants.ElementID.Lightning},
            {21002081, SchemaConstants.ElementID.Lightning},
            {21002163, SchemaConstants.ElementID.Lightning},
            {21002069, SchemaConstants.ElementID.Lightning},
            {21005006, SchemaConstants.ElementID.Lightning},
            {21006007, SchemaConstants.ElementID.Lightning},
            {21008006, SchemaConstants.ElementID.Lightning},
            {21008049, SchemaConstants.ElementID.Lightning},
            {21008013, SchemaConstants.ElementID.Lightning},
            {21009011, SchemaConstants.ElementID.Lightning},
            {21009017, SchemaConstants.ElementID.Lightning},
            {21010006, SchemaConstants.ElementID.Lightning},
            {22050044, SchemaConstants.ElementID.Lightning},
            {21005004, SchemaConstants.ElementID.Earth},
            {21008007, SchemaConstants.ElementID.Earth},
            {21009007, SchemaConstants.ElementID.Earth},
            {22055015, SchemaConstants.ElementID.Earth},
            {22055021, SchemaConstants.ElementID.Earth},
            {21001045, SchemaConstants.ElementID.Wind},
            {21001085, SchemaConstants.ElementID.Wind},
            {21007008, SchemaConstants.ElementID.Wind},
            {21009001, SchemaConstants.ElementID.Wind},
            {22051021, SchemaConstants.ElementID.Wind},
            {21003017, SchemaConstants.ElementID.Water},
            {21002153, SchemaConstants.ElementID.Holy},
            {21002136, SchemaConstants.ElementID.Holy},
            {21002103, SchemaConstants.ElementID.Holy},
            {21002062, SchemaConstants.ElementID.Holy},
            {21008030, SchemaConstants.ElementID.Holy},
            {21008004, SchemaConstants.ElementID.Holy},
            {21008060, SchemaConstants.ElementID.Holy},
            {21008037, SchemaConstants.ElementID.Holy},
            {21008054, SchemaConstants.ElementID.Holy},
            {21009018, SchemaConstants.ElementID.Holy},
            {21009014, SchemaConstants.ElementID.Holy},
            {21009048, SchemaConstants.ElementID.Holy},
            {21009054, SchemaConstants.ElementID.Holy},
            {22050038, SchemaConstants.ElementID.Holy},
            {21002026, SchemaConstants.ElementID.Dark},
            {21002157, SchemaConstants.ElementID.Dark},
            {21002149, SchemaConstants.ElementID.Dark},
            {22054040, SchemaConstants.ElementID.Dark},
            {22054050, SchemaConstants.ElementID.Dark},
            {21008009, SchemaConstants.ElementID.Poison}
        };
        public static Dictionary<uint, SchemaConstants.ElementID> ElementalEquipment
        {
            get
            {
                return mElementalEquipment;
            }
        }
    }
}
