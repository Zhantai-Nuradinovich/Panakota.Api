
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conscious.Choice.OnionApi.Domain.Entities
{
    public class TSetting: BaseEntity
    {
        public string Name { get; set; }
        public string Value { get; set; }
    }
}