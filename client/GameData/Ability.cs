using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FFRKInspector.GameData
{
    abstract class Ability
    {       
        public virtual uint AbilityId { get { return 9999999; } }
        public virtual SchemaConstants.AbilityCategory Category { get { return SchemaConstants.AbilityCategory.None; } }
        public virtual SchemaConstants.ElementID Element { get { return SchemaConstants.ElementID.None; } }
        public virtual SchemaConstants.Formulas Formula { get { return SchemaConstants.Formulas.None; } }
        public virtual int MinimumDamage { get { return 0; } }
        public virtual double Multiplier { get { return 1; } }
        public abstract string Name { get; }
        public virtual int NumberOfHits { get { return 1; } }
        public virtual int Rarity { get { return 1; } }
        public const double AtkCap = 589.95023429747326088728466463427; // Atk^1.3 == 4000
        public const double MagCap = 1055.8049644771952131356256105084; // Mag^1.15 == 3000
        public const double NinCap = 370.60095144271811733509290520149; // Mag^0.575 == 30

        public override string ToString()
        {
            return Name;
        }
        
        private static List<Ability> mAbilities = null;
        public static List<Ability> AllAbilities() {
            if (mAbilities != null)
            {
                return mAbilities;
            }
            mAbilities = new List<Ability>();
            var abilities = System.Reflection.Assembly
                 .GetExecutingAssembly()
                 .GetTypes().Where(t => t.Namespace != null && t.Namespace.StartsWith("FFRKInspector.GameData.Abilities"));
            foreach(var ability in abilities)
            {
                mAbilities.Add((Ability)Activator.CreateInstance(ability));
            }
            mAbilities = mAbilities.OrderBy(ability => ability.Name).ToList();
            return mAbilities;
        }

        public virtual double CalculateDamage(double atk, double def, double mag, double res, double mnd)
        {
            switch (Formula)
            {
                case SchemaConstants.Formulas.Physical:
                    return PhysicalDamage(atk, def);
                case SchemaConstants.Formulas.Magical:
                    if (Category == SchemaConstants.AbilityCategory.WhiteMagic)
                    {
                        return MagicalDamage(mnd, res);
                    }
                    else if (Category == SchemaConstants.AbilityCategory.Ninja)
                    {
                        return NinjaDamage(mag);
                    }
                    return MagicalDamage(mag, res);
                case SchemaConstants.Formulas.Healing:
                    return HealingAmount(mnd);
                default:
                    return -5;
            }
        }

        public virtual double HealingAmount(double mnd)
        {
            return 5 + Math.Pow(mnd, 0.75) * 100.0 / 256.0;
        }
        
        public virtual double MagicalDamage(double mag, double res)
        {
            double normal_damage = ((mag < MagCap) ? Math.Pow(mag, 1.65) : 3000 * Math.Pow(mag, 0.5)) / Math.Pow(res, 0.5);
            if (MinimumDamage > 0 && MinimumDamage / Math.Pow(res, 0.05) > normal_damage * Multiplier)
            {
                normal_damage = MinimumDamage / Math.Pow(res, 0.05) / Multiplier;
            }
            return normal_damage;
        }

        public virtual double NinjaDamage(double mag)
        {
            return ((mag < NinCap) ? Math.Pow(mag, 0.575) : 30) * Math.Pow(mag, 0.25);
        }
        
        public virtual double PhysicalDamage(double atk, double def)
        {
            return ((atk < AtkCap) ? Math.Pow(atk, 1.8) : 4000 * Math.Pow(atk, 0.5)) / Math.Pow(def, 0.5);
        }

        public virtual bool IsJumpAttack()
        {
            return false;
        }
    }
}
