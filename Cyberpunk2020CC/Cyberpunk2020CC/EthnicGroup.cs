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
			Random random = new Random();
			Ethnicity = random.Next(1, 10);
		}

		public int Ethnicity;

		public override string ToString()
		{
			switch (Ethnicity)
			{
				case 1:
					return "Anglo-American (English)";

				case 2:
					return "African (Bantu, Fante, Kongo, Ashanti, Zulu, Swahili)";

				case 3:
					return "Japanese/Korean (Japanese, Korean)";

				case 4:
					return "Central European/Soviet (Bulgarian, Russian, Czech, Polish, Ukranian, Slovak)";

				case 5:
					return "Pacific Islander (Microneasian, Tagalog, Polynesian, Malayan, Sudanese, Indonesian, Hawaiian)";

				case 6:
					return "Chinese/Southeast Asian (Burmese, Cantonese, Mandarin, Thai, Tibetan, Vietnamese)";

				case 7:
					return "Black American (English, Blackfolk)";

				case 8:
					return "Hispanic American (Spanish, English)";

				case 9:
					return "Central/South American (Spanish, Portuguese)";

				case 10:
					return "European (French, German, English, Spanish, Italian, Greek, Danish, Dutch, Norwegian, Swedish, Finnish)";

				default:
					return null;
			}
		}
	}
}
