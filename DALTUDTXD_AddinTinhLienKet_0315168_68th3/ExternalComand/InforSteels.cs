using Autodesk.Revit.Attributes;
using Autodesk.Revit.DB;
using Autodesk.Revit.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DALTUDTXD_AddinTinhLienKet_0315168_68th3.ExternalComand
{
    [Transaction(TransactionMode.Manual)]
    internal class InforSteels : IExternalCommand
    {
        // The main Execute method (inherited from IExternalCommand) must be public
        public Result Execute(ExternalCommandData CommandData,
            ref string message, ElementSet elements)
        {
            try
            {
                TaskDialog.Show("Steels", "Thông số thép tổ hợp");
                return Result.Succeeded;
            }
            catch (Exception ex)
            {
                message = ex.Message;
                return Result.Failed;
            }
            return Autodesk.Revit.UI.Result.Succeeded;
        }
    }
}
