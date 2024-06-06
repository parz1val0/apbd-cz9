using APBD_9.Contex;
using APBD_9.Models;
using APBD_9.ModelsDto;
using Microsoft.EntityFrameworkCore;

namespace APBD_9.Repositories;

public class ClientTripRepository:IClientTripRepository
{
    private Postgres _postgresContext;

    public ClientTripRepository(Postgres postgresContext)
    {
        _postgresContext = postgresContext;
    }

    public async Task<bool> IsClientWithTrip(int clientId)
    {
        return await _postgresContext.ClientTrips.AnyAsync(trip => trip.Idclient == clientId);
    }

    public async Task<int> CreateClientTrip(ClientTrip clientTrip)
    {
        await _postgresContext.ClientTrips.AddAsync(clientTrip);
        await _postgresContext.SaveChangesAsync();
        return 1;
    }
}