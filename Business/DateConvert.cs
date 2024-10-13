namespace TaskMvc.Business
{
    public class DateConvert
    {
        public DateTime? ConvertToDate(string dateString, string format = "yyyyMMdd")
        {
            DateTime parsedDate;
            if (DateTime.TryParseExact(dateString, format, null, System.Globalization.DateTimeStyles.None, out parsedDate))
            {
                return parsedDate.Date;
            }
            return null; 
        }
    }
}
