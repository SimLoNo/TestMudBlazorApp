namespace TestMudBlazorApplication.Models
{
    public class Column
    {
        public int ColumnId { get; set; }
        public string ColumnName { get; set; } = string.Empty;
        public bool NewTaskOpen { get; set; } = false;
        public int ?Order { get; set; }

        public Column(int columnId, string columnName, bool newTaskOpen)
        {
            ColumnId= columnId;
			ColumnName = columnName;
            NewTaskOpen= newTaskOpen;
        }
    }
}
