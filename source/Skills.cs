using System;
using System.Collections.Generic;
using System.Linq;

namespace Cyberpunk2020Library
{
    public class SkillDoesNotExistException : ApplicationException
    {
        private SkillDoesNotExistException(string message)
        {
        }
    }

    [Serializable]
    public class Skills
    {
        //Dictionary of the skills, with a string key being the nameo f the skill, and int being the level in the skill
        private readonly Dictionary<string, int> skills = new Dictionary<string, int>();

        public int this[string s]
        {
            get
            {
                try
                {
                    return skills[s];
                }
                catch (Exception e)
                {
                    skills[s] = 0;
                    return skills[s];
                }
            }
            set => skills[i] = value;
        }

        public Skills()
        {
            foreach (var key in skills.Keys.ToList())
            {
                dict
            }
        }
    }
}