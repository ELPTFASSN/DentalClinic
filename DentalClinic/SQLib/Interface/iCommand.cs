using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SQLib.Interface
{
    internal interface iCommand
    {
        void CommandExec(string sqlCommand, DataGridView targetDataGridView);
        void CommandExec(TextBox sqlCommandFromTextBox, DataGridView targetDataGridView);
    }
}
