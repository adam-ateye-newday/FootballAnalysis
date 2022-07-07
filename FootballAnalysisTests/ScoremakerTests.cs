namespace FootballAnalysisTest
{
    public class ScoremakerTests
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
            var actualScore = score.aveScoreATT(goals, assists, apps);
            actualScore.Should().Be(ave);

        }

        [Theory]
        [InlineData(107, 31, 34, 7)]                  //Van Dijk
        [InlineData(95, 44, 32, 7)]                   //Thiago Silva
        [InlineData(87, 28, 34, 6)]                   //Rudiger
        [InlineData(65, 23, 29, 6)]                   //Dias
        [InlineData(90, 44, 31, 7)]                   //Matip
        public void ScoremakerDEFTest(int clearances, int interceptions, int apps, int ave)
        {
            var score = new ScoremakerDEF();
            var actualScore = score.aveScoreDEF(clearances, interceptions, apps);
            actualScore.Should().Be(ave);
        }

        [Theory]
        [InlineData(60, 20, 26, 19, 37, 6)]         //Ederson
        [InlineData(76, 20, 24, 30, 36, 7)]         //Alisson
        [InlineData(128, 8, 57, 7, 38, 7)]          //De Gea
        [InlineData(73, 14, 31, 19, 34, 6)]         //Mendy
        [InlineData(90, 12, 39, 21, 34, 6)]         //Ramsdale
        public void ScoremakerGKTest(int saves, int cleansheets, int conceded, int sweeps, int apps, int ave)
        {
            var score = new ScoremakerGK();
            var actualScore = score.aveScoreGK(saves, cleansheets, conceded, sweeps, apps);
            actualScore.Should().Be(ave);
        }
    }
}