using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace ServerProva1.Controllers
{
    [ApiController]
    [Route("libri")]
    public class BookController : ControllerBase
    {
        private static readonly Book[] books = new[]
        {
            new Book{
                Id=0,
                ISBN="123",
                Title= "Il signore degli anelli",
                Author="Jrr",
                Classification="1",
                Collocation="a",
                DateAdded=new DateTime(),
                Digitizers="2",
                Edition="3",
                Editor="sss",
                Language="italiano",
                Notes="ggg",
                OtherTitles="hg",
                PageNumber=2,
                PhysicalDescription="fddd",
                PublicationCountry="hggg",
                PublicationDate="25dec",
                PublicationPlace="hghg",
                Series="67",
                Subject="5"

            },
            new Book{
                Id=1,
                ISBN="183",
                Title= "Il signore ",
                Author="mir",
                Classification="4",
                Collocation="b",
                DateAdded=new DateTime(),
                Digitizers="52",
                Edition="53",
                Editor="jss",
                Language="italiano",
                Notes="kkgg",
                OtherTitles="kkkkg",
                PageNumber=222,
                PhysicalDescription="hddd",
                PublicationCountry="rttt",
                PublicationDate="17 dec",
                PublicationPlace="hreff",
                Series="7",
                Subject="5"

            }
        };

       

        [HttpGet]
        public Book[] GetBooks()
        {
            return books;
        }

        [HttpGet("{id}")]
        public Book GetBook(int id)
        {
            return books[id];
        }
    }
}
