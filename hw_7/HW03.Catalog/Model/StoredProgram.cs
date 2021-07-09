using System;
using System.Collections.Generic;
using System.Text;

namespace HW03.Catalog.Model
{
    class StoredProgram : StorageItem
    {
        public StoredProgram(string name, string code, string category, int size) : base(name, code, category, size) { }
    }
}
