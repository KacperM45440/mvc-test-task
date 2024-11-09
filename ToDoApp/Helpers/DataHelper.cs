using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ToDoApp.Helpers
{
    public class DataHelper
    {
        public static List<ComboBoxItem> GetYears(DateTime startDate)
        {
            List<ComboBoxItem> yearList = new List<ComboBoxItem>();
            int startYear = startDate.Year - 5;
            int endYear = startDate.Year + 5;
            int id = 1;

            for (int i = startYear; i <= endYear; i++)
            {
                ComboBoxItem item = new ComboBoxItem()
                {
                    ID = id,
                    Name = i.ToString()
                };

                yearList.Add(item);
                id++;
            }

            return yearList;
        }
    }
}