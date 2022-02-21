interface Myinterface
{
    int x{ get; set; }
    string myString { get; set; }
    bool boo { get; set; }
}
public class myClass : Myinterface
{
   public int x {
        get { return x; }
        set{ x= 1; }
        
    }
    public string myString
    {
        get { return myString; }
        set { myString = "Hello api"; }
    }
    public bool boo
    {
        get { return boo; }
        set { boo = true; }
    }
    public delegate void resultReturn(object source, EventArgs args);

    public event resultReturn result;

    public void prepareResult()
    {
        Onresult();
    }

    protected virtual void Onresult()
    {
        if(result != null)
        {
            result(this, null);
        }
    }

}
class SampleCollection<T>
{
    private T[] arr = new T[100];
    public T this[int i] {
        get { return arr[i]; }
        set { arr[i] = value; }
    }
}
public class program
{
    static void Main(string[] arg)
    {
        var myClass = new myClass { x = 1, myString = "hello c#", boo = false,};
        var stringCollection = new SampleCollection<string>();
        stringCollection[0] = "Hello c#";
        Console.WriteLine(stringCollection[0]);
    }
}

