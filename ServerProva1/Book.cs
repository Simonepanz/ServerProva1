using System;
using System.ComponentModel.DataAnnotations;

namespace ServerProva1
{
    public class Book
    {
        public int Id { get; set; }

        // Metadati Unicam
        [Required]
        [StringLength(255)]
        public string ISBN { get; set; }

        [Required]
        [StringLength(255)]
        public string Title { get; set; }

        [Required]
        [StringLength(255)]
        public string Author { get; set; }

        public string PhysicalDescription { get; set; }

        public string Language { get; set; }

        public string Subject { get; set; }

        public string Edition { get; set; }

        public string Editor { get; set; }

        public string PublicationDate { get; set; }

        public string PublicationCountry { get; set; }

        public string PublicationPlace { get; set; }

        public string Series { get; set; }

        public string Collocation { get; set; }

        public string OtherTitles { get; set; }

        public string Classification { get; set; }

        public string Notes { get; set; }


        // Campi di servizio
        public int PageNumber { get; set; }

        [Display(Name = "Date added")]
        public DateTime DateAdded { get; set; }

        

        // Extra
        public string Digitizers { get; set; }
    }
}