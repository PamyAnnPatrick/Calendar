using System.Collections.Generic;

namespace Calendar_729
{
    public class MyCalendar
    {
        SortedList<int, int> CalenderData = new SortedList<int, int>();
        public MyCalendar()
        {

        }

        public bool Book(int start, int end)
        {
            try
            {
                CalenderData.Add(start, end);
            }
            catch
            {
                //Same start already exist, as sorted list doesn't allow duplicate.
                return false;
            }

            int count = CalenderData.Count;
            if (count == 1)
                return true;

            int currentIndex = CalenderData.IndexOfKey(start);

            //checking if start time is lesser than next element's end time in sorted list  
            //or end is greater that next element's start time in sorted list
            if ((currentIndex > 0 && start < CalenderData.Values[currentIndex - 1]) ||
                (currentIndex < (count - 1) && end > CalenderData.Keys[currentIndex + 1]))
            {
                CalenderData.Remove(start);
                return false;
            }



            return true;
        }
    }
}
