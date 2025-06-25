using Godot;
using System;

public partial class ThreeDGameScene : Node3D
{
	// Cube devCube;
	// public PackedScene devCubeScene = ResourceLoader.Load<PackedScene>("res://scenes/objects/cube.tscn");
	Node3D spawnPoint;

	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		spawnPoint = GetNode<Node3D>("SpawnPoint");
		// GD.Print(spawnPoint);
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
	}

	public void WallEnteredView(Wall_1 wall)
	{
		GD.Print("Wall Entered");
		wall.instantiateCube();
		// devCube.OnViewExited += DestroyCube;

		spawnPoint.AddChild(wall.devCube);

	}


	public void WallExtedView(Wall_1 wall)
	{
		GD.Print("Wall Exited");
		DestroyCube(wall.devCube);
	}


	public void DestroyCube(Cube cube)
	{
		cube.QueueFree();
	}

	//will need to link the 2D walls and 3D objects later.





}
