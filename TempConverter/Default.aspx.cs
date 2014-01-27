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
                int startTemp = int.Parse(StartTempTextBox.Text);

                // Initialize maxTemp as loop index maximum value.
                int maxTemp = int.Parse(EndTempTextBox.Text);

                // TempToConvert is the current temperature to send to TemperatureConverter.
                int tempToConvert;

                // Initialize TSR (TemperatureScaleRate) as loop incrementer.
                int TSR = int.Parse(TempScaleTextBox.Text);

                // Initialize calculated value for number of table rows.
                int rowCnt = maxTemp/TSR;

                int cellsPerRow = 2;


                for (int rows = 0; rows < maxTemp; rows += TSR)
                {
                    // Calculate current temp to convert.
                    tempToConvert = rows == 0 ? startTemp : startTemp += TSR;

                    // Create new table row and add it to the table.
                    TableRow tr = new TableRow();
                    TempConvertResultTable.Rows.Add(tr);

                    // Create the first cell for each row.
                    TableCell firstColumnTc = new TableCell();
                    firstColumnTc.Text = tempToConvert.ToString();
                    tr.Cells.Add(firstColumnTc);

                    // Create the remaining cells
                    for (int cells = 0; cells < cellsPerRow - 1; cells++)
                    {
                        TableCell tc = new TableCell();
                        int cellInput = CF_RadioButton.Checked ? cellInput = tempToConvert.CelsiusToFahrenheit() : cellInput = tempToConvert.FahrenheitToCelcius();

                        tc.Text = cellInput.ToString();
                        tr.Cells.Add(tc);
                    }
                }
                TempConvertResultTable.Visible = true;
                //int degreesF = int.Parse(StartTempTextBox.Text).CelsiusToFahrenheit();
                //int degreesC = int.Parse(StartTempTextBox.Text).FahrenheitToCelcius();
            }
        }
    }
}