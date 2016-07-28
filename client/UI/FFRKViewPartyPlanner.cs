using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FFRKInspector.Proxy;
using FFRKInspector.GameData.Party;


namespace FFRKInspector.UI
{
    public partial class FFRKViewPartyPlanner : UserControl
    {
        private ComboBox[] characterBoxes = new ComboBox[5];
        private ComboBox[] abilityBoxes = new ComboBox[10];
        private ToolTip[] abilityTooltips = new ToolTip[10];
        private ComboBox[] soulBreakBoxes = new ComboBox[5];
        private ComboBox[] weaponBoxes = new ComboBox[5];
        private ComboBox[] armorBoxes = new ComboBox[5];
        private ComboBox[] accessoryBoxes = new ComboBox[5];
        private ComboBox[] recordMateriaBoxes = new ComboBox[5];
        private TextBox[] hpFields = new TextBox[5];
        private TextBox[] atkFields = new TextBox[5];
        private TextBox[] magFields = new TextBox[5];
        private TextBox[] mndFields = new TextBox[5];
        private TextBox[] defFields = new TextBox[5];
        private TextBox[] resFields = new TextBox[5];
        private TextBox[] evaFields = new TextBox[5];
        private TextBox[] spdFields = new TextBox[5];
        private TextBox[] abilityDamageFields = new TextBox[10];
        private ToolTip[] abilityDamageTooltips = new ToolTip[10];
        private TextBox[] soulBreakDamageFields = new TextBox[5];
        private ToolTip[] soulBreakDamageTooltips = new ToolTip[5];
        private EquipmentSelectorModal equipmentModal = new EquipmentSelectorModal();
        private TextInput textInputModal = new TextInput();
        private ProgressDisplay progressDisplay = new ProgressDisplay();
        private OptimizerRoleSelector optimizerRoleSelector = new OptimizerRoleSelector();
        private Dictionary<string, PartyData> savedPartyData = new Dictionary<string, PartyData>();
        private Dictionary<uint, int> abilityCounts = new Dictionary<uint, int>();
        private bool skipRecalculations = true;

        public class ElementAdvantage
        {
            public ElementAdvantage(string name, uint advantageId, float multiplier)
            {
                Name = name;
                AdvantageId = advantageId;
                Multiplier = multiplier;
            }
            public string Name { get; set; }
            public uint AdvantageId { get; set; }
            public float Multiplier { get; set; }
            public override string ToString()
            {
                return Name;
            }
        }

        public class Synergy
        {
            public Synergy(string name, uint seriesId, GameData.SchemaConstants.AbilityCategory nightmareCategory)
            {
                Name = name;
                SeriesId = seriesId;
                NightmareCategory = nightmareCategory;
            }
            public string Name { get; set; }
            public uint SeriesId { get; set; }
            public GameData.SchemaConstants.AbilityCategory NightmareCategory { get; set; }
            public override string ToString()
            {
                return Name;
            }
        }

        public FFRKViewPartyPlanner()
        {
            InitializeComponent();
            characterBoxes[0] = comboBoxPartyMember1;
            characterBoxes[1] = comboBoxPartyMember2;
            characterBoxes[2] = comboBoxPartyMember3;
            characterBoxes[3] = comboBoxPartyMember4;
            characterBoxes[4] = comboBoxPartyMember5;

            abilityBoxes[0] = comboBoxAbility1;
            abilityBoxes[1] = comboBoxAbility2;
            abilityBoxes[2] = comboBoxAbility3;
            abilityBoxes[3] = comboBoxAbility4;
            abilityBoxes[4] = comboBoxAbility5;
            abilityBoxes[5] = comboBoxAbility6;
            abilityBoxes[6] = comboBoxAbility7;
            abilityBoxes[7] = comboBoxAbility8;
            abilityBoxes[8] = comboBoxAbility9;
            abilityBoxes[9] = comboBoxAbility10;

            abilityTooltips[0] = toolTipAbility1;
            abilityTooltips[1] = toolTipAbility2;
            abilityTooltips[2] = toolTipAbility3;
            abilityTooltips[3] = toolTipAbility4;
            abilityTooltips[4] = toolTipAbility5;
            abilityTooltips[5] = toolTipAbility6;
            abilityTooltips[6] = toolTipAbility7;
            abilityTooltips[7] = toolTipAbility8;
            abilityTooltips[8] = toolTipAbility9;
            abilityTooltips[9] = toolTipAbility10;

            soulBreakBoxes[0] = comboBoxSoulBreak1;
            soulBreakBoxes[1] = comboBoxSoulBreak2;
            soulBreakBoxes[2] = comboBoxSoulBreak3;
            soulBreakBoxes[3] = comboBoxSoulBreak4;
            soulBreakBoxes[4] = comboBoxSoulBreak5;

            weaponBoxes[0] = comboBoxWeapon1;
            weaponBoxes[1] = comboBoxWeapon2;
            weaponBoxes[2] = comboBoxWeapon3;
            weaponBoxes[3] = comboBoxWeapon4;
            weaponBoxes[4] = comboBoxWeapon5;

            armorBoxes[0] = comboBoxArmor1;
            armorBoxes[1] = comboBoxArmor2;
            armorBoxes[2] = comboBoxArmor3;
            armorBoxes[3] = comboBoxArmor4;
            armorBoxes[4] = comboBoxArmor5;

            accessoryBoxes[0] = comboBoxAccessory1;
            accessoryBoxes[1] = comboBoxAccessory2;
            accessoryBoxes[2] = comboBoxAccessory3;
            accessoryBoxes[3] = comboBoxAccessory4;
            accessoryBoxes[4] = comboBoxAccessory5;

            recordMateriaBoxes[0] = comboBoxRecordMateria1;
            recordMateriaBoxes[1] = comboBoxRecordMateria2;
            recordMateriaBoxes[2] = comboBoxRecordMateria3;
            recordMateriaBoxes[3] = comboBoxRecordMateria4;
            recordMateriaBoxes[4] = comboBoxRecordMateria5;

            hpFields[0] = textBoxHP1;
            hpFields[1] = textBoxHP2;
            hpFields[2] = textBoxHP3;
            hpFields[3] = textBoxHP4;
            hpFields[4] = textBoxHP5;

            atkFields[0] = textBoxAtk1;
            atkFields[1] = textBoxAtk2;
            atkFields[2] = textBoxAtk3;
            atkFields[3] = textBoxAtk4;
            atkFields[4] = textBoxAtk5;

            magFields[0] = textBoxMag1;
            magFields[1] = textBoxMag2;
            magFields[2] = textBoxMag3;
            magFields[3] = textBoxMag4;
            magFields[4] = textBoxMag5;

            mndFields[0] = textBoxMnd1;
            mndFields[1] = textBoxMnd2;
            mndFields[2] = textBoxMnd3;
            mndFields[3] = textBoxMnd4;
            mndFields[4] = textBoxMnd5;

            defFields[0] = textBoxDef1;
            defFields[1] = textBoxDef2;
            defFields[2] = textBoxDef3;
            defFields[3] = textBoxDef4;
            defFields[4] = textBoxDef5;

            resFields[0] = textBoxRes1;
            resFields[1] = textBoxRes2;
            resFields[2] = textBoxRes3;
            resFields[3] = textBoxRes4;
            resFields[4] = textBoxRes5;

            evaFields[0] = textBoxEva1;
            evaFields[1] = textBoxEva2;
            evaFields[2] = textBoxEva3;
            evaFields[3] = textBoxEva4;
            evaFields[4] = textBoxEva5;

            spdFields[0] = textBoxSpd1;
            spdFields[1] = textBoxSpd2;
            spdFields[2] = textBoxSpd3;
            spdFields[3] = textBoxSpd4;
            spdFields[4] = textBoxSpd5;

            abilityDamageFields[0] = textBoxAbilityDamage1;
            abilityDamageFields[1] = textBoxAbilityDamage2;
            abilityDamageFields[2] = textBoxAbilityDamage3;
            abilityDamageFields[3] = textBoxAbilityDamage4;
            abilityDamageFields[4] = textBoxAbilityDamage5;
            abilityDamageFields[5] = textBoxAbilityDamage6;
            abilityDamageFields[6] = textBoxAbilityDamage7;
            abilityDamageFields[7] = textBoxAbilityDamage8;
            abilityDamageFields[8] = textBoxAbilityDamage9;
            abilityDamageFields[9] = textBoxAbilityDamage10;

            abilityDamageTooltips[0] = toolTipAbilityDamage1;
            abilityDamageTooltips[1] = toolTipAbilityDamage2;
            abilityDamageTooltips[2] = toolTipAbilityDamage3;
            abilityDamageTooltips[3] = toolTipAbilityDamage4;
            abilityDamageTooltips[4] = toolTipAbilityDamage5;
            abilityDamageTooltips[5] = toolTipAbilityDamage6;
            abilityDamageTooltips[6] = toolTipAbilityDamage7;
            abilityDamageTooltips[7] = toolTipAbilityDamage8;
            abilityDamageTooltips[8] = toolTipAbilityDamage9;
            abilityDamageTooltips[9] = toolTipAbilityDamage10;

            soulBreakDamageFields[0] = textBoxSoulBreakDamage1;
            soulBreakDamageFields[1] = textBoxSoulBreakDamage2;
            soulBreakDamageFields[2] = textBoxSoulBreakDamage3;
            soulBreakDamageFields[3] = textBoxSoulBreakDamage4;
            soulBreakDamageFields[4] = textBoxSoulBreakDamage5;

            soulBreakDamageTooltips[0] = toolTipSoulBreakDamage1;
            soulBreakDamageTooltips[1] = toolTipSoulBreakDamage2;
            soulBreakDamageTooltips[2] = toolTipSoulBreakDamage3;
            soulBreakDamageTooltips[3] = toolTipSoulBreakDamage4;
            soulBreakDamageTooltips[4] = toolTipSoulBreakDamage5;

            foreach (GameData.RealmSynergy.SynergyValue synergy in GameData.RealmSynergy.Values)
            {
                comboBoxRealmSynergy.Items.Add(new Synergy(synergy.Text, synergy.GameSeries, GameData.SchemaConstants.AbilityCategory.None));
            }
            comboBoxRealmSynergy.Items.Add(new Synergy("Ultima Nightmare", 401001, GameData.SchemaConstants.AbilityCategory.BlackMagic));
            comboBoxRealmSynergy.Items.Add(new Synergy("Crushdown Nightmare", 402001, GameData.SchemaConstants.AbilityCategory.Combat));
            comboBoxRealmSynergy.Items.Add(new Synergy("Reraise Nightmare", 403001, GameData.SchemaConstants.AbilityCategory.WhiteMagic));
            comboBoxRealmSynergy.Items.Add(new Synergy("Neo Bahamut Nightmare", 404001, GameData.SchemaConstants.AbilityCategory.Summoning));
            comboBoxRealmSynergy.Items.Add(new Synergy("Tetra Foul Nightmare", 405001, GameData.SchemaConstants.AbilityCategory.Support));
            comboBoxRealmSynergy.Items.Add(new Synergy("Northern Cross Nightmare", 406001, GameData.SchemaConstants.AbilityCategory.Celerity));
            comboBoxRealmSynergy.Items.Add(new Synergy("Meltdown Nightmare", 407001, GameData.SchemaConstants.AbilityCategory.BlackMagic));

            equipmentModal.UpdateRealmSynergies(comboBoxRealmSynergy.Items);
            fillBossElementalReactions();
            LoadSavedParties();
            skipRecalculations = false;
        }

