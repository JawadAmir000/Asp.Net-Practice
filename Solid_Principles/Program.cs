using System.Text;
using System.Threading.Tasks;

namespace Solid_Principles
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    public class SingleResponsibilityPrinciple
    {
        public bool AddEmployee (Employee em)
        {
            return true;
        }
    }

    public class reportGeneration
    {
        public void GenerateReport(Employee em)
        {
            //Report Generations
        }
    }
}