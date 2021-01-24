var gate = new PrintGate();

var p1 = Task.Run(() =>
{
	var p = new Person() { Name = "Alan", Place = "Africa" };
	while (true)
	{
		gate.Pass(p);
	}
});
var p2 = Task.Run(() =>
{
	var p = new Person() { Name = "Bob", Place = "Bazil" };
	while (true)
	{
		gate.Pass(p);
	}
});

public class Person {
	public string Name {set; get;}
	public string Place {set; get;}
}

public class PrintGate
{
	private string Name {set; get;}
	private string Place {set ;get;}
	
	public void Pass(Person p)
	{
		lock (this)
		{
			this.Name = p.Name;
			this.Place = p.Place;
		
			if (this.Name[0] != this.Place[0])
				Console.WriteLine($"{(this.Name[0] == this.Place[0] ? "" : "[Error]")} {this.Name} - {this.Place}");
		}
	}
}
