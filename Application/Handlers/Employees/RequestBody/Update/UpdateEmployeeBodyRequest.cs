﻿using Application.Models.Abstracts;
using Application.Models.Response.Employees;
using MediatR;

namespace Application.Handlers.Employees.RequestBody.Update
{
    public class UpdateEmployeeBodyRequest : IRequest<ResponseBase<UpdateEmployeeResponseItem>>
    {
        public long Id { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Signature { get; set; }
        public bool Active { get; set; }
        public string Position { get; set; }
        public DateTime InsertUpdateDatetime { get; set; }
    }
}
