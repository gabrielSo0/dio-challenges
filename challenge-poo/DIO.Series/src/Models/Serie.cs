namespace DIO.Series.src
{
    public class Serie : EntitieBase
    {
        private Genre Genre { get; set; }
        private string? Title { get; set; }
        private string? Description { get; set; }
        private int Year { get; set; }
        private bool Removed { get; set; }
        public Serie(int id, Genre genre, string title, string description, int year) : base(id)
        {
            this.Title = title;
            this.Description = description;
            this.Genre = genre;
            this.Year = year;
            this.Removed = false;
        }
        public override string ToString()
        {
            string str = "";

            str += "Genre: " + this.Genre + Environment.NewLine;
            str += "Title: " + this.Title + Environment.NewLine;
            str += "Description: " + this.Description + Environment.NewLine;
            str += "Release date: " + this.Year;
            return str;
            
        }
        public string returnTitle()
        {
            return this.Title;
        }
        public int returnId()
        {
            return this.Id;
        }
        public void Remove()
        {
            this.Removed = true;
        }

    }
}