        private string SavedPartiesFilePath
        {
            get
            {
                string dirPath = System.Reflection.Assembly.GetExecutingAssembly().Location;
                dirPath = System.IO.Path.GetDirectoryName(dirPath);
                return dirPath + @"\" + "partyData.json";
            }
        }

        private void LoadSavedParties()
        {
            try
            {
                string input = System.IO.File.ReadAllText(SavedPartiesFilePath);
                savedPartyData = Newtonsoft.Json.JsonConvert.DeserializeObject<Dictionary<string, PartyData>>(input);
            }
            catch (Exception) { }
            if (savedPartyData == null)
            {
                savedPartyData = new Dictionary<string, PartyData>();
            }
            RefreshSavedParties();
        }

        private void RefreshSavedParties()
        {
            comboBoxSavedParties.Items.Clear();
            comboBoxSavedParties.SelectedIndex = -1;
            comboBoxSavedParties.Text = "";
            foreach (string partyName in savedPartyData.Keys.OrderBy(name => name))
            {
                comboBoxSavedParties.Items.Add(partyName);
            }
        }
        private void FFRKViewPartyPlanner_Load(object sender, EventArgs e)
        {
            if (DesignMode)
                return;

            if (FFRKProxy.Instance != null)
            {
                FFRKProxy.Instance.OnPartyList += FFRKProxy_OnPartyList;

                DataPartyDetails party = FFRKProxy.Instance.GameState.PartyDetails;
                if (party != null)
                {
                    UpdateDropdowns();
                }
            }
        }

        private void UpdateDropdowns()
        {
            DataPartyDetails party = FFRKProxy.Instance.GameState.PartyDetails;
            
            GameData.DataBuddyInformation[] selectedCharacters = new GameData.DataBuddyInformation[5];
            int[] selectedCharacterIndices = new int[5];
            for (int i = 0; i < 5; i++)
            {
                selectedCharacters[i] = (GameData.DataBuddyInformation)characterBoxes[i].SelectedItem;
                selectedCharacterIndices[i] = -1;
                characterBoxes[i].Items.Clear();
            }

            int tempIndex;
            foreach (GameData.DataBuddyInformation buddy in party.Buddies.OrderBy(buddy => buddy.Name))
            {
                for (int i = 0; i < 5; i++)
                {
                    tempIndex = characterBoxes[i].Items.Add(buddy);
                    if (selectedCharacters[i] != null && selectedCharacters[i].BuddyId == buddy.BuddyId)
                    {
                        selectedCharacterIndices[i] = tempIndex;
                    }
                }
            }

            for (int i = 0; i < 5; i++)
            {
                if (selectedCharacterIndices[i] > -1)
                {
                    characterBoxes[i].SelectedIndex = selectedCharacterIndices[i];
                }
                else
                {
                    characterBoxes[i].Text = "Character";
                }
                UpdateDropdownsForCharacter(i);
            }

            abilityCounts.Clear();
            var groupedAbilities = party.Abilities.GroupBy(ability => ability.AbilityId, ability => ability.Name);
            foreach (var group in groupedAbilities)
            {
                abilityCounts[group.Key] = group.Count();
            }
        }
              
        void FFRKProxy_OnPartyList(DataPartyDetails party)
        {
            BeginInvoke((Action)(() =>
            {
                UpdateDropdowns();
            }));
        }

        private GameData.DataBuddyInformation[] characters
        {
            get { return new GameData.DataBuddyInformation[] {
                (GameData.DataBuddyInformation)comboBoxPartyMember1.SelectedItem,
                (GameData.DataBuddyInformation)comboBoxPartyMember2.SelectedItem,
                (GameData.DataBuddyInformation)comboBoxPartyMember3.SelectedItem,
                (GameData.DataBuddyInformation)comboBoxPartyMember4.SelectedItem,
                (GameData.DataBuddyInformation)comboBoxPartyMember5.SelectedItem};
            }
        }

        private FFRKInspector.GameData.Ability[] abilities
        {
            get
            {
                return new FFRKInspector.GameData.Ability[] {
                (FFRKInspector.GameData.Ability)comboBoxAbility1.SelectedItem,
                (FFRKInspector.GameData.Ability)comboBoxAbility2.SelectedItem,
                (FFRKInspector.GameData.Ability)comboBoxAbility3.SelectedItem,
                (FFRKInspector.GameData.Ability)comboBoxAbility4.SelectedItem,
                (FFRKInspector.GameData.Ability)comboBoxAbility5.SelectedItem,
                (FFRKInspector.GameData.Ability)comboBoxAbility6.SelectedItem,
                (FFRKInspector.GameData.Ability)comboBoxAbility7.SelectedItem,
                (FFRKInspector.GameData.Ability)comboBoxAbility8.SelectedItem,
                (FFRKInspector.GameData.Ability)comboBoxAbility9.SelectedItem,
                (FFRKInspector.GameData.Ability)comboBoxAbility10.SelectedItem};
            }
        }

        private GameData.SoulBreak[] soulBreaks
        {
            get
            {
                return new GameData.SoulBreak[] {
                (GameData.SoulBreak)comboBoxSoulBreak1.SelectedItem,
                (GameData.SoulBreak)comboBoxSoulBreak2.SelectedItem,
                (GameData.SoulBreak)comboBoxSoulBreak3.SelectedItem,
                (GameData.SoulBreak)comboBoxSoulBreak4.SelectedItem,
                (GameData.SoulBreak)comboBoxSoulBreak5.SelectedItem};
            }
        }
        
        private DataEquipmentInformation[] weapons
        {
            get
            {
                return new DataEquipmentInformation[] {
                (DataEquipmentInformation)comboBoxWeapon1.SelectedItem,
                (DataEquipmentInformation)comboBoxWeapon2.SelectedItem,
                (DataEquipmentInformation)comboBoxWeapon3.SelectedItem,
                (DataEquipmentInformation)comboBoxWeapon4.SelectedItem,
                (DataEquipmentInformation)comboBoxWeapon5.SelectedItem};
            }
        }

        private DataEquipmentInformation[] armors
        {
            get
            {
                return new DataEquipmentInformation[] {
                (DataEquipmentInformation)comboBoxArmor1.SelectedItem,
                (DataEquipmentInformation)comboBoxArmor2.SelectedItem,
                (DataEquipmentInformation)comboBoxArmor3.SelectedItem,
                (DataEquipmentInformation)comboBoxArmor4.SelectedItem,
                (DataEquipmentInformation)comboBoxArmor5.SelectedItem};
            }
        }

        private DataEquipmentInformation[] accessories
        {
            get
            {
                return new DataEquipmentInformation[] {
                (DataEquipmentInformation)comboBoxAccessory1.SelectedItem,
                (DataEquipmentInformation)comboBoxAccessory2.SelectedItem,
                (DataEquipmentInformation)comboBoxAccessory3.SelectedItem,
                (DataEquipmentInformation)comboBoxAccessory4.SelectedItem,
                (DataEquipmentInformation)comboBoxAccessory5.SelectedItem};
            }
        }

        private DataRecordMateriaInformation[] recordMaterias
        {
            get
            {
                return new DataRecordMateriaInformation[] {
                (DataRecordMateriaInformation)comboBoxRecordMateria1.SelectedItem,
                (DataRecordMateriaInformation)comboBoxRecordMateria2.SelectedItem,
                (DataRecordMateriaInformation)comboBoxRecordMateria3.SelectedItem,
                (DataRecordMateriaInformation)comboBoxRecordMateria4.SelectedItem,
                (DataRecordMateriaInformation)comboBoxRecordMateria5.SelectedItem};
            }
        }

        private Synergy RealmSynergy
        {
            get
            {
                if (comboBoxRealmSynergy.SelectedItem != null)
                {
                    return (Synergy)comboBoxRealmSynergy.SelectedItem;
                }
                return (Synergy)comboBoxRealmSynergy.Items[0];
            }
        }

        private void RecalculateAllStats()
        {
            textBoxEnemyEffectiveDef.Text = Math.Ceiling(Double.Parse(textBoxEnemyDef.Text) *
                DebuffedDefensiveMultiplier(1
                * (checkBoxFullBreak.Checked ? (checkBoxArmorBreakResistant.Checked ? 0.85 : 0.7) : 1)
                * (checkBoxArmorBreakdown.Checked ? (checkBoxArmorBreakResistant.Checked ? 0.8 : 0.6) : 1)
                * (checkBoxBanishingBlade.Checked ? (checkBoxArmorBreakResistant.Checked ? 0.75 : 0.5) : 1))).ToString();

            textBoxEnemyEffectiveRes.Text = Math.Ceiling(Double.Parse(textBoxEnemyRes.Text) *
                DebuffedDefensiveMultiplier(1
                * (checkBoxFullBreak.Checked ? (checkBoxMentalBreakResistant.Checked ? 0.85 : 0.7) : 1)
                * (checkBoxMentalBreakdown.Checked ? (checkBoxMentalBreakResistant.Checked ? 0.75 : 0.5) : 1))).ToString();
            
            for (int i = 0; i < 5; i++)
            {
                RecalculateStats(i);
            }
        }

        private double BuffedOffensiveMultiplier(double multiplier)
        {
            if (multiplier <= 2.5)
            {
                return multiplier;
            }
            double newMultiplier = 2.5 + 0.3 * Math.Log(1 + (multiplier - 2.5));
            return Math.Min(3, newMultiplier);
        }

        private double BuffedDefensiveMultiplier(double multiplier)
        {
            if (multiplier <= 4.5)
            {
                return multiplier;
            }
            double newMultiplier = 4.5 + 1.05 * Math.Log(1 + (multiplier - 4.5));
            return Math.Min(9, newMultiplier);
        }

        private double DebuffedOffensiveMultiplier(double multiplier)
        {
            if (multiplier >= 0.35)
            {
                return multiplier;
            }
            double newMultiplier = 0.35 - 1.1 * Math.Log10(1 + (0.35 - multiplier));
            return Math.Max(newMultiplier, 0.3);
        }

