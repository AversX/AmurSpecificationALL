using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace SpecificationPack
{
    public partial class MainForm : Form
    {
        private Excel.Application excel;

        struct Unit
        {
            private string pos;
            private string code;
            private string name;
            private string manufacture;
            private double num;
            private string measure;

            public string Pos { get => pos; set => pos = value; }
            public string Code { get => code; set => code = value; }
            public string Name { get => name; set => name = value; }
            public string Manufacture { get => manufacture; set => manufacture = value; }
            public double Num { get => num; set => num = value; }
            public string Measure { get => measure; set => measure = value; }
        }


        public MainForm()
        {
            InitializeComponent();
        }

        private void formBtn_Click(object sender, EventArgs e)
        {
            List<Unit> Units = new List<Unit>();
            if (specAlexTBox.Text!="")
                Units.AddRange(LoadSpec(specAlexTBox.Text, false));
            if (specAlexAvrTBox.Text != "")
                Units.AddRange(LoadSpec(specAlexAvrTBox.Text, true));
            Units = consolidate(Units);
            uploadData(Units);
        }

        private List<Unit> consolidate(List<Unit> units)
        {
            for (int i = 0; i < units.Count; i++)
            {
                Unit unit = units[i];
                for (int j = i + 1; j < units.Count; j++)
                    if (unit.Code == units[j].Code && unit.Name == units[j].Name && unit.Measure.ToUpper().Replace(".", "") == units[j].Measure.ToUpper().Replace(".", ""))
                    {
                        if (unit.Pos != "")
                        {
                            if (units[j].Pos != "")
                                unit.Pos += ", " + units[j].Pos;
                        }
                        else
                        {
                            if (units[j].Pos != "")
                                unit.Pos += units[j].Pos;
                        }
                        unit.Num += units[j].Num;
                        units.RemoveAt(j);
                        j--;
                        units[i] = unit;
                    }
            }
            return units;
        }

        private List<Unit> LoadSpec(string path, bool cbSpec)
        {
            List<Unit> units = new List<Unit>();
            DataSet dataSet = new DataSet("EXCEL");
            string connectionString;
            connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + path + ";Extended Properties='Excel 12.0;HDR=YES'";
            OleDbConnection connection = new OleDbConnection(connectionString);
            connection.Open();

            System.Data.DataTable schemaTable = connection.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, new object[] { null, null, null, "TABLE" });
            string sheet1 = (string)schemaTable.Rows[0].ItemArray[2];

            string select = String.Format("SELECT * FROM [{0}]", sheet1);
            OleDbDataAdapter adapter = new OleDbDataAdapter(select, connection);
            adapter.Fill(dataSet);
            connection.Close();

            int column = 0;
            if (!cbSpec) column++;
            for (int row = 0; row < dataSet.Tables[0].Rows.Count; row++)
            {
                if (dataSet.Tables[0].Rows[row][2].ToString().Length > 0)
                {
                    Unit unit = new Unit();
                    if (!cbSpec) unit.Pos = dataSet.Tables[0].Rows[row][0].ToString().Trim();
                    unit.Code = dataSet.Tables[0].Rows[row][column].ToString().Trim();
                    unit.Name = dataSet.Tables[0].Rows[row][column + 1].ToString().Trim();
                    unit.Manufacture = dataSet.Tables[0].Rows[row][column + 2].ToString().Trim();
                    unit.Num = double.Parse(dataSet.Tables[0].Rows[row][column +3].ToString().Trim());
                    if (cbSpec) unit.Measure = dataSet.Tables[0].Rows[row][4].ToString().Trim();
                    else unit.Measure = "шт";
                    if ((unit.Manufacture.ToUpper() == "Helukabel" || unit.Manufacture=="HELUKABEL") && SpecAlexHelukabel.Checked) { unit.Num = unit.Num * int.Parse(SpecAlexHelukabelTxt.Text); unit.Measure = "м"; }
                    units.Add(unit);
                }
            }
            return units;
        }

        private void uploadData(List<Unit> units)
        {
            excel = new Excel.Application();
            excel.SheetsInNewWorkbook = 1;
            excel.Workbooks.Add(Type.Missing);
            Excel.Worksheet sheet = (Excel.Worksheet)excel.Sheets.get_Item(1);
            sheet.Cells[1, 1] = "№п/п";
            sheet.Columns[1].NumberFormat = "#";
            sheet.Cells[1, 2] = "Поз";
            sheet.Columns[2].NumberFormat = "@";
            sheet.Cells[1, 3] = "Артикул";
            sheet.Columns[3].NumberFormat = "@";
            sheet.Cells[1, 4] = "Наименование";
            sheet.Columns[4].NumberFormat = "@";
            sheet.Cells[1, 5] = "Кол.";
            sheet.Columns[5].NumberFormat = "#";
            sheet.Cells[1, 6] = "Ед. изм";
            sheet.Columns[6].NumberFormat = "@";
            sheet.Cells[1, 7] = "Производитель";
            sheet.Columns[7].NumberFormat = "@";
            for (int i = 1; i < units.Count; i++)
            {
                sheet.Cells[i + 1, 1] = i+1;
                sheet.Cells[i + 1, 2] = units[i].Pos;
                sheet.Cells[i + 1, 3] = units[i].Code;
                sheet.Cells[i + 1, 4] = units[i].Name;
                sheet.Cells[i + 1, 5] = units[i].Num;
                sheet.Cells[i + 1, 6] = units[i].Measure;
                sheet.Cells[i + 1, 7] = units[i].Manufacture;
            }
            excel.Visible = true;
        }
        

        private void specAlexTBox_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop) && ((e.AllowedEffect & DragDropEffects.Move) == DragDropEffects.Move))
                e.Effect = DragDropEffects.Move;
        }

        private void specAlexAvrTBox_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop) && ((e.AllowedEffect & DragDropEffects.Move) == DragDropEffects.Move))
                e.Effect = DragDropEffects.Move;
        }

        private void specAndrTBox_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop) && ((e.AllowedEffect & DragDropEffects.Move) == DragDropEffects.Move))
                e.Effect = DragDropEffects.Move;
        }

        private void specVladTBox_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop) && ((e.AllowedEffect & DragDropEffects.Move) == DragDropEffects.Move))
                e.Effect = DragDropEffects.Move;
        }

        private void clrBtn_Click(object sender, EventArgs e)
        {
            specAlexAvrTBox.Text = "";
            specAlexTBox.Text = "";
        }

        private void specAlexTBox_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop) && e.Effect == DragDropEffects.Move)
            {
                string[] objects = (string[])e.Data.GetData(DataFormats.FileDrop);
                specAlexTBox.Text = objects[0];
            }
        }

        private void specAlexAvrTBox_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop) && e.Effect == DragDropEffects.Move)
            {
                string[] objects = (string[])e.Data.GetData(DataFormats.FileDrop);
                specAlexAvrTBox.Text = objects[0];
            }
        }

        private void addSpec1Btn_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "(*.xlsx); (*.xls)|*.xlsx; *.xls";
            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                specAlexTBox.Text = ofd.FileName;
            }
        }

        private void addSpec2Btn_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "(*.xlsx); (*.xls)|*.xlsx; *.xls";
            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                specAlexAvrTBox.Text = ofd.FileName;
            }
        }
    }
}
