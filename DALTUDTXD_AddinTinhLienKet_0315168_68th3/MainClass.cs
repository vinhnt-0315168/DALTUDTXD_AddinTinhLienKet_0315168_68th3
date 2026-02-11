
using Autodesk.Revit.UI;
using System.Reflection;
using System.Windows.Media.Imaging;

namespace DALTUDTXD_AddinTinhLienKet_0315168_68th3
{
    public class MainClass : IExternalApplication
    {
        public Result OnStartup(UIControlledApplication application)
        {
            //Add a new ribbon tab
            application.CreateRibbonTab("DALTUDTXD68TH3");
            // Add a new ribbon panel
            RibbonPanel ribbonPanel = application.CreateRibbonPanel("DALTUDTXD68TH3", "Cấu kiện");
            // Create a push button to trigger a command add it to the ribbon panel.
            string thisAssemblyPath = Assembly.GetExecutingAssembly().Location;
            PushButtonData buttonData = new PushButtonData("cmdInforSteels",
               "Steels", thisAssemblyPath, "DALTUDTXD_AddinTinhLienKet_0315168_68th3.ExternalComand.InforSteels");
            PushButton pushButton = ribbonPanel.AddItem(buttonData) as PushButton;
            // Optionally, other properties may be assigned to the button
            // a) tool-tip
            pushButton.ToolTip = "Ch?n c?u ki?n";
            // b) large bitmap
            Uri uriImage = new Uri(@"E:\vs26\DALTUDTXD_AddinTinhLienKet_0315168_68th3\DALTUDTXD_AddinTinhLienKet_0315168_68th3\Assets\Icons\Steel I Beam.ico");
            BitmapImage largeImage = new BitmapImage(uriImage);
            pushButton.LargeImage = largeImage;

            //tạo nút thứ 2
            PushButtonData buttonData2 = new PushButtonData("cmdInforJoin",
               "Join", thisAssemblyPath, "DALTUDTXD_AddinTinhLienKet_0315168_68th3.ExternalComand.InforJoin");
            //khai báo nút
            PushButton pushButton2 = ribbonPanel.AddItem(buttonData2) as PushButton;
            // Optionally, other properties may be assigned to the button
            // a) tool-tip
            pushButton.ToolTip = "Chọn cấu kiện";
            // b) large bitmap
            Uri uriImage1 = new Uri(@"E:\vs26\DALTUDTXD_AddinTinhLienKet_0315168_68th3\DALTUDTXD_AddinTinhLienKet_0315168_68th3\Assets\Icons\Link.png");
            BitmapImage largeImage1 = new BitmapImage(uriImage);
            pushButton.LargeImage = largeImage;

            return Result.Succeeded;
        }
        public Result OnShutdown(UIControlledApplication application)
        {
            TaskDialog.Show("Thông báo", "Add-in ?ã t?t thành công!");
            return Result.Succeeded;
        }
    }

}
