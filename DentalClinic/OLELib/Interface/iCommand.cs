using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace OLELib.Interface
{
    public interface iCommand
    {
        void CommandExec(string oleCommand, DataGridView targetDataGridView);
        void CommandExec(TextBox oleCommandFromTextBox, DataGridView targetDataGridView);
    }
}
