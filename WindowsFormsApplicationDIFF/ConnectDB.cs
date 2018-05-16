using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;



namespace StudentTrackerNS
{
    public class ConnectDb
    {
        SqlConnection con;
        DataTable dt;
        SqlDataAdapter sda;
        SqlCommandBuilder scb;

        //establish the connection to the database
        private void ConnectToDB()
        {
            con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\PHILO\Documents\Visual Studio 2015\Projects\StudentTracking\WindowsFormsApplicationDIFF3\WindowsFormsApplicationDIFF\StudentData.mdf;Integrated Security=True;Connect Timeout=30");
            con.Close();
        }

        //displays retrieved items required from the database (class A and B)
        public void queryDatabase(int caseNumber, StudentDataForm sdf)
        {
            try
            {
                if (sdf.cmbClass.Text == "Class A")
                {
                    ConnectToDB();
                    con.Open();
                    //call method to set the query data.
                    classAType(caseNumber);
                    dt = new DataTable();
                    sda.Fill(dt);
                    sdf.dgvStudentProgress.DataSource = dt;
                    con.Close();
                }
                else if (sdf.cmbClass.Text == "Class B")
                {
                    ConnectToDB();
                    con.Open();
                    //call method to set the query data.
                    classBType(caseNumber);
                    dt = new DataTable();
                    sda.Fill(dt);
                    sdf.dgvStudentProgress.DataSource = dt;
                    con.Close();
                }
            }
            catch (Exception e)
            {
                errorTracking et = new errorTracking();
                et.outputErrorToText(e.Message);
            }    
        }

        //sets the SQLDataAdapter to query the database on specific conditions.
        private void classAType(int caseNumber)
        {
            try
            {
            if (caseNumber == 1)
            {
                sda = new SqlDataAdapter("SELECT * From [tblStudentA]", con); 
            }
            else if (caseNumber == 2)
            {
                sda = new SqlDataAdapter("SELECT * From [tblStudentA] Where [Gender] = 'Male'", con);
            }
            else if (caseNumber == 3)
            {
                sda = new SqlDataAdapter("SELECT * From [tblStudentA] Where [Gender] = 'Female'", con);
            }
            else if (caseNumber == 4)
            {
                sda = new SqlDataAdapter("SELECT * From [tblStudentA] Where [EAL?] = 'Y'", con);
            }
            else if (caseNumber ==5)
            {
                sda = new SqlDataAdapter("SELECT * From [tblStudentA] Where [Disadvantaged?] = 'Y'", con);
            }
            else
                {
                    errorTracking et = new errorTracking();
                    et.outputErrorToText("Error with  SQL query");
                }
        }
            catch (Exception e)
            {
                errorTracking et = new errorTracking();
                et.outputErrorToText(e.Message);
            }

           
        }
        private void classBType(int caseNumber)
        {
            try
            {
                if (caseNumber == 1)
                {
                    sda = new SqlDataAdapter("SELECT * From [tblStudentB]", con);
                }
                else if (caseNumber == 2)
                {
                    sda = new SqlDataAdapter("SELECT * From [tblStudentB] Where [Gender] = 'Male'", con);
                }
                else if (caseNumber == 3)
                {
                    sda = new SqlDataAdapter("SELECT * From [tblStudentB] Where [Gender] = 'Female'", con);
                }
                else if (caseNumber == 4)
                {
                    sda = new SqlDataAdapter("SELECT * From [tblStudentB] Where [EAL?] = 'Y'", con);
                }
                else
                {
                    sda = new SqlDataAdapter("SELECT * From [tblStudentB] Where [Disadvantaged?] = 'Y'", con);
                }
            }
            catch (Exception e)
            {
                errorTracking et = new errorTracking();
                et.outputErrorToText(e.Message);
            }
        }

        //Populating the total and average columns
        public void calculateTotalAndAverage(StudentDataForm sdf)
        {
            int totalMock1 = 0;
            int totalMock2 = 0;
            double valueAdded = 0;

            for (int i = 0; i < sdf.dgvStudentProgress.Rows.Count - 1; i++)
            {
                totalMock1 += int.Parse(dt.Rows[i][7].ToString());
                totalMock2 += int.Parse(dt.Rows[i][9].ToString());

                valueAdded += double.Parse(dt.Rows[i][11].ToString());
            }
            sdf.txtTotalM1.Text = totalMock1.ToString();
            sdf.txtTotalM2.Text = totalMock2.ToString();

            //averages from data input
            double average = (totalMock1 / (sdf.dgvStudentProgress.Rows.Count - 1));
            double average2 = (totalMock2 / (sdf.dgvStudentProgress.Rows.Count - 1));
            sdf.txtAverageM1.Text = average.ToString();
            sdf.txtAverageM2.Text = average2.ToString();

            double avgVA = (valueAdded / (sdf.dgvStudentProgress.Rows.Count - 1));
            sdf.txtAverageVA.Text = avgVA.ToString();

            //Passing the average of the whole class through the algorithm
            DataAnalysis da = new DataAnalysis();
            double averageGrade = da.progress8Mock1(Convert.ToInt32(average));
            double averageGrade2 = da.progress8Mock2(Convert.ToInt32(average2));
            sdf.txtAvgGM1.Text = averageGrade.ToString();
            sdf.txtAvgGM2.Text = averageGrade2.ToString();

           

        }

        //works out the grades by passing the progress 8 scores through DataAnalysis class (grade boundaries)
        public void gradeWorkout(StudentDataForm sdf)
        {
            //Adding the grade to the mock result from DatAnalysis
            DataAnalysis mock = new DataAnalysis();
            #region  progress 8 conversions -------------
            //new progress 8 measures conversions.
            for (int i = 0; i <= dt.Rows.Count - 1; i++)
            {
                //takes the value from the table and passes through mock 1 (2015 exam boundaries).
                double prog8 = mock.progress8Mock1(Convert.ToInt32(dt.Rows[i][7]));
                //takes the value from the table and passes through mock 2 (2016 exam boundaries).
                double prog82 = mock.progress8Mock2(Convert.ToInt32(dt.Rows[i][9]));
                //this adds the result into the datagrid.
                //I need to stop this from rounding
                sdf.dgvStudentProgress.Rows[i].Cells[8].Value = prog8;
                sdf.dgvStudentProgress.Rows[i].Cells[10].Value = prog82;

                //Distance travelled displayed and worked out.
                double totalDist = mock.distanceTravelled(prog8, prog82);
                sdf.dgvStudentProgress.Rows[i].Cells[11].Value = (totalDist - (Convert.ToInt32(dt.Rows[i][6])));
            }
            #endregion
        }

        //updates the database with any changes (selected cells can be modified)
        public void update(StudentDataForm sdf)
        {
            try
            {
                con.Open();
                scb = new SqlCommandBuilder(sda);
                sda.Update(dt);
                con.Close();

            }
            catch (Exception e)
            {

                errorTracking et = new errorTracking();
                et.outputErrorToText(e.Message);
            }
        }

        //clear the Form, DataTable and closes the connection.
        public void clearDT(StudentDataForm sdf)
        {
            try
            {
                con.Open();
                dt.Clear();
                con.Close();
            }
            catch (Exception e)
            {
                errorTracking et = new errorTracking();
                et.outputErrorToText(e.Message);
            }
        }
    }
}

