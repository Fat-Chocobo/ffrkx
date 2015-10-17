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
using FFRKInspector.GameData.RWs;
using FFRKInspector.UI.ListViewFields;
using FFRKInspector.GameData;
using FFRKInspector.DataCache;
using FFRKInspector.Analyzer;
using System.Diagnostics;
using System.IO;

namespace FFRKInspector.UI
{
    public partial class FFRKViewRWs : UserControl
    {
        public FFRKViewRWs()
        {
            InitializeComponent();
        }

        private void FFRKViewInventory_Load(object sender, EventArgs e)
        {
            if (DesignMode)
                return;

            if (FFRKProxy.Instance != null)
            {
                FFRKProxy.Instance.OnRWList += FFRKProxy_OnRWList;

                List<DataRelatedRW> RWs = FFRKProxy.Instance.GameState.RelatedRWs;
                if (RWs != null)
                {
                    UpdateRWGrid(RWs);
                }
            }
        }

        void FFRKProxy_OnRWList(List<DataRelatedRW> RWs)
        {
            BeginInvoke((Action)(() =>
            {
                UpdateRWGrid(RWs);
            }));
        }

        private void UpdateRWGrid(List<DataRelatedRW> RWs)
        {
            dataGridViewRWs.Rows.Clear();
            dataGridViewRWs.Rows.Add(RWs.Count);
            int cur_row = 0;
            foreach (DataRelatedRW RWData in RWs)
            {
                DataGridViewRow row = dataGridViewRWs.Rows[cur_row];
                row.Tag = RWData;
                row.Cells[dgcNickname.Name].Value = RWData.NickName;
                row.Cells[dgcRelation.Name].Value = Enum.GetName(typeof(DataRelatedRW.Relationship), RWData.RelationStatus);
                row.Cells[dgcSBName.Name].Value = RWData.SBName;
                //TODO: Figure out how the hell to derive this from the UserID data
                row.Cells[dgcFriendCode.Name].Value = "";
                row.Cells[dgcUserID.Name].Value = RWData.UserID;

                ++cur_row;
            }
        }
    }
}
