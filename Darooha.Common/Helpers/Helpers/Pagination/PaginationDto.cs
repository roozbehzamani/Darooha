using Darooha.Common.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace Darooha.Common.Helpers.Helpers.Pagination
{
    public class PaginationDto
    {
        public int PageNumber { get; set; } = 0;

        private int pageSize = 10;

        public int PageSize
        {
            get { return pageSize; }
            set { pageSize = (value > Constants.MaxPageSize) ? Constants.MaxPageSize : value; }
        }
    }
}
