using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace MVCCore.Models
{
	public class CardSet
	{
		[Key]
		public int CardSetId { get; set; }
		public string SetId { get; set; }
		public IList<Card> Cards { get; set; }
	}
	public class Language
	{
		[Key]
		public int LanguageId { get; set; }
		public string Name { get; set; }
		public string iso2 { get; set; }
	}
	public class CardColour
	{
		[Key]
		public int CardColourId { get; set; }
		public string Name { get; set; }
	}
	public class CardType
	{
		[Key]
		public int CardTypeId { get; set; }
		public string Name { get; set; }
	}
	public class CardReferenceType
	{
		[Key]
		public int CardReferenceTypeId { get; set; }
		public string Name { get; set; }
	}
	public class Card
	{
		[Key]
		public int CardId { get; set; }
		public int Attack { get; set; }
		public int Armor { get; set; }
		public int HitPoints { get; set; }

		public int cardSetId { get; set; }
		public CardSet CardSet { get; set; }
	}

}
