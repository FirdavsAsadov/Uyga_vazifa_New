DateTime[] sleepDates = new DateTime[]
{
    new DateTime(2023,7,14),
    new DateTime(2023, 7,15),
    new DateTime(2023,7,16),
    new DateTime(2023,7,17),
    new DateTime(2023,7,18),
};
TimeSpan[] During = new TimeSpan[]
{
    new TimeSpan(7, 0, 0),
    new TimeSpan(8, 0, 0),
    new TimeSpan (6, 0, 0),
    new TimeSpan (5, 0, 0),
    new TimeSpan (9, 0, 0),
};
int[] awakengindex = new int[] { 0, 1, 0, 0, 0 };
int yetmayqolganuyqukunlari = 0;
double[] sleepQualityScores = new double[sleepDates.Length];
for (int i = 0; i < sleepDates.Length; i++)
{
    TimeSpan duration = During[i];
    double awakeningindex1 = awakengindex[i];

    double sleepQualityScore = (duration.TotalHours - awakeningindex1) / (8 + yetmayqolganuyqukunlari) * 10;
    sleepQualityScores[i] = sleepQualityScore;
}
for(int i = 0; i < sleepDates.Length - 1; i++)
{
    for(int j = i+1; j < sleepDates.Length; j++)
    {
        if (sleepDates[i] < sleepDates[j])
        {
            DateTime temp = sleepDates[i];
            sleepDates[i] = sleepDates[j];
            sleepDates[j] = temp;

            TimeSpan tempduration = During[i];
            During[i] = During[j];
            During[j] = tempduration;

            var tempScore = sleepQualityScores[i];
            sleepQualityScores[i] = sleepQualityScores[j];
            sleepQualityScores[j] = tempScore;
        }
    }
}
for(int i = 0; i < sleepDates.Length; i++)
{
    Console.WriteLine($"{sleepDates[i].ToString("dd.MM.yyyy")} - {During[i].TotalHours} hours - {sleepQualityScores[i]:F2} score");
}
