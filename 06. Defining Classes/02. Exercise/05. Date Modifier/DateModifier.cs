
namespace DateModifier;

public class DateModifier
{
    private int differenceInDays;
    private DateTime firstDate;
    private DateTime secondDate;

    public DateModifier(string firstDate, string secondDate)
    {
        this.firstDate = DateTime.Parse(firstDate);
        this.secondDate = DateTime.Parse(secondDate);

    }
    public int DifferenceInDays
    {
        get
        {
            return this.differenceInDays = Math.Abs((int)(firstDate - secondDate).TotalDays);
        }
        //set
        //{
        //    differenceInDays = value;
        //}
    }
}
