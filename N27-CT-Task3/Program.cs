using N27_CT_Task3;

List<Meeting> GetMeetingList = new List<Meeting>();
Meeting GetMeeting = new Meeting("Jadidchilar kuni",TimeSpan.FromHours(3));
Meeting GetMeeting2 = new Meeting("Bandidlar qaytishi", TimeSpan.FromHours(4));
Meeting GetMeeting3 = new Meeting("Jangchilar kuni", TimeSpan.FromHours(5));
Meeting GetMeeting4 = new Meeting("Qaroqchilar kuni", TimeSpan.FromHours(1.5));
GetMeetingList.Add(GetMeeting);
GetMeetingList.Add(GetMeeting2);
GetMeetingList.Add(GetMeeting3);
GetMeetingList.Add(GetMeeting4);
var totalduration = new TimeSpan();
foreach (var item in GetMeetingList)
{
    totalduration += item;
}
Console.WriteLine(totalduration);