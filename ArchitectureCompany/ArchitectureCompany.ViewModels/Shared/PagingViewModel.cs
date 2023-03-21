using System;

namespace ArchitectureCompany.WebApp.Models
{
    public class PagingViewModel
    {
        public PagingViewModel(int itemsPerPage = 5, string action = "Index")
        {
            this.ItemsPerPage = itemsPerPage;
            this.Action = action;
            this.PageNumber = 1;
        }

        public int PageNumber { get; set; }

        public bool HasPreviousPage => this.PageNumber > 1;

        public int PreviousPageNumber => this.PageNumber - 1;

        public bool HasNextPage => this.PageNumber < this.PagesCount;

        public int NextPageNumber => this.PageNumber + 1;

        public int PagesCount => (int)Math.Ceiling((double)this.ElementsCount / this.ItemsPerPage);

        public int ElementsCount { get; set; }

        public int ItemsPerPage { get; set; }

        public string Action { get; set; }
    }
}
