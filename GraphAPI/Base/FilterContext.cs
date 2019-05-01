using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GraphAPI.Base
{
    public class FilterContext<T, E>
    {

        public IEnumerable<T> Data { get; set; }
        public Paging Paging { get; set; }
        public E FilterParams { get; set; }
        public FilterContext(IEnumerable<T> list, int pageSize, int pageNumber)
        {
            var listCount = list.Count();
            Paging = new Paging
            {
                TotalItems = listCount,
                PageSize = pageSize,
                PageNumber = pageNumber,
                TotalPage = listCount / pageSize % 2 == 0
                            ? listCount / pageSize
                            : (listCount / pageSize) + 1
            };

            Data = list.Skip((pageNumber - 1) * pageSize).Take(pageSize);
        }
    }
    public class Paging
    {
        public int TotalItems { get; set; }
        public int PageSize { get; set; }
        public int PageNumber { get; set; }
        public int TotalPage { get; set; }
    }
    public class FilterMastParam
    {
        public int? Lon { get; set; }
        public int? Lat { get; set; }
    }
}
