using System;
using System.Collections.Generic;

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


        public int this[string i]
        {
            get => skills[i];
            set => skills[i] = value;
        }

        public int PersonalGrooming
        {
            get => skills["PersonalGrooming"];
            set => skills["PersonalGrooming"] = value;
        }

        public int WardrobeAndStyle
        {
            get => skills["WardrobeAndStyle"];
            set => skills["WardrobeAndStyle"] = value;
        }

        public int Endurance
        {
            get => skills["Endurance"];
            set => skills["Endurance"] = value;
        }

        public int StrengthFeat
        {
            get => skills["StrengthFeat"];
            set => skills["StrengthFeat"] = value;
        }

        public int Swimming
        {
            get => skills["Swimming"];
            set => skills["Swimming"] = value;
        }

        public int Interrogation
        {
            get => skills["Interrogation"];
            set => skills["Interrogation"] = value;
        }

        public int Intimidate
        {
            get => skills["Intimidate"];
            set => skills["Intimidate"] = value;
        }

        public int Oratory
        {
            get => skills["Oratory"];
            set => skills["Oratory"] = value;
        }

        public int ResistTortureOrDrugs
        {
            get => skills["ResistTortureOrDrugs"];
            set => skills["ResistTortureOrDrugs"] = value;
        }

        public int Streetwise
        {
            get => skills["Streetwise"];
            set => skills["Streetwise"] = value;
        }

        public int HumanPerception
        {
            get => skills["HumanPerception"];
            set => skills["HumanPerception"] = value;
        }

        public int Interview
        {
            get => skills["Interview"];
            set => skills["Interview"] = value;
        }

        public int Leadership
        {
            get => skills["Leadership"];
            set => skills["Leadership"] = value;
        }

        public int Seduction
        {
            get => skills["Seduction"];
            set => skills["Seduction"] = value;
        }

        public int Social
        {
            get => skills["Social"];
            set => skills["Social"] = value;
        }

        public int PersuasionAndFastTalk
        {
            get => skills["PersuasionAndFastTalk"];
            set => skills["PersuasionAndFastTalk"] = value;
        }

        public int Perform
        {
            get => skills["Perform"];
            set => skills["Perform"] = value;
        }

        public int Accounting
        {
            get => skills["Accounting"];
            set => skills["Accounting"] = value;
        }

        public int Anthropology
        {
            get => skills["Anthropology"];
            set => skills["Anthropology"] = value;
        }

        public int AwarenessNotice
        {
            get => skills["AwarenessNotice"];
            set => skills["AwarenessNotice"] = value;
        }

        public int Biology
        {
            get => skills["Biology"];
            set => skills["Biology"] = value;
        }

        public int Botany
        {
            get => skills["Botany"];
            set => skills["Botany"] = value;
        }

        public int Chemistry
        {
            get => skills["Chemistry"];
            set => skills["Chemistry"] = value;
        }

        public int Composition
        {
            get => skills["Composition"];
            set => skills["Composition"] = value;
        }

        public int DiagnoseIllness
        {
            get => skills["DiagnoseIllness"];
            set => skills["DiagnoseIllness"] = value;
        }

        public int EducationAndGeneralKnowledge
        {
            get => skills["EducationAndGeneralKnowledge"];
            set => skills["EducationAndGeneralKnowledge"] = value;
        }

        public int Expert
        {
            get => skills["Expert"];
            set => skills["Expert"] = value;
        }

        public int Gamble
        {
            get => skills["Gamble"];
            set => skills["Gamble"] = value;
        }

        public int Geology
        {
            get => skills["Geology"];
            set => skills["Geology"] = value;
        }

        public int HideOrEvade
        {
            get => skills["HideOrEvade"];
            set => skills["HideOrEvade"] = value;
        }

        public int History
        {
            get => skills["History"];
            set => skills["History"] = value;
        }

        public int LibrarySearch
        {
            get => skills["LibrarySearch"];
            set => skills["LibrarySearch"] = value;
        }

        public int Mathematics
        {
            get => skills["Mathematics"];
            set => skills["Mathematics"] = value;
        }

        public int Physics
        {
            get => skills["Physics"];
            set => skills["Physics"] = value;
        }

        public int Programming
        {
            get => skills["Programming"];
            set => skills["Programming"] = value;
        }

        public int ShadowOrTrack
        {
            get => skills["ShadowOrTrack"];
            set => skills["ShadowOrTrack"] = value;
        }

        public int StockMarket
        {
            get => skills["StockMarket"];
            set => skills["StockMarket"] = value;
        }

        public int SystemKnowledge
        {
            get => skills["SystemKnowledge"];
            set => skills["SystemKnowledge"] = value;
        }

        public int Teaching
        {
            get => skills["Teaching"];
            set => skills["Teaching"] = value;
        }

        public int WildernessSurvival
        {
            get => skills["WildernessSurvival"];
            set => skills["WildernessSurvival"] = value;
        }

        public int Zoology
        {
            get => skills["Zoology"];
            set => skills["Zoology"] = value;
        }

        public int Archery
        {
            get => skills["Archery"];
            set => skills["Archery"] = value;
        }

        public int Athletics
        {
            get => skills["Athletics"];
            set => skills["Athletics"] = value;
        }

        public int Brawling
        {
            get => skills["Brawling"];
            set => skills["Brawling"] = value;
        }

        public int Dance
        {
            get => skills["Dance"];
            set => skills["Dance"] = value;
        }

        public int DodgeAndEscape
        {
            get => skills["DodgeAndEscape"];
            set => skills["DodgeAndEscape"] = value;
        }

        public int Driving
        {
            get => skills["Driving"];
            set => skills["Driving"] = value;
        }

        public int Fencing
        {
            get => skills["Fencing"];
            set => skills["Fencing"] = value;
        }

        public int Handgun
        {
            get => skills["Handgun"];
            set => skills["Handgun"] = value;
        }

        public int HeavyWeapons
        {
            get => skills["HeavyWeapons"];
            set => skills["HeavyWeapons"] = value;
        }

        public int Melee
        {
            get => skills["Melee"];
            set => skills["Melee"] = value;
        }

        public int Motorcycle
        {
            get => skills["Motorcycle"];
            set => skills["Motorcycle"] = value;
        }

        public int OperateHeavyMachinery
        {
            get => skills["OperateHeavyMachinery"];
            set => skills["OperateHeavyMachinery"] = value;
        }

        public int PilotGyro
        {
            get => skills["PilotGyro"];
            set => skills["PilotGyro"] = value;
        }

        public int PilotFixedWing
        {
            get => skills["PilotFixedWing"];
            set => skills["PilotFixedWing"] = value;
        }

        public int PilotDirigible
        {
            get => skills["PilotDirigible"];
            set => skills["PilotDirigible"] = value;
        }

        public int PilotVectorThrust
        {
            get => skills["PilotVectorThrust"];
            set => skills["PilotVectorThrust"] = value;
        }

        public int Rifle
        {
            get => skills["Rifle"];
            set => skills["Rifle"] = value;
        }

        public int Stealth
        {
            get => skills["Stealth"];
            set => skills["Stealth"] = value;
        }

        public int Submachinegun
        {
            get => skills["Submachinegun"];
            set => skills["Submachinegun"] = value;
        }

        public int AeroTech
        {
            get => skills["AeroTech"];
            set => skills["AeroTech"] = value;
        }

        public int AVTech
        {
            get => skills["AVTech"];
            set => skills["AVTech"] = value;
        }

        public int BasicTech
        {
            get => skills["BasicTech"];
            set => skills["BasicTech"] = value;
        }

        public int CryotankOperation
        {
            get => skills["CryotankOperation"];
            set => skills["CryotankOperation"] = value;
        }

        public int CyberdeckDesign
        {
            get => skills["CyberdeckDesign"];
            set => skills["CyberdeckDesign"] = value;
        }

        public int CyberTech
        {
            get => skills["CyberTech"];
            set => skills["CyberTech"] = value;
        }

        public int Demolitions
        {
            get => skills["Demolitions"];
            set => skills["Demolitions"] = value;
        }

        public int Disguise
        {
            get => skills["Disguise"];
            set => skills["Disguise"] = value;
        }

        public int Electronics
        {
            get => skills["Electronics"];
            set => skills["Electronics"] = value;
        }

        public int ElectronicSecurity
        {
            get => skills["ElectronicSecurity"];
            set => skills["ElectronicSecurity"] = value;
        }

        public int FirstAid
        {
            get => skills["FirstAid"];
            set => skills["FirstAid"] = value;
        }

        public int Forgery
        {
            get => skills["Forgery"];
            set => skills["Forgery"] = value;
        }

        public int GyroTech
        {
            get => skills["GyroTech"];
            set => skills["GyroTech"] = value;
        }

        public int PaintOrDraw
        {
            get => skills["PaintOrDraw"];
            set => skills["PaintOrDraw"] = value;
        }

        public int PhotoAndFilm
        {
            get => skills["PhotoAndFilm"];
            set => skills["PhotoAndFilm"] = value;
        }

        public int Pharmacuticals
        {
            get => skills["Pharmacuticals"];
            set => skills["Pharmacuticals"] = value;
        }

        public int PickLock
        {
            get => skills["PickLock"];
            set => skills["PickLock"] = value;
        }

        public int PickPocket
        {
            get => skills["PickPocket"];
            set => skills["PickPocket"] = value;
        }

        public int PlayInstrument
        {
            get => skills["PlayInstrument"];
            set => skills["PlayInstrument"] = value;
        }

        public int WeaponSmith
        {
            get => skills["WeaponSmith"];
            set => skills["WeaponSmith"] = value;
        }
    }
}