using System;
public class ScoremakerATT
{
    public int Goals(int goals)
    {
        if (goals <= 10 && goals > 0)
        {
            goals = 1;
        }
        if (goals <= 20 && goals > 10)
        {
            goals = 2;
        }
        if (goals <= 30 && goals > 20)
        {
            goals = 3;
        }
        return goals;
    }

    public int Assists(int assists)
    {
        if (assists <= 5 && assists > 0)
        {
            assists = 1;
        }
        if (assists <= 10 && assists > 5)
        {
            assists = 2;
        }
        if (assists <= 20 && assists > 10)
        {
            assists = 3;
        } 
        return assists;
    }

    public int Appearances(int apps)
    {
        if (apps <= 20 && apps > 0)
        {
            apps = 4;
        }
        if (apps <= 30 && apps > 20)
        {
            apps = 3;
        }
        if (apps <= 40 && apps > 30)
        {
            apps = 2;
        }
        return apps;
    }


    public int aveScoreATT(int goals, int assists, int apps)
    {
        int score = Goals(goals) + Assists(assists) + Appearances(apps);
        return score;
    }

}
