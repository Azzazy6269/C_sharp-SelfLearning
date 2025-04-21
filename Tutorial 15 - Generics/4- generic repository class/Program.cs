class Program
{
    static void Main()
    {
        var users = new Repository<User>();
        users.Add(new User(1));
        users.Add(new User(2));
        users.Add(new User(3));
        users.Add(new User(4));
        users.Add(new User(5));
        users.Add(new User(6));
        users.Remove(4);

        var products = new Repository<Product>();
        products.Add(new Product(1));
        products.Add(new Product(2));
        products.Add(new Product(3));
        products.Add(new Product(4));
        products.Add(new Product(5));
        products.Add(new Product(6));
        users.Remove(4);

    }
}

interface IEntity
{
    int id { get; set; }
}

class User : IEntity
{
    public int id { get; set; }

    public User(int ID)
    {
        id = ID;
    }
}

class Product : IEntity
{
    public int id { get; set; }

    public Product(int ID)
    {
        id = ID;
    }
}

class Repository<T> where T : IEntity
{
    private List<T> _list = new List<T>();
    public void Add(T item)
    {
        _list.Add(item);
    }
    public void Remove(int id)
    {
        //int index = _list.FindIndex(item => item.id == id);
        int index = -1;
        for (int i = 0; i < _list.Count; i++)
        {
            if (_list[i].id == id) index = i;
        }
        if(index != -1) _list.RemoveAt(index);
    }
    public T GetById(int id)
    {
        int index = -1;
        for (int i = 0; i < _list.Count; i++)
        {
            if (_list[i].id == id) index = i;
        }
        if (index != -1) return _list[index];
        return default;

    }
    public T[] GetAll()
    {
        T [] arr = new T[_list.Count];
        for (int i = 0; i < _list.Count; i++)
        {
            arr[i] = _list[i];
        }
            return arr;
    }

    
}