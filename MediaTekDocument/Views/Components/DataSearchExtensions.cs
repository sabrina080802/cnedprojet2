using MediaTekDocument.Data.Model;

namespace MediaTekDocument.Views.Components
{

    /// <summary>
    /// Extension du SearchArea pour les livres
    /// </summary>
    public class BookSearch : SearchArea<Book>
    {
        public BookSearch()
        {
            DisplayedColumns.Add("Auteur");
            DisplayedColumns.Add("Collection");
        }
    }

    /// <summary>
    /// Extension du SearchArea pour les DVD
    /// </summary>
    public class DvdSearch : SearchArea<Dvd>
    {
        public DvdSearch()
        {
            DisplayedColumns.Add("Realisateur");
            DisplayedColumns.Add("Duree");
        }
    }

    /// <summary>
    /// Extension du SearchArea pour les revues
    /// </summary>
    public class ReviewSearch : SearchArea<Review>
    {
        public ReviewSearch()
        {
            DisplayedColumns.Add("Periodicite");
        }
    }
}
