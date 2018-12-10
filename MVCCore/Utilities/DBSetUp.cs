using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MVCCore.EF;
using MVCCore.Models;



namespace MVCCore.Utilities
{
	public static class DBSetUp
	{
		public static void createDefaultLanguages()
		{
			ArtifactContext db = new ArtifactContext();
			db.Languages.Add(new Language() { iso2 = "en", Name = "english" });
			db.Languages.Add(new Language() { iso2 = "es", Name = "spanish" });
			db.Languages.Add(new Language() { iso2 = "de", Name = "german" });
			db.Languages.Add(new Language() { iso2 = "fr", Name = "french" });
			db.Languages.Add(new Language() { iso2 = "it", Name = "italian" });
			db.Languages.Add(new Language() { iso2 = "ko", Name = "koreana" });
			db.Languages.Add(new Language() { iso2 = "zh", Name = "schinese" });
			db.Languages.Add(new Language() { iso2 = "zh2", Name = "tchinese" });
			db.Languages.Add(new Language() { iso2 = "ru", Name = "russian" });
			db.Languages.Add(new Language() { iso2 = "ja", Name = "japanese" });
			db.Languages.Add(new Language() { iso2 = "br", Name = "brazilian" });
			db.Languages.Add(new Language() { iso2 = "la", Name = "latam" });
			db.Languages.Add(new Language() { iso2 = "th", Name = "thai" });
			db.Languages.Add(new Language() { iso2 = "pt", Name = "portuguese" });
			db.Languages.Add(new Language() { iso2 = "pl", Name = "polish" });
			db.Languages.Add(new Language() { iso2 = "da", Name = "danish" });
			db.Languages.Add(new Language() { iso2 = "nl", Name = "dutch" });
			db.Languages.Add(new Language() { iso2 = "fi", Name = "finnish" });
			db.Languages.Add(new Language() { iso2 = "no", Name = "norwegian" });
			db.Languages.Add(new Language() { iso2 = "sv", Name = "swedish" });
			db.Languages.Add(new Language() { iso2 = "hu", Name = "hungarian" });
			db.Languages.Add(new Language() { iso2 = "cs", Name = "czech" });
			db.Languages.Add(new Language() { iso2 = "ro", Name = "romanian" });
			db.Languages.Add(new Language() { iso2 = "tr", Name = "turkish" });
			db.Languages.Add(new Language() { iso2 = "bg", Name = "bulgarian" });
			db.Languages.Add(new Language() { iso2 = "el", Name = "greek" });
			db.Languages.Add(new Language() { iso2 = "uk", Name = "ukrainian" });
			db.Languages.Add(new Language() { iso2 = "vi", Name = "vietnamese" });
			db.SaveChanges();
		}
		public static void createDefaultColours()
		{
			ArtifactContext db = new ArtifactContext();
			db.CardColours.Add(new CardColour() { Name = "red" });
			db.CardColours.Add(new CardColour() { Name = "green" });
			db.CardColours.Add(new CardColour() { Name = "blue" });
			db.CardColours.Add(new CardColour() { Name = "black" });
			db.SaveChanges();
		}

	}
}
