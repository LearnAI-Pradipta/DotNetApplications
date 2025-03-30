class RealDbContext : DbContext
{
    //Pointing to Real Db
}

class MockDbContext : DbContext
{
    //Pointing to Real Db
}



//Repository Interface
interface IDbRepository
{
    void GetData();
}


Class RealDbRepository : IDbRepository
{
    private RealDbContext _dbContext;
    FileNotification(RealDbContext dbContext)
    {
    _dbContext = dbContext;
    }
    public void GetData()
    {
        _dbContext.GetData()
    }

}



Class MockDbRepository : IDbRepository
{
    private MockDbContext _dbContext;
    FileNotification(MockDbContext dbContext)
    {
        _dbContext = dbContext;
    }
    public void GetData()
    {
        _dbContext.GetData()
    }

}




// We are injecting Dependency Injecttion 
//program.cs
builder.service.AddScoped(IDbRepository, MockDbContext);