namespace TestMudBlazorApplication.Models
{
	public class Card
	{
		public int CardId { get; set; }
		public int UserId { get; set; }
		public string Title { get; set; } = string.Empty;
		public string CardDescription { get; set; } = string.Empty;
		public string CardStatus { get; set; } = string.Empty;
		public User ?AssignedUser { get; set; }
		public Attachment[] ?Attachment { get; set; }

		public Card()
		{

		}
		public Card(Card card)
		{
			CardId = card.CardId;
			UserId = card.UserId;
			Title = card.Title;
			CardDescription = card.CardDescription;
			CardStatus = card.CardStatus;
			AssignedUser = card.AssignedUser;
			Attachment = card.Attachment;

		}

	}
}
