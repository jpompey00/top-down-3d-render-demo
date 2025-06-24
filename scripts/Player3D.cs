using Godot;
using System;

public partial class Player3D : CharacterBody3D
{
	public PackedScene devCubeScene = ResourceLoader.Load<PackedScene>("res://scenes/objects/cube.tscn");

	public override void _Ready()
	{
		// base._Ready();
	}

	public override void _Process(double delta)
	{
		// if(Input.GetAxis)
	}

    public override void _Input(InputEvent @event)
    {
		if (@event.IsActionPressed("spawn-dev"))
		{
			Node3D devCube = devCubeScene.Instantiate<Node3D>();
			Node3D spawnPoint = GetNode<Node3D>("../SpawnPoint");
			// devCube.Initialize()
			GD.Print(spawnPoint);
			spawnPoint.AddChild(devCube);
			GD.Print("Spawned");
		}
    }




}
