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
    public partial class EquipmentSelectorModal : Form
    {
        private GameData.DataBuddyInformation mCharacter;
        private ComboBox mEquipmentList;
        private List<uint> mEquippedItems;
        public uint SelectedInstanceId { get; set; }
        
        public EquipmentSelectorModal()
        {
            InitializeComponent();
        }


        public void UpdateEquipmentGrid(object character, ComboBox equipmentList, List<uint> equippedItems, FFRKViewPartyPlanner.Synergy realmSynergy)
        {
            mCharacter = (GameData.DataBuddyInformation)character;
            mEquipmentList = equipmentList;
            mEquippedItems = equippedItems;
            bool characterHasSynergy = mCharacter != null && (mCharacter.SeriesId == realmSynergy.SeriesId ||
                mCharacter.EligibleForNightmareShift(realmSynergy.NightmareCategory));
            for (int i = 0; i < comboBoxRealmSynergy.Items.Count; i++)
            {
                if (((FFRKViewPartyPlanner.Synergy)comboBoxRealmSynergy.Items[i]).SeriesId == realmSynergy.SeriesId)
                {
                    comboBoxRealmSynergy.SelectedIndex = i;
                    break;
                }
            }
            dataGridViewEquipment.Rows.Clear();
            foreach (GameData.Party.DataEquipmentInformation item in equipmentList.Items)
            {
                bool itemHasSynergy = item.SeriesId == realmSynergy.SeriesId ||
                    mCharacter.EligibleForNightmareShift(realmSynergy.NightmareCategory);
                bool itemEquippedElsewhere = equippedItems.Any(equippedItemId => equippedItemId == item.InstanceId);
                DataGridViewRow row = new DataGridViewRow();
                row.Tag = item;

                DataGridViewCell cell = new DataGridViewButtonCell();
                cell.Value = item.Name;
                cell.Tag = item.InstanceId;
                row.Cells.Add(cell);

                cell = new DataGridViewTextBoxCell();
                cell.Value = item.StatWithSynergy("Atk", itemHasSynergy);
                row.Cells.Add(cell);

                cell = new DataGridViewTextBoxCell();
                cell.Value = item.StatWithSynergy("Mag", itemHasSynergy);
                row.Cells.Add(cell);

                cell = new DataGridViewTextBoxCell();
                cell.Value = item.StatWithSynergy("Mnd", itemHasSynergy);
                row.Cells.Add(cell);

                cell = new DataGridViewTextBoxCell();
                cell.Value = item.StatWithSynergy("Def", itemHasSynergy);
                row.Cells.Add(cell);

                cell = new DataGridViewTextBoxCell();
                cell.Value = item.StatWithSynergy("Res", itemHasSynergy);
                row.Cells.Add(cell);

                cell = new DataGridViewTextBoxCell();
                cell.Value = item.StatWithSynergy("Acc", itemHasSynergy);
                row.Cells.Add(cell);

                cell = new DataGridViewTextBoxCell();
                cell.Value = item.StatWithSynergy("Eva", itemHasSynergy);
                row.Cells.Add(cell);

                cell = new DataGridViewTextBoxCell();
                cell.Value = item.StatWithSynergy("Spd", itemHasSynergy);
                row.Cells.Add(cell);

                if (itemEquippedElsewhere)
                {
                    row.DefaultCellStyle.BackColor = System.Drawing.Color.Red;
                }
                else if (itemHasSynergy)
                {
                    row.DefaultCellStyle.BackColor = System.Drawing.Color.Aqua;
                }
                else
                {
                    row.DefaultCellStyle.BackColor = System.Drawing.Color.Empty;
                }

                dataGridViewEquipment.Rows.Add(row);
            }
            if (dataGridViewEquipment.SortedColumn != null)
            {
                ListSortDirection sortDirection = dataGridViewEquipment.SortOrder == SortOrder.Descending ?
                    ListSortDirection.Descending : ListSortDirection.Ascending;
                dataGridViewEquipment.Sort(dataGridViewEquipment.SortedColumn, sortDirection);
            }
        }

        private FFRKViewPartyPlanner.Synergy RealmSynergy
        {
            get
            {
                if (comboBoxRealmSynergy.SelectedItem != null)
                {
                    return (FFRKViewPartyPlanner.Synergy)comboBoxRealmSynergy.SelectedItem;
                }
                return (FFRKViewPartyPlanner.Synergy)comboBoxRealmSynergy.Items[0];
            }
        }
        
        public void UpdateRealmSynergies(ComboBox.ObjectCollection synergies)
        {
            comboBoxRealmSynergy.Items.Clear();
            foreach (FFRKViewPartyPlanner.Synergy synergy in synergies)
            {
                comboBoxRealmSynergy.Items.Add(synergy);
            }
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Close();
        }

        private void comboBoxRealmSynergy_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateEquipmentGrid(mCharacter, mEquipmentList, mEquippedItems, RealmSynergy);
        }

        private void dataGridViewEquipment_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0)
            {
                var button = (DataGridViewButtonCell)senderGrid.Rows[e.RowIndex].Cells[0];
                SelectedInstanceId = (uint)button.Tag;
                this.DialogResult = System.Windows.Forms.DialogResult.OK;
                this.Close();
            }
        }
    }
}
