using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Cyberpunk2020CharacterCreator.Stats;

namespace Cyberpunk2020CharacterCreator
{
	class LifeEvents
	{


		/// <summary>
		/// Generates Life events following the chart in the Cyberpunk 2020 book, currently not done
		/// </summary>
		/// <returns>A Dictionary<int,string> with the int value representing age and starting at 16</returns>
		public static Dictionary<int, string> GenerateLifeEvents(Character character)
		{

			Random rnd = new Random();
			Dictionary<int, string> events = new Dictionary<int, string>();
			for (int i = 16; i < character.age; i++)
			{
				int random = rnd.Next(1, 10);
				//Big Problems, Big Wins
				if (random <= 3)
				{
					random = rnd.Next(1, 10) % 2;
					if (random == 0)
					{
						random = rnd.Next(1, 10);
						switch (random)
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
								events.Add(i, "You had a Financial Windfall and gained " + random * 100 + " Eurodollars.");
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
								character.stats.stats[getStatsIndex("REF")] -= 1;
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
									character.stats.stats[getStatsIndex("ATT")] -= 5;
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
									character.stats.stats[getStatsIndex("REF")] -= 1;
								}
								else if (random <= 7)
								{
									events.Add(i, "You have experienced some type of mental problem; you suffer anxiety attacks and phobias. You've lost 1 pt. CL.");
									character.stats.stats[getStatsIndex("CL")] -= 1;
								}
								else if (random <= 10)
								{
									events.Add(i, "You have experienced a major psychosis. You hear voices, are violent, irrational, depressive. You have lost 1 pt from your CL, and 1 from REF");
									character.stats.stats[getStatsIndex("CL")] -= 1;
									character.stats.stats[getStatsIndex("REF")] -= 1;
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
								events[i] += "\nI am gong to save, if possible, anyone else involved with the situation.";
							}

						}

					}
				}
				else if (random <= 6)
				{
					Character character1 = new Character();
					Relationship relationship = new Relationship();
					random = rnd.Next(1, 10);
					List<Character> potentials = new List<Character>();
					//You made a friend
					if (random <= 5)
					{
						bool preexisting = false;
						random = rnd.Next(1, 10);
						relationship.Friend = true;
						if (random == 5)
						{
							foreach (KeyValuePair<Character, Relationship> pair in character.relationships)
							{
								if (character.relationships[pair.Key].Acquaintance)
								{
									preexisting = true;
									potentials.Add(pair.Key);
								}
							}
							character1 = potentials[rnd.Next(0, potentials.Count)];
						}
						else if (random == 6)
						{
							foreach (KeyValuePair<Character, Relationship> pair in character.relationships)
							{
								if (character.relationships[pair.Key].Enemy)
								{
									preexisting = true;
									potentials.Add(pair.Key);
								}
							}
							character1 = potentials[rnd.Next(0, potentials.Count)];
						}

						if (preexisting)
						{
							character.relationships[character1].Friend = true;
							character1.relationships[character].Friend = true;
						}
						else
						{
							character1 = Character.MakeQuickRelation(character, Relationship.QuickRelation.Friend);
						}

						events.Add(i, "You made a new friend! ");
						if (character1.male)
						{
							events[i] += "He is ";
						}
						else
						{
							events[i] += "She is ";
						}
						if (random == 1)
						{
							events[i] += "like a big brother to you.";
						}
						else if (random == 2)
						{
							events[i] += "like a kid brother to you.";
						}
						else if (random == 3)
						{
							events[i] += "a teacher or mentor to you.";
						}
						else if (random == 4)
						{
							events[i] += "a partner or co-worker to you.";
						}
						else if (random == 5)
						{
							events[i] += "an old lover of yours, " + character1.name + ".";
						}
						else if (random == 6)
						{
							events[i] += "an old enemy of yours, " + character1.name + ".";
						}
						else if (random == 7)
						{
							events[i] += "like a foster parent to you.";
						}
						else if (random == 8)
						{
							events[i] += "a relative.";
						}
						else if (random == 9)
						{
							events[i] += "an old childhood friend you have reconnected with.";
						}
						else if (random == 10)
						{
							events[i] += "someone you met through a common interest.";
						}

						if (random == 1 || random == 2)
						{
							if (!character1.male)
							{
								events[i].Replace("brother", "sister");
							}

						}
					}
					else
					{
						relationship.Enemy = true;

						bool preexisting = false;
						int random1 = rnd.Next(1, 10);
						int random2 = rnd.Next(1, 10);
						int random3 = rnd.Next(1, 10);
						int random4 = rnd.Next(1, 10);
						int random5 = rnd.Next(1, 10);
						relationship.Friend = true;
						if (random1 == 1)
						{
							foreach (KeyValuePair<Character, Relationship> pair in character.relationships)
							{
								if (character.relationships[pair.Key].Friend)
								{
									preexisting = true;
									character1 = pair.Key;
								}
							}
							character1 = potentials[rnd.Next(0, potentials.Count)];

							character.relationships[character1].Friend = false;
							character1.relationships[character].Friend = false;
						}
						else if (random1 == 2)
						{
							foreach (KeyValuePair<Character, Relationship> pair in character.relationships)
							{
								if (character.relationships[pair.Key].ExLover)
								{
									preexisting = true;
									character1 = pair.Key;
								}
							}
							character1 = potentials[rnd.Next(0, potentials.Count)];
						}
						else if (random1 == 3)
						{
							foreach (KeyValuePair<Character, Relationship> pair in character.relationships)
							{
								if (character.relationships[pair.Key].Family)
								{
									preexisting = true;
									character1 = pair.Key;
								}
							}
							character1 = potentials[rnd.Next(0, potentials.Count)];
						}

						if (!preexisting)
						{
							character.relationships[character1].Enemy = true;
							character1.relationships[character].Enemy = true;
						}
						else
						{
							character1 = Character.MakeQuickRelation(character, Relationship.QuickRelation.Enemy);
						}

						events.Add(i, "You made a new enemy!");

						if (random3 <= 4)
						{
							if (random1 == 1)
							{
								events[i] += " An ex friend";
							}
							else if (random1 == 2)
							{
								events[i] += " An ex lover";
							}
							else if (random1 == 3)
							{
								events[i] += " A relative";
							}
							else if (random1 == 4)
							{
								events[i] += " A childhood enemy";
							}
							else if (random1 == 5)
							{
								events[i] += " A person working for you";
							}
							else if (random1 == 6)
							{
								events[i] += " A person you work for";
							}
							else if (random1 == 7)
							{
								events[i] += " A partner or co-worker";
							}
							else if (random1 == 8)
							{
								events[i] += " A booster gang member";
							}
							else if (random1 == 9)
							{
								events[i] += " A corporate exec";
							}
							else if (random1 == 10)
							{
								events[i] += " A government official";
							}
							events[i] += " hates you";
						}
						else if (random3 <= 7)
						{
							events[i] += " You hate";
							if (random1 == 1)
							{
								events[i] += " an ex friend";
							}
							else if (random1 == 2)
							{
								events[i] += " an ex lover";
							}
							else if (random1 == 3)
							{
								events[i] += " a relative";
							}
							else if (random1 == 4)
							{
								events[i] += " a childhood enemy";
							}
							else if (random1 == 5)
							{
								events[i] += " a person working for you";
							}
							else if (random1 == 6)
							{
								events[i] += " a person you work for";
							}
							else if (random1 == 7)
							{
								events[i] += " a partner or co-worker";
							}
							else if (random1 == 8)
							{
								events[i] += " a booster gang member";
							}
							else if (random1 == 9)
							{
								events[i] += " a corporate exec";
							}
							else if (random1 == 10)
							{
								events[i] += " a government official";
							}
						}
						else if (random3 <= 10)
						{
							events[i] += " You and";
							if (random1 == 1)
							{
								events[i] += " an ex friend";
							}
							else if (random1 == 2)
							{
								events[i] += " an ex lover";
							}
							else if (random1 == 3)
							{
								events[i] += " a relative";
							}
							else if (random1 == 4)
							{
								events[i] += " a childhood enemy";
							}
							else if (random1 == 5)
							{
								events[i] += " a person working for you";
							}
							else if (random1 == 6)
							{
								events[i] += " a person you work for";
							}
							else if (random1 == 7)
							{
								events[i] += " a partner or co-worker";
							}
							else if (random1 == 8)
							{
								events[i] += " a booster gang member";
							}
							else if (random1 == 9)
							{
								events[i] += " a corporate exec";
							}
							else if (random1 == 10)
							{
								events[i] += " a government official";
							}
							events[i] += " hate each other";
						}

						events[i] += ", because one of you ";
						if (random2 == 1)
						{
							events[i] += "caused the other to lose face or status.";
						}
						else if (random2 == 2)
						{
							events[i] += "caused the loss of a lover, friend or relative.";
						}
						else if (random2 == 3)
						{
							events[i] += "caused a major humiliation.";
						}
						else if (random2 == 4)
						{
							events[i] += "accused the other of cowardice or some other personal flaw.";
						}
						else if (random2 == 5)
						{
							random = rnd.Next(1, 6);
							if (random <= 2)
							{
								events[i] += "caused the other to lose an eye.";
							}
							else if (random <= 4)
							{
								events[i] += "caused the other to lose an arm.";
							}
							else if (random <= 6)
							{
								events[i] += "caused the other to be badly scarred.";
							}
						}
						else if (random2 == 6)
						{
							events[i] += "deserted or betrayed the other.";
						}
						else if (random2 == 7)
						{
							events[i] += "turned down the other's offer of job or romantic involvement.";
						}
						else if (random2 == 8)
						{
							events[i] += "just didn't like each other.";
						}
						else if (random2 == 9)
						{
							events[i] += "was a romantic rival.";
						}
						else if (random2 == 10)
						{
							events[i] += "foiled a plan of the other's.";
						}

						events[i] += " If the two of you met face to face, ";
						if (random3 <= 4)
						{
							events[i] += "they would ";
						}
						else if (random3 <= 7)
						{
							events[i] += "you would";
						}
						else if (random3 <= 10)
						{
							events[i] += "you would both";
						}
						if (random4 <= 2)
						{
							events[i] += " go into a murderous, killing rage and rip his face off!";
						}
						else if (random4 <= 4)
						{
							events[i] += " avoid the scum.";
						}
						else if (random4 <= 6)
						{
							events[i] += " backstab him indirectly.";
						}
						else if (random4 <= 8)
						{
							events[i] += " ignore the scum.";
						}
						else if (random4 <= 10)
						{
							events[i] += " rip into him verbally.";
						}

						if (random3 > 7)
						{
							events[i].Replace("his", "each others");
							events[i].Replace("him", "each other");
							events[i].Replace("scum", "each other");
						}
						else if (!character1.male)
						{
							events[i].Replace("his", "her");
							events[i].Replace("him", "her");
						}

						if (random5 <= 3)
						{
							events[i] += " Only your enemy is involved.";
						}
						else if (random5 <= 5)
						{
							events[i] += " Only your enemy and a few of their friends are involved.";
						}
						else if (random5 <= 7)
						{
							events[i] += " Your enemy's entire gang is involved.";
						}
						else if (random5 == 8)
						{
							events[i] += " Your enemy's small corporation is involved.";
						}
						else if (random5 == 9)
						{
							events[i] += " Your enemy's large corporation is involved.";
						}
						else if (random5 == 10)
						{
							events[i] += " Your enemy's entire government agency is involved.";
						}
					}
				}
				else if (random <= 8)
				{
					random = rnd.Next(1, 10);
					if (random <= 4)
					{
						Character character1 = null;
						foreach (KeyValuePair<Character, Relationship> pair in character.relationships)
						{
							if (character.relationships[pair.Key].Lover)
							{
								character1 = pair.Key;
							}
						}

						if (character1 == null) //alternatively try (character1 is null) if it fails
						{
							character1 = Character.MakeQuickRelation(character, Relationship.QuickRelation.Lover);
							events.Add(i, "You fell happily in love with " + character1.name + ".");
						}
						else
						{
							events.Add(i, "You spent a lot of time with " + character1.name + " this year.");
						}
					}
					else if (random == 5)
					{
						int random1 = rnd.Next(1, 10);
						int random2 = rnd.Next(1, 10);

						Character character1 = null;
						bool preexisting = false;
						foreach (KeyValuePair<Character, Relationship> pair in character.relationships)
						{
							if (character.relationships[pair.Key].Lover)
							{
								character1 = pair.Key;
								preexisting = true;
							}
						}
						if (!preexisting)
						{
							character1 = Character.MakeQuickRelation(character, Relationship.QuickRelation.Lover);
						}

						if (random1 == 1)
						{
							if (preexisting)
							{
								events.Add(i, character1.name + "died in an accident.");
							}
							else
							{
								events.Add(i, "You fell in love with " + character1.name);
								if (character1.male)
								{
									events[i] += ". Sadly, he died in an accident the same year.";
								}
								else
								{
									events[i] += ". Sadly, she died in an accident the same year.";
								}
							}
						}
						else if (random1 == 2)
						{
							if (preexisting)
							{
								events.Add(i, character1.name + "have mysteriously vanished.");
							}
							else
							{
								events.Add(i, "You fell in love with " + character1.name);
								if (character1.male)
								{
									events[i] += ". Sadly, he mysteriously vanished the same year.";
								}
								else
								{
									events[i] += ". Sadly, she mysteriously vanished the same year.";
								}
							}
						}
						else if (random1 == 3)
						{
							if (preexisting)
							{
								events.Add(i, "You and " + character1.name + "have gone your seperate ways. It didn't work out.");
							}
							else
							{
								events.Add(i, "You fell in love with " + character1.name + ". Sadly, it didn't work out.");
							}
						}
						else if (random1 == 4)
						{
							if (preexisting)
							{
								events.Add(i, "A personal goal or vendetta came in between you and " + character1.name + ".");
							}
							else
							{
								events.Add(i, "You fell in love with " + character1.name + ". Sadly, a personal goal or vendetta came between you.");
							}
						}
						else if (random1 == 5)
						{
							if (preexisting)
							{
								events.Add(i, character1.name + "has been kidnapped.");
							}
							else
							{
								events.Add(i, "You fell in love with " + character1.name);
								if (character1.male)
								{
									events[i] += ". Sadly, he was kidnapped.";
								}
								else
								{
									events[i] += ". Sadly, she was kidnapped.";
								}
							}
						}
						else if (random1 == 6)
						{
							if (preexisting)
							{
								events.Add(i, character1.name + "has gone insane.");
							}
							else
							{
								events.Add(i, "You fell in love with " + character1.name);
								if (character1.male)
								{
									events[i] += ". Sadly, he went insane.";
								}
								else
								{
									events[i] += ". Sadly, she went insane.";
								}
							}
						}
						else if (random1 == 7)
						{
							if (preexisting)
							{
								events.Add(i, character1.name + "has commited suicide.");
							}
							else
							{
								events.Add(i, "You fell in love with " + character1.name);
								if (character1.male)
								{
									events[i] += ". Sadly, he commited suicide.";
								}
								else
								{
									events[i] += ". Sadly, she commited suicide.";
								}
							}
						}
						else if (random1 == 8)
						{
							if (preexisting)
							{
								events.Add(i, character1.name + "has been killed in a fight.");
							}
							else
							{
								events.Add(i, "You fell in love with " + character1.name);
								if (character1.male)
								{
									events[i] += ". Sadly, he were killed in a fight.";
								}
								else
								{
									events[i] += ". Sadly, she were killed in a fight.";
								}
							}
						}
						else if (random1 == 9)
						{
							Character character2 = Character.MakeQuickRelation(character, Relationship.QuickRelation.Enemy);
							if (preexisting)
							{
								events.Add(i, character1.name + "has left you over a romantic rival, " + character2.name);
							}
							else
							{
								events.Add(i, "You fell in love with " + character1.name);
								if (character1.male)
								{
									events[i] += ". Sadly, he left you over your romantic rival " + character2.name + ".";
								}
								else
								{
									events[i] += ". Sadly, she left you over your romantic rival " + character2.name + ".";
								}
							}
						}
						else if (random1 == 10)
						{
							if (preexisting)
							{
								events.Add(i, character1.name + "has been imprisoned or exiled.");
							}
							else
							{
								events.Add(i, "You fell in love with " + character1.name);
								if (character1.male)
								{
									events[i] += ". Sadly, he were imprisoned or exiled.";
								}
								else
								{
									events[i] += ". Sadly, she were imprisoned or exiled.";
								}
							}
						}

						if (random2 == 1)
						{
							character1.relationships[character].Lover = true;
							character.relationships[character1].Lover = false;
							events[i] += " They still love you.";
						}
						else if (random2 == 2)
						{
							character1.relationships[character].Lover = false;
							character.relationships[character1].Lover = true;
							events[i] += " You still love them.";
						}
						else if (random2 == 3)
						{
							character1.relationships[character].Lover = true;
							character.relationships[character1].Lover = true;
							events[i] += " You still love each other.";
						}
						else if (random2 == 4)
						{
							character1.relationships[character].Lover = false;
							character.relationships[character1].Enemy = true;
							events[i] += " You hate them.";
						}
						else if (random2 == 5)
						{
							character1.relationships[character].Enemy = true;
							character.relationships[character1].Lover = false;
							events[i] += " They hate you.";
						}
						else if (random2 == 6)
						{
							character1.relationships[character].Enemy = true;
							character.relationships[character1].Enemy = true;
							events[i] += " You hate each other.";
						}
						else if (random2 == 7)
						{
							character1.relationships[character].Friend = true;
							character.relationships[character1].Friend = true;
							events[i] += " You are friends.";
						}
						else if (random2 == 8)
						{
							character1.relationships[character].Lover = false;
							character.relationships[character1].Lover = false;
							events[i] += " No feelings either way, it's over.";
						}
						else if (random2 == 9)
						{
							character1.relationships[character].Enemy = true;
							character.relationships[character1].Lover = true;
							events[i] += " You like them, they hate you.";
						}
						else if (random2 == 10)
						{
							character1.relationships[character].Lover = true;
							character.relationships[character1].Enemy = true;
							events[i] += " They like you, you hate them.";
						}
					}
					else if (random <= 7)
					{
						random = rnd.Next(1, 10);
						Character character1 = null;
						bool preexisting = false;
						foreach (KeyValuePair<Character, Relationship> pair in character.relationships)
						{
							if (character.relationships[pair.Key].Lover)
							{
								character1 = pair.Key;
								preexisting = true;
							}
						}
						if (!preexisting)
						{
							character1 = Character.MakeQuickRelation(character, Relationship.QuickRelation.Lover);
						}

						if (random == 1)
						{
							if (preexisting)
							{
								events.Add(i, character1.name + "'s friends/family hate you");
							}
							else
							{
								events.Add(i, "You fell in love with " + character1.name);
								if (character1.male)
								{
									events[i] += ", but his friends/family hate you";
								}
								else
								{
									events[i] += ", but her friends/family hate you";
								}
							}
						}
						else if (random == 2)
						{
							if (preexisting)
							{
								events.Add(i, character1.name + "'s friends/family would use any means to get rid of you.");
							}
							else
							{
								events.Add(i, "You fell in love with " + character1.name);
								if (character1.male)
								{
									events[i] += ", but his friends/family would use any means to get rid of you.";
								}
								else
								{
									events[i] += ", but her friends/family would use any means to get rid of you.";
								}
							}
						}
						else if (random == 3)
						{
							if (preexisting)
							{
								events.Add(i, "Your friends/family hate " + character1.name + ".");
							}
							else
							{
								events.Add(i, "You fell in love with " + character1.name);
								if (character1.male)
								{
									events[i] += ", but your friends/family hate him.";
								}
								else
								{
									events[i] += ", but your friends/family hate her.";
								}
							}
						}
						else if (random == 4)
						{
							if (preexisting)
							{
								events.Add(i, "A romantic lover complicates your relationship with " + character1.name + ".");
							}
							else
							{
								events.Add(i, "You fell in love with " + character1.name + ", but a romantic lover made it complicated.");
							}
						}
						else if (random == 5)
						{
							if (preexisting)
							{
								events.Add(i, "You have been seperated with " + character1.name + " in some way.");
							}
							else
							{
								events.Add(i, "You fell in love with " + character1.name);
								events[i] += ", but you have been seperated in some way.";
							}
						}
						else if (random == 6)
						{
							if (preexisting)
							{
								events.Add(i, "You and " + character1.name + " fight constantly.");
							}
							else
							{
								events.Add(i, "You fell in love with " + character1.name);
								events[i] += ", but you fight constantly.";
							}
						}
						else if (random == 7)
						{
							if (preexisting)
							{
								events.Add(i, "You and " + character1.name + " become professional rivals.");
							}
							else
							{
								events.Add(i, "You fell in love with " + character1.name);
								events[i] += ", but you are professional rivals.";
							}
						}
						else if (random == 8)
						{
							if (preexisting)
							{
								events.Add(i, "Jealousy complicates you and " + character1.name + "'s relationship.");
							}
							else
							{
								events.Add(i, "You fell in love with " + character1.name);
								events[i] += ", but one of you are insanely jealous.";
							}
						}
						else if (random == 9)
						{
							if (preexisting)
							{
								events.Add(i, "Messing around complicates you and " + character1.name + "'s relationship.");
							}
							else
							{
								events.Add(i, "You fell in love with " + character1.name);
								events[i] += ", but one of are messing around.";
							}
						}
						else if (random == 9)
						{
							if (preexisting)
							{
								events.Add(i, "It turns out you and " + character1.name + " have conflicting backgrounds and families.");
							}
							else
							{
								events.Add(i, "You fell in love with " + character1.name);
								events[i] += ", but you have conflicting backgrounds and families.";
							}
						}
					}
					else if (random <= 10)
					{
						events.Add(i, "This year was filled with fast affairs, hot dates and one-night-stands.");
					}
				}
				else if (random <= 10)
				{
					events.Add(i, "Nothing happened that year.");
				}
			}
			return events;
		}

		static void SkillBoost(string skill, int ifNotKnown, int ifKnown)
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
	}
}
