
using Autodesk.Revit.UI;
using System.Reflection;
using System.Windows.Media.Imaging;

namespace DALTUDTXD_AddinTinhLienKet_0315168_68th3
{
    public class MainClass : IExternalApplication
    {
        public Result OnStartup(UIControlledApplication application)
        {
           
            return Result.Succeeded;
        }
        public Result OnShutdown(UIControlledApplication application)
        {
            TaskDialog.Show("Thông báo", "Add-in ?ã t?t thành công!");
            return Result.Succeeded;
        }
    }

}
