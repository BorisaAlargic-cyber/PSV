using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PSV.Model
{
    public class Pager
    {
        private int page = 0;
        private int perPage = 20;
        private string search = string.Empty;

        public Pager()
        {

        }

        public Pager(int page, int perPage, string search)
        {
            this.page = page;
            this.perPage = perPage;
            this.search = search;
        }

        public int Page
        {
            get { return page; }
            set { page = value; }
        }

        public int PerPage
        {
            get { return perPage; }
            set { perPage = value; }
        }

        public string Search
        {
            get { return search; }
            set { search = value; }
        }
    }
}
