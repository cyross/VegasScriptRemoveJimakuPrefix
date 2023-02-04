using ScriptPortal.Vegas;
using VegasScriptHelper;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace VegasScriptRemoveJimakuPrefix
{
    public class EntryPoint: IEntryPoint
    {
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

            SettingForm form = new SettingForm()
            {
                RemoveJimakuDataSource = videoTrackKeys,
                RemoveJimakuTrackName = initialKey
            };

            try
            {
                helper.DeleteJimakuPrefix(keyValuePairs[form.RemoveJimakuTrackName]);
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
