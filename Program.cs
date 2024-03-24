// See https://aka.ms/new-console-template for more information
using WorldApp.Model;

//Console.WriteLine("Hello, World!");

CountryManager manager = new CountryManager();
//manager.Register(new Country()
//{
//    ShortName = "Китай",
//    FullName = "Китайская Народная Республика",
//    Alpha2Code = "CN",
//    Alpha3Code = "CHN",
//    NumericCode = "156",
//    Population = 1425742.676,
//    Area = 9598077
//});
//manager.Register(new Country()
//{
//    ShortName = "Конго",
//    FullName = "Республика Конго",
//    Alpha2Code = "CG",
//    Alpha3Code = "COG",
//    NumericCode = "178",
//    Population = 5970.424,
//    Area = 342000
//});

//TestRegistr(manager);
//TestRegistr(manager);
//TestFindById(manager);
//TestFindById(manager);
//TestDeleteById(manager);
//TestListAll(manager);
//TestUpdateById(manager);
//TestListAll(manager);

//TestFindByCode(manager);
//Console.WriteLine();
//TestFindByCode(manager);
//Console.WriteLine();
//TestFindByCode(manager);
//Console.WriteLine();

TestListOrderBy(manager);
Console.WriteLine();
TestListOrderBy(manager);
Console.WriteLine();

void TestListOrderBy(CountryManager manager)
{
    Console.WriteLine("1 - order by id asc");
    Console.WriteLine("2 - order by id desc");
    Console.WriteLine("3 - order by short name asc");
    Console.WriteLine("4 - order by short name desc");
    Console.WriteLine("5 - order by full name asc");
    Console.WriteLine("6 - order by full name desc");
    Console.WriteLine("7 - order by alpha2 code asc");
    Console.WriteLine("8 - order by alpha2 code desc");
    Console.WriteLine("9 - order by alpha3 code asc");
    Console.WriteLine("10 - order by alpha3 code desc");
    Console.WriteLine("11 - order by numeric code asc");
    Console.WriteLine("12 - order by numeric code desc");
    Console.WriteLine("13 - order by population asc");
    Console.WriteLine("14 - order by population desc");
    Console.WriteLine("15 - order by area asc");
    Console.WriteLine("16 - order by area desc");
    Console.Write("Enter number: ");
    int num = Convert.ToInt32(Console.ReadLine());
    switch (num)
    {
        case 1:
            manager.ListOrderBy(OrderBy.OrderByIdAsc).ForEach(Console.WriteLine);
            return;
        case 2:
            manager.ListOrderBy(OrderBy.OrderByIdDesc).ForEach(Console.WriteLine);
            return;
        case 3:
            manager.ListOrderBy(OrderBy.OrderByShortNameAsc).ForEach(Console.WriteLine);
            return;
        case 4:
            manager.ListOrderBy(OrderBy.OrderByShortNameDesc).ForEach(Console.WriteLine);
            return;
        case 5:
            manager.ListOrderBy(OrderBy.OrderByFullNameAsc).ForEach(Console.WriteLine);
            return;
        case 6:
            manager.ListOrderBy(OrderBy.OrderByFullNameDesc).ForEach(Console.WriteLine);
            return;
        case 7:
            manager.ListOrderBy(OrderBy.OrderByAlpha2CodeAsc).ForEach(Console.WriteLine);
            return;
        case 8:
            manager.ListOrderBy(OrderBy.OrderByAlpha2CodeDesc).ForEach(Console.WriteLine);
            return;
        case 9:
            manager.ListOrderBy(OrderBy.OrderByAlpha3CodeAsc).ForEach(Console.WriteLine);
            return;
        case 10:
            manager.ListOrderBy(OrderBy.OrderByAlpha3CodeDesc).ForEach(Console.WriteLine);
            return;
        case 11:
            manager.ListOrderBy(OrderBy.OrderByNumericCodeAsc).ForEach(Console.WriteLine);
            return;
        case 12:
            manager.ListOrderBy(OrderBy.OrderByNumericCodeDesc).ForEach(Console.WriteLine);
            return;
        case 13:
            manager.ListOrderBy(OrderBy.OrderByPopulationAsc).ForEach(Console.WriteLine);
            return;
        case 14:
            manager.ListOrderBy(OrderBy.OrderByPopulationDesc).ForEach(Console.WriteLine);
            return;
        case 15:
            manager.ListOrderBy(OrderBy.OrderByAreaAsc).ForEach(Console.WriteLine);
            return;
        case 16:
            manager.ListOrderBy(OrderBy.OrderByAreaDesc).ForEach(Console.WriteLine);
            return;
    }
}

