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

        public int PersonalGrooming() { return skills["PersonalGrooming"]; }
        public int WardrobeAndStyle() { return skills["WardrobeAndStyle"]; }
        public int Endurance() { return skills["Endurance"]; }
        public int StrengthFeat() { return skills["StrengthFeat"]; }
        public int Swimming() { return skills["Swimming"]; }
        public int Interrogation() { return skills["Interrogation"]; }
        public int Intimidate() { return skills["Intimidate"]; }
        public int Oratory() { return skills["Oratory"]; }
        public int ResistTortureOrDrugs() { return skills["ResistTortureOrDrugs"]; }
        public int Streetwise() { return skills["Streetwise"]; }
        public int HumanPerception() { return skills["HumanPerception"]; }
        public int Interview() { return skills["Interview"]; }
        public int Leadership() { return skills["Leadership"]; }
        public int Seduction() { return skills["Seduction"]; }
        public int Social() { return skills["Social"]; }
        public int PersuassionAndFastTalk() { return skills["PersuassionAndFastTalk"]; }
        public int Perform() { return skills["Perform"]; }
        public int Accounting() { return skills["Accounting"]; }
        public int Anthropology() { return skills["Anthropology"]; }
        public int AwarenessNotice() { return skills["AwarenessNotice"]; }
        public int Biology() { return skills["Biology"]; }
        public int Botany() { return skills["Botany"]; }
        public int Chemisty() { return skills["Chemisty"]; }
        public int Compossition() { return skills["Compossition"]; }
        public int DiagnoseIllness() { return skills["DiagnoseIllness"]; }
        public int EdducationAndGeneralKnowledge() { return skills["EdducationAndGeneralKnowledge"]; }
        public int Expert() { return skills["Expert"]; }
        public int Gamble() { return skills["Gamble"]; }
        public int Geology() { return skills["Geology"]; }
        public int HideOrEvade() { return skills["HideOrEvade"]; }
        public int History() { return skills["History"]; }
        public int LibrarySearch() { return skills["LibrarySearch"]; }
        public int Mathematics() { return skills["Mathematics"]; }
        public int Physics() { return skills["Physics"]; }
        public int Programming() { return skills["Programming"]; }
        public int ShadowOrTrack() { return skills["ShadowOrTrack"]; }
        public int StockMarket() { return skills["StockMarket"]; }
        public int SystemKnowledge() { return skills["SystemKnowledge"]; }
        public int Teaching() { return skills["Teaching"]; }
        public int WildernessSurvival() { return skills["WildernessSurvival"]; }
        public int Zoology() { return skills["Zoology"]; }
        public int Archery() { return skills["Archery"]; }
        public int Athletics() { return skills["Athletics"]; }
        public int Brawling() { return skills["Brawling"]; }
        public int Dance() { return skills["Dance"]; }
        public int DodgeAndEscape() { return skills["DodgeAndEscape"]; }
        public int Driving() { return skills["Driving"]; }
        public int Fencing() { return skills["Fencing"]; }
        public int Handgun() { return skills["Handgun"]; }
        public int HeavyWeapons() { return skills["HeavyWeapons"]; }
        public int Melee() { return skills["Melee"]; }
        public int Motorcycle() { return skills["Motorcycle"]; }
        public int OperateHeavyMachinery() { return skills["OperateHeavyMachinery"]; }
        public int PilotGyro() { return skills["PilotGyro"]; }
        public int PilotFixedWing() { return skills["PilotFixedWing"]; }
        public int PilotDirigible() { return skills["PilotDirigible"]; }
        public int PilotVectorThrust() { return skills["PilotVectorThrust"]; }
        public int Rifle() { return skills["Rifle"]; }
        public int Stealth() { return skills["Stealth"]; }
        public int Submachinegun() { return skills["Submachinegun"]; }
        public int AeroTech() { return skills["AeroTech"]; }
        public int AVTech() { return skills["AVTech"]; }
        public int BasicTech() { return skills["BasicTech"]; }
        public int CryotankOperation() { return skills["CryotankOperation"]; }
        public int CyberdeckDesign() { return skills["CyberdeckDesign"]; }
        public int CyberTech() { return skills["CyberTech"]; }
        public int Demolitions() { return skills["Demolitions"]; }
        public int Disguise() { return skills["Disguise"]; }
        public int Electronics() { return skills["Electronics"]; }
        public int ElectronicSecurity() { return skills["ElectronicSecurity"]; }
        public int FirstAid() { return skills["FirstAid"]; }
        public int Forgery() { return skills["Forgery"]; }
        public int GyroTech() { return skills["GyroTech"]; }
        public int PaintOrDraw() { return skills["PaintOrDraw"]; }
        public int PhotoAndFilm() { return skills["PhotoAndFilm"]; }
        public int Pharmacuticals() { return skills["Pharmacuticals"]; }
        public int PickLock() { return skills["PickLock"]; }
        public int PickPocket() { return skills["PickPocket"]; }
        public int PlayInstrument() { return skills["PlayInstrument"]; }
        public int WeaponSmith() { return skills["WeaponSmith"]; }

    }
}


        
        
    


