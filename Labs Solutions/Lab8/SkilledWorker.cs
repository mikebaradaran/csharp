using System;
using System.Collections.Generic;
using System.Text;

public class SkilledWorker : Employee
{
    internal List<string> skills = null;

    public SkilledWorker(string name, string jobTitle) : base(name, jobTitle)
    {
        skills = new List<string>();
    }

    public void AddSkill(string skillName)
    {
        skills.Add(skillName);
    }

    public override string GetDetails()
    {
        StringBuilder res = new StringBuilder(base.GetDetails());
        foreach (string skill in skills)
        {
            res.Append(skill + ",");
        }
        return res.ToString() + "\n";
    }
}

