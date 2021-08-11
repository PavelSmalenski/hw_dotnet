using System;
using System.Collections.Generic;
using System.Text;

namespace HW01.GenericRepo.Models
{
    interface IRepositoryItem
    {
        public Guid Id { get; set; }

        public void Update(IRepositoryItem item);
    }
}
