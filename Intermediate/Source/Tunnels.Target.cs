using UnrealBuildTool;

public class TunnelsTarget : TargetRules
{
	public TunnelsTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.V2;
		Type = TargetType.Game;
		ExtraModuleNames.Add("Tunnels");
	}
}
