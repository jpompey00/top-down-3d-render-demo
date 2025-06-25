using Godot;
using System;

public partial class TopDownScene : Node2D
{
	[Signal]
	public delegate void WallEnteredViewEventHandler(Wall_1 wall);

	[Signal]
	public delegate void WallExtedViewEventHandler(Wall_1 wall_1);


	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
	}

	public void onBodyEntered(Node2D node2D)
	{

		if (!node2D.GetClass().Equals("CharacterBody2D"))
		{
			if (!node2D.GetParent().GetGroups().Equals(null))
			{
				//detects a wall
				//node2D.GetParent().GetGroups()[0]*
				// GD.Print(node2D.GetParent().GetGroups()[0]);
				if (node2D.GetParent().GetGroups()[0].Equals("Wall"))
				{
					Wall_1 wall = GetNode<Wall_1>(node2D.GetParent().GetPath());
					// GD.Print(wall);
					EmitSignal(SignalName.WallEnteredView, wall);
				}
			}
		}

	}

	public void onBodyExited(Node2D node2D)
	{

		if (!node2D.GetClass().Equals("CharacterBody2D"))
		{
			if (!node2D.GetParent().GetGroups().Equals(null))
			{
				// GD.Print(node2D.GetParent().GetGroups()[0]);
				if (node2D.GetParent().GetGroups()[0].Equals("Wall"))
				{
					Wall_1 wall = GetNode<Wall_1>(node2D.GetParent().GetPath());
					// GD.Print(wall);
					EmitSignal(SignalName.WallExtedView, wall);
				}
			}
		}

	}
	

}
