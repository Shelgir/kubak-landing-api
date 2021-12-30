using KubakLandingApi.Models;

namespace KubakLandingApi.Repo;
public class ViewCounterRepo : IViewCounterRepo
{

    private int count { get; set; }


    public async Task<ViewCounter> GetViewCount()
    {

        count += 1;
        return await Task.FromResult<ViewCounter>(new ViewCounter { count = count });

    }
}
