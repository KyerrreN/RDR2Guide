using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.DTO
{
    public record BaseDto<T>
    {
        public IEnumerable<T> Data { get; init; }
    }
}
