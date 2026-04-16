using UnrealBuildTool;

public class Plunder_PartyClientTarget : TargetRules
{
	public Plunder_PartyClientTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Client;
		ExtraModuleNames.Add("Plunder_Party");
	}
}
