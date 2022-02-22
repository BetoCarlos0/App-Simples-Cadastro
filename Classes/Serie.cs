namespace App_Simples_Cadastro
{
    public class Serie : EntityBase
    {
        private Genre Genre { get; set; }
		private string Title { get; set; }
		private string Description { get; set; }
		private int Year { get; set; }
        private bool Exclude { get; set; }

        public Serie(int id, Genre genre, string title, string description, int year)
        {
            this.Id = id;
            this.Genre = genre;
            this.Title = title;
            this.Description = description;
            this.Year = year;
            this.Exclude = false;
        }

        public override string ToString()
		{
			// Environment.NewLine https://docs.microsoft.com/en-us/dotnet/api/system.environment.newline?view=netcore-3.1
            string retorno = "";
            retorno += "Gênero: " + this.Genre + Environment.NewLine;
            retorno += "Titulo: " + this.Title + Environment.NewLine;
            retorno += "Descrição: " + this.Description + Environment.NewLine;
            retorno += "Ano de Início: " + this.Year + Environment.NewLine;
            retorno += "Excluido" + this.Exclude;
			return retorno;
		}

        public string ReturnTitle()
		{
			return this.Title;
		}

		public int ReturnId()
		{
			return this.Id;
		}
        public bool ReturnExclude()
		{
			return this.Exclude;
		}
        public void Delete()
        {
            this.Exclude = true;
        }
    }
}