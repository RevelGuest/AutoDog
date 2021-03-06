using System.Windows;
using System.Windows.Automation.Peers;

namespace AutoDog.UI.Controls
{
    /// <summary>
    /// The MetroThumbContentControlAutomationPeer class exposes the <see cref="T:AutoDog.UI.Controls.MetroThumbContentControl" /> type to UI Automation.
    /// </summary>
    public class MetroThumbContentControlAutomationPeer : FrameworkElementAutomationPeer
    {
        public MetroThumbContentControlAutomationPeer(FrameworkElement owner)
            : base(owner)
        {
        }

        protected override AutomationControlType GetAutomationControlTypeCore()
        {
            return AutomationControlType.Custom;
        }

        protected override string GetClassNameCore()
        {
            return "MetroThumbContentControl";
        }
    }
}