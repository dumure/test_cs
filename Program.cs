using test_cs;

StandardUserBuilder standardUserBuilder = new StandardUserBuilder();
User user = standardUserBuilder.AddFirstName("Rasul")
                               .AddLastName("Umud")
                               .AddBirthday(new DateTime(2007, 12, 29))
                               .AddAddress("asdadas")
                               .AddPhone("+2131321231")
                               .AddEmail("adadasda@gmail.com")
                               .AddMiddleName("Sadas")
                               .Build();


Console.WriteLine(user.Birthday);