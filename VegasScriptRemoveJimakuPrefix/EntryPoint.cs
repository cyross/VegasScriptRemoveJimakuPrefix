using ScriptPortal.Vegas;
using VegasScriptHelper;
using System.Windows.Forms;

namespace VegasScriptRemoveJimakuPrefix
{
    public class EntryPoint
    {
        public void FromVegas(Vegas vegas)
        {
            VegasScriptSettings.Load();
            VegasHelper helper = VegasHelper.Instance(vegas);

            try
            {
                helper.DeleteJimakuPrefix();
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
