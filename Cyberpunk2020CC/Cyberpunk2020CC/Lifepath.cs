using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cyberpunk2020CharacterCreator
{
    class LifeEvents
    {
       
        
        /// <summary>
        /// Generates Life events following the chart in the Cyberpunk 2020 book, currently not done
        /// </summary>
        /// <returns>A Dictionary<int,string> with the int value representing age and starting at 16</returns>
        public static Dictionary<int, string> GenerateLifeEvents (Character character)
        {
            
            Random rnd = new Random();
            Dictionary<int, string> events = new Dictionary<int, string>();
            for (int i = 16; i < character.age; i++)
            {
                int random = rnd.Next(1,10);
                //Big Problems, Big Wins
                if (random <= 3)
                {
                    random = rnd.Next(1, 10) % 2;
                    if (random == 0)
                    {
                        random = rnd.Next(1, 10);
                        switch(random)
                        {
                            case 1:
                                random = rnd.Next(1, 10);
                                if (1 <= random || random <= 4)
                                {
                                    events.Add(i, "You made a powerful connection in the Police Dept.");
                                }
                                if (5 <= random || random <= 7)
                                {
                                    events.Add(i, "You made a powerful connection in the Districts Attorney's Office.");
                                }
                                if (8 <= random || random <= 10)
                                {
                                    events.Add(i, "You made a powerful connection in the Mayor's Office.");
                                }
                                break;
                            case 2:
                                random = rnd.Next(1, 10);
                                events.Add(i, "You had a Financial Windfall and gained " + random*100 + " Eurodollars.");
                                character.Eurodollars += random * 100;
                                break;
                            case 3:
                                random = rnd.Next(1, 10);
                                events.Add(i, "You got a big score on a job or deal and gained " + random * 100 + " Eurodollars.");
                                character.Eurodollars += random * 100;
                                break;
                            case 4:
                                events.Add(i, "You find a sensei(Teacher). Begin at +2 or add +1 to a Martial Arts Skill of your choice.");
								SkillBoost("Martial Arts", 2, 1);
                                break;
                            case 5:
                                events.Add(i, "You find a teacher. Add +1 to any INT based skill, or begin a new INT based skill at +2.");
								SkillBoost("INT", 2, 1);
                                break;
                            case 6:
                                events.Add(i, "A powerful Corporate Exec owes you a favor.");
                                break;
                            case 7:
                                events.Add(i, "A local Nomad Pack befriends you. You can call upon them for one favor a month, equivilant to a Family Special Ability of +2.");
                                break;
                            case 8:
                                events.Add(i, "You made a friend in the police force, You may use him for inside information at a level of +2 streetwise on any police related situation.");
                                break;
                            case 9:
                                events.Add(i, "A local Booster Gang likes you (Who knows why. These are Boosters, right?). You can call upon them for one favor a month, equivilant to a Family Special Ability of +2. But don't push it.");
                                break;
                            case 10:
                                events.Add(i, "You found a combat teacher. Add +1 to any weapon skill with the exception of Martial Arts or Brawling, or begin a new combat skill at +2.");
								SkillBoost("Weapon*", 2, 1);
                                break;
                        }
                    }
                    else
                    {
                        random = rnd.Next(1, 10);
                        int temp = random;
                        switch (random)
                        {
                            case 1:
                                random = rnd.Next(1, 10);
                                events.Add(i, "Financial Loss or Debt. You have lost " + random * 100 + " Eurodollars, if you can't pay this now, you have a debt to pay, in cash--or blood.");
                                character.Eurodollars -= random * 100;
                                break;
                            case 2:
                                random = rnd.Next(1, 10);
                                events.Add(i, "Imprisonment. You were imprisoned or held hostage (your choice) for " + random + "months.");
                                break;
                            case 3:
                                events.Add(i, "Illness or addiction. You have contracted either and illness or a drug habit in this time. You have lost 1 REF as a result");
                                character.stats.stats["REF"] -= 1;
                                break;
                            case 4:
                                random = rnd.Next(1, 10);
                                if (random <= 3)
                                {
                                    events.Add(i, "Betrayel. You are being blackmailed in some manner.");
                                }
                                else if (random <= 7)
                                {
                                    events.Add(i, "Betrayel. One of your secrets has been exposed.");
                                }
                                else
                                {
                                    events.Add(i, "Betrayel.You were betrayed by a close friend in romance or career (your choice).");
                                }
                                break;
                            case 5:
                                random = rnd.Next(1, 10);
                                if (random <= 4)
                                {
                                    events.Add(i, "Accident. You were in a terrible accident, and were terribly disfigured, you have lost 5 ATT.");
                                    character.stats.stats["ATT"] -= 5;
                                }
                                else if (random <= 6)
                                {
                                    random = rnd.Next(1, 10);
                                    events.Add(i, "Accident. You were in a terrible accident, You were hospitalized for " + random + "months.");
                                }
                                else if (random <= 8)
                                {
                                    random = rnd.Next(1, 10);
                                    events.Add(i, "Accident. You were in a terrible accident, you have lost " + random + "months of memory that year.");
                                }
                                else
                                {
                                    events.Add(i, "Accident. You were in a terrible accident, you constantly relive nightmares(8 in 10 chance each night) of the accident and wake up screaming");
                                }
                                break;
                            case 6:
                                random = rnd.Next(1, 10);
                                if (random <= 5)
                                {
                                    events.Add(i, "You lost someone you really cared about. They died accidentally.");
                                }
                                else if (random <= 8)
                                {
                                    events.Add(i, "You lost someone you really cared about. They were murdered by unknown parties.");
                                }
                                else if (random <= 10)
                                {
                                    events.Add(i, "You lost someone you really cared about. They were murdered, and you know who did it. You just need the proof.");
                                }
                                break;
                            case 7:
                                random = rnd.Next(1, 10);
                                if (random <= 3)
                                {
                                    events.Add(i, "You were set up and accused of theft.");
                                }
                                else if (random <= 5)
                                {
                                    events.Add(i, "You were set up and accused of cowardise.");
                                }
                                else if (random <= 8)
                                {
                                    events.Add(i, "You were set up and accused of murder.");
                                }
                                else if (random <= 9)
                                {
                                    events.Add(i, "You were set up and accused of rape.");
                                }
                                else
                                {
                                    events.Add(i, "You were set up and accused of lying or betrayel.");
                                }
                                break;
                            case 8:
                                random = rnd.Next(1, 10);
                                if (random <= 3)
                                {
                                    events.Add(i, "You are hunted by the law for crimes you may or may not have committed (Your choice). Only a couple local cops want you. ");
                                }
                                else if (random <= 6)
                                {
                                    events.Add(i, "You are hunted by the law for crimes you may or may not have committed (Your choice). The entire local force wants you.");
                                }
                                else if (random <= 8)
                                {
                                    events.Add(i, "You are hunted by the law for crimes you may or may not have committed (Your choice). The state police or Militia want you.");
                                }
                                else if (random <= 10)
                                {
                                    events.Add(i, "You are hunted by the law for crimes you may or may not have committed (Your choice). The FBI or equivalent national police force wants you.");
                                }
                                break;
                            case 9:
                                if (random <= 3)
                                {
                                    events.Add(i, "You have angered some corporate honcho. It's a small, local firm.");
                                }
                                else if (random <= 6)
                                {
                                    events.Add(i, "You have angered some corporate honcho. It's a larger corp with offices statewide.");
                                }
                                else if (random <= 8)
                                {
                                    events.Add(i, "You have angered some corporate honcho. I's a big, national corp with agents in major cities nationwide.");
                                }
                                else if (random <= 10)
                                {
                                    events.Add(i, "You have angered some corporate honcho. It's a huge multinational corp with armies, ninjas and spies everywhere.");
                                }
                                break;
                            case 10:
                                random = rnd.Next(1, 10);
                                if (random <= 3)
                                {
                                    events.Add(i, "You have experienced some type of nervous disorder, probably from a bioplague. You have lost 1 pt. REF.");
                                    character.stats.stats["REF"] -= 1;
                                }
                                else if (random <= 7)
                                {
                                    events.Add(i, "You have experienced some type of mental problem; you suffer anxiety attacks and phobias. You've lost 1 pt. CL.");
                                    character.stats.stats["CL"] -= 1;
                                }
                                else if (random <= 10)
                                {
                                    events.Add(i, "You have experienced a major psychosis. You hear voices, are violent, irrational, depressive. You have lost 1 pt from your CL, and 1 from REF");
                                    character.stats.stats["CL"] -= 1;
                                    character.stats.stats["REF"] -= 1;
                                }
                                break;
                        }

                        //What are you gonna do about it
                        if (temp != 10 || temp != 3)
                        {
                            random = rnd.Next(1, 10);
                            if (random <= 3)
                            {
                                events[i] += "\nI am going to clear my name.";
                            }
                            else if (random <= 6)
                            {
                                events[i] += "\nI am going to try to live it down and forget it.";
                            }
                            else if (random <= 8)
                            {
                                events[i] += "\nI am going to hunt down those responsible and make them pay!";
                            }
                            else
                            {
                                events[i] += "\nI am going to clear my name.";
                            }

                        }

                    }
                }
                else if (random <= 6)
                {
                    
                    //You made a friend
                    if (random <= 5)
                    {
                        NPC friend = new NPC();
                        string[] friends =
                               {
                            "like a big brother.",
                            "like a kid brothaer to me.",
                            "as a teacher or mentor.",
                            "as a partner or co-worker.",
                            "as an old lover, who is now my friend.",
                            "as an old enemy, who is now my friend.",
                            "like a foster parent to me.",
                            "like a relative.",
                            "an old childhood friend.",
                            "a friend with common interest."
                        };
                        events.Add(i, "I think of " + friend.name + " ");
                        bool notFound = true;
                        random = rnd.Next(1, 10);
                        if (random == 5)
                        {
                            foreach(KeyValuePair<NPC,int> pair in character.relationships)
                            {
                                if (notFound)
                                {
                                    if (character.relationships[pair.Key] == 2)
                                    {
                                        notFound = false;
                                        friend = pair.Key;

                                    }
                                }
                                
                            }
                            
                        }
                        else if (random == 6)
                        {
                            
                            foreach (KeyValuePair<NPC, int> pair in character.relationships)
                            {
                                if (notFound)
                                {
                                    if (character.relationships[pair.Key] == -1)
                                    {
                                        notFound = false;
                                        friend = pair.Key;
                                    }
                                }

                            }
                        }
                        
                        if (random == 1 || random == 2)
                        {
                            if (!friend.male)
                            {
                                string temp = friends[random].Replace("brother", "sister");
                                events[i] += temp;
                            }

                        }
                        else
                        {
                            events[i] += friends[i];
                        }



                    }
                    else if (random > 5)
                    {
                        NPC enemy = new NPC();
                        bool notFound = false;
                        random = rnd.Next(1,10);
                        if (random == 1)
                        {
                            foreach (KeyValuePair<NPC,int> valuePair in character.relationships)
                            {
                                if (valuePair.Value == 0 && notFound)
                                {
                                    notFound = true;
                                    enemy = valuePair.Key;
                                    character.relationships[valuePair.Key] = -1;
                                }
                            }
                            if (!notFound)
                            {
                                events.Add(i, enemy.name + " is one of my old friends, ");
                            }
                                
                        }
                        else if (random == 2)
                        {
                            foreach (KeyValuePair<NPC, int> valuePair in character.relationships)
                            {
                                if (valuePair.Value == 2 && notFound)
                                {
                                    notFound = true;
                                    enemy = valuePair.Key;
                                    character.relationships[valuePair.Key] = -1;
                                }
                            }
                            if(!notFound)
                            {
                                events.Add(i, enemy.name + " is one of my old lovers, ");
                            }
                            
                        }
                        else if (random == 3)
                        {
                            foreach (KeyValuePair<NPC, int> valuePair in character.relationships)
                            {
                                if (valuePair.Value == 3 && notFound)
                                {
                                    notFound = true;
                                    enemy = valuePair.Key;
                                    character.relationships[valuePair.Key] = -1;
                                }
                            }
                            if (!notFound)
                            {
                                events.Add(i, enemy.name + " is one of my relatives, ");
                            }
                        }
                        else if (notFound)
                        {

                            switch (random)
                                {
                                case 5:
                                    events.Add(i, enemy.name + " is one of my employees, ");
                                    break;
                                case 6:
                                    events.Add(i, enemy.name + " is one of my employers, ");
                                    break;
                                case 7:
                                    events.Add(i, enemy.name + " is one of my partners or co-workers, ");
                                    break;
                                case 8:
                                    events.Add(i, enemy.name + " is a Booster gang member, ");
                                    break;
                                case 9:
                                    events.Add(i, enemy.name + " is a corporate executive, ");
                                    break;
                                case 10:
                                    events.Add(i, enemy.name + " is a government official, ");
                                    break;
                                default:
                                    events.Add(i, enemy.name + " is one of my childhood enemies, ");
                                    break;
                            }
                        }
                        random = rnd.Next(1, 10);
                        if (random <= 4)
                        {
                            events[i] += "They hate me because I"; 
                        }
                        else if (random <= 7)
                        {
                            events[i] += "I hate them because they";
                        } 
                        else
                        {
                            events[i] += "We hate eachother because one of us (your choice)";
                        }
                    }
                }
                else if (random <= 8)
                {

                }
                else if (random <= 10)
                {
                    events.Add(i,"Nothing happened that year");
                }
            }
            return events;
        }

		void SkillBoost(string skill, int ifNotKnown, int ifKnown)
		{
			switch (skill)
			{
				case "Martial Arts":
					//see line 59
					break;

				case "INT":
					//see line 63
					break;

				case "Weapon*":
					//see line 79
					break;
			}
		}

		void StatBoost(string stat, int amount)
		{

		}

		void StatBoost(string stat, int amount, int special)
		{

		}
    }
}
