class State
{
    public string Name { get; set; } = "";
    public string Abbreviation { get; set; } = "";
    public string Region { get; set; } = "";
}

class State
{
    public string Name { get; set; } = "";
    public string Abbreviation { get; set; } = "";
    public string Region { get; set; } = "";
}

State[] states = {
    new State { Name="Acre", Abbreviation="AC", Region="Norte" },
    new State { Name="Alagoas", Abbreviation="AL", Region="Nordeste" },
    // [...]
    new State { Name="Pará", Abbreviation="PA", Region="Norte" },
    new State { Name="Paraíba", Abbreviation="PB", Region="Nordeste" },
    // [...]
};

City[] cities = {
    new City { Name="Belém", StateAbbreviation="PA" },
    new City { Name="Rio Branco", StateAbbreviation="AC" },
    new City { Name="Maceió", StateAbbreviation="AL" },
    // [...]
};