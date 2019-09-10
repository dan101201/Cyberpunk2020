using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cyberpunk2020CharacterCreator
{
    public class SkillDoesNotExistException : ApplicationException
    {
        SkillDoesNotExistException(string message)
        {

        }
    }
    class Skills
    {
        //Dictionary of the skills, with a string key being the nameo f the skill, and int being the level in the skill
        public static Dictionary<string, int> returnSkillDictionary(bool interlock)
        {
            Dictionary<string, int> skills = new Dictionary<string, int>();
            foreach(string skill in returnSkillArray(interlock))
            {
                skills.Add(skill, 0);
            }
            return skills;
        }
        
            
        

    //Returns a string array full of all the skills, using either the interlock(official system) or a homebrew one
    static string[] returnSkillArray(bool InterLock)
        {
            if (!InterLock)
            {
                string[] temp =
        {
        "PersonalGrooming",
        "WardrobeAndStyle",
        "Endurance",
        "StrengthFeat",
        "Swimming",
        "Interrogation",
        "Intimidate",
        "Oratory",
        "ResistTortureOrDrugs",
        "Streetwise",
        "HumanPerception",
        "Interview",
        "Leadership",
        "Seduction",
        "Social",
        "PersuassionAndFastTalk",
        "Perform",
        "Accounting",
        "Anthropology",
        "Awareness/Notice",
        "Biology",
        "Botany",
        "Chemisty",
        "Compossition",
        "DiagnoseIllness",
        "EdducationAndGeneralKnowledge",
        "Expert",
        "Gamble",
        "Geology",
        "HideOrEvade",
        "History",
        "LibrarySearch",
        "Mathematics",
        "Physics",
        "Programming",
        "ShadowOrTrack",
        "StockMarket",
        "SystemKnowledge",
        "Teaching",
        "WildernessSurvival",
        "Zoology",
        "Archery",
        "Athletics",
        "Brawling",
        "Dance",
        "DodgeAndEscape",
        "Driving",
        "Fencing",
        "Handgun",
        "HeavyWeapons",
        "Melee",
        "Motorcycle",
        "OperateHeavyMachinery",
        "PilotGyro",
        "PilotFixedWing",
        "PilotDirigible",
        "PilotVectorThrust",
        "Rifle",
        "Stealth",
        "Submachinegun",
        "AeroTech",
        "AVTech",
        "BasicTech",
        "CryotankOperation",
        "CyberdeckDesign",
        "CyberTech",
        "Demolitions",
        "Disguise",
        "Electronics",
        "ElectronicSecurity",
        "FirstAid",
        "Forgery",
        "GyroTech",
        "PaintOrDraw",
        "PhotoAndFilm",
        "Pharmacuticals",
        "PickLock",
        "PickPocket",
        "PlayInstrument",
        "WeaponSmith"
        };
                return temp;
            }
            else
            {

                string[] temp = {
"Wardrobe &amp; Style",
"Personal Grooming",
"BODY",
"Endurance",
"Fitness/Body Building",
"Rowing",
"Strength Feat",
"Swimming",
"Intimidate",
"Interrogation",
"Leadership",
"Oratory",
"Resist Torture/Drugs",
"Skydiving",
"Streetwise",
"Animal Handling",
"Design",
"Human Perception",
"Hypnotism/Brainwashing",
"Interview",
"Lip Reading",
"Massage",
"Networking",
"Parenting",
"Perform",
"Persuasion &amp; Fast Talk",
"Seduction",
"Sing",
"Social",
"Storytelling",
"Accounting",
"Appraise",
"Awareness: Notice",
"Awareness: Tactical",
"Awareness Track",
"Business Sense",
"Composition",
"Diagnose Illness",
"Education &amp; General Knowledge",
"Expert: (Subject)",
"Gamble",
"Gardening/Farming",
"Language: (Choose One)",
"Library Search",
"Navigation",
"Programming",
"S.C.U.B.A.",
"Survival: (Environment)",
"System Knowledge",
"Teaching",
"Athletics",
"Blind Fighting",
"Brawling/Melee",
"Dance",
"Initiative",
"Juggle",
"Martial Arts: (Style)",
"Operate: ACPA",
"Operate: Animal",
"Operate: Car/Truck",
"Operate: Dirigible",
"Operate: EVA",
"Operate: Fixed Wing",
"Operate: Glider",
"Operate: Gyro",
"Operate: Heavy Machinery",
"Operate: Motorcycle",
"Operate: OTV",
"Operate: Remote",
"Operate: Sail Driven",
"Operate: Space Plane/Shuttle",
"Operate: Sub (Large/Small)",
"Operate: Vectored Thrust",
"Skate/Ski/Surf",
"Stealth/Evasion",
"Underwater Maneuver",
"Weapon: Archery",
"Weapon: Handgun",
"Weapon: Heavy Weapons",
"Weapon: Rifle",
"Zero-G Maneuver",
"Calligraphy",
"Cooking",
"Cryotank Operation",
"Demolitions",
"Disguise",
"Electronic Security",
"Forgery",
"Glass blowing",
"Jeweler",
"Jury Rig",
"Med: First Aid",
"Med: Pharmaceuticals",
"Med:Surgery",
"Origami",
"Photography &amp; Film",
"Pick Lock",
"Pick Pocket/Sleight of hand",
"Play Instrument",
"Rope Use",
"Paint or Draw",
"Sculpt",
"Sewing",
"Stage Magic",
"Tattooing (Hand-Pick)",
"Traps and snares",
"Tattooing",
"Tech: Aero",
"Tech: AV Tech: Basic",
"Tech: Carpentry",
"Tech: Chemistry",
"Tech: Cyber",
"Tech: Cyberdeck Design",
"Tech: Electronics",
"Tech: Gyro",
"Tech: Marine/Underwater Equip",
"Tech: Metal Smith",
"Tech: Powered Armor",
"Tech: Pressure Suit",
"Tech: Spacecraft",
"Tech: Submarine",
"Tech: Weaponsmith",
"Tech: Wetware",
"Typing",
"Video Manipulation"
                    };
                return temp;
            }



        }
    }
}


        
        
    


