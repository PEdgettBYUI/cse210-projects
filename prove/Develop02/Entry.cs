class Entry 
{
    private string e_date;
    private string e_prompt;
    private string e_response;

    public void setEDate()
    {
        DateTime currentDate = DateTime.Now;    // retrieves in format (y/m/d)
        string dateAsString = currentDate.ToString("MMMM dd, yyyy");
        e_date = dateAsString;
    }

    // public void showDate()
    // {
    //     Console.WriteLine(e_date);
    // }

}