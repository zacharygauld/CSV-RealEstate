using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSV_RealEstate
{
    class Program
    {
        static void Main(string[] args)
        {
            List<RealEstateData> realEstateDataList = new List<RealEstateData>();
            //read in the realestatedata.csv file.  As you process each row, you'll add a new 
            // RealEstateData object to the list for each row of the document, excluding the first.


            //Display the average square footage of a Condo sold in the city of Sacramento, 
            // round to 2 decimal points

            //Display the total sales of all residential homes in Elk Grove, display in dollars

            //Display the total number of residential homes sold in the following  
            // zip codes: 95842, 95825, 95815

            //Display the average sale price of a lot in Sacramento, display in dollars

            //Display the average price per square foot for a condo in Sacramento, display in dollars

            //Display the number of all sales that were completed on a Wednesday

            //Display the average number of bedrooms for a residential home in Sacramento when the 
            // price is greater than 300000, round to 2 decimal points
            
            //Extra Credit:
            //Display top 5 cities and the number of homes sold (using the GroupBy extension)

        }
    }

    public enum RealEstateType
    {
        //fill in with enum types: Residential, MultiFamily, Condo, Lot
    }

    public class RealEstateData
    {
        //Create properties, using the correct data types (not all are strings) for all columns of the CSV

        //The constructor will take a single string arguement.  This string will be one line of the real estate data.
        // Inside the constructor, you will seperate the values into their corrosponding properties, and do the necessary conversions

        //When computing the RealEstateType, if the square footage is 0, then it is of the Lot type, otherwise, use the string
        // value of the "Type" column to determine its corresponding enumeration type.
    }
}
