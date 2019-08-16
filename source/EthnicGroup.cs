using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cyberpunk2020CharacterCreator
{
	class EthnicGroup
	{
		public EthnicGroup()
		{
			Random rnd;
			Ethnicity = rnd.Next(1, 10);
		}

		public int Ethnicity;

		public override static string ToString()
		{
			switch (Ethnicity)
			{
				case 1:
					return "Anglo-American (English)";
					break;

				case 2:
					return "African (Bantu, Fante, Kongo, Ashanti, Zulu, Swahili";
					break;

				case 3:
					return "Japanese/Korean (Japanese, Korean)";
					break;

				case 4:
					return "Central European/Soviet (Bulgarian, Russian, Czech, Polish, Ukranian, Slovak)";
					break;

				case 5:
					return "Pacific Islander (Microneasian, Tagalog, Polynesian, Malayan, Sudanese, Indonesian, Hawaiian)";
					break;

				case 6:
					return "Chinese/Southeast Asian (Burmese, Cantonese, Mandarin, Thai, Tibetan, Vietnamese)";
					break;
				case 7:
					return "Black American (English, Blackfolk)";
					break;
				case 8:
					return "Hispanic American (Spanish, English)";
					break;
				case 9:
					return "Central/South American (Spanish, Portuguese)";
					break;
				case 10:
					return "European (French, German, English, Spanish, Italian, Greek, Danish, Dutch, Norwegian, Swedish, Finnish)";
					break;
				default:
					return null;
			}
		}
	}
}
