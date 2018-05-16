using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace StudentTrackerNS
{
    public partial class StudentDataForm : Form
    {
        ConnectDb cdb = new ConnectDb();

        public StudentDataForm()
        {
            InitializeComponent();
        }

        //loads preset data for drop down Class, (Class A or B)
        private void StudentDataForm_Load(object sender, EventArgs e)
        {
            cmbClass.Items.Add("Class A");
            cmbClass.Items.Add("Class B");

        }

        //Retrives and displays all of the information on the class selected
        private void btnPopulateFullClass_Click(object sender, EventArgs e)
        {
            int num = 1;
            cdb.queryDatabase(num,this);
            autoSizeColumns();
            //call things to do the maths.
            cdb.gradeWorkout(this);
            cdb.calculateTotalAndAverage(this);
            NationalData nd = new NationalData();
            nd.generateNationalData(this);
            //formatting 
            readAndSetData();
            conditionalFormatDataTable();
        }

        //calls methods(from ConnectDB class) to populate Male only data
        private void btnMale_Click(object sender, EventArgs e)
        {
            int num = 2;
            cdb.queryDatabase(num, this);
            cdb.gradeWorkout(this);
            cdb.calculateTotalAndAverage(this);
            NationalData nd = new NationalData();
            nd.generateNationalData(this);
            //formatting             
            autoSizeColumns();
            readAndSetData();
            conditionalFormatDataTable();
        }

        //calls methods(from ConnectDB class) to populate Female only data
        private void btnFemale_Click(object sender, EventArgs e)
        {
            int num = 3;
            cdb.queryDatabase(num, this);
            cdb.gradeWorkout(this);
            cdb.calculateTotalAndAverage(this);
            NationalData nd = new NationalData();
            nd.generateNationalData(this);
            //formatting             
            autoSizeColumns();
            readAndSetData();
            conditionalFormatDataTable();
        }

        //calls methods(from ConnectDB class) to populate EAL only data
        private void btnEAL_Click(object sender, EventArgs e)
        {
            int num = 4;
            cdb.queryDatabase(num, this);
            cdb.gradeWorkout(this);
            cdb.calculateTotalAndAverage(this);
            NationalData nd = new NationalData();
            nd.generateNationalData(this);
            //formatting 
            autoSizeColumns();
            readAndSetData();
            conditionalFormatDataTable();
        }

        //calls methods(from ConnectDB class) to populate Disadvantaged only data
        private void btnDisadvantaged_Click(object sender, EventArgs e)
        {
            int num = 5;
            cdb.queryDatabase(num, this);
            cdb.gradeWorkout(this);
            cdb.calculateTotalAndAverage(this);
            NationalData nd = new NationalData();
            nd.generateNationalData(this);
            //formatting             
            autoSizeColumns();
            readAndSetData();
            conditionalFormatDataTable();
        }

        //resizes the columns to fit data size
        public void autoSizeColumns()
        {
            dgvStudentProgress.AutoResizeColumns();
            dgvStudentProgress.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        //data cannot be input into these cells, only calculated and retrieved.
        public void readAndSetData()
        {
            //Set the columns 'Mock 1 Grade' and 'Mock 1 P8' to read only.
            dgvStudentProgress.Columns["Mock 2 P8"].ReadOnly = true;
            dgvStudentProgress.Columns["Mock 1 P8"].ReadOnly = true;
            dgvStudentProgress.Columns["Distance Travelled"].ReadOnly = true;
            //Read only the text boxes
            txtTotalM2.ReadOnly = true;
            txtTotalM1.ReadOnly = true;
            txtAverageM2.ReadOnly = true;
            txtAverageM1.ReadOnly = true;
            txtAvgGM1.ReadOnly = true;
            txtAvgGM2.ReadOnly = true;
            txtAverageVA.ReadOnly = true;
            txtNatAvgMK1.ReadOnly = true;
            txtNatAvgMK2.ReadOnly = true;
            txtNatAverageGrade1.ReadOnly = true;
            txtNatAverageGrade2.ReadOnly = true;


        }

        //colours code each students performance for visual of progress.
        public void conditionalFormatDataTable()
        {
            foreach (DataGridViewRow row in dgvStudentProgress.Rows)
            {
                if (Convert.ToInt32(row.Cells[11].Value) < 0)
                {
                    row.Cells[11].Style.BackColor = Color.Red;
                }
                else if (Convert.ToInt32(row.Cells[11].Value) == 0)
                {
                    row.Cells[11].Style.BackColor = Color.White;
                }
                else
                {
                    row.Cells[11].Style.BackColor = Color.ForestGreen;
                }
                //colouring the Value Added text box
                if (Convert.ToDouble(txtAverageVA.Text) < 0)
                {
                    txtAverageVA.BackColor = Color.Red;
                }
                else if (Convert.ToDouble(txtAverageVA.Text) == 0)
                {
                    txtAverageVA.BackColor = Color.White;
                }
                else
                {
                    txtAverageVA.BackColor = Color.ForestGreen;
                }
            }
        }
        
        //calls the update method to save any data changes.
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            cdb.update(this);
        }

        //clears the form and collections.
        private void btnClear_Click(object sender, EventArgs e)
        {
            //clears the items on the screen.
            dgvStudentProgress.Refresh();
            cdb.clearDT(this);
            txtTotalM1.Text = "";
            txtTotalM2.Text = "";
            txtAverageM1.Text = "";
            txtAverageM2.Text = "";
            txtAverageVA.Text = "";
            txtAverageVA.BackColor = Color.White;
            txtAvgGM1.Text = "";
            txtAvgGM2.Text = "";
            txtNatAvgMK1.Text = "";
            txtNatAvgMK2.Text = "";
            txtNatAverageGrade1.Text = "";
            txtNatAverageGrade2.Text = "";

        }
    }
}

