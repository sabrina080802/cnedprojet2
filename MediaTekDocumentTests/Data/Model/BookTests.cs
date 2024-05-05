using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MediaTekDocument.Data.Model.Tests
{
    public class BookTests
    {
        /** Document data */
        private const string id = "00001";
        private const string title = "Mon super livre";
        private const string image = "/mon-super-chemin/vers-mon-image.png";
        private const string idRayon = "00005";
        private const string idPublic = "10005";
        private const string idGenre = "20005";

        /** Book data */
        private const string isbn = "0DZA5R1";
        private const string author = "Cathoche de midi-six";
        private const string collection = "Collection405";


        private static readonly Book book = new Book(id, title, image, idRayon, idPublic, idGenre, isbn, author, collection);

        [TestMethod()]
        public void BookTest()
        {
            Assert.AreEqual(id, book.Id, "Success : id valorisé");
            Assert.AreEqual(title, book.Titre, "Success : titre valorisé");
            Assert.AreEqual(image, book.Image, "Success : image valorisé");
            Assert.AreEqual(idRayon, book.IdRayon, "Success : idRayon valorisé");
            Assert.AreEqual(idPublic, book.IdPublic, "Success : idPublic valorisé");
            Assert.AreEqual(idGenre, book.IdGenre, "Success : idGenre valorisé");
            Assert.AreEqual(isbn, book.ISBN, "Success : isbn valorisé");
            Assert.AreEqual(author, book.Auteur, "Success : auteur valorisé");
            Assert.AreEqual(collection, book.Collection, "Success : collection valorisé");
        }
    }
}