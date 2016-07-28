using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FFRKInspector.GameData
{
    abstract class SoulBreak : Ability
    {
        public virtual uint SoulBreakId { get { return 0; } }
        public virtual SchemaConstants.BuddyID BuddyId { get { return SchemaConstants.BuddyID.DESHI; } }

        private static List<SoulBreak> mSoulBreaks = null;
        public static List<SoulBreak> AllSoulBreaks()
        {
            if (mSoulBreaks != null)
            {
                return mSoulBreaks;
            }
            mSoulBreaks = new List<SoulBreak>();
            var soulBreaks = System.Reflection.Assembly
                 .GetExecutingAssembly()
                 .GetTypes().Where(t => t.Namespace != null && t.Namespace.StartsWith("FFRKInspector.GameData.SoulBreaks"));
            foreach (var soulBreak in soulBreaks)
            {
                mSoulBreaks.Add((SoulBreak)Activator.CreateInstance(soulBreak));
            }
            mSoulBreaks = mSoulBreaks.OrderBy(soulBreak => soulBreak.Name).ToList();
            return mSoulBreaks;
        }
    }
}
