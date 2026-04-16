using UnrealBuildTool;

public class Plunder_PartyServerTarget : TargetRules
{
	public Plunder_PartyServerTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Server;
		ExtraModuleNames.Add("Plunder_Party");
	}
}
