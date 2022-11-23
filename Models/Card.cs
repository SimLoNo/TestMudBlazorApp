namespace TestMudBlazorApplication.Models
{
	public class Card
	{
		public int CardId { get; set; }
		public string Title { get; set; }
		public string Description { get; set; }
		public string Status { get; set; }
		public User ?AssignedUser { get; set; }
		public Attachment[] ?Attachment { get; set; }

	}
}
