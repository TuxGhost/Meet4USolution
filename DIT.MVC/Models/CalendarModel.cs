namespace DIT.MVC.Models;

public class CalendarModel
{
    public class DayModel
    {
        public string Name { get; set; } = "";
        public  DateTime Datum {  get; set; }    
    }
    public DateTime Datum = DateTime.Now;
    public DateTime FirstDayDate = DateTime.Today.AddDays(-(int)DateTime.Today.DayOfWeek);

    public List<DayModel> WeekDays { get; set; } = new List<DayModel>
        { new DayModel() { Name = "Monday" , Datum = DateTime.Today.AddDays(-(int)DateTime.Today.DayOfWeek+1)},
            new DayModel() { Name= "Tuesday", Datum = DateTime.Today.AddDays(-(int)DateTime.Today.DayOfWeek +2) },
            new DayModel() { Name ="Wednessday" , Datum = DateTime.Today.AddDays(-(int)DateTime.Today.DayOfWeek +3)  },
            new DayModel() { Name = "Thursday" , Datum = DateTime.Today.AddDays(-(int)DateTime.Today.DayOfWeek +4) } ,
            new DayModel() { Name = "Friday" ,  Datum = DateTime.Today.AddDays(-(int)DateTime.Today.DayOfWeek +5) } ,
            new DayModel() { Name = "Saturday" , Datum = DateTime.Today.AddDays(-(int)DateTime.Today.DayOfWeek +6) } ,
            new DayModel() { Name = "Sunday" ,  Datum = DateTime.Today.AddDays(-(int)DateTime.Today.DayOfWeek +7) }
    };
}
