namespace FootballAnalysis
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(23, 13, 35, 8)]                 //Salah
        [InlineData(15, 8, 30, 7)]                  //De Bruyne
        [InlineData(23, 7, 35, 7)]                  //Son
        [InlineData(28, 17, 35, 8)]                 //Mbappe
        [InlineData(6, 14, 26, 7)]                  //Messi
        public void ScoremakerATTTest(int goals, int assists, int apps, int ave)
        {
            var score = new ScoremakerATT();
            var actualScore = score.aveScore(goals, assists, apps);
            actualScore.Should().Be(ave);

        }
        [Theory]
        [InlineData(107, 31, 34, 7)]                  //Van Dijk
        [InlineData(95, 44, 32, 7)]                   //Thiago Silva
        [InlineData(87, 28, 34, 6)]                   //Rudiger
        [InlineData(65, 23, 29, 6)]                   //Dias
        [InlineData(90, 44, 31, 6)]                   //Matip
        public void ScoremakerDEFTest(int clearances, int interceptions, int apps, int ave)
        {
            var score = new ScoremakerDEF();
            var actualScore = score.aveScore(clearances, interceptions, apps);
            actualScore.Should().Be(ave);
        }
    }
    public class ScoremakerDEF
    {
        public int Clearances(int clearances)
        {
            if (clearances <= 120 && clearances > 100)
            {
                clearances = 3;
            }
            if (clearances <= 100 && clearances > 80)
            {
                clearances = 2;
            }
            if (clearances <= 80 && clearances > 60)
            {
                clearances = 1;
            }
            return clearances;
        }
        public int Interceptions(int interceptions)
        {
            if (interceptions <= 60 && interceptions > 40)
            {
                interceptions = 3;
            }
            if (interceptions <= 40 && interceptions > 20)
            {
                interceptions = 2;
            }
            if (interceptions <= 20 && interceptions > 0)
            {
                interceptions = 1;
            }
            return interceptions;
        }
        public int Appearances(int apps)
        {
            if (apps <= 15 && apps > 0)
            {
                apps = 4;
            }
            if (apps <= 30 && apps > 15)
            {
                apps = 3;
            }
            if (apps <= 45 && apps > 30)
            {
                apps = 2;
            }
            return apps;
        }
        public int aveScore(int clearances, int interceptions, int apps)
        {
            int score = Clearances(clearances) + Interceptions(interceptions) + Appearances(apps);
            return score;
        }
    }



}