using System.Linq;
using ClassLibrary1;
using Godot;
using Godot.Collections;


namespace NewGameProject
{
    public class NewScript : Node
    {
      public override void _Ready()
      {

        // var array = new Array() {"Test", "Test2"}.Cast<string>().ToArray();
        // var json = JsonConvert.SerializeObject(array);
        // GD.Print(json);
        GD.Print(Class1.GetSomething());
        base._Ready();
      }
    }
}
