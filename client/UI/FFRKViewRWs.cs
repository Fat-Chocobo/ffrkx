using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
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
        class ChartSeriesItem
        {
            public string SBName;
            public int Count;
        }

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
                    UpdatePieCharts(RWs);
                }
            }
        }

        void FFRKProxy_OnRWList(List<DataRelatedRW> RWs)
        {
            BeginInvoke((Action)(() =>
            {
                UpdateRWGrid(RWs);
                UpdatePieCharts(RWs);
            }));
        }

        private void UpdatePieCharts(List<DataRelatedRW> RWs)
        {
            Dictionary<string, int> FriendSeries = GetSeriesDict(RWs, DataRelatedRW.Relationship.Followee);
            if (FriendSeries.Count > 0)
            {
                pchtFriendSB.Series[0].Points.DataBindXY(FriendSeries.Keys, FriendSeries.Values);
                pchtFriendSB.Series[0].Label = "#AXISLABEL - #PERCENT{P0}";
                pchtFriendSB.Series[0]["PieLabelStyle"] = "Disabled";
                pchtFriendSB.Invalidate();
            }

            Dictionary<string, int> MutualSeries = GetSeriesDict(RWs, DataRelatedRW.Relationship.Mutual);
            if (MutualSeries.Count > 0)
            {
                pchtMutualSB.Series[0].Points.DataBindXY(MutualSeries.Keys, MutualSeries.Values);
                pchtMutualSB.Series[0].Label = "#AXISLABEL - #PERCENT{P0}";
                pchtMutualSB.Series[0]["PieLabelStyle"] = "Disabled";
                pchtMutualSB.Invalidate();
            }
            
            Dictionary<string, int> FollowerSeries = GetSeriesDict(RWs, DataRelatedRW.Relationship.Follower);
            if (FollowerSeries.Count > 0)
            {
                pchtFollowerSB.Series[0].Points.DataBindXY(FollowerSeries.Keys, FollowerSeries.Values);
                pchtFollowerSB.Series[0].Label = "#AXISLABEL - #PERCENT{P0}";
                pchtFollowerSB.Series[0]["PieLabelStyle"] = "Disabled";
                pchtFollowerSB.Invalidate();        
            }
        }

        private static Dictionary<string, int> GetSeriesDict(List<DataRelatedRW> RWs, DataRelatedRW.Relationship Relationship)
        {
            Dictionary<string, int> SeriesDict;
            List<ChartSeriesItem> SeriesList = RWs.Where(rw => rw.RelationStatus == (int)Relationship)
                             .GroupBy(rw => rw.SBName)
                             .Select(sb => new ChartSeriesItem { SBName = sb.Key, Count = sb.Distinct().Count() }).ToList<ChartSeriesItem>();
            //Change blank row SB names to 'Unknown'
            foreach (var fr in SeriesList.Where(x => x.SBName == ""))
            {
                fr.SBName = "Unknown";
            }
            SeriesDict = new Dictionary<string, int>(SeriesList.OrderByDescending(x => x.Count).ToDictionary(k => k.SBName, v => v.Count));
            return SeriesDict;
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

                ++cur_row;
            }
        }
    }
}
