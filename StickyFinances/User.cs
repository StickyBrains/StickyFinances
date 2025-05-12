namespace StickyFinances;

public class User
{
    private String name;
    private long id;

    public User()
    {
        name = "";
        id = -1;
    }
    public User(String name, long id)
    {
        this.name = name;
        this.id = id;
    }
}