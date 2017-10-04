using ConsumingRESTServiceCRUD_Client.ServiceReference1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Script.Serialization;

namespace ConsumingRESTServiceCRUD_Client.Models
{
    public class BookServiceClient
    {
        String BASE_URL = "http://localhost:1862/BookServices.svc";
        public List<Book> getAllBook()
        {
            //var syncClient = new WebClient();
            //var content = syncClient.DownloadString(BASE_URL+"Books");
            //var json_serializer = new JavaScriptSerializer();
            //return json_serializer.Deserialize<List<Book>>(content);
            BookServicesClient client = new BookServicesClient();
            var rt = new List<Book>();
            (client.GetBookList()).ToList().ForEach(b => rt.Add(new Book() {BookId=b.BookId,ISBN=b.ISBN,Title=b.Title }));
            return rt;
        }
    }
}