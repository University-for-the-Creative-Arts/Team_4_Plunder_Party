using UnrealBuildTool;

public class Plunder_PartyEditorTarget : TargetRules
{
	public Plunder_PartyEditorTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Editor;
		ExtraModuleNames.Add("Plunder_Party");
	}
}
