﻿namespace CCiG_WebApi.Models.Worker
{
    public class EmployeeModel
    {
        public int Id { get; set; }
        public string Email { get; set; } = default!;
        public string FirstName { get; set; } = default!;
        public string LastName { get; set; } = default!;
    }
}
