using System.Globalization;

namespace Composition_Workers.Entities
{
    internal class HourContract
    {
        public DateTime Date { get; set; }
        public double ValuePerHour { get; set; }
        public int Hour { get; set; }

        public HourContract()
        {

        }

        public HourContract(DateTime date, double valuePerHour, int hour) : this()
        {
            Date = date;
            ValuePerHour = valuePerHour;
            Hour = hour;
        }

        public override string ToString()
        {
            string retorno = "";
            retorno += "Contract date: " + Date.ToString("dd/MM/yyyy") + Environment.NewLine;
            retorno += "Value per hour: $" + ValuePerHour.ToString("F2", CultureInfo.InvariantCulture) + Environment.NewLine;
            retorno += "Hours: " + Hour + Environment.NewLine;
            return retorno;
        }

        public double TotalValue()
        {
            return Hour * ValuePerHour;
        }
    }
}
