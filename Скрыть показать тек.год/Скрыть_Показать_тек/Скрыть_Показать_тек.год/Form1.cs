using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace Скрыть_Показать_тек.год
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            hideRadioButton.Checked = true;

            chooseAllFormsBut.Enabled = false;
            getListBut.Enabled = false;

            getListOPBut.Enabled = false;
            chooseAllOpBut.Enabled = false;

            startBut.Enabled = false;
        }

        List<string> pathList1 = new List<string>(); 
        List<string> pathList2 = new List<string>();
        List<string> nameList = new List<string>();
        List<string> lst = new List<string>(); //Здесь хранятся все пути ПФ'ок которые будут редачиться

        private void clearDataBut_Click(object sender, EventArgs e)
        {
            checkedListBox1.Items.Clear();
            checkedListBox2.Items.Clear();
            pathTextBox.Text = "";
            bool flag1 = false;
            bool flag2 = false;
            pathList1.Clear();
            pathList2.Clear();
        }
        
        private void chooseButton_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folder = new FolderBrowserDialog();
            if (folder.ShowDialog() == DialogResult.OK)
            {
                pathTextBox.Text = folder.SelectedPath;
            }

            getListBut.Enabled = true;
        }

        private void getListBut_Click(object sender, EventArgs e)
        {
            checkedListBox1.Items.Clear();
            pathList1.Clear();
            
            string dirName = pathTextBox.Text;
            var directory = new DirectoryInfo(dirName);
            
            
            DirectoryInfo[] dirs = directory.GetDirectories();
            foreach (DirectoryInfo dir in dirs)
            {
                checkedListBox1.Items.Add(dir.Name);
                pathList1.Add(dir.FullName);
            }

            if (pathList1.Count == 0)
                MessageBox.Show("В папке " + dirName + " нет вложенных папок!", "Внимание!");
            else
            {
                label3.Text = pathList1.Count.ToString();
                chooseAllFormsBut.Enabled = true;
                getListOPBut.Enabled = true;
            }
        }

        private void getListOpMethod()
        {
            for (int i = 0; i < pathList1.Count; i++)
            {
                //сравниваются выделенные ОБАС и сокрщенные split'ом пути в pathList1
                if (checkedListBox1.CheckedItems.Contains(Convert.ToString(pathList1[i]).Substring(pathList1[i].LastIndexOf('\\') + 1)))
                {
                    string catName = pathList1[i].ToString();
                    var catDire = new DirectoryInfo(catName);

                    DirectoryInfo[] catDirs = catDire.GetDirectories();

                    foreach (DirectoryInfo dir in catDirs)
                    {
                        nameList.Add(dir.Name);
                        pathList2.Add(dir.FullName);
                    }
                }
            }
        }
        
        private void getListOPBut_Click(object sender, EventArgs e)
        {
            checkedListBox2.Items.Clear();
            pathList2.Clear();
            nameList.Clear();

            if (checkedListBox1.CheckedItems.Count == 0)
                MessageBox.Show("Не выбраны папки!", "Внимание!");
            else
            {
                getListOpMethod();
                nameList = nameList.Distinct().ToList();
                for (int i = 0; i < nameList.Count; i++)
                    checkedListBox2.Items.Add(nameList[i]);

                label4.Text = nameList.Count.ToString();
                chooseAllOpBut.Enabled = true;
                startBut.Enabled = true;
            }
        }

        bool flag1 = false;
        bool flag2 = false;

        private bool flagSwitch(int flagNum)
        {
            switch(flagNum)
            {
                case 1: return flag1 = !flag1;
                case 2: return flag2 = !flag2;
                default: return false;
            }
        }

        private void checkSwitch1(bool flag)
        {
            for (int i = 0; i < pathList1.Count; i++)
                checkedListBox1.SetItemChecked(i, flag);
        }

        private void checkSwitch2(bool flag)
        {
            for (int i = 0; i < checkedListBox2.Items.Count; i++)
                checkedListBox2.SetItemChecked(i, flag);
        }

        private void chooseAllFormsBut_Click(object sender, EventArgs e)
        {
            checkSwitch1(flagSwitch(1));
        }

        private void chooseAllOpBut_Click(object sender, EventArgs e)
        {
            checkSwitch2(flagSwitch(2));
        }

        private void pfList()
        {
            for (int i = 0; i < pathList2.Count; i++)
            {
                if (checkedListBox2.CheckedItems.Contains(Convert.ToString(pathList2[i]).Substring(pathList2[i].LastIndexOf('\\') + 1)))
                {
                    DirectoryInfo dir = new DirectoryInfo(pathList2[i]);

                    foreach (FileInfo file in dir.GetFiles("*(ПФ)*.xls*"))
                    {
                        //добавить в наш лист
                        lst.Add(file.FullName);
                    }
                }
            }
        }

        private void startBut_Click(object sender, EventArgs e)
        {
            if (checkedListBox2.CheckedItems.Count == 0)
                MessageBox.Show("Не выбраны OP!", "Внимание!");
            else
            {
                Stopwatch stopwatch = new Stopwatch();
                stopwatch.Start();
                lst.Clear();
                progressBar1.Value = 0;
                pfList();
                progressBar1.Maximum = lst.Count;

                var excel = new Microsoft.Office.Interop.Excel.Application();
                for (int i = 0; i < lst.Count; i++) //Идём по всем ПФ-ам
                {
                    progressBar1.Value++;
                    var PF = excel.Workbooks.Open(lst[i], false);
                    for (int j = 1; j <= PF.Worksheets.Count; j++) //Идём по всем листам
                    {
                        Excel.Worksheet sheet = (Excel.Worksheet)excel.Worksheets.get_Item(j);
                        if (hideRadioButton.Checked)
                        {
                            hideMethod(sheet);
                        }
                        else
                        {
                            showMethod(sheet);
                        }

                    }
                    excel.DisplayAlerts = false;
                    PF.SaveAs(lst[i],
                        Type.Missing, Type.Missing, Type.Missing,
                        Type.Missing, Type.Missing, Excel.XlSaveAsAccessMode.xlNoChange,
                        Type.Missing, Type.Missing, Type.Missing,
                        Type.Missing, Type.Missing);
                    PF.Close();

                }
                //excel.Quit();

                stopwatch.Stop();
                MessageBox.Show("Готово. Время - " + stopwatch.ElapsedMilliseconds / 1000);

            }
        }

        private static void showMethod(Excel.Worksheet sheet)
        {
            //раскрываем теги
            if (sheet.Cells[1, 1].Value == "%Таблица:")
            {
                //раскрываем тек. год
                for (int k = 1; k <= 100; k++)
                {
                    if (sheet.Cells[1, k].Value == "%Year_1")
                    {
                        sheet.Columns[k].ColumnWidth = sheet.Columns[k + 1].ColumnWidth;
                    }
                    if (sheet.Cells[1, k].Value == "%конец_")
                    {
                        break;
                    }

                }
            }
            if (sheet.Cells[1, 1].Value == "%Раздел:")
            {
                sheet.Visible = Excel.XlSheetVisibility.xlSheetVisible;
            }
        }

        private static void hideMethod(Excel.Worksheet sheet)
        {
            //смотрим теги
            if (sheet.Cells[1, 1].Value == "%Таблица:")
            {

                //скрываем тек. год
                for (int k = 1; k <= 100; k++)
                {
                    //MessageBox.Show("Нашли таблицу");
                    if (sheet.Cells[1, k].Value == "%Year_1")
                    {
                        //MessageBox.Show("cузили)");
                        sheet.Columns[k].ColumnWidth = 0;
                    }
                    if (sheet.Cells[1, k].Value == "%конец_")
                    {
                        break;
                    }

                }

            }
            if (sheet.Cells[1, 1].Value == "%Раздел:")
            {
                if (sheet.Cells[1, 2].Value == "%Year_1")  //Нашли тек. год

                {
                    //MessageBox.Show("скрыть табл=)");
                    sheet.Visible = 0;
                }

            }
        }
    }
}
