using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace comic_book_gallery.Models
{
    public class ComicBook
    {
        public int Id { get; set; }
        public string SeriesTitle { get; set; }
        public string IssueNumber { get; set; }
        public string Description { get; set; }
        public Artist[] Artists { get; set; }
        public bool Favorite { get; set; }

        public string DisplayTextc
        {
            get
            {
                return SeriesTitle + "#" + IssueNumber;

            }
        }
        // series-title-issuenumber.jpg
        public string CoverImageFileName
        {
            get
            {
                return SeriesTitle.Replace("", "-")
                 .ToLower() + "-" + IssueNumber + ".jpg";
            }
        }
    }


}
}