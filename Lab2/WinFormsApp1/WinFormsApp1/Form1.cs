
using Microsoft.Office.Interop.Excel;
using Excel = Microsoft.Office.Interop.Excel;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        List<User> users = new List<User>();
        public Form1()
        {
            List<User> users = new List<User>();

            InitializeComponent();
            dateTimePicker1.Value = DateTime.Today;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged_1(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String fio = textBox1.ToString() + '\n';
            String adr = comboBox1.SelectedItem.ToString() + "\n";
            User user = new User(fio, adr);
            Text += user.print();

            if (radioButton1.Checked) Text += "Пол мужской \n";
            if (radioButton2.Checked) Text += "Пол женский \n";
            for (int i = 0; i < checkedListBox1.CheckedItems.Count; i++)
                Text += checkedListBox1.CheckedItems[i].ToString() + "\n";
            Text = Text.Replace("System.Windows.Forms.TextBox, Text:", "");
            Text = Text.Replace("Form1", "");
            richTextBox1.AppendText(Text);
            dateTimePicker1.Value = DateTime.Today;
            MessageBox.Show("Результаты сохранены");

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.ShowDialog();
            String filename = ofd.FileName;

            Microsoft.Office.Interop.Excel.Application excelObj = new Microsoft.Office.Interop.Excel.Application();
            excelObj.Visible = true;

            Excel.Workbook wb = excelObj.Workbooks.Open(filename, 0, false, 5, "", "", false, XlPlatform.xlWindows, "", true, false, 0, true, false, false);
            Worksheet ws = wb.Worksheets[1];
            ws.Cells[1, 1] = users[0].Fio;
            ws.Cells[1, 2] = users[0].Adress;

            wb.Save();
            wb.Close();
        }
    }
}