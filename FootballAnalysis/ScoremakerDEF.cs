using System;

public class ScoremakerDEF
{
    public int Clearances(int clearances)
    {
        if (clearances <= 80 && clearances > 60)
        {
            clearances = 1;
        }
        if (clearances <= 100 && clearances > 80)
        {
            clearances = 2;
        }
        if (clearances <= 120 && clearances > 100)
        {
            clearances = 3;
        }
        return clearances;
    }

    public int Interceptions(int interceptions)
    {
        if (interceptions <= 20 && interceptions > 0)
        {
            interceptions = 1;
        }
        if (interceptions <= 40 && interceptions > 20)
        {
            interceptions = 2;
        }
        if (interceptions <= 60 && interceptions > 40)
        {
            interceptions = 3;
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

    public int aveScoreDEF(int clearances, int interceptions, int apps)
    {
        int score = Clearances(clearances) + Interceptions(interceptions) + Appearances(apps);
        return score;
    }
}