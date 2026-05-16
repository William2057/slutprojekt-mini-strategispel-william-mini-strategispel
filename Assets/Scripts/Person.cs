using System;
using System.Collections.Generic;
using UnityEngine;
public abstract class Person
{
    public string Name;
    public int Age;
    public string Work;
    public List<string> CriminalRecord;
    public string Location;
    public string ID;
    public int BaselineRisk;
    public Person(string name, int age, string work, string location, string id)
    {
        Name = name;
        Age = age;
        Work = work;
        Location = location;
        ID = id;
        CriminalRecord = new List<string>();
        BaselineRisk = UnityEngine.Random.Range(0, 100);
    }
    public abstract Message GenerateMessage();
    public virtual int GetRiskLevel()
    {
        int criminalBonus = CriminalRecord.Count * 10;
        return BaselineRisk + criminalBonus;
    }
    public virtual bool IsIllegal()
    {
        return GetRiskLevel() > 70;
    }
}
