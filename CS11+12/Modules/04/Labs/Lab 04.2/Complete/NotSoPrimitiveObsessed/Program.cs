Customer customer = new()
{
    Id = new CustomerId(),
    FirstName = "Keanu",
    LastName = "Reaves",
    Membership = new ClubMembership(),
    Email = EmailAddress.Parse("keanu@reaves.com"),
    PhoneNumber = PhoneNumber.Parse("1800666777")
};

Product product = new()
{
    Id = new ProductId(1),
    Name = "Continuum Transfunctioner",
    VendorId = new VendorId(87),
    Price = 42
};

ProductShipper.Ship(customer, product);

// Update email address
if( EmailAddress.TryParse("super@paulmull.in", out EmailAddress? newEmailAddress))
{
    customer.Email = newEmailAddress;
}