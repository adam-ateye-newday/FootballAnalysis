using System;

public class ScoremakerGK
{
    public int Saves(int saves)
    {
        if (saves <= 150 && saves > 100)
        {
            saves = 2;
        }
        if (saves <= 100 && saves > 50)
        {
            saves = 1;
        }
        return saves;
    }
    public int Cleansheets(int cleansheets)
    {
        if (cleansheets <= 30 && cleansheets > 15)
        {
            cleansheets = 2;
        }
        if (cleansheets <= 15 && cleansheets > 1)
        {
            cleansheets = 1;
        }
        return cleansheets;
    }
    public int Conceded(int conceded)
    {
        if (conceded <= 25 && conceded > 20)
        {
            conceded = 2;
        }
        if (conceded <= 100 && conceded > 20)
        {
            conceded = 1;
        }
        return conceded;
    }
    public int Sweeps(int sweeps)
    {
        if (sweeps <= 30 && sweeps > 10)
        {
            sweeps = 2;
        }
        if (sweeps <= 10 && sweeps > 0)
        {
            sweeps = 1;
        }
        return sweeps;
    }
    public int Appearances(int apps)
    {
        if (apps <= 20 && apps > 0)
        {
            apps = 1;
        }
        if (apps <= 40 && apps > 20)
        {
            apps = 2;
        }
        return apps;
    }
    public int aveScoreGK(int saves, int cleansheets, int conceded, int sweeps, int apps)
    {
        int score = Saves(saves) + Cleansheets(cleansheets) + Conceded(conceded) + Sweeps(sweeps) + Appearances(apps);
        return score;
    }

}
