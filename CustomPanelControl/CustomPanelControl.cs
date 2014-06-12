
using SoftVelocity.ClarionNet.CommonProperties;
using SoftVelocity.ClarionNet.Windows;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Drawing;
namespace Fushnisoft.CustomClarionIDEControls
{
    [WindowDesignerClassAttribute, Designer(typeof(PanelControlDesigner), typeof(IDesigner)), ToolboxBitmap(typeof(Panel_CUSTOM), "Resources.grid.png")]
    public class Panel_CUSTOM : SoftVelocity.ClarionNet.Windows.PANEL
    {
        public Panel_CUSTOM()
        {
            Bevel.Outer = 0;
        }

    }
}
