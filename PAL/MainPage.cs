using System;
using System.Windows.Forms;

namespace IT481_Unit_2_Assignment.PAL
{
    public partial class MainPage : Form
    {
        //Intialize BAL Class
        BAL.BusinessLayer busAccess = new BAL.BusinessLayer();

        public MainPage()
        {
            InitializeComponent();
        }

        //Event Methods
        private void MainPage_Load(object sender, EventArgs e)
        {
            connectionTextBox.Text = busAccess.Load_Customer_Data();
        }
        private void MainPage_FormClosing(object sender, FormClosingEventArgs e)
        {
            connectionTextBox.Text += Environment.NewLine + "Saving Data to Database...";
            MessageBox.Show(busAccess.Save_Customer_Data());
        }
        private void viewDataButton_Click(object sender, EventArgs e)
        {
            dbViewer.DataSource = busAccess.Populate_DataGrid();
            connectionTextBox.Text += Environment.NewLine + "Data Grid View Populated...";
        }
        private void countRecordButton_Click(object sender, EventArgs e)
        {
            countRecordTextBox.Text = busAccess.Count_Customer_Records().ToString();
            connectionTextBox.Text += Environment.NewLine + "Records Counted...";
        }
        private void addRecordButton_Click(object sender, EventArgs e)
        {
            if (idTextBox.Text != "" && companyTextBox.Text != "")
            {
                busAccess.Add_Customer_Record(idTextBox.Text, companyTextBox.Text);
                connectionTextBox.Text += Environment.NewLine + "Record Added...";
                idTextBox.Text = "";
                companyTextBox.Text = "";
            }
            else connectionTextBox.Text += Environment.NewLine + "Invalid Record Inputs...";
        }
    }
}
