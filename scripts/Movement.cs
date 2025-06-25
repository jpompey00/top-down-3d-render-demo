using Godot;
// using System.Numerics;

public partial class Movement : CharacterBody2D
{

	TopDownScene topDown; 

	[Export]
	public int Speed { get; set; } = 300;

	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		topDown = GetNode<TopDownScene>("../../Top Down Scene");
		// GD.Print(topDown);
	}

	public void GetInput()
	{

		Vector2 inputDirection = Input.GetVector("Left", "Right", "Up", "Down");
		Velocity = inputDirection * Speed;

		LookAt(Velocity + Transform.Origin);
		// GD.Print(Input.GetAxis("Left", "Right"));
	}

	public override void _PhysicsProcess(double delta)
	{

		GetInput();
		MoveAndSlide();

	}

	public void onAreaEntered(Area2D area2D)
	{
		// GD.Print(area2D);
	}

	public void onBodyEntered(Node2D node2D)
	{
		
		if (!node2D.GetClass().Equals("CharacterBody2D"))
		{
			if (!node2D.GetParent().GetGroups().Equals(null))
			{
				//detects a wall
				//node2D.GetParent().GetGroups()[0]*
				GD.Print(node2D.GetParent().GetGroups()[0]);
				if (node2D.GetParent().GetGroups()[0].Equals("Wall"))
				{
					
				}
			}
		}
		
	}

}
