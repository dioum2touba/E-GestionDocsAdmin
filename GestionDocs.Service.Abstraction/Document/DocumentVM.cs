using GestionDocs.Data.Abstraction.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace GestionDocs.Service.Abstraction.CollectionViewModels
{
    public class DocumentVM
    {
        public Guid Id { get; set; }
        public int Number { get; set; }
        public string Name { get; set; }
        public string Comment { get; set; }
        public Guid AuthorId { get; set; }
        public Guid? ManagerId { get; set; }
        public decimal Sum { get; set; }
        public string State { get; set; }
        public string StateName { get; set; }

        public virtual Employee Author { get; set; }
        public virtual Employee Manager { get; set; }
    }
}
