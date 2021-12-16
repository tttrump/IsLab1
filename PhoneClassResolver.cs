using System.Collections.Generic;
using System.Linq;

namespace lab_1
{
    class PhoneClassResolver
    {
        private int checkedNumber = 0;
        List<int> checkedCriterion;
        Dictionary<string, double> cellphones = new Dictionary<string, double>();
        public PhoneClassResolver(List<int> data)
        {
            checkedNumber = data.Count;
            checkedCriterion = data;
        }
        public List<string> valideClasses()
        {
            List<string> validClass = new List<string>();
            cellphones.Clear();
            cellphones.Add("Class_A", 0);
            cellphones.Add("Class_B", 0);
            cellphones.Add("Class_C", 0);
            cellphones.Add("Class_D", 0);
            cellphones.Add("Class_G", 0);
            cellphones.Add("Class_L", 0);
            cellphones.Add("Class_S", 0);

            if (checkedCriterion.IndexOf(1) > -1)
            {
                cellphones["Class_A"] += 1 / checkedNumber;
                cellphones["Class_B"] += 1 / checkedNumber;
                cellphones["Class_D"] += 1 / checkedNumber;
                cellphones["Class_G"] += 1 / checkedNumber;
                cellphones["Class_L"] += 1 / checkedNumber;
                cellphones["Class_S"] += 1 / checkedNumber;
            }

            if (checkedCriterion.IndexOf(2) > -1)
            {
                cellphones["Class_A"] += 1 / checkedNumber;
                cellphones["Class_D"] += 1 / checkedNumber;
            }

            if (checkedCriterion.IndexOf(3) > -1)
            {
                cellphones["Class_C"] += 1 / checkedNumber;
                cellphones["Class_G"] += 1 / checkedNumber;
                cellphones["Class_L"] += 1 / checkedNumber;
                cellphones["Class_S"] += 1 / checkedNumber;
            }

            if (checkedCriterion.IndexOf(4) > -1)
            {
                cellphones["Class_C"] += 1 / checkedNumber;
                cellphones["Class_L"] += 1 / checkedNumber;
                cellphones["Class_S"] += 1 / checkedNumber;
            }

            if (checkedCriterion.IndexOf(5) > -1)
            {
                cellphones["Class_C"] += 1 / checkedNumber;
                cellphones["Class_G"] += 1 / checkedNumber;
                cellphones["Class_L"] += 1 / checkedNumber;
                cellphones["Class_S"] += 1 / checkedNumber;
            }

            if (checkedCriterion.IndexOf(6) > -1)
            {
                cellphones["Class_B"] += 1 / checkedNumber;
                cellphones["Class_C"] += 1 / checkedNumber;
                cellphones["Class_G"] += 1 / checkedNumber;
                cellphones["Class_L"] += 1 / checkedNumber;
                cellphones["Class_S"] += 1 / checkedNumber;
            }

            if (checkedCriterion.IndexOf(7) > -1)
            {
                cellphones["Class_B"] += 1 / checkedNumber;
                cellphones["Class_C"] += 1 / checkedNumber;
                cellphones["Class_D"] += 1 / checkedNumber;
                cellphones["Class_G"] += 1 / checkedNumber;
                cellphones["Class_L"] += 1 / checkedNumber;
                cellphones["Class_S"] += 1 / checkedNumber;
            }

            if (checkedCriterion.IndexOf(8) > -1)
            {
                cellphones["Class_C"] += 1 / checkedNumber;
                cellphones["Class_L"] += 1 / checkedNumber;
                cellphones["Class_S"] += 1 / checkedNumber;
            }

            if (checkedCriterion.IndexOf(9) > -1)
            {
                cellphones["Class_C"] += 1 / checkedNumber;
                cellphones["Class_G"] += 1 / checkedNumber;
                cellphones["Class_L"] += 1 / checkedNumber;
                cellphones["Class_S"] += 1 / checkedNumber;
            }

            if (checkedCriterion.IndexOf(10) > -1)
            {
                cellphones["Class_A"] += 1 / checkedNumber;
                cellphones["Class_B"] += 1 / checkedNumber;
                cellphones["Class_C"] += 1 / checkedNumber;
                cellphones["Class_D"] += 1 / checkedNumber;
                cellphones["Class_S"] += 1 / checkedNumber;
            }

            double max = cellphones.Values.Max();
            foreach (var x in cellphones)
                if (x.Value == max) validClass.Add(x.Key);
            return validClass;
        }
    }
}
