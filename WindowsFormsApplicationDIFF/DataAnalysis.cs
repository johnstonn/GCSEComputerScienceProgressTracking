using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentTrackerNS
{
    public class DataAnalysis
    {
        //return mock 1 grade values based on OCR 2015 June paper.
        public double progress8Mock1(int mock1Result)
        {
            if ((mock1Result >= 76) && (mock1Result <= 80))
            {
                return 8.50;
            }
            else if (((mock1Result >= 70) && (mock1Result <= 75)))
            {
                return 7.00;
            }
            else if (((mock1Result >= 65) && (mock1Result <= 69)))
            {
                return 5.50;
            }
            else if (((mock1Result >= 60) && (mock1Result <= 64)))
            {
                return 4.00;
            }
            else if (((mock1Result >= 55) && (mock1Result <= 59)))
            {
                return 3.00;
            }
            else if (((mock1Result >= 50) && (mock1Result <= 54)))
            {
                return 2.00;
            }
            else if (((mock1Result >= 45) && (mock1Result <= 49)))
            {
                return 1.50;
            }
            else if (((mock1Result >= 40) && (mock1Result <= 44)))
            {
                return 1.00;
            }
            else
            {
                return 0.00;
            }
        }
        
        //return mock 2 grade values based on OCR 2016 June paper.
        public double progress8Mock2(int mock2Result)
        {
            if ((mock2Result >= 76) && (mock2Result <= 80))
            {
                return 8.50;
            }
            else if (((mock2Result >= 70) && (mock2Result <= 75)))
            {
                return 7.00;
            }
            else if (((mock2Result >= 65) && (mock2Result <= 69)))
            {
                return 5.50;
            }
            else if (((mock2Result >= 60) && (mock2Result <= 64)))
            {
                return 4.00;
            }
            else if (((mock2Result >= 55) && (mock2Result <= 59)))
            {
                return 3.00;
            }
            else if (((mock2Result >= 50) && (mock2Result <= 54)))
            {
                return 2.00;
            }
            else if (((mock2Result >= 45) && (mock2Result <= 49)))
            {
                return 1.50;
            }
            else if (((mock2Result >= 40) && (mock2Result <= 44)))
            {
                return 1.00;
            }
            else
            {
                return 0.00;
            }
        }
                
        //works out the average of the distance travelled for both mocks completed, 0 indicates missed test.
        public double distanceTravelled(double mock1Result, double mock2Result)
        {
            if (mock1Result == 0.00)
            {
                return mock2Result;
            }
            else if (mock2Result == 0.00)
            {
                return mock1Result;
            }

            else
            {
                double total = ((mock1Result + mock2Result)/2);
                return total;
            }
        }
    }
}
