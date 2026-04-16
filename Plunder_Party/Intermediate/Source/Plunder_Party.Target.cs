using UnrealBuildTool;

public class Plunder_PartyTarget : TargetRules
{
	public Plunder_PartyTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Game;
		ExtraModuleNames.Add("Plunder_Party");
	}
}
