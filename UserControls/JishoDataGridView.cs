using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace JapaneseApp.UserControls
{
    public partial class JishoDataGridView : UserControl
    {

        public event EventHandler changedCell = delegate { };
        public JishoDataGridView()
        {
            InitializeComponent();

           dataGridView.SelectionChanged += new EventHandler(selectionChanged);//this is also an event.
        }

        private void selectionChanged(object sender, EventArgs e)
        {
            changedCell(this, new EventArgs());
        }

        public void AddRows(List<string[]> rows)
        {
            dataGridView.Rows.Clear();
            foreach (string[] row in rows)
            {
                dataGridView.Rows.Add(row);
            }
        }

        public void UpdateCurrentCell()
        {
            for (int colIndex = 0; dataGridView.CurrentCell.Value == null; colIndex++)
            {
                if (colIndex == 4)
                    throw new InvalidDataException();
                dataGridView.CurrentCell = dataGridView[++colIndex, 0];
            }
        }

        public string GetCurrentCellText()
        {
            if (dataGridView.CurrentCell == null || dataGridView.CurrentCell.Value == null)
                return null;
            return dataGridView.CurrentCell.Value.ToString();
        }

        public void SetFont(Font font)
        {
            dataGridView.Font = font;
        }
    }
}
