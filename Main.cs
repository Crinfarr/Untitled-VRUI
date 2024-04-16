using Godot;
using GodotPlugins.Game;
using System;

public partial class Main:Node3D
{
	private XRInterface _xrInterface;
	// Called when the node enters the scene tree for the first time.
	public override void _Ready() {
		_xrInterface = XRServer.FindInterface("OpenXR");
		if (_xrInterface != null && _xrInterface.IsInitialized()) {
			GD.Print("OpenXR Initialized");

			DisplayServer.WindowSetVsyncMode(DisplayServer.VSyncMode.Disabled);

			GetViewport().UseXR = true;

			// Change engine physics rate to not lag
			Engine.PhysicsTicksPerSecond = 120;
			
		} else {
			GD.PrintErr("OpenXR initialization failed");
		}
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
	}
}
