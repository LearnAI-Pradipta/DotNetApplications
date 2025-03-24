/// <summary>
/// //////////////////////////////////////////////Synchronus Programming//////////////////////////////////////////////////////////////////
/// </summary>

Class Service
{
    public string LongRunningFunction()
    {
        // A Long running function
        thread.sleep(150000);
    }

    public string ShortRunningFunction()
    {
        // A Short running function
        thread.sleep(20000);
    }
}

[Route("api/{controller}")]
[ApiController]
Class CallingApiController : ControllerBase
{
    [HttpGet]
    public IActionResult CalilngMethod()
    {
        LongRunningFunction();
        ShortRunningFunction();
    }
}

/// Client Call
Class ClientCall
{
    public void ClientCall()
    {
        using(HttpClient hc = new HttpClient())
        {
            hc.Get(${CallingApiUrl})
        }
    }
}


/// <summary>
/// //////////////////////////////////////////////Asynchronus Programming//////////////////////////////////////////////////////////////////
/// </summary>

Class Service
{
    public async Task<string> LongRunningFunctionAsync()
    {
        // A Long running function
        thread.sleep(150000);
    }

    public async Task<string> ShortRunningFunctionAsync()
    {
        // A Short running function
        thread.sleep(20000);
    }
}

[Route("api/{controller}")]
[ApiController]
Class CallingApiController : ControllerBase
{
    [HttpGet]
    public async async Task<IActionResult> CalilngMethodAsync()
    {
        await LongRunningFunctionAsync();
        await ShortRunningFunctionAsync();
    }
}


/// Client Call

Class ClientCall
{
    public void ClientCall()
    {
        using(HttpClient hc = new HttpClient())
        {
            hc.GetAsync(${CallingApiUrl})
        }
    }
}



/// <summary>
/// //////////////////////////////////////////////Parallel Programming//////////////////////////////////////////////////////////////////
/// </summary>

Class Service
{
    public async Task<string> LongRunningFunctionAsync()
    {
        // A Long running function
        thread.sleep(150000);
        
    }

    public async Task<string> ShortRunningFunctionAsync()
    {
        // A Short running function
        thread.sleep(20000);
    }
}

[Route("api/{controller}")]
[ApiController]
Class CallingApiController : ControllerBase
{
    [HttpGet]
    public async async Task<IActionResult> CalilngMethodAsync()
    {
        var task1 = LongRunningFunctionAsync();
        var task2 = ShortRunningFunctionAsync();

        task1.WhenAll(task1,task2);
    }
}


/// Client Call

Class ClientCall
{
    public void ClientCall()
    {
        using(HttpClient hc = new HttpClient())
        {
            hc.GetAsync(${CallingApiUrl})
        }
    }
}