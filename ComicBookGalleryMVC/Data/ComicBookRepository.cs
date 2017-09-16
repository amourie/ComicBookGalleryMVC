using ComicBookGalleryMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace ComicBookGalleryMVC.Data
{
    public class ComicBookRepository
    {

        private static ComicBook[] _comicBooks = new ComicBook[]
        {

             new ComicBook()
            {
                SeriesTitle = "The Amazing Spider Man",
                IssueNumber = 700,
                DescriptionHtml = "<p>Final issue!Witness the final hours of Doctor Octopus' life and his one, last, great act of revenge! Even if Spider-Man survives... <strong>will Peter Parker?</strong></p>",
                Artists = new Artist[]
              {
                    new Artist() { Name = "Dan Slott", Role = "Script" },
                    new Artist() { Name = "Humberto Ramos", Role = "Pencils" },
                    new Artist() { Name = "Victor Olazaba", Role = "Inks" },
                    new Artist() { Name = "Edgar Delgado", Role = "Letters" },
                    new Artist() { Name = "Chris Eliopoulos", Role = "Colours" }
              },
                Id = 1
            },
              new ComicBook()
            {
                SeriesTitle = "The Amazing Spider Man",
                IssueNumber = 657,
                DescriptionHtml = "<p>Final issue!Witness the final hours of Doctor Octopus' life and his one, last, great act of revenge! Even if Spider-Man survives... <strong>will Peter Parker?</strong></p>",
                Artists = new Artist[]
              {
                    new Artist() { Name = "Dan Slott", Role = "Script" },
                    new Artist() { Name = "Humberto Ramos", Role = "Pencils" },
                    new Artist() { Name = "Victor Olazaba", Role = "Inks" },
                    new Artist() { Name = "Edgar Delgado", Role = "Letters" },
                    new Artist() { Name = "Chris Eliopoulos", Role = "Colours" }
              },
                Id = 2
            },

               new ComicBook()
            {
                SeriesTitle = "Bone",
                IssueNumber = 50,
                DescriptionHtml = "<p>Final issue!Witness the final hours of Doctor Octopus' life and his one, last, great act of revenge! Even if Spider-Man survives... <strong>will Peter Parker?</strong></p>",
                Artists = new Artist[]
              {
                    new Artist() { Name = "Dan Slott", Role = "Script" },
                    new Artist() { Name = "Humberto Ramos", Role = "Pencils" },
                    new Artist() { Name = "Victor Olazaba", Role = "Inks" },
                    new Artist() { Name = "Edgar Delgado", Role = "Letters" },
                    new Artist() { Name = "Chris Eliopoulos", Role = "Colours" }
              },
                Id = 3
            }
    };


        public ComicBook[] GetComicBooks()
        {
            return _comicBooks;
        }

        public ComicBook GetComicBook(int id)
        {

            ComicBook comicBookReturn = null;


            foreach (var comicBook in _comicBooks)
            {
                if (comicBook.Id == id)
                {
                    comicBookReturn = comicBook;
                    break;
                }
            }

             return comicBookReturn;
        }
    }
}