        private double DebuffedDefensiveMultiplier(double multiplier)
        {
            if (multiplier >= 0.3)
            {
                return multiplier;
            }
            double newMultiplier = 0.3 - 1.5 * Math.Log10(1 + (0.3 - multiplier));
            return Math.Max(newMultiplier, 0.2);
        }
        
        private void RecalculateStats(int characterIndex)
        {
            GameData.DataBuddyInformation character = characters[characterIndex];
            DataEquipmentInformation weapon = weapons[characterIndex];
            DataEquipmentInformation armor = armors[characterIndex];
            DataEquipmentInformation accessory = accessories[characterIndex];
            DataRecordMateriaInformation recordMateria = recordMaterias[characterIndex];
            Color synergyColor = System.Drawing.Color.Aqua;
            Color nonSynergyColor = System.Drawing.SystemColors.Window;
            bool characterHasSynergy = character != null && (character.SeriesId == RealmSynergy.SeriesId ||
                character.EligibleForNightmareShift(RealmSynergy.NightmareCategory));
            bool weaponHasSynergy = weapon != null && (weapon.SeriesId == RealmSynergy.SeriesId ||
                character.EligibleForNightmareShift(RealmSynergy.NightmareCategory));
            bool armorHasSynergy = armor != null && (armor.SeriesId == RealmSynergy.SeriesId ||
                 character.EligibleForNightmareShift(RealmSynergy.NightmareCategory));
            bool accessoryHasSynergy = accessory != null && (accessory.SeriesId == RealmSynergy.SeriesId ||
                 character.EligibleForNightmareShift(RealmSynergy.NightmareCategory));


            if (character != null)
            {
                characterBoxes[characterIndex].BackColor = characterHasSynergy ? synergyColor : nonSynergyColor;
            }
            else
            {
                characterBoxes[characterIndex].BackColor = nonSynergyColor;
            }

            if (weapon != null)
            {
                weaponBoxes[characterIndex].BackColor = weaponHasSynergy ? synergyColor : nonSynergyColor;
            }
            else
            {
                weaponBoxes[characterIndex].BackColor = nonSynergyColor;
            }

            if (armor != null)
            {
                armorBoxes[characterIndex].BackColor = armorHasSynergy ? synergyColor : nonSynergyColor;
            }
            else
            {
                armorBoxes[characterIndex].BackColor = nonSynergyColor;
            }

            if (accessory != null)
            {
                accessoryBoxes[characterIndex].BackColor = accessoryHasSynergy ? synergyColor : nonSynergyColor;
            }
            else
            {
                accessoryBoxes[characterIndex].BackColor = nonSynergyColor;
            }

            hpFields[characterIndex].Text = CalculateStat("HP", character, weapon, armor, accessory, recordMateria, characterHasSynergy, weaponHasSynergy, armorHasSynergy, accessoryHasSynergy).ToString("#,##0.##"); ;
            atkFields[characterIndex].Text = CalculateStat("Atk", character, weapon, armor, accessory, recordMateria, characterHasSynergy, weaponHasSynergy, armorHasSynergy, accessoryHasSynergy).ToString("#,##0.##");
            magFields[characterIndex].Text = CalculateStat("Mag", character, weapon, armor, accessory, recordMateria, characterHasSynergy, weaponHasSynergy, armorHasSynergy, accessoryHasSynergy).ToString("#,##0.##");
            mndFields[characterIndex].Text = CalculateStat("Mnd", character, weapon, armor, accessory, recordMateria, characterHasSynergy, weaponHasSynergy, armorHasSynergy, accessoryHasSynergy).ToString("#,##0.##");
            defFields[characterIndex].Text = CalculateStat("Def", character, weapon, armor, accessory, recordMateria, characterHasSynergy, weaponHasSynergy, armorHasSynergy, accessoryHasSynergy).ToString("#,##0.##");
            resFields[characterIndex].Text = CalculateStat("Res", character, weapon, armor, accessory, recordMateria, characterHasSynergy, weaponHasSynergy, armorHasSynergy, accessoryHasSynergy).ToString("#,##0.##");
            evaFields[characterIndex].Text = CalculateStat("Eva", character, weapon, armor, accessory, recordMateria, characterHasSynergy, weaponHasSynergy, armorHasSynergy, accessoryHasSynergy).ToString("#,##0.##");
            spdFields[characterIndex].Text = CalculateStat("Spd", character, weapon, armor, accessory, recordMateria, characterHasSynergy, weaponHasSynergy, armorHasSynergy, accessoryHasSynergy).ToString("#,##0.##");

            if (abilities[characterIndex * 2] != null)
            {
                GameData.Ability ability = abilities[characterIndex * 2];
                abilityDamageFields[characterIndex * 2].Text = damageStringForCharacter(characterIndex, ability, abilityDamageFields[characterIndex * 2], abilityDamageTooltips[characterIndex * 2]);
                if (ability.Formula == GameData.SchemaConstants.Formulas.Healing)
                {
                    abilityDamageFields[characterIndex * 2].BackColor = System.Drawing.Color.Lime;
                }
                else
                {
                    abilityDamageFields[characterIndex * 2].BackColor = System.Drawing.SystemColors.Control;
                }
            }
            else
            {
                abilityTooltips[characterIndex * 2].SetToolTip(abilityBoxes[characterIndex * 2], "");
                abilityDamageFields[characterIndex * 2].Text = "";
                abilityDamageFields[characterIndex * 2].BackColor = System.Drawing.SystemColors.Control;
                abilityDamageTooltips[characterIndex * 2].SetToolTip(abilityDamageFields[characterIndex * 2], "");
            }

            if (abilities[characterIndex * 2 + 1] != null)
            {
                GameData.Ability ability = abilities[characterIndex * 2 + 1];
                abilityDamageFields[characterIndex * 2 + 1].Text = damageStringForCharacter(characterIndex, ability, abilityDamageFields[characterIndex * 2 + 1], abilityDamageTooltips[characterIndex * 2 + 1]);
                if (ability.Formula == GameData.SchemaConstants.Formulas.Healing)
                {
                    abilityDamageFields[characterIndex * 2 + 1].BackColor = System.Drawing.Color.Lime;
                }
                else
                {
                    abilityDamageFields[characterIndex * 2 + 1].BackColor = System.Drawing.SystemColors.Control;
                }
            }
            else
            {
                abilityTooltips[characterIndex * 2 + 1].SetToolTip(abilityBoxes[characterIndex * 2 + 1], "");
                abilityDamageFields[characterIndex * 2 + 1].Text = "";
                abilityDamageFields[characterIndex * 2 + 1].BackColor = System.Drawing.SystemColors.Control;
                abilityDamageTooltips[characterIndex * 2 + 1].SetToolTip(abilityDamageFields[characterIndex * 2 + 1], "");
            }

            if (soulBreaks[characterIndex] != null)
            {
                GameData.SoulBreak soulBreak = soulBreaks[characterIndex];
                soulBreakDamageFields[characterIndex].Text = damageStringForCharacter(characterIndex, soulBreak, soulBreakDamageFields[characterIndex], soulBreakDamageTooltips[characterIndex]);

                if (soulBreak.Formula == GameData.SchemaConstants.Formulas.Healing)
                {
                    soulBreakDamageFields[characterIndex].BackColor = System.Drawing.Color.Lime;
                }
                else
                {
                    soulBreakDamageFields[characterIndex].BackColor = System.Drawing.SystemColors.Control;
                }
            }
            else
            {
                soulBreakDamageFields[characterIndex].Text = "";
                soulBreakDamageFields[characterIndex].BackColor = System.Drawing.SystemColors.Control;
                soulBreakDamageTooltips[characterIndex].SetToolTip(soulBreakDamageFields[characterIndex], "");
            }
        }

        private double CalculateStat(string stat, GameData.DataBuddyInformation character, DataEquipmentInformation weapon, 
            DataEquipmentInformation armor, DataEquipmentInformation accessory, DataRecordMateriaInformation recordMateria,
            bool characterHasSynergy, bool weaponHasSynergy, bool armorHasSynergy, bool accessoryHasSynergy)
        {
            double baseValue = (character != null ? character.StatWithSynergy(stat, characterHasSynergy) : 0) +
                (weapon != null ? weapon.StatWithSynergy(stat, weaponHasSynergy) : 0) +
                (armor != null ? armor.StatWithSynergy(stat, armorHasSynergy) : 0) +
                (accessory != null ? accessory.StatWithSynergy(stat, accessoryHasSynergy) : 0);

            double multiplier;
            if (recordMateria != null && (stat == "Atk" || stat == "Mag" || stat == "Mnd" || stat == "Def" || stat == "Res"))
            {
                System.Reflection.MethodInfo method = recordMateria.GetType().GetMethod(stat + "Modifier");
                multiplier = (double)method.Invoke(recordMateria, new object[] { weapon, armor, accessory });
            }
            else
            {
                multiplier = 1;
            }

            switch (stat)
            {
                case "Atk":
                    if (recordMateria != null && (recordMateria.RecordMateriaId == 111070100 || recordMateria.RecordMateriaId == 111080060))
                    {
                        // Loner or Solitude
                        for (int i = 0; i < characterBoxes.Count(box => box.SelectedItem == null); i++)
                        {
                            multiplier *= 1.1;
                        }
                    }
                    if (checkBoxShout.Checked)
                    {
                        multiplier *= 1.5;
                    }

                    if (checkBoxHotE.Checked)
                    {
                        multiplier *= 1.3;
                    }
                    baseValue *= BuffedOffensiveMultiplier(multiplier);
                    break;

                case "Mag":
                    if (checkBoxFocus.Checked)
                    {
                        multiplier *= 1.2;
                    }

                    if (checkBoxFaith.Checked)
                    {
                        multiplier *= 1.2;
                    }
                    baseValue *= BuffedOffensiveMultiplier(multiplier);
                    break;

                case "Mnd":
                    baseValue *= BuffedOffensiveMultiplier(multiplier);
                    break;

                case "Def":
                    if (recordMateria != null && (recordMateria.RecordMateriaId == 111070100 || recordMateria.RecordMateriaId == 111080060))
                    {
                        // Loner or Solitude
                        for (int i = 0; i < characterBoxes.Count(box => box.SelectedItem == null); i++)
                        {
                            multiplier *= 1.1;
                        }
                    }
                    if (checkBoxHotE.Checked)
                    {
                        multiplier *= 1.3;
                    }
                    baseValue *= BuffedDefensiveMultiplier(multiplier);
                    break;

                case "Res":
                    if (checkBoxFaith.Checked)
                    {
                        multiplier *= 1.5;
                    }
                    baseValue *= BuffedDefensiveMultiplier(multiplier);
                    break;
                default:
                    break;
            }

            return baseValue;
        }

