﻿namespace ContactManagerStarter.Provider.Domain.Entities;

public class Contact : Entity
{
    public string Title { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public DateTime DOB { get; set; }
    public virtual List<EmailAddress> EmailAddresses { get; set; } = new List<EmailAddress>();
    public virtual List<Address> Addresses { get; set; } = new List<Address>();
}
