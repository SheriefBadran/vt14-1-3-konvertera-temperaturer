using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TempConverter.Model;

namespace TempConverter
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // Empty
        }

        protected void ConvertButton_Click(object sender, EventArgs e)
        {
            if (IsValid)
            {
                // Initialize startTemp.
                var startTemp = int.Parse(StartTempTextBox.Text);

                // Initialize maxTemp as loop index maximum value.
                var maxTemp = int.Parse(EndTempTextBox.Text);

                // Initialize TSR (TemperatureScaleRate) as loop incrementer.
                var TSR = int.Parse(TempScaleTextBox.Text);

                // Initialize calculated value for number of table rows.
                var rowCnt = maxTemp/TSR;

                var cellsPerRow = 2;

                if (FC_RadioButton.Checked)
                {
                    FirstHeaderCell.Text = "&deg;F";
                    SecondHeaderCell.Text = "&deg;C";
                }
                // Render table header with content.
                //TableHeaderRow tableHeaderRow = new TableHeaderRow();
                //TempConvertResultTable.Rows.Add(tableHeaderRow);
                //for (int i = 0; i < cellsPerRow; i++)
                //{
                //    TableHeaderCell thc = new TableHeaderCell();

                    
                //    if (CF_RadioButton.Checked && i == 0)
                //    {
                //        thc.Text = "&deg;C";
                //    }
                //    else if(CF_RadioButton.Checked)
                //    {
                //        thc.Text = "&deg;F";
                //    }

                //    if (FC_RadioButton.Checked && i == 0)
                //    {
                //        thc.Text = "&deg;F";
                //    }
                //    else if (FC_RadioButton.Checked)
                //    {
                //        thc.Text = "&deg;C";
                //    }
                //    tableHeaderRow.Cells.Add(thc);
                //}

                // Render table, table rows and table cells with content.
                for (int temp = startTemp; temp <= maxTemp; temp += TSR)
                {
                    // Create new table row and add it to the table.
                    TableRow tr = new TableRow();
                    TempConvertResultTable.Rows.Add(tr);

                    // Create the first cell for each row.
                    TableCell firstColumnTc = new TableCell();
                    firstColumnTc.Text = temp.ToString();
                    tr.Cells.Add(firstColumnTc);

                    // Create the remaining cells
                    for (int cells = 0; cells < cellsPerRow - 1; cells++)
                    {
                        TableCell secondColumnTc = new TableCell();

                        secondColumnTc.Text = CF_RadioButton.Checked ?
                            secondColumnTc.Text = temp.CelsiusToFahrenheit().ToString()
                            : secondColumnTc.Text = temp.FahrenheitToCelcius().ToString();
                        tr.Cells.Add(secondColumnTc);
                    }
                }
                TempConvertResultTable.Visible = true;
            }
        }
    }
}