using System;
using System.Collections.Generic;
using System.Text;

namespace RelTransCustomer.Application.Wrappers;

public class PagedResponse<T> : Response<T>
{
    public int PageNumber { get; set; }
    public int PageSize { get; set; }

    public PagedResponse(T data, int pageNumber, int pageSize)
    {
        this.PageNumber = pageNumber;
        this.PageSize = pageSize;
        this.Result = data;
        this.Message = string.Empty;
        this.Succeeded = true;
    }
}
