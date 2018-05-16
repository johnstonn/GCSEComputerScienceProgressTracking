using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace StudentTrackerNS
{
    public class NationalData
    {
        //generate national averages for the mock exams used:
        //national average source:  https://www.jcq.org.uk/examination-results/gcses
        public void generateNationalData(StudentDataForm sdf)
        {            
            //June 2015
           double nationalAverageMock1 = 65.1;
            //June 2016
           double nationalAverageMock2 = 60.8;

            sdf.txtNatAvgMK1.Text = nationalAverageMock1.ToString();
            sdf.txtNatAvgMK2.Text = nationalAverageMock2.ToString();

            DataAnalysis da = new DataAnalysis();
            double nationalAverageGrade1= da.progress8Mock1(Convert.ToInt32(nationalAverageMock1));
            sdf.txtNatAverageGrade1.Text = nationalAverageGrade1.ToString();
            double nationalAverageGrade2 = da.progress8Mock2(Convert.ToInt32(nationalAverageMock2));
            sdf.txtNatAverageGrade2.Text = nationalAverageGrade2.ToString();



        }
    }
}