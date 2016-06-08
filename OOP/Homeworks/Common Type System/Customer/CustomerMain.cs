using System;
using System.Collections.Generic;

public class CustomerMain
{
    private static void Main()
    {
        var zaNapred = new Payment("Deset", 10);

        var dude = new Customer(
            "Cool",
            "Dude",
            +359888888888,
            +359888888889,
            "dude@abv.bg",
            CustomerType.OneTime,
            zaNapred);

        var man = dude.Clone() as Customer;
        man.FirstName = "Cool";
        man.LastName = "Man";

        Console.WriteLine(man);
        Console.WriteLine(dude);

        var sirStenly = new Customer(
            "Sir Stenly ",
            "Rois",
            +35988878787,
            +35987798798,
            "bashtata@gmail.com",
            CustomerType.Diamond);

        var newSir = sirStenly.Clone() as Customer;
        newSir.Id = 8234353535;
        newSir.LastName = "Bakarkov";

        var customers = new List<Customer> { dude, man, sirStenly, newSir };
        customers.Sort();

        Console.WriteLine(string.Join(", ", customers));
    }
}