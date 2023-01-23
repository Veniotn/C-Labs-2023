namespace SchoolTracker;

public interface IGraduate
{
    void Graduate();
}

public class Registrar
{
    private List<IGraduate> grads;

    
    public Registrar(List<IGraduate> grads)
    {
        this.grads = grads;                           
    }



    public void GraduateAll()
    {
        foreach (var grad in grads)
        {
            grad.Graduate();
        }
    }
}