void TestRegistr(CountryManager manager)
{
    Console.Write("Enter short name country: ");
    string shortName = Console.ReadLine();
    Console.Write("Enter full name: ");
    string fullName = Console.ReadLine();
    Console.Write("Enter Alpha2 Code: ");
    string alpha2 = Console.ReadLine();
    Console.Write("Enter Alpha3 Code: ");
    string alpha3 = Console.ReadLine();
    Console.Write("Enter Numeric Code: ");
    string numeric = Console.ReadLine();
    Console.Write("Enter population(th.p.): ");
    double population = Convert.ToDouble(Console.ReadLine());
    Console.Write("Enter area(sq.k.): ");
    double area = Convert.ToDouble(Console.ReadLine());
    Country country = new Country()
    {
        ShortName = shortName,
        FullName = fullName,
        Alpha2Code = alpha2,
        Alpha3Code = alpha3,
        NumericCode = numeric,
        Population = population,
        Area = area
    };
    manager.Register(country);
    Console.WriteLine($"Aded country: {country}");
    Console.WriteLine();
}

void TestListAll(CountryManager manager)
{
    List<Country> countries = manager.ListAll();
    countries.ForEach(Console.WriteLine);
    Console.WriteLine();
}

void TestFindById(CountryManager manager)
{
    Console.Write("Enetr id (finded): ");
    int id = Convert.ToInt32(Console.ReadLine());
    Country country = manager.FindById(id);
    if(country != null)
    {
        Console.WriteLine(country);
    }
    else
    {
        Console.WriteLine($"Country with id = {id} does not exists");
    }
    Console.WriteLine();
}

void TestDeleteById(CountryManager manager)
{
    Console.Write("Enetr id (deleted): ");
    int id = Convert.ToInt32(Console.ReadLine());
    try
    {        
        manager.DeleteById(id);
        Console.WriteLine($"Country with id = {id} deleted");
    }
    catch
    {
        Console.WriteLine($"Country with id = {id} does not exists");
    }
    Console.WriteLine();
}

void TestUpdateById(CountryManager manager)
{
    Console.Write("Enetr id (updated): ");
    int id = Convert.ToInt32(Console.ReadLine());
    Console.Write("Enter short name country: ");
    string shortName = Console.ReadLine();
    Console.Write("Enter full name: ");
    string fullName = Console.ReadLine();
    Console.Write("Enter Alpha2 Code: ");
    string alpha2 = Console.ReadLine();
    Console.Write("Enter Alpha3 Code: ");
    string alpha3 = Console.ReadLine();
    Console.Write("Enter Numeric Code: ");
    string numeric = Console.ReadLine();
    Console.Write("Enter population(th.p.): ");
    double population = Convert.ToDouble(Console.ReadLine());
    Console.Write("Enter area(sq.k.): ");
    double area = Convert.ToDouble(Console.ReadLine());
    Country country = new Country()
    {
        Id = id,
        ShortName = shortName,
        FullName = fullName,
        Alpha2Code = alpha2,
        Alpha3Code = alpha3,
        NumericCode = numeric,
        Population = population,
        Area = area
    };
    try
    {
        manager.UpdateById(country);
        Console.WriteLine($"updated: {country}");
    }
    catch
    {
        Console.WriteLine($"Country with id = {id} does not exists");
    }
    Console.WriteLine();
}

void TestFindByCode(CountryManager manager)
{
    Console.WriteLine("1 - Alpha2 code");
    Console.WriteLine("2 - Alpha3 code");
    Console.WriteLine("3 - Numeric code");
    Console.Write("Enter code spec.: ");
    int spec = Convert.ToInt32(Console.ReadLine());
    Console.Write("Enter code: ");
    string code = Console.ReadLine();    
    switch (spec)
    {
        case 1:
            Console.WriteLine(manager.FindByCode(code, CodeSpec.Alpha2Code));
            return;
        case 2:
            Console.WriteLine(manager.FindByCode(code, CodeSpec.Alpha3Code));
            return;
        case 3:
            Console.WriteLine(manager.FindByCode(code, CodeSpec.NumericCode));
            return;
        default:
            Console.WriteLine("incorrect input");
            return;
    }    
}


