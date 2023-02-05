using ScriptPortal.Vegas;
using VegasScriptHelper;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace VegasScriptRemoveJimakuPrefix
{
    public class EntryPoint: IEntryPoint
    {
        private SettingForm settingForm = null;

        public void FromVegas(Vegas vegas)
        {
            VegasHelper helper = VegasHelper.Instance(vegas);

            Dictionary<string, VideoTrack> keyValuePairs = helper.GetVideoKeyValuePairs();

            if(!keyValuePairs.Any())
            {
                MessageBox.Show("ビデオトラックがありません");
            }

            List<string> videoTrackKeys = keyValuePairs.Keys.ToList();

            VideoTrack selected = helper.SelectedVideoTrack(false);

            string initialKey = selected != null ? helper.GetTrackKey(selected) : videoTrackKeys[0];

            if(settingForm == null) { settingForm = new SettingForm(); }

            settingForm.RemoveJimakuDataSource = videoTrackKeys;
            settingForm.RemoveJimakuTrackName = initialKey;

            if(settingForm.ShowDialog() == DialogResult.Cancel) { return; }

            try
            {
                helper.DeleteJimakuPrefix(keyValuePairs[settingForm.RemoveJimakuTrackName]);
            }
            catch (VegasHelperTrackUnselectedException)
            {
                MessageBox.Show("ビデオトラックが選択されていません。");
            }
            catch (VegasHelperNoneEventsException)
            {
                MessageBox.Show("選択したビデオトラック中にイベントが存在していません。");
            }
        }
    }
}
