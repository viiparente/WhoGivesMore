using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhoGivesMore.Core.Entities
{
    public abstract class BaseEntity
    {
        protected BaseEntity()
        {
        }

        public int Id { get; private set; }
    }
}