        private string damageStringForCharacter(int characterIndex, GameData.Ability ability, TextBox damageField, ToolTip tooltip)
        {
            GameData.DataBuddyInformation character = characters[characterIndex];
            DataEquipmentInformation weapon = weapons[characterIndex];
            DataEquipmentInformation armor = armors[characterIndex];
            DataEquipmentInformation accessory = accessories[characterIndex];
            DataRecordMateriaInformation recordMateria = recordMaterias[characterIndex];

            int damage = (int)Math.Floor(damagePerHit(character, weapon, armor, accessory, recordMateria,
                Double.Parse(atkFields[characterIndex].Text), Double.Parse(magFields[characterIndex].Text),
                Double.Parse(mndFields[characterIndex].Text), ability));

            string damageString = damage.ToString("#,##0.##");
            if (ability.NumberOfHits > 1 || ability.GetType() == typeof(GameData.Abilities.ThiefsRevenge))
            {
                int hits = ability.NumberOfHits;
                if (ability.GetType() == typeof(GameData.Abilities.ThiefsRevenge))
                {
                    hits = Math.Max(1, (int)Math.Floor((Double.Parse(spdFields[characterIndex].Text) - 120) / 10));
                }
                else if (ability.GetType() == typeof(GameData.SoulBreaks.AeonsOfWingAndFlame))
                {
                    double mag = Double.Parse(magFields[characterIndex].Text);
                    if (mag >= 723)
                    {
                        hits = 9;
                    }
                    else if (mag >= 681)
                    {
                        hits = 8;
                    }
                    else if (mag >= 562)
                    {
                        hits = 7;
                    }
                }
                tooltip.SetToolTip(damageField, (Math.Min(damage, 9999) * hits).ToString("#,##0.##") + " total damage");
                damageString += " * " + hits;
            }
            else
            {
                tooltip.SetToolTip(damageField, "");
            }
            return damageString;
        }

        private double damagePerHit(GameData.DataBuddyInformation character, DataEquipmentInformation weapon, DataEquipmentInformation armor, 
            DataEquipmentInformation accessory, DataRecordMateriaInformation recordMateria, 
            double atk, double mag, double mnd, GameData.Ability ability)
        {
            if (ability.Name == "Cactuar")
            {
                return 1000;
            }

            double damage = ((ability.Formula == GameData.SchemaConstants.Formulas.Healing ? 0 : 5) + ability.CalculateDamage(atk, Double.Parse(textBoxEnemyEffectiveDef.Text), mag, Double.Parse(textBoxEnemyEffectiveRes.Text), mnd)
                    * ability.Multiplier)
                    * (recordMateria != null ? recordMateria.AbilityModifier(weapon, armor, accessory, ability) : 1);

            if (ability.Formula != GameData.SchemaConstants.Formulas.Healing)
            {
                damage *= (weapon != null ? weapon.ElementalMultiplier(ability.Element) : 1)
                    * (armor != null ? armor.ElementalMultiplier(ability.Element) : 1)
                    * (accessory != null ? accessory.ElementalMultiplier(ability.Element) : 1)
                    * BossElementalMultiplier(ability.Element);
            }

            return damage;
        }

        private float BossElementalMultiplier(GameData.SchemaConstants.ElementID element)
        {
            foreach(DataGridViewRow row in dataGridViewBossElementReactions.Rows)
            {
                if (element == (GameData.SchemaConstants.ElementID)row.Tag)
                {
                    return ((ElementAdvantage)row.Cells[VulnerabilityColumn.Name].Value).Multiplier;
                }
            }

            return 1.0f;
        }

        private string abilityTipFor(GameData.Ability ability)
        {
            if (ability == null)
            {
                return "";
            }
            var _abilities = FFRKProxy.Instance.GameState.PartyDetails.Abilities.Where(ab => ab.AbilityId == ability.AbilityId).OrderByDescending(ab => ab.Level);
            if (_abilities.Count() == 0)
            {
                return "You have 0 of this skill.";
            }

            StringBuilder sb = new StringBuilder("You have:");
            var groupedAbilities = _abilities.GroupBy(ab => ab.Level, ab => ab.Name);
            foreach (var grouping in groupedAbilities)
            {
                sb.AppendLine();
                sb.Append(grouping.Count().ToString());
                sb.Append("x Rank ");
                sb.Append(grouping.Key);
            }
            return sb.ToString();
        }

        private void UpdateDropdownsForCharacter(int index)
        {
            DataPartyDetails party = FFRKProxy.Instance.GameState.PartyDetails;
            DataEquipmentInformation selectedWeapon = (DataEquipmentInformation)weaponBoxes[index].SelectedItem;
            int weaponIndex = -1;
            int tempIndex;
            weaponBoxes[index].Items.Clear();
            if (characterBoxes[index].SelectedItem != null)
            {
                foreach (DataEquipmentInformation weapon in party.Equipments.Where(equip => equip.Type == GameData.SchemaConstants.ItemType.Weapon).OrderBy(equip => equip.Name))
                {
                    if (characters[index].UsableEquipCategories.Contains(weapon.Category))
                    {
                        tempIndex = weaponBoxes[index].Items.Add(weapon);
                        if (selectedWeapon != null && weapon.InstanceId == selectedWeapon.InstanceId)
                        {
                            weaponIndex = tempIndex;
                        }
                    }
                }
            }

            if (weaponIndex > -1)
            {
                weaponBoxes[index].SelectedIndex = weaponIndex;
            }
            else
            {
                weaponBoxes[index].Text = "Weapon";
            }

            DataEquipmentInformation selectedArmor = (DataEquipmentInformation)armorBoxes[index].SelectedItem;
            int armorIndex = -1;
            armorBoxes[index].Items.Clear();
            if (characterBoxes[index].SelectedItem != null)
            {
                foreach (DataEquipmentInformation armor in party.Equipments.Where(equip => equip.Type == GameData.SchemaConstants.ItemType.Armor).OrderBy(equip => equip.Name))
                {
                    if (characters[index].UsableEquipCategories.Contains(armor.Category))
                    {
                        tempIndex = armorBoxes[index].Items.Add(armor);
                        if (selectedArmor != null && armor.InstanceId == selectedArmor.InstanceId)
                        {
                            armorIndex = tempIndex;
                        }
                    }
                }
            }

            if (armorIndex > -1)
            {
                armorBoxes[index].SelectedIndex = armorIndex;
            }
            else
            {
                armorBoxes[index].Text = "Armor";
            }

            DataEquipmentInformation selectedAccessory = (DataEquipmentInformation)accessoryBoxes[index].SelectedItem;
            int accessoryIndex = -1;
            accessoryBoxes[index].Items.Clear();
            if (characterBoxes[index].SelectedItem != null)
            {
                foreach (DataEquipmentInformation accessory in party.Equipments.Where(equip => equip.Type == GameData.SchemaConstants.ItemType.Accessory).OrderBy(equip => equip.Name))
                {
                    tempIndex = accessoryBoxes[index].Items.Add(accessory);
                    if (selectedAccessory != null && accessory.InstanceId == selectedAccessory.InstanceId)
                    {
                        accessoryIndex = tempIndex;
                    }
                }
            }

            if (accessoryIndex > -1)
            {
                accessoryBoxes[index].SelectedIndex = accessoryIndex;
            }
            else
            {
                accessoryBoxes[index].Text = "Accessory";
            }

            DataRecordMateriaInformation selectedRecordMateria = (DataRecordMateriaInformation)recordMateriaBoxes[index].SelectedItem;
            int recordMateriaIndex = -1;
            recordMateriaBoxes[index].Items.Clear();
            if (characterBoxes[index].SelectedItem != null)
            {
                foreach (DataRecordMateriaInformation recordMateria in party.RecordMaterias.OrderBy(rm => rm.Name))
                {
                    tempIndex = recordMateriaBoxes[index].Items.Add(recordMateria);
                    if (selectedRecordMateria != null && recordMateria.RecordMateriaId == selectedRecordMateria.RecordMateriaId)
                    {
                        recordMateriaIndex = tempIndex;
                    }
                }
            }

            if (recordMateriaIndex > -1)
            {
                recordMateriaBoxes[index].SelectedIndex = recordMateriaIndex;
            }
            else
            {
                recordMateriaBoxes[index].Text = "Record Materia";
            }

            FFRKInspector.GameData.Ability selectedAbility1 = (FFRKInspector.GameData.Ability)abilityBoxes[index * 2].SelectedItem;
            FFRKInspector.GameData.Ability selectedAbility2 = (FFRKInspector.GameData.Ability)abilityBoxes[index * 2 + 1].SelectedItem;
            int ability1Index = -1;
            int ability2Index = -1;
            abilityBoxes[index * 2].Items.Clear();
            abilityBoxes[index * 2 + 1].Items.Clear();
            if (characterBoxes[index].SelectedItem != null)
            {
                foreach (var ability in FFRKInspector.GameData.Ability.AllAbilities())
                {
                    if (characters[index].CanUseAbility(ability))
                    {
                        tempIndex = abilityBoxes[index * 2].Items.Add(ability);
                        if (selectedAbility1 != null && ability.Name == selectedAbility1.Name)
                        {
                            ability1Index = tempIndex;
                        }

                        tempIndex = abilityBoxes[index * 2 + 1].Items.Add(ability);
                        if (selectedAbility2 != null && ability.Name == selectedAbility2.Name)
                        {
                            ability2Index = tempIndex;
                        }
                    }
                }
            }

            if (ability1Index > -1)
            {
                abilityBoxes[index * 2].SelectedIndex = ability1Index;
            }
            else
            {
                abilityBoxes[index * 2].Text = "Ability";
            }

            if (ability2Index > -1)
            {
                abilityBoxes[index * 2 + 1].SelectedIndex = ability2Index;
            }
            else
            {
                abilityBoxes[index * 2 + 1].Text = "Ability";
            }

            GameData.SoulBreak selectedSoulBreak = (GameData.SoulBreak)soulBreakBoxes[index].SelectedItem;
            int soulBreakIndex = -1;
            soulBreakBoxes[index].Items.Clear();
            if (characterBoxes[index].SelectedItem != null)
            {
                foreach (GameData.SoulBreak soulBreak in characters[index].UsableSoulBreaks)
                {
                    tempIndex = soulBreakBoxes[index].Items.Add(soulBreak);
                    if (selectedSoulBreak != null && soulBreak.SoulBreakId == selectedSoulBreak.SoulBreakId)
                    {
                        soulBreakIndex = tempIndex;
                    }
                }
            }

            if (soulBreakIndex > -1)
            {
                soulBreakBoxes[index].SelectedIndex = soulBreakIndex;
            }
            else
            {
                soulBreakBoxes[index].Text = "Soul Break";
            }

            RecalculateStats(index);
        }

        private ComboBox mCurrentEquipmentList = null;

