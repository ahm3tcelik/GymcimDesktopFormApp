using System.Collections.Generic;
using System.Windows.Forms;

namespace Gymcim.FormUI.Utilities
{
    public static class NavigationTool
    {
        public static void Open(Form currentForm, Form newForm)
        {     
            currentForm.Hide();
            newForm.ShowDialog();
            currentForm.Close();
        }
        public static void OpenNewTab(Form newForm)
        {
            newForm.ShowDialog();
        }
    }
}
