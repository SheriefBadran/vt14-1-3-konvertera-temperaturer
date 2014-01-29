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
                if (!CF_RadioButton.Checked && !FC_RadioButton.Checked)
                {
                    ModelState.AddModelError(String.Empty, "Ett fel har inträffat med alternativknapparna!");
                }

                // Initialize TSR (TemperatureScaleRate) as loop incrementer for the Temperature class.
                var TSR = int.Parse(TempScaleTextBox.Text);
                bool convDirection = CF_RadioButton.Checked ? convDirection = true : convDirection = false;

                try
                {
                    Temperature temperature = new Temperature(int.Parse(StartTempTextBox.Text), int.Parse(EndTempTextBox.Text), TSR, convDirection);

                    if (FC_RadioButton.Checked)
                    {
                        FirstHeaderCell.Text = "&deg;F";
                        SecondHeaderCell.Text = "&deg;C";
                    }

                    RenderResultTable(temperature);
                }
                catch (Exception ex)
                {
                    ModelState.AddModelError(String.Empty, ex.Message);
                }
            }
        }

        protected void RenderResultTable(Temperature temp)
        {
            Dictionary<int, int> tableContents = temp.CreateResultTableTemperatures();
            foreach (var temperature in tableContents.Keys)
            {
                TableRow tr = new TableRow();
                TempConvertResultTable.Rows.Add(tr);

                // Create the first cell for each row.
                TableCell firstColumnTc = new TableCell();
                firstColumnTc.Text = temperature.ToString();
                tr.Cells.Add(firstColumnTc);

                TableCell secondColumnTc = new TableCell();
                secondColumnTc.Text = tableContents[temperature].ToString();
                tr.Cells.Add(secondColumnTc);
            }
            TempConvertResultTable.Visible = true;
        }
    }
}