        private void UpdateEquipmentGrid(GameData.DataBuddyInformation character, ComboBox equipmentList, List<uint> equippedItems)
        {
            mCurrentEquipmentList = equipmentList;
            equipmentModal.UpdateEquipmentGrid(character, equipmentList, equippedItems, RealmSynergy);
        }

        private void comboBoxPartyMember_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = Int32.Parse(((ComboBox)sender).Name.Last().ToString()) - 1;
            UpdateDropdownsForCharacter(index);
            if (skipRecalculations)
            {
                return;
            }
            for(int i = 0; i < 5; i++)
            {
                if(characterBoxes[i].SelectedItem != null && recordMateriaBoxes[i].SelectedItem != null &&
                    (((DataRecordMateriaInformation)recordMateriaBoxes[i].SelectedItem).RecordMateriaId == 111070100 ||
                    ((DataRecordMateriaInformation)recordMateriaBoxes[i].SelectedItem).RecordMateriaId == 111080060))
                {
                    // Check if anyone has Loner or Solitude equipped
                    UpdateDropdownsForCharacter(i);
                }
            }
        }

        private void comboBoxWeapon_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (skipRecalculations)
            {
                return;
            }
            RecalculateStats(Int32.Parse(((ComboBox)sender).Name.Last().ToString()) - 1);
        }

        private void comboBoxArmor_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (skipRecalculations)
            {
                return;
            }
            RecalculateStats(Int32.Parse(((ComboBox)sender).Name.Last().ToString()) - 1);
        }

        private void comboBoxAccessory_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (skipRecalculations)
            {
                return;
            }
            RecalculateStats(Int32.Parse(((ComboBox)sender).Name.Last().ToString()) - 1);
        }

        private void comboBoxRealmSynergy_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (skipRecalculations)
            {
                return;
            }
            RecalculateAllStats();
        }

        private void checkBoxBuff_CheckedChanged(object sender, EventArgs e)
        {
            if (skipRecalculations)
            {
                return;
            }
            RecalculateAllStats();
        }

        private void comboBoxAbility_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = (Int32.Parse(((ComboBox)sender).Name.Last().ToString())) - 1;
            if(index == -1)
            {
                index = 9;
            }

            abilityTooltips[index].SetToolTip((ComboBox)sender, abilityTipFor(abilities[index]));
            if (skipRecalculations)
            {
                return;
            }
            RecalculateStats(index / 2);
        }

        private void textBoxEnemyStats_TextChanged(object sender, EventArgs e)
        {
            if (skipRecalculations)
            {
                return;
            }
            int val;
            if (Int32.TryParse(((TextBox)sender).Text, out val))
            {
                RecalculateAllStats();
            }
        }

        private void comboBoxSoulBreak_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (skipRecalculations)
            {
                return;
            }
            RecalculateStats(Int32.Parse(((ComboBox)sender).Name.Last().ToString()) - 1);
        }

        private void comboBoxRecordMateria_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (skipRecalculations)
            {
                return;
            }
            RecalculateStats(Int32.Parse(((ComboBox)sender).Name.Last().ToString()) - 1);
        }

        private void checkBoxDebuff_CheckedChanged(object sender, EventArgs e)
        {
            if (skipRecalculations)
            {
                return;
            }
            RecalculateAllStats();
        }

        private void SelectEquipment(ComboBox equipmentList, uint instanceId)
        {
            for (int i = 0; i < equipmentList.Items.Count; i++)
            {
                if (((DataEquipmentInformation)equipmentList.Items[i]).InstanceId == instanceId)
                {
                    equipmentList.SelectedIndex = i;
                    return;
                }
            }
        }
        
        private void comboBoxWeapon_Click(object sender, EventArgs e)
        {
            if(((ComboBox)sender).Items.Count == 0)
            {
                return;
            }
            int index = Int32.Parse(((ComboBox)sender).Name.Last().ToString()) - 1;
            GameData.DataBuddyInformation character = characters[index];
            List<uint> equippedItems = new List<uint>();
            for (int i = 0; i < 5; i++)
            {
                if (i == index)
                {
                    continue;
                }
                if (weaponBoxes[i].SelectedItem != null)
                {
                    equippedItems.Add(((DataEquipmentInformation)weaponBoxes[i].SelectedItem).InstanceId);
                }
            }
            UpdateEquipmentGrid(character, (ComboBox)sender, equippedItems);
            if (equipmentModal.ShowDialog(this) == DialogResult.OK)
            {
                SelectEquipment((ComboBox)sender, equipmentModal.SelectedInstanceId);
                ((ComboBox)sender).Select(0, 0);
            }
        }

        private void comboBoxArmor_Click(object sender, EventArgs e)
        {
            if (((ComboBox)sender).Items.Count == 0)
            {
                return;
            }
            int index = Int32.Parse(((ComboBox)sender).Name.Last().ToString()) - 1;
            GameData.DataBuddyInformation character = characters[index];
            List<uint> equippedItems = new List<uint>();
            for (int i = 0; i < 5; i++)
            {
                if (i == index)
                {
                    continue;
                }
                if (armorBoxes[i].SelectedItem != null)
                {
                    equippedItems.Add(((DataEquipmentInformation)armorBoxes[i].SelectedItem).InstanceId);
                }
            }
            UpdateEquipmentGrid(character, (ComboBox)sender, equippedItems);
            if (equipmentModal.ShowDialog(this) == DialogResult.OK)
            {
                SelectEquipment((ComboBox)sender, equipmentModal.SelectedInstanceId);
                ((ComboBox)sender).Select(0, 0);
            }
        }

        private void comboBoxAccessory_Click(object sender, EventArgs e)
        {
            if (((ComboBox)sender).Items.Count == 0)
            {
                return;
            }
            int index = Int32.Parse(((ComboBox)sender).Name.Last().ToString()) - 1;
            GameData.DataBuddyInformation character = characters[index];
            List<uint> equippedItems = new List<uint>();
            for (int i = 0; i < 5; i++)
            {
                if (i == index)
                {
                    continue;
                }
                if (accessoryBoxes[i].SelectedItem != null)
                {
                    equippedItems.Add(((DataEquipmentInformation)accessoryBoxes[i].SelectedItem).InstanceId);
                }
            }
            UpdateEquipmentGrid(character, (ComboBox)sender, equippedItems);
            if (equipmentModal.ShowDialog(this) == DialogResult.OK)
            {
                SelectEquipment((ComboBox)sender, equipmentModal.SelectedInstanceId);
                ((ComboBox)sender).Select(0, 0);
            }
        }

        class PartyData
        {
            public Dictionary<string, uint>[] PartyMembers;
            public Dictionary<ushort, ElementAdvantage> ElementalVulnerabilities;
            public uint RealmSynergy { get; set; }
            public string EnemyDef { get; set; }
            public string EnemyRes { get; set; }
            public bool Shout { get; set; }
            public bool HotE { get; set; }
            public bool Focus { get; set; }
            public bool Faith { get; set; }
            public bool FullBreak { get; set; }
            public bool ArmorBreakdown { get; set; }
            public bool MentalBreakdown { get; set; }
            public bool BanishingBlade { get; set; }
            public bool ArmorBreakResistant { get; set; }
            public bool MentalBreakResistant { get; set; }
            
            public PartyData()
            {
                PartyMembers = new Dictionary<string, uint>[5];
                ElementalVulnerabilities = new Dictionary<ushort, ElementAdvantage>();
            }
        }
        
        private void buttonSaveParty_Click(object sender, EventArgs e)
        {
            textInputModal.Text = "Save Party";
            textInputModal.Label = "Enter a new party name or the same name to overwrite an existing party.";
            textInputModal.Value = (string)comboBoxSavedParties.SelectedItem;
            if (textInputModal.ShowDialog(this) != DialogResult.OK)
            {
                return;
            }
            
            PartyData data = new PartyData();

            for (int i = 0; i < 5; i++)
            {
                data.PartyMembers[i] = new Dictionary<string, uint>();
                GameData.DataBuddyInformation character = (GameData.DataBuddyInformation)characterBoxes[i].SelectedItem;
                if (character == null)
                {
                    continue;
                }
                data.PartyMembers[i]["characterId"] = character.BuddyId;
                data.PartyMembers[i]["weaponId"] = weaponBoxes[i].SelectedItem != null ? ((GameData.Party.DataEquipmentInformation)weaponBoxes[i].SelectedItem).InstanceId : 0;
                data.PartyMembers[i]["armorId"] = armorBoxes[i].SelectedItem != null ? ((GameData.Party.DataEquipmentInformation)armorBoxes[i].SelectedItem).InstanceId : 0;
                data.PartyMembers[i]["accessoryId"] = accessoryBoxes[i].SelectedItem != null ? ((GameData.Party.DataEquipmentInformation)accessoryBoxes[i].SelectedItem).InstanceId : 0;
                data.PartyMembers[i]["recordMateriaId"] = recordMateriaBoxes[i].SelectedItem != null ? ((DataRecordMateriaInformation)recordMateriaBoxes[i].SelectedItem).RecordMateriaId : 0;
                data.PartyMembers[i]["ability1Id"] = abilityBoxes[i * 2].SelectedItem != null ? ((GameData.Ability)abilityBoxes[i * 2].SelectedItem).AbilityId : 0;
                data.PartyMembers[i]["ability2Id"] = abilityBoxes[i * 2 + 1].SelectedItem != null ? ((GameData.Ability)abilityBoxes[i * 2 + 1].SelectedItem).AbilityId : 0;
                data.PartyMembers[i]["soulBreakId"] = soulBreakBoxes[i].SelectedItem != null ? ((GameData.SoulBreak)soulBreakBoxes[i].SelectedItem).SoulBreakId : 0;
            }
            data.RealmSynergy = RealmSynergy.SeriesId;
            data.Shout = checkBoxShout.Checked;
            data.HotE = checkBoxHotE.Checked;
            data.Focus = checkBoxFocus.Checked;
            data.Faith = checkBoxFaith.Checked;
            data.FullBreak = checkBoxFullBreak.Checked;
            data.ArmorBreakdown = checkBoxArmorBreakdown.Checked;
            data.MentalBreakdown = checkBoxMentalBreakdown.Checked;
            data.ArmorBreakResistant = checkBoxArmorBreakResistant.Checked;
            data.MentalBreakResistant = checkBoxMentalBreakResistant.Checked;
            data.BanishingBlade = checkBoxBanishingBlade.Checked;
            data.EnemyDef = textBoxEnemyDef.Text;
            data.EnemyRes = textBoxEnemyRes.Text;
            foreach (DataGridViewRow row in dataGridViewBossElementReactions.Rows)
            {
                data.ElementalVulnerabilities[(ushort)row.Cells[ElementColumn.Name].Tag] = (ElementAdvantage)row.Cells[VulnerabilityColumn.Name].Value;
            }

            string partyName = textInputModal.Value;
            savedPartyData[partyName] = data;
            WriteSavedPartiesFile(partyName);
        }

        private void WriteSavedPartiesFile(string partyName)
        {
            System.IO.File.WriteAllText(SavedPartiesFilePath, Newtonsoft.Json.JsonConvert.SerializeObject(savedPartyData));

            RefreshSavedParties();
            for (int i = 0; i < comboBoxSavedParties.Items.Count; i++)
            {
                if ((string)comboBoxSavedParties.Items[i] == partyName)
                {
                    comboBoxSavedParties.SelectedIndex = i;
                    break;
                }
            }
        }

        private void buttonLoadParty_Click(object sender, EventArgs e)
        {
            string partyName = (string)comboBoxSavedParties.SelectedItem;
            if(partyName == null) {
                return;
            }
            skipRecalculations = true;
            try
            {
                PartyData data = savedPartyData[partyName];
                for (int i = 0; i < 5; i++)
                {
                    Dictionary<string, uint> member = data.PartyMembers[i];
                    if (member.Keys.Count == 0)
                    {
                        characterBoxes[i].SelectedIndex = -1;
                        characterBoxes[i].Text = "Character";
                        weaponBoxes[i].SelectedIndex = -1;
                        weaponBoxes[i].Text = "Weapon";
                        weaponBoxes[i].Items.Clear();
                        armorBoxes[i].SelectedIndex = -1;
                        armorBoxes[i].Text = "Armor";
                        armorBoxes[i].Items.Clear();
                        accessoryBoxes[i].SelectedIndex = -1;
                        accessoryBoxes[i].Text = "Accessory";
                        accessoryBoxes[i].Items.Clear();
                        recordMateriaBoxes[i].SelectedIndex = -1;
                        recordMateriaBoxes[i].Text = "Record Materia";
                        abilityBoxes[i * 2].SelectedIndex = -1;
                        abilityBoxes[i * 2].Text = "Ability";
                        abilityBoxes[i * 2].Items.Clear();
                        abilityBoxes[i * 2 + 1].SelectedIndex = -1;
                        abilityBoxes[i * 2 + 1].Text = "Ability";
                        abilityBoxes[i * 2 + 1].Items.Clear();
                        soulBreakBoxes[i].SelectedIndex = -1;
                        soulBreakBoxes[i].Text = "Soul Break";
                        soulBreakBoxes[i].Items.Clear();
                        continue;
                    }

                    for (int j = 0; j < characterBoxes[i].Items.Count; j++)
                    {
                        if (((GameData.DataBuddyInformation)characterBoxes[i].Items[j]).BuddyId == member["characterId"])
                        {
                            characterBoxes[i].SelectedIndex = j;
                            break;
                        }
                    }

                    if (member["weaponId"] > 0)
                    {
                        for (int j = 0; j < weaponBoxes[i].Items.Count; j++)
                        {
                            if (((GameData.Party.DataEquipmentInformation)weaponBoxes[i].Items[j]).InstanceId == member["weaponId"])
                            {
                                weaponBoxes[i].SelectedIndex = j;
                                break;
                            }
                        }
                    }
                    else
                    {
                        weaponBoxes[i].SelectedIndex = -1;
                        weaponBoxes[i].Text = "Weapon";
                    }

                    if (member["armorId"] > 0)
                    {
                        for (int j = 0; j < armorBoxes[i].Items.Count; j++)
                        {
                            if (((GameData.Party.DataEquipmentInformation)armorBoxes[i].Items[j]).InstanceId == member["armorId"])
                            {
                                armorBoxes[i].SelectedIndex = j;
                                break;
                            }
                        }
                    }
                    else
                    {
                        armorBoxes[i].SelectedIndex = -1;
                        armorBoxes[i].Text = "Armor";
                    }

                    if (member["accessoryId"] > 0)
                    {
                        for (int j = 0; j < accessoryBoxes[i].Items.Count; j++)
                        {
                            if (((GameData.Party.DataEquipmentInformation)accessoryBoxes[i].Items[j]).InstanceId == member["accessoryId"])
                            {
                                accessoryBoxes[i].SelectedIndex = j;
                                break;
                            }
                        }
                    }
                    else
                    {
                        accessoryBoxes[i].SelectedIndex = -1;
                        accessoryBoxes[i].Text = "Accessory";
                    }

                    if (member["recordMateriaId"] > 0)
                    {
                        for (int j = 0; j < recordMateriaBoxes[i].Items.Count; j++)
                        {
                            if (((DataRecordMateriaInformation)recordMateriaBoxes[i].Items[j]).RecordMateriaId == member["recordMateriaId"])
                            {
                                recordMateriaBoxes[i].SelectedIndex = j;
                                break;
                            }
                        }
                    }
                    else
                    {
                        recordMateriaBoxes[i].SelectedIndex = -1;
                        recordMateriaBoxes[i].Text = "Record Materia";
                    }

                    if (member["ability1Id"] > 0)
                    {
                        for (int j = 0; j < abilityBoxes[i * 2].Items.Count; j++)
                        {
                            if (((GameData.Ability)abilityBoxes[i * 2].Items[j]).AbilityId == member["ability1Id"])
                            {
                                abilityBoxes[i * 2].SelectedIndex = j;
                                break;
                            }
                        }
                    }
                    else
                    {
                        abilityBoxes[i * 2].SelectedIndex = -1;
                        abilityBoxes[i * 2].Text = "Ability";
                    }

                    if (member["ability2Id"] > 0)
                    {
                        for (int j = 0; j < abilityBoxes[i * 2 + 1].Items.Count; j++)
                        {
                            if (((GameData.Ability)abilityBoxes[i * 2 + 1].Items[j]).AbilityId == member["ability2Id"])
                            {
                                abilityBoxes[i * 2 + 1].SelectedIndex = j;
                                break;
                            }
                        }
                    }
                    else
                    {
                        abilityBoxes[i * 2 + 1].SelectedIndex = -1;
                        abilityBoxes[i * 2 + 1].Text = "Ability";
                    }

                    if (member["soulBreakId"] > 0)
                    {
                        for (int j = 0; j < soulBreakBoxes[i].Items.Count; j++)
                        {
                            if (((GameData.SoulBreak)soulBreakBoxes[i].Items[j]).SoulBreakId == member["soulBreakId"])
                            {
                                soulBreakBoxes[i].SelectedIndex = j;
                                break;
                            }
                        }
                    }
                    else
                    {
                        soulBreakBoxes[i].SelectedIndex = -1;
                        soulBreakBoxes[i].Text = "Soul Break";
                    }
                }

                for (int i = 0; i < comboBoxRealmSynergy.Items.Count; i++)
                {
                    if (((Synergy)comboBoxRealmSynergy.Items[i]).SeriesId == data.RealmSynergy)
                    {
                        comboBoxRealmSynergy.SelectedIndex = i;
                        break;
                    }
                }

                textBoxEnemyDef.Text = data.EnemyDef;
                textBoxEnemyRes.Text = data.EnemyRes;
                checkBoxShout.Checked = data.Shout;
                checkBoxHotE.Checked = data.HotE;
                checkBoxFocus.Checked = data.Focus;
                checkBoxFaith.Checked = data.Faith;
                checkBoxFullBreak.Checked = data.FullBreak;
                checkBoxArmorBreakdown.Checked = data.ArmorBreakdown;
                checkBoxMentalBreakdown.Checked = data.MentalBreakdown;
                checkBoxArmorBreakResistant.Checked = data.ArmorBreakResistant;
                checkBoxMentalBreakResistant.Checked = data.MentalBreakResistant;
                checkBoxBanishingBlade.Checked = data.BanishingBlade;

                for (int i = 0; i < dataGridViewBossElementReactions.RowCount; i++)
                {
                    dataGridViewBossElementReactions.Rows[i].Cells[VulnerabilityColumn.Name].Value =
                        ((DataGridViewComboBoxCell)dataGridViewBossElementReactions.Rows[i].Cells[VulnerabilityColumn.Name]).Items[0];
                }
                if (data.ElementalVulnerabilities.Count > 0)
                {
                    foreach (ushort element in data.ElementalVulnerabilities.Keys)
                    {
                        for (int i = 0; i < dataGridViewBossElementReactions.RowCount; i++)
                        {
                            if (((ushort)dataGridViewBossElementReactions.Rows[i].Cells[ElementColumn.Name].Tag) != element)
                            {
                                continue;
                            }
                            ElementAdvantage vulnerability = data.ElementalVulnerabilities[element];
                            dataGridViewBossElementReactions.Rows[i].Cells[VulnerabilityColumn.Name].Value =
                                ((DataGridViewComboBoxCell)dataGridViewBossElementReactions.Rows[i].Cells[VulnerabilityColumn.Name])
                                    .Items.Cast<ElementAdvantage>().Where(vuln => vuln.Name == vulnerability.Name)
                                    .FirstOrDefault();
                            break;
                        }
                    }
                }
            }
            finally
            {
                skipRecalculations = false;
            }

            RecalculateAllStats();
        }

        private void buttonDeleteParty_Click(object sender, EventArgs e)
        {
            string partyName = (string)comboBoxSavedParties.SelectedItem;
            if (partyName == null)
            {
                return;
            }
            if(MessageBox.Show(this, "Are you sure you want to delete the party " + partyName + "?", "Confirm party deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2)
                != DialogResult.Yes)
            {
                return;
            }
            savedPartyData.Remove(partyName);
            WriteSavedPartiesFile(partyName);
        }

        private void buttonOptimize_Click(object sender, EventArgs e)
        {
            if (!backgroundWorkerOptimizer.IsBusy)
            {
                if (!characters.Any(character => character != null))
                {
                    MessageBox.Show("You must have at least 1 character in your party before you can optimize.", "No Party Members", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                    return;
                }
                optimizerRoleSelector.SetInitialRoles(characters, RealmSynergy.SeriesId, RealmSynergy.NightmareCategory);
                if (optimizerRoleSelector.ShowDialog(this) != DialogResult.OK)
                {
                    return;
                }
                backgroundWorkerOptimizer.RunWorkerAsync();
                progressDisplay.ShowDialog(this);
            }
        }

        private void OptimizeCharacter(GameData.DataBuddyInformation character, string stat, bool ignoreRecordMateria, int numberOfEquipment)
        {
            DataPartyDetails party = FFRKProxy.Instance.GameState.PartyDetails;
            int index = -1;
            for (int i = 0; i < 5; i++)
            {
                if (characters[i] != null && characters[i].BuddyId == character.BuddyId)
                {
                    index = i;
                    break;
                }
            }
            if (index == -1)
            {
                return;
            }

            List<uint> equippedWeapons = new List<uint>();
            List<uint> equippedArmor = new List<uint>();
            List<uint> equippedAccessories = new List<uint>();
            List<DataRecordMateriaInformation> equippedRecordMateria = new List<DataRecordMateriaInformation>();
            for (int i = 0; i < 5; i++)
            {
                if (i == index)
                {
                    continue;
                }
                
                if (weaponBoxes[i].SelectedItem != null)
                {
                    equippedWeapons.Add(((DataEquipmentInformation)weaponBoxes[i].SelectedItem).InstanceId);
                }
                
                if (armorBoxes[i].SelectedItem != null)
                {
                    equippedArmor.Add(((DataEquipmentInformation)armorBoxes[i].SelectedItem).InstanceId);
                }

                if (accessoryBoxes[i].SelectedItem != null)
                {
                    equippedAccessories.Add(((DataEquipmentInformation)accessoryBoxes[i].SelectedItem).InstanceId);
                }

                if (recordMateriaBoxes[i].SelectedItem != null)
                {
                    equippedRecordMateria.Add(((DataRecordMateriaInformation)recordMateriaBoxes[i].SelectedItem));
                }
            }

            List<DataEquipmentInformation> atkWeapons = new List<DataEquipmentInformation>();
            foreach (DataEquipmentInformation weapon in party.Equipments.Where(equip => equip.Type == GameData.SchemaConstants.ItemType.Weapon && !equippedWeapons.Contains(equip.InstanceId)))
            {
                if (characters[index].UsableEquipCategories.Contains(weapon.Category))
                {
                    atkWeapons.Add(weapon);
                }
            }

            List<DataEquipmentInformation> atkArmor = new List<DataEquipmentInformation>();
            foreach (DataEquipmentInformation armor in party.Equipments.Where(equip => equip.Type == GameData.SchemaConstants.ItemType.Armor && !equippedArmor.Contains(equip.InstanceId)))
            {
                if (characters[index].UsableEquipCategories.Contains(armor.Category))
                {
                    atkArmor.Add(armor);
                }
            }

            atkWeapons = atkWeapons.OrderByDescending(weapon => weapon.StatWithSynergy(stat,
                weapon.SeriesId == RealmSynergy.SeriesId || character.EligibleForNightmareShift(RealmSynergy.NightmareCategory))).ToList();
            List<DataEquipmentInformation> possibleWeapons = new List<DataEquipmentInformation>();
            foreach (DataEquipmentInformation weapon in atkWeapons)
            {
                if (FFRKInspector.GameData.EquipmentElementalInformation.ElementalEquipment.ContainsKey(weapon.EquipmentId) ||
                    possibleWeapons.Count(item => item.Category == weapon.Category) < numberOfEquipment)
                {
                    possibleWeapons.Add(weapon);
                }
            }

            atkArmor = atkArmor.OrderByDescending(armor => armor.StatWithSynergy(stat,
                armor.SeriesId == RealmSynergy.SeriesId || character.EligibleForNightmareShift(RealmSynergy.NightmareCategory)))
                .ThenByDescending(armor => armor.StatWithSynergy("Res", armor.SeriesId == RealmSynergy.SeriesId
                    || character.EligibleForNightmareShift(RealmSynergy.NightmareCategory))
                        + armor.StatWithSynergy("Def", armor.SeriesId == RealmSynergy.SeriesId
                        || character.EligibleForNightmareShift(RealmSynergy.NightmareCategory)))
                .ToList();
            List<DataEquipmentInformation> possibleArmor = new List<DataEquipmentInformation>();
            foreach (DataEquipmentInformation armor in atkArmor)
            {
                if (FFRKInspector.GameData.EquipmentElementalInformation.ElementalEquipment.ContainsKey(armor.EquipmentId) ||
                    possibleArmor.Count(item => item.Category == armor.Category) < numberOfEquipment)
                {
                    possibleArmor.Add(armor);
                }
            }

            DataEquipmentInformation accessory = party.Equipments.Where(equip => equip.Type == GameData.SchemaConstants.ItemType.Accessory
                && !equippedAccessories.Contains(equip.InstanceId))
                .OrderByDescending(acc => acc.StatWithSynergy(stat, acc.SeriesId == RealmSynergy.SeriesId
                    || character.EligibleForNightmareShift(RealmSynergy.NightmareCategory)))
                    .ThenByDescending(acc => acc.StatWithSynergy("Res", acc.SeriesId == RealmSynergy.SeriesId
                    || character.EligibleForNightmareShift(RealmSynergy.NightmareCategory))
                        + acc.StatWithSynergy("Def", acc.SeriesId == RealmSynergy.SeriesId
                        || character.EligibleForNightmareShift(RealmSynergy.NightmareCategory)))
                    .First();

            List<DataRecordMateriaInformation> possibleRecordMateria = new List<DataRecordMateriaInformation>();
            if (!ignoreRecordMateria)
            {
                possibleRecordMateria = party.RecordMaterias.Where(rm => !equippedRecordMateria.Any(eRM => eRM.RecordMateriaId == rm.RecordMateriaId)).ToList();
                if ((character.BuddyId == (uint)GameData.SchemaConstants.BuddyID.DESHI && character.UsableSoulBreaks.Any(sb => sb.SoulBreakId == new GameData.SoulBreaks.SentinelsGrimoire().SoulBreakId))
                    || (character.BuddyId == (uint)GameData.SchemaConstants.BuddyID.YSHTOLA && character.UsableSoulBreaks.Any(sb => sb.SoulBreakId == new GameData.SoulBreaks.StoneskinII().SoulBreakId))
                    || (character.BuddyId == (uint)GameData.SchemaConstants.BuddyID.RAMZA && character.UsableSoulBreaks.Any(sb => sb.SoulBreakId == new GameData.SoulBreaks.Shout().SoulBreakId))
                    )
                {
                    if (possibleRecordMateria.Any(rm => rm.RecordMateriaId == new GameData.RecordMaterias.MakoMight().RecordMateriaId || rm.RecordMateriaId == new GameData.RecordMaterias.DrMogsTeachings().RecordMateriaId))
                    {
                        possibleRecordMateria.RemoveAll(rm => !(rm.RecordMateriaId == new GameData.RecordMaterias.MakoMight().RecordMateriaId
                            || rm.RecordMateriaId == new GameData.RecordMaterias.DrMogsTeachings().RecordMateriaId));
                    }
                }
            }
            
            DataEquipmentInformation weaponToEquip = null;
            DataEquipmentInformation armorToEquip = null;
            DataRecordMateriaInformation recordMateriaToEquip = null;

            double maxDamage = 0;
            GameData.SchemaConstants.Formulas formulaToUse;
            switch (stat)
            {
                case "Mag":
                    formulaToUse = GameData.SchemaConstants.Formulas.Magical;
                    break;
                case "Mnd":
                    formulaToUse = GameData.SchemaConstants.Formulas.Healing;
                    break;
                default:
                    formulaToUse = GameData.SchemaConstants.Formulas.Physical;
                    break;
            }
            GameData.Ability ability = (GameData.Ability)abilityBoxes[index * 2].SelectedItem;
            if (ability == null || ability.Formula != formulaToUse || ability.Category == GameData.SchemaConstants.AbilityCategory.None)
            {
                switch (formulaToUse)
                {
                    case GameData.SchemaConstants.Formulas.Magical:
                        ability = new GameData.Abilities.Ruin();
                        break;
                    
                    case GameData.SchemaConstants.Formulas.Healing:
                        ability = new GameData.Abilities.Cure();
                        break;

                    default:
                        ability = new GameData.Abilities.Attack();
                        break;
                }
            }
            bool characterHasNightmareShift = character.EligibleForNightmareShift(RealmSynergy.NightmareCategory);
            bool characterHasSynergy = character != null && (character.SeriesId == RealmSynergy.SeriesId ||
                characterHasNightmareShift);
            bool accessoryHasSynergy = accessory != null && (accessory.SeriesId == RealmSynergy.SeriesId ||
                characterHasNightmareShift);

            int recordMateriaCount = possibleRecordMateria.Count;
            Dictionary<GameData.SchemaConstants.EquipmentCategory, int> categoriesChecked = new Dictionary<GameData.SchemaConstants.EquipmentCategory, int>();
            foreach (DataEquipmentInformation weapon in possibleWeapons)
            {
                bool weaponHasSynergy = weapon != null && (weapon.SeriesId == RealmSynergy.SeriesId ||
                    characterHasNightmareShift);
                foreach (DataEquipmentInformation armor in possibleArmor)
                {
                    bool armorHasSynergy = armor != null && (armor.SeriesId == RealmSynergy.SeriesId ||
                        characterHasNightmareShift);
                    if (recordMateriaCount > 0)
                    {
                        foreach (DataRecordMateriaInformation recordMateria in possibleRecordMateria)
                        {
                            double atk = CalculateStat("Atk", character, weapon, armor, accessory, recordMateria, characterHasSynergy, weaponHasSynergy, armorHasSynergy, accessoryHasSynergy);
                            double mag = CalculateStat("Mag", character, weapon, armor, accessory, recordMateria, characterHasSynergy, weaponHasSynergy, armorHasSynergy, accessoryHasSynergy);
                            double mnd = CalculateStat("Mnd", character, weapon, armor, accessory, recordMateria, characterHasSynergy, weaponHasSynergy, armorHasSynergy, accessoryHasSynergy);
                            double damage = damagePerHit(character, weapon, armor, accessory, recordMateria, atk, mag, mnd, ability);
                            if (damage > maxDamage)
                            {
                                if (damage > 9999 && maxDamage >= 9999)
                                {
                                    continue;
                                }
                                maxDamage = damage;
                                weaponToEquip = weapon;
                                armorToEquip = armor;
                                recordMateriaToEquip = recordMateria;
                            }
                            else if (damage == maxDamage && weapon == weaponToEquip && armor != armorToEquip)
                            {
                                bool otherArmorSynergy = armorToEquip.SeriesId == RealmSynergy.SeriesId || characterHasNightmareShift;
                                if ((armor.StatWithSynergy("Def", armorHasSynergy) + armor.StatWithSynergy("Res", armorHasSynergy)) >
                                    (armorToEquip.StatWithSynergy("Def", otherArmorSynergy) + armorToEquip.StatWithSynergy("Res", otherArmorSynergy)))
                                {
                                    armorToEquip = armor;
                                }
                            }
                        }
                    }
                    else
                    {
                        DataRecordMateriaInformation recordMateria = recordMaterias[index];
                        double atk = CalculateStat("Atk", character, weapon, armor, accessory, recordMateria, characterHasSynergy, weaponHasSynergy, armorHasSynergy, accessoryHasSynergy);
                        double mag = CalculateStat("Mag", character, weapon, armor, accessory, recordMateria, characterHasSynergy, weaponHasSynergy, armorHasSynergy, accessoryHasSynergy);
                        double mnd = CalculateStat("Mnd", character, weapon, armor, accessory, recordMateria, characterHasSynergy, weaponHasSynergy, armorHasSynergy, accessoryHasSynergy);
                        double damage = damagePerHit(character, weapon, armor, accessory, recordMateria, atk, mag, mnd, ability);
                        if (damage > maxDamage)
                        {
                            if (damage > 9999 && maxDamage >= 9999)
                            {
                                continue;
                            }
                            maxDamage = damage;
                            weaponToEquip = weapon;
                            armorToEquip = armor;
                            recordMateriaToEquip = recordMateria;
                        }
                        else if (damage == maxDamage && weapon == weaponToEquip && armor != armorToEquip)
                        {
                            bool otherArmorSynergy = armorToEquip.SeriesId == RealmSynergy.SeriesId || characterHasNightmareShift;
                            if ((armor.StatWithSynergy("Def", armorHasSynergy) + armor.StatWithSynergy("Res", armorHasSynergy)) >
                                (armorToEquip.StatWithSynergy("Def", otherArmorSynergy) + armorToEquip.StatWithSynergy("Res", otherArmorSynergy)))
                            {
                                armorToEquip = armor;
                            }
                        }
                    }
                }
            }

            if (weaponToEquip != null)
            {
                for (int i = 0; i < weaponBoxes[index].Items.Count; i++)
                {
                    if (((DataEquipmentInformation)weaponBoxes[index].Items[i]).InstanceId == weaponToEquip.InstanceId)
                    {
                        weaponBoxes[index].SelectedIndex = i;
                        break;
                    }
                }
            }

            if (armorToEquip != null)
            {
                for (int i = 0; i < armorBoxes[index].Items.Count; i++)
                {
                    if (((DataEquipmentInformation)armorBoxes[index].Items[i]).InstanceId == armorToEquip.InstanceId)
                    {
                        armorBoxes[index].SelectedIndex = i;
                        break;
                    }
                }
            }

            if (accessory != null)
            {
                for (int i = 0; i < accessoryBoxes[index].Items.Count; i++)
                {
                    if (((DataEquipmentInformation)accessoryBoxes[index].Items[i]).InstanceId == accessory.InstanceId)
                    {
                        accessoryBoxes[index].SelectedIndex = i;
                        break;
                    }
                }
            }

            if (recordMateriaToEquip != null)
            {
                for (int i = 0; i < recordMateriaBoxes[index].Items.Count; i++)
                {
                    if (((DataRecordMateriaInformation)recordMateriaBoxes[index].Items[i]).RecordMateriaId == recordMateriaToEquip.RecordMateriaId)
                    {
                        recordMateriaBoxes[index].SelectedIndex = i;
                        break;
                    }
                }
            }
        }

        private void backgroundWorkerOptimizer_DoWork(object sender, DoWorkEventArgs e)
        {
            // bool forceWhiteMage = true;
            BackgroundWorker worker = sender as BackgroundWorker;
            
            List<GameData.DataBuddyInformation> atkCharacters = new List<GameData.DataBuddyInformation>();
            List<GameData.DataBuddyInformation> magCharacters = new List<GameData.DataBuddyInformation>();
            List<GameData.DataBuddyInformation> mndCharacters = new List<GameData.DataBuddyInformation>();
            Dictionary<uint, bool> ignoreRecordMateria = new Dictionary<uint,bool>();
            bool[] rm = optimizerRoleSelector.IgnoreRecordMaterias;
            for (int i = 0; i < 5; i++)
            {
                if (characters[i] == null)
                {
                    continue;
                }
                switch (optimizerRoleSelector.roles()[i])
                {
                    case OptimizerRoleSelector.Roles.Healer:
                        mndCharacters.Add(characters[i]);
                        break;

                    case OptimizerRoleSelector.Roles.Magical:
                        magCharacters.Add(characters[i]);
                        break;

                    default:
                        atkCharacters.Add(characters[i]);
                        break;
                }
                ignoreRecordMateria[characters[i].BuddyId] = rm[i];
            }

            atkCharacters = atkCharacters.OrderByDescending(character => character.UsableSoulBreaks.Where(sb => sb.Formula == GameData.SchemaConstants.Formulas.Physical)
                    .DefaultIfEmpty().Max(sb => sb != null ? sb.Multiplier * sb.NumberOfHits : 0)).ToList();
            magCharacters = magCharacters.OrderByDescending(character => character.UsableSoulBreaks.DefaultIfEmpty().Max(sb => sb != null ? sb.Multiplier * sb.NumberOfHits : 0)).ToList();

            if (optimizerRoleSelector.ClearExistingEquipmentSelections)
            {
                for (int i = 0; i < 5; i++)
                {
                    weaponBoxes[i].SelectedIndex = -1;
                    armorBoxes[i].SelectedIndex = -1;
                    accessoryBoxes[i].SelectedIndex = -1;
                    if (!ignoreRecordMateria[characters[i].BuddyId])
                    {
                        recordMateriaBoxes[i].SelectedIndex = -1;
                    }
                }
            }

           

            int done = 0;
            double step = 1.0 / (atkCharacters.Count + magCharacters.Count + mndCharacters.Count);
            int numberOfEquipmentToCheck = optimizerRoleSelector.SearchLessEquipment ? 1 : 5;
            foreach (GameData.DataBuddyInformation character in atkCharacters)
            {
                OptimizeCharacter(character, "Atk", ignoreRecordMateria[character.BuddyId], numberOfEquipmentToCheck);
                worker.ReportProgress((int)(++done * step * 100));
            }
            
            foreach (GameData.DataBuddyInformation character in magCharacters)
            {
                OptimizeCharacter(character, "Mag", ignoreRecordMateria[character.BuddyId], numberOfEquipmentToCheck);
                worker.ReportProgress((int)(++done * step * 100));
            }

            foreach (GameData.DataBuddyInformation character in mndCharacters)
            {
                OptimizeCharacter(character, "Mnd", ignoreRecordMateria[character.BuddyId], numberOfEquipmentToCheck);
                worker.ReportProgress((int)(++done * step * 100));
            }
        }

        private void backgroundWorkerOptimizer_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressDisplay.Value = e.ProgressPercentage;
        }

        private void backgroundWorkerOptimizer_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            progressDisplay.Value = 0;
            progressDisplay.Close();
        }

        private void comboBoxAbility_DrawItem(object sender, DrawItemEventArgs e)
        {
            e.DrawBackground();
            ComboBox comboBox = (ComboBox)sender;
            GameData.Ability ability = (GameData.Ability)comboBox.Items[e.Index];
            Brush brush = (abilityCounts.ContainsKey(ability.AbilityId) && abilityCounts[ability.AbilityId] > 0) ?
                            SystemBrushes.WindowText : SystemBrushes.GrayText;
            e.Graphics.DrawString(ability.Name, comboBox.Font, brush, e.Bounds.X, e.Bounds.Y);
        }

        private void fillBossElementalReactions()
        {
            dataGridViewBossElementReactions.Rows.Clear();
            VulnerabilityColumn.ValueType = typeof(ElementAdvantage);
            VulnerabilityColumn.ValueMember = "This";
            VulnerabilityColumn.DisplayMember = "Name";

            foreach (GameData.SchemaConstants.ElementID element in Enum.GetValues(typeof(GameData.SchemaConstants.ElementID)))
            {
                if (element == GameData.SchemaConstants.ElementID.None || element == GameData.SchemaConstants.ElementID.Nothing)
                {
                    continue;
                }
                DataGridViewRow row = new DataGridViewRow();
                DataGridViewCell cell = new DataGridViewTextBoxCell();
                cell.Value = element.ToString();
                cell.Tag = (ushort)element;
                row.Cells.Add(cell);

                cell = new DataGridViewComboBoxCell();
                ((DataGridViewComboBoxCell)cell).Items.Add(new ElementAdvantage("None", 0, 1.0f));
                ((DataGridViewComboBoxCell)cell).Items.Add(new ElementAdvantage("Resist 50%", 6, 0.5f));
                ((DataGridViewComboBoxCell)cell).Items.Add(new ElementAdvantage("Vulnerable 100%", 1, 2.0f));
                ((DataGridViewComboBoxCell)cell).Items.Add(new ElementAdvantage("Immune 100%", 11, 0f));
                for(int i = 10; i > 0; i--) {
                    ((DataGridViewComboBoxCell)cell).Items.Add(
                        new ElementAdvantage(String.Format("Absorb {0}%", i * 10), (uint)(11 + i), -0.1f * (float)i));
                }
                for(int i = 2; i <= 10; i++) {
                    if(i == 6) {
                        continue;
                    }
                    ((DataGridViewComboBoxCell)cell).Items.Add(
                        new ElementAdvantage(String.Format("Resist {0}%", 100 - ((i - 1) * 10)), (uint)i, 0.1f * (float)(i - 1)));
                }
                for(int i = 11; i < 20; i++) {
                    ((DataGridViewComboBoxCell)cell).Items.Add(
                        new ElementAdvantage(String.Format("Vulnerable {0}%", (i - 10) * 10), (uint)(41 - i), 1.0f + (0.1f * (float)(i - 10))));
                }

                cell.Value = ((DataGridViewComboBoxCell)cell).Items[0];
                row.Cells.Add(cell);

                row.Tag = element;
                dataGridViewBossElementReactions.Rows.Add(row);
            }

            if (dataGridViewBossElementReactions.SortedColumn != null)
            {
                ListSortDirection sortDirection = dataGridViewBossElementReactions.SortOrder == SortOrder.Descending ?
                    ListSortDirection.Descending : ListSortDirection.Ascending;
                dataGridViewBossElementReactions.Sort(dataGridViewBossElementReactions.SortedColumn, sortDirection);
            }
            else
            {
                dataGridViewBossElementReactions.Sort(dataGridViewBossElementReactions.Columns[0], ListSortDirection.Ascending);
            }
        }

        private void dataGridViewBossElementReactions_CellParsing(object sender, DataGridViewCellParsingEventArgs e)
        {
            if (e == null || e.Value == null ||
                dataGridViewBossElementReactions.Columns[e.ColumnIndex].Name != VulnerabilityColumn.Name)
            {
                return;
            }

            try
            {
                foreach(ElementAdvantage element in ((DataGridViewComboBoxCell)dataGridViewBossElementReactions.Rows[e.RowIndex].Cells[e.ColumnIndex]).Items)
                {
                    if (element.Name == e.Value.ToString())
                    {
                        e.Value = element;
                        break;
                    }
                }
                e.ParsingApplied = true;
            }
            catch(FormatException)
            {
                e.ParsingApplied = false;
            }
        }

        private void dataGridViewBossElementReactions_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            dataGridViewBossElementReactions.CommitEdit(DataGridViewDataErrorContexts.Commit);
        }

        private void dataGridViewBossElementReactions_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (skipRecalculations)
            {
                return;
            }
            RecalculateAllStats();
        }
    }
}
