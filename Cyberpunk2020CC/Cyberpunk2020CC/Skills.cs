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
        Dictionary<string, int> skills = new Dictionary<string, int>();
        

        public int this[string i]
        {
            get
            {
                return skills[i];
            }
            set
            {
                skills[i] = value;
            }
        }

        public int PersonalGrooming { get { return skills["PersonalGrooming"]; } set { skills["PersonalGrooming"] = value; } }
        public int WardrobeAndStyle { get { return skills["WardrobeAndStyle"]; } set { skills["WardrobeAndStyle"] = value; } }
        public int Endurance { get { return skills["Endurance"]; } set { skills["Endurance"] = value; } }
        public int StrengthFeat { get { return skills["StrengthFeat"]; } set { skills["StrengthFeat"] = value; } }
        public int Swimming { get { return skills["Swimming"]; } set { skills["Swimming"] = value; } }
        public int Interrogation { get { return skills["Interrogation"]; } set { skills["Interrogation"] = value; } }
        public int Intimidate { get { return skills["Intimidate"]; } set { skills["Intimidate"] = value; } }
        public int Oratory { get { return skills["Oratory"]; } set { skills["Oratory"] = value; } }
        public int ResistTortureOrDrugs { get { return skills["ResistTortureOrDrugs"]; } set { skills["ResistTortureOrDrugs"] = value; } }
        public int Streetwise { get { return skills["Streetwise"]; } set { skills["Streetwise"] = value; } }
        public int HumanPerception { get { return skills["HumanPerception"]; } set { skills["HumanPerception"] = value; } }
        public int Interview { get { return skills["Interview"]; } set { skills["Interview"] = value; } }
        public int Leadership { get { return skills["Leadership"]; } set { skills["Leadership"] = value; } }
        public int Seduction { get { return skills["Seduction"]; } set { skills["Seduction"] = value; } }
        public int Social { get { return skills["Social"]; } set { skills["Social"] = value; } }
        public int PersuassionAndFastTalk { get { return skills["PersuassionAndFastTalk"]; } set { skills["PersuassionAndFastTalk"] = value; } }
        public int Perform { get { return skills["Perform"]; } set { skills["Perform"] = value; } }
        public int Accounting { get { return skills["Accounting"]; } set { skills["Accounting"] = value; } }
        public int Anthropology { get { return skills["Anthropology"]; } set { skills["Anthropology"] = value; } }
        public int AwarenessNotice { get { return skills["AwarenessNotice"]; } set { skills["AwarenessNotice"] = value; } }
        public int Biology { get { return skills["Biology"]; } set { skills["Biology"] = value; } }
        public int Botany { get { return skills["Botany"]; } set { skills["Botany"] = value; } }
        public int Chemisty { get { return skills["Chemisty"]; } set { skills["Chemisty"] = value; } }
        public int Compossition { get { return skills["Compossition"]; } set { skills["Compossition"] = value; } }
        public int DiagnoseIllness { get { return skills["DiagnoseIllness"]; } set { skills["DiagnoseIllness"] = value; } }
        public int EdducationAndGeneralKnowledge { get { return skills["EdducationAndGeneralKnowledge"]; } set { skills["EdducationAndGeneralKnowledge"] = value; } }
        public int Expert { get { return skills["Expert"]; } set { skills["Expert"] = value; } }
        public int Gamble { get { return skills["Gamble"]; } set { skills["Gamble"] = value; } }
        public int Geology { get { return skills["Geology"]; } set { skills["Geology"] = value; } }
        public int HideOrEvade { get { return skills["HideOrEvade"]; } set { skills["HideOrEvade"] = value; } }
        public int History { get { return skills["History"]; } set { skills["History"] = value; } }
        public int LibrarySearch { get { return skills["LibrarySearch"]; } set { skills["LibrarySearch"] = value; } }
        public int Mathematics { get { return skills["Mathematics"]; } set { skills["Mathematics"] = value; } }
        public int Physics { get { return skills["Physics"]; } set { skills["Physics"] = value; } }
        public int Programming { get { return skills["Programming"]; } set { skills["Programming"] = value; } }
        public int ShadowOrTrack { get { return skills["ShadowOrTrack"]; } set { skills["ShadowOrTrack"] = value; } }
        public int StockMarket { get { return skills["StockMarket"]; } set { skills["StockMarket"] = value; } }
        public int SystemKnowledge { get { return skills["SystemKnowledge"]; } set { skills["SystemKnowledge"] = value; } }
        public int Teaching { get { return skills["Teaching"]; } set { skills["Teaching"] = value; } }
        public int WildernessSurvival { get { return skills["WildernessSurvival"]; } set { skills["WildernessSurvival"] = value; } }
        public int Zoology { get { return skills["Zoology"]; } set { skills["Zoology"] = value; } }
        public int Archery { get { return skills["Archery"]; } set { skills["Archery"] = value; } }
        public int Athletics { get { return skills["Athletics"]; } set { skills["Athletics"] = value; } }
        public int Brawling { get { return skills["Brawling"]; } set { skills["Brawling"] = value; } }
        public int Dance { get { return skills["Dance"]; } set { skills["Dance"] = value; } }
        public int DodgeAndEscape { get { return skills["DodgeAndEscape"]; } set { skills["DodgeAndEscape"] = value; } }
        public int Driving { get { return skills["Driving"]; } set { skills["Driving"] = value; } }
        public int Fencing { get { return skills["Fencing"]; } set { skills["Fencing"] = value; } }
        public int Handgun { get { return skills["Handgun"]; } set { skills["Handgun"] = value; } }
        public int HeavyWeapons { get { return skills["HeavyWeapons"]; } set { skills["HeavyWeapons"] = value; } }
        public int Melee { get { return skills["Melee"]; } set { skills["Melee"] = value; } }
        public int Motorcycle { get { return skills["Motorcycle"]; } set { skills["Motorcycle"] = value; } }
        public int OperateHeavyMachinery { get { return skills["OperateHeavyMachinery"]; } set { skills["OperateHeavyMachinery"] = value; } }
        public int PilotGyro { get { return skills["PilotGyro"]; } set { skills["PilotGyro"] = value; } }
        public int PilotFixedWing { get { return skills["PilotFixedWing"]; } set { skills["PilotFixedWing"] = value; } }
        public int PilotDirigible { get { return skills["PilotDirigible"]; } set { skills["PilotDirigible"] = value; } }
        public int PilotVectorThrust { get { return skills["PilotVectorThrust"]; } set { skills["PilotVectorThrust"] = value; } }
        public int Rifle { get { return skills["Rifle"]; } set { skills["Rifle"] = value; } }
        public int Stealth { get { return skills["Stealth"]; } set { skills["Stealth"] = value; } }
        public int Submachinegun { get { return skills["Submachinegun"]; } set { skills["Submachinegun"] = value; } }
        public int AeroTech { get { return skills["AeroTech"]; } set { skills["AeroTech"] = value; } }
        public int AVTech { get { return skills["AVTech"]; } set { skills["AVTech"] = value; } }
        public int BasicTech { get { return skills["BasicTech"]; } set { skills["BasicTech"] = value; } }
        public int CryotankOperation { get { return skills["CryotankOperation"]; } set { skills["CryotankOperation"] = value; } }
        public int CyberdeckDesign { get { return skills["CyberdeckDesign"]; } set { skills["CyberdeckDesign"] = value; } }
        public int CyberTech { get { return skills["CyberTech"]; } set { skills["CyberTech"] = value; } }
        public int Demolitions { get { return skills["Demolitions"]; } set { skills["Demolitions"] = value; } }
        public int Disguise { get { return skills["Disguise"]; } set { skills["Disguise"] = value; } }
        public int Electronics { get { return skills["Electronics"]; } set { skills["Electronics"] = value; } }
        public int ElectronicSecurity { get { return skills["ElectronicSecurity"]; } set { skills["ElectronicSecurity"] = value; } }
        public int FirstAid { get { return skills["FirstAid"]; } set { skills["FirstAid"] = value; } }
        public int Forgery { get { return skills["Forgery"]; } set { skills["Forgery"] = value; } }
        public int GyroTech { get { return skills["GyroTech"]; } set { skills["GyroTech"] = value; } }
        public int PaintOrDraw { get { return skills["PaintOrDraw"]; } set { skills["PaintOrDraw"] = value; } }
        public int PhotoAndFilm { get { return skills["PhotoAndFilm"]; } set { skills["PhotoAndFilm"] = value; } }
        public int Pharmacuticals { get { return skills["Pharmacuticals"]; } set { skills["Pharmacuticals"] = value; } }
        public int PickLock { get { return skills["PickLock"]; } set { skills["PickLock"] = value; } }
        public int PickPocket { get { return skills["PickPocket"]; } set { skills["PickPocket"] = value; } }
        public int PlayInstrument { get { return skills["PlayInstrument"]; } set { skills["PlayInstrument"] = value; } }
        public int WeaponSmith { get { return skills["WeaponSmith"]; } set { skills["WeaponSmith"] = value; } }

    }
}


        
        
    


