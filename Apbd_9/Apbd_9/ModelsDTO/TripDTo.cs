using System.Collections;
using APBD_9.Models;

namespace APBD_9.ModelsDto;

public class TripDTo
{
    public string Name { get; set; } = null!;

    public string Description { get; set; } = null!;

    public DateTime Datefrom { get; set; }

    public DateTime Dateto { get; set; }

    public int Maxpeople { get; set; }
    public IEnumerable<ClientDTO> Clients { get; set; }
    public IEnumerable<CountryDTO> Countries { get; set; }
}