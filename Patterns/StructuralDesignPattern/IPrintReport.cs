namespace Patterns.StructuralDesignPattern
{
    public interface IPrintReport
    {
        void Print(string context);
    }

    public class PdfReport : IPrintReport
    {
        public void Print(string context)
        {
            Console.WriteLine($"Pdf+ {context}");
        }
    }

    public class WordReport : IPrintReport
    {
        public void Print(string context)
        {
            Console.WriteLine($"Word+ {context}");
        }
    }

    public abstract class Report
    {
        protected IPrintReport _printReport;
        public Report(IPrintReport printReport)
        {
            _printReport = printReport;
        }

        public abstract void CreateReprt()
        {
            _printReport.Print();
        }
    }

    public class Employee : Report
    {
        public Employee(IPrintReport printReport) : base(printReport)
        {
        }

        public override void CreateReprt();
    }

    public class Manager : Report
    {
        public Manager(IPrintReport printReport) : base(printReport)
        {
        }

        public override void CreateReprt()
        {
            _printReport.Print("Manager Report");
        }
    }

   

}