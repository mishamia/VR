using UnrealBuildTool;

public class vr427Target : TargetRules
{
	public vr427Target(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;
		ExtraModuleNames.Add("vr427");
	}
}
