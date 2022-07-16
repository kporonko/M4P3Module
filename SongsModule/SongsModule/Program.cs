global using SongsModule.Data;
using SongsModule;

using (SongsModuleContext context = new SongsModuleContextFactory().CreateDbContext(Array.Empty<string>()))
{
    IQueries queriesEF = new QueriesEf();
    IQueries queriesADO = new QueriesAdo();

    queriesEF.InnerJoin(context);
    queriesADO.InnerJoin(context);

    queriesEF.SongsBeforeTheYoungestArtist(context);
    queriesADO.SongsBeforeTheYoungestArtist(context);
}

Console.WriteLine("Hello, World!");
