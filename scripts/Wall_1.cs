using Godot;
using System;

public partial class Wall_1 : Node2D
{
	// Called when the node enters the scene tree for the first time.
	public Cube devCube;
	public PackedScene devCubeScene = ResourceLoader.Load<PackedScene>("res://scenes/objects/cube.tscn");

	public override void _Ready()
	{

	}

	public void instantiateCube()
	{
		devCube = devCubeScene.Instantiate<Cube>();
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
	}
}
