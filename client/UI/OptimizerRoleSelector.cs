using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FFRKInspector.UI
{
    public partial class OptimizerRoleSelector : Form
    {
        public enum Roles { Healer, Magical, Physical };
        private Label[] nameLabels = new Label[5];
        private ComboBox[] roleBoxes = new ComboBox[5];
        private CheckBox[] recordMateriaBoxes = new CheckBox[5];
        public OptimizerRoleSelector()
        {
            InitializeComponent();
            
            nameLabels[0] = labelCharacter1;
            nameLabels[1] = labelCharacter2;
            nameLabels[2] = labelCharacter3;
            nameLabels[3] = labelCharacter4;
            nameLabels[4] = labelCharacter5;

            roleBoxes[0] = comboBoxRole1;
            roleBoxes[1] = comboBoxRole2;
            roleBoxes[2] = comboBoxRole3;
            roleBoxes[3] = comboBoxRole4;
            roleBoxes[4] = comboBoxRole5;

            recordMateriaBoxes[0] = checkBoxIgnoreRecordMateria1;
            recordMateriaBoxes[1] = checkBoxIgnoreRecordMateria2;
            recordMateriaBoxes[2] = checkBoxIgnoreRecordMateria3;
            recordMateriaBoxes[3] = checkBoxIgnoreRecordMateria4;
            recordMateriaBoxes[4] = checkBoxIgnoreRecordMateria5;

            for (int i = 0; i < roleBoxes.Length; i++)
            {
                foreach (var role in Enum.GetValues(typeof(Roles)))
                {
                    roleBoxes[i].Items.Add(role);
                }
            }

            toolTipSearchLessEquipment.SetToolTip(checkBoxSearchLessEquipment, 
                "If this is checked, the system will only look at the very best item in each equippable category\n"
                + "and items with elemental multipliers. Without this checked, if an item will put a character's damage\n"
                + "farther over the damage cap than they already are, it won't use that item. It will check up to\n"
                + "5 items per category rather than 1.");
        }

        public void SetInitialRoles(object[] rawCharacters, uint seriesId, GameData.SchemaConstants.AbilityCategory nightmareCategory)
        {
            GameData.DataBuddyInformation[] characters = (GameData.DataBuddyInformation[])rawCharacters;
            List<GameData.DataBuddyInformation> atkCharacters = new List<GameData.DataBuddyInformation>();
            var charactersWithMultiHitSoulBreaksAndLifesiphon = characters.Where(character =>
                character != null && character.UsableSoulBreaks.Any(sb => sb.NumberOfHits > 1 && sb.Formula == GameData.SchemaConstants.Formulas.Physical)
                && character.CanUseAbility(new GameData.Abilities.Lifesiphon()))
                .OrderByDescending(character => character.UsableSoulBreaks.DefaultIfEmpty().Max(sb => sb != null ? sb.Multiplier * sb.NumberOfHits : 0));

            atkCharacters.AddRange(charactersWithMultiHitSoulBreaksAndLifesiphon);
            var otherCharacters = characters.Except(charactersWithMultiHitSoulBreaksAndLifesiphon);
            var otherPhysicalCharacters = otherCharacters.Where(character => character != null && character.Atk > character.Mag && character.Atk > character.Mnd)
                .OrderByDescending(character => character.UsableSoulBreaks.DefaultIfEmpty().Max(sb => sb != null ? (sb.Multiplier * sb.NumberOfHits) : 0));
            atkCharacters.AddRange(otherPhysicalCharacters);
            otherCharacters = characters.Except(atkCharacters);
            var magCharacters = otherCharacters.Where(character => character != null && character.Mag > character.Atk && character.Mag > character.Mnd)
                .OrderByDescending(character => character.UsableSoulBreaks.DefaultIfEmpty().Max(sb => sb != null ? sb.Multiplier * sb.NumberOfHits : 0));
            List<GameData.DataBuddyInformation> mndCharacters = otherCharacters.Except(magCharacters).ToList();
            if (mndCharacters.Count == 0)
            {
                GameData.DataBuddyInformation healer = atkCharacters.Where(character => character != null && character.AbilityUsage.Any(ab => ab.Category == GameData.SchemaConstants.AbilityCategory.WhiteMagic))
                    .OrderBy(character => character.AbilityUsage.Where(ab => ab.Category == GameData.SchemaConstants.AbilityCategory.WhiteMagic).First().Rarity)
                    .ThenBy(character => character.StatWithSynergy("Mnd", (character.SeriesId == seriesId ||
                        character.EligibleForNightmareShift(nightmareCategory)))).Last();
                atkCharacters.Remove(healer);
                mndCharacters.Add(healer);
            }
            
            for(int i = 0; i < 5; i++)
            {
                if (characters[i] == null)
                {
                    nameLabels[i].Text = "";
                    roleBoxes[i].Text = "";
                    roleBoxes[i].SelectedIndex = -1;
                    continue;
                }

                nameLabels[i].Text = characters[i].ToString();

                if (mndCharacters.Any(character => character != null && character.BuddyId == characters[i].BuddyId))
                {
                    roleBoxes[i].SelectedItem = Roles.Healer;
                    continue;
                }

                if (magCharacters.Any(character => character != null && character.BuddyId == characters[i].BuddyId))
                {
                    roleBoxes[i].SelectedItem = Roles.Magical;
                    continue;
                }

                roleBoxes[i].SelectedItem = Roles.Physical;
            }
        }

        public Roles[] roles()
        {
            return roleBoxes.Select(roleBox => roleBox.SelectedItem != null ? (Roles)(roleBox.SelectedItem) : default(Roles)).ToArray();
        }

        public bool[] IgnoreRecordMaterias
        {
            get
            {
                return recordMateriaBoxes.Select(rm => rm.Checked).ToArray();
            }
        }

        public bool ClearExistingEquipmentSelections
        {
            get
            {
                return checkBoxClearEquipment.Checked;
            }
        }

        public bool SearchLessEquipment
        {
            get
            {
                return checkBoxSearchLessEquipment.Checked;
            }
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Close();
        }
    }
}
