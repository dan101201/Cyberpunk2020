using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cyberpunk2020Library
{
    [Serializable]
    public class EthnicGroup
    {
        public EthnicGroup()
		{
			Random random = new Random();
			ethnicity = random.Next(1, 10);
		}

		public int ethnicity;

		public override string ToString()
		{
			switch (ethnicity)
			{
				case 1:
					return "Anglo-American (English)";

				case 2:
					return "African (Ashanti, Bantu, Congo, Egyptian, Fante, Morrocan, Swahili, Zulu)";

				case 3:
					return "West Asian/Indo Chinese (Burmese, Cambodian, Indian, Thai, Pakistani, Vietnamese, )";

				case 4:
					return "Eastern European/Soviet (Czech, Estonian, Finnish, Latvian, Lithuanian, Polish, Romanian, Russian, Ukranian, Slovak)";

				case 5:
					return "Pacific Islander (Hawaiian, Indonesian, Malayan, Microneasian, Polynesian, Sudanese, Tagalog)";

				case 6:
					return "Chinese/East Asian (Cantonese, Japanese, Korean, Mandarin, Tibetan)";

				case 7:
					return "Black American (English, Blackfolk)";

				case 8:
					return "Hispanic American (Spanish, English)";

				case 9:
					return "Central/South American (Portuguese, Spanish, French)";

				case 10:
					return "West European (Danish, Dutch, French, German, English, Italian, Norwegian, Portuguese, Spanish, Swedish)";

                case 11:
                    return "Balkan (Albanian, Bosnian, Bulgarian, Croatian, Greek, Serbian,)";

                case 12:
                    return "Middle Eastern (Afghan, Arabs, Iranian, Iraqi, Israeli, Lebanese, Syrian, Turkish)";

                case 13:
                    return "Caribbean (Cuban, Haitian, Jamaican, English, French)";

				default:
					return null;
			}
		}
	}
}
