using UnrealBuildTool;

public class SteamProjectTarget : TargetRules
{
	public SteamProjectTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;
		ExtraModuleNames.Add("SteamProject");
	}
}
