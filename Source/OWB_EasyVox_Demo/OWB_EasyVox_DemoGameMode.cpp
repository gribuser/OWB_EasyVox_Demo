// Copyright Epic Games, Inc. All Rights Reserved.

#include "OWB_EasyVox_DemoGameMode.h"
#include "OWB_EasyVox_DemoCharacter.h"
#include "UObject/ConstructorHelpers.h"

AOWB_EasyVox_DemoGameMode::AOWB_EasyVox_DemoGameMode()
{
	// set default pawn class to our Blueprinted character
	static ConstructorHelpers::FClassFinder<APawn> PlayerPawnBPClass(TEXT("/Game/ThirdPersonCPP/Blueprints/ThirdPersonCharacter"));
	if (PlayerPawnBPClass.Class != NULL)
	{
		DefaultPawnClass = PlayerPawnBPClass.Class;
	}
}
