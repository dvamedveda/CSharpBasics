using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.models

{
    public class Book
    {
        private string? Author;
        private string? Title;
        private string? Description;

        public string GetAuthor()
        {
            return Author;
        }

        public void SetAuthor(string? Author)
        {
            this.Author = Author;
        }

        public string GetTitle()
        {
            return Title;
        }

        public void SetTitle(string? Title)
        {
            this.Title = Title;
        }

        public string GetDescription()
        {
            return Description;
        }

        public void SetDescription(string? Description)
        {
            this.Description = Description;
        }
    }
}
