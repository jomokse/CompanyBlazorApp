namespace CompanyBlazorApp.Models;

public class Root
{
    public int totalResults { get; set; }
    public List<Company>? companies { get; set; }
}

public class Company
{
    public BusinessId? businessId { get; set; }
    public EuId? euId { get; set; }
    public List<Name>? names { get; set; }
    public MainBusinessLine? mainBusinessLine { get; set; }
    public Website? website { get; set; }
    public List<CompanyForm>? companyForms { get; set; }
    public List<CompanySituation>? companySituations { get; set; }
    public List<RegisteredEntry>? registeredEntries { get; set; }
    public List<Address>? addresses { get; set; }
    public string? tradeRegisterStatus { get; set; }
    public string? status { get; set; }
    public DateTime registrationDate { get; set; }
    public DateTime endDate { get; set; }
    public string? lastModified { get; set; }
}

public class BusinessId
{
    public string? value { get; set; }
    public DateTime registrationDate { get; set; }
    public string? source { get; set; }
}

public class EuId
{
    public string? value { get; set; }
    public string? source { get; set; }
}

public class Name
{
    public string? name { get; set; }
    public string? type { get; set; }
    public DateTime registrationDate { get; set; }
    public DateTime endDate { get; set; }
    public int version { get; set; }
    public string? source { get; set; }
}

public class MainBusinessLine
{
    public string? type { get; set; }
    public List<Description>? descriptions { get; set; }
    public string? typeCodeSet { get; set; }
    public DateTime registrationDate { get; set; }
    public string? source { get; set; }
}

public class Description
{
    public string? languageCode { get; set; }
    public string? description { get; set; }
}

public class Website
{
    public string? url { get; set; }
    public DateTime registrationDate { get; set; }
    public string? source { get; set; }
}

public class CompanyForm
{
    public string? type { get; set; }
    public List<Description>? descriptions { get; set; }
    public DateTime registrationDate { get; set; }
    public DateTime endDate { get; set; }
    public int version { get; set; }
    public string? source { get; set; }
}

public class CompanySituation
{
    public string? type { get; set; }
    public DateTime registrationDate { get; set; }
    public DateTime endDate { get; set; }
    public string? source { get; set; }
}

public class RegisteredEntry
{
    public string? type { get; set; }
    public List<Description>? descriptions { get; set; }
    public DateTime registrationDate { get; set; }
    public DateTime endDate { get; set; }
    public string? register { get; set; }
    public string? authority { get; set; }
}

public class Address
{
    public int type { get; set; }
    public string? street { get; set; }
    public string? postCode { get; set; }
    public List<PostOffice>? postOffices { get; set; }
    public string? postOfficeBox { get; set; }
    public string? buildingNumber { get; set; }
    public string? entrance { get; set; }
    public string? apartmentNumber { get; set; }
    public string? apartmentIdSuffix { get; set; }
    public string? co { get; set; }
    public string? country { get; set; }
    public string? freeAddressLine { get; set; }
    public DateTime registrationDate { get; set; }
    public string? source { get; set; }
}

public class PostOffice
{
    public string? city { get; set; }
    public string? languageCode { get; set; }
    public string? municipalityCode { get; set; }
}
