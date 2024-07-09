// Strubloid

using UnrealBuildTool;
using System.Collections.Generic;

public class ocapirotoEditorTarget : TargetRules
{
	public ocapirotoEditorTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Editor;
		DefaultBuildSettings = BuildSettingsVersion.V5;

		ExtraModuleNames.AddRange( new string[] { "ocapiroto" } );
	}
}
