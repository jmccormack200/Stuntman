﻿public static class Constants 
{
    public const string DBlocation = "/gameDB.db";

    public enum health
    {
        MAX_HEALTH = 150,
        MIN_HEALTH = 0
    };
    public enum skillDefaults
    {
        SKILL = 0,
        REP = 0,
        MONEY = 0
    };
    public enum scenes
    {
        MainMenu,
        CharacterSelection,
        GameScreen,
        StoreDesigner,
        Stuntman,
        NewGame

    };
    public enum crewJob
    {
        Mechanic,
        Driver,
        RampBuilder,
        Videographer,
        PR
    };
    public enum jobDefaults
    {
        cashReward = 0,
        cashRequirement = 0,
        repReward = 0,
        repRequirement = 0
    };
    public enum characters
    {
        Zj,
        Jesse,
        John,
        Rod
    }

}
