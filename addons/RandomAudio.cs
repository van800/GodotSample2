using Godot;

namespace NewGameProject.addons
{
  [Tool]
  public class RandomAudio : EditorPlugin
  {
    public override void _EnterTree()
    {
      AddCustomType("RandomAudioStreamPlayer", "Node",
        ResourceLoader.Load<Script>("res://addons/RandomAudio/RandomAudioStreamPlayer.cs"),
        ResourceLoader.Load<Texture>("res://addons/RandomAudio/RandomAudioIcon.svg"));
      AddCustomType("RandomAudioStreamPlayer2D", "Node2D",
        ResourceLoader.Load<Script>("res://addons/RandomAudio/RandomAudioStreamPlayer2D.cs"), 
        ResourceLoader.Load<Texture>("res://addons/RandomAudio/RandomAudioIcon2D.svg"));
    }

    public override void _ExitTree()
    {
      RemoveCustomType("RandomAudioStreamPlayer");
      RemoveCustomType("RandomAudioStreamPlayer2D");
    }
  }
}