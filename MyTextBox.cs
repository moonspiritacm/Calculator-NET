using System.Windows.Controls;
using System.Windows.Input;

namespace Calculator_NET
{
    internal sealed class MyTextBox : TextBox
    {
        protected override void OnPreviewGotKeyboardFocus(KeyboardFocusChangedEventArgs e)
        {
            e.Handled = true;
            base.OnPreviewGotKeyboardFocus(e);
        }
    }
}