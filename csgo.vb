' 2019-02-16 10:40:14.085054400 UTC

Namespace hazedumper
    Public Const timestamp as Integer = &H5C67E88E
    Public Shared Class netvars
        Public Const cs_gamerules_data as Integer = &H0
        Public Const m_ArmorValue as Integer = &HB328
        Public Const m_Collision as Integer = &H31C
        Public Const m_CollisionGroup as Integer = &H474
        Public Const m_Local as Integer = &H2FBC
        Public Const m_MoveType as Integer = &H25C
        Public Const m_OriginalOwnerXuidHigh as Integer = &H31B4
        Public Const m_OriginalOwnerXuidLow as Integer = &H31B0
        Public Const m_SurvivalGameRuleDecisionTypes as Integer = &H1318
        Public Const m_SurvivalRules as Integer = &HCF0
        Public Const m_aimPunchAngle as Integer = &H302C
        Public Const m_aimPunchAngleVel as Integer = &H3038
        Public Const m_angEyeAnglesX as Integer = &HB32C
        Public Const m_angEyeAnglesY as Integer = &HB330
        Public Const m_bBombPlanted as Integer = &H99D
        Public Const m_bFreezePeriod as Integer = &H20
        Public Const m_bGunGameImmunity as Integer = &H3928
        Public Const m_bHasDefuser as Integer = &HB338
        Public Const m_bHasHelmet as Integer = &HB31C
        Public Const m_bInReload as Integer = &H3285
        Public Const m_bIsDefusing as Integer = &H3914
        Public Const m_bIsQueuedMatchmaking as Integer = &H74
        Public Const m_bIsScoped as Integer = &H390A
        Public Const m_bIsValveDS as Integer = &H75
        Public Const m_bSpotted as Integer = &H93D
        Public Const m_bSpottedByMask as Integer = &H980
        Public Const m_clrRender as Integer = &H70
        Public Const m_dwBoneMatrix as Integer = &H26A8
        Public Const m_fAccuracyPenalty as Integer = &H3304
        Public Const m_fFlags as Integer = &H104
        Public Const m_flC4Blow as Integer = &H2990
        Public Const m_flDefuseCountDown as Integer = &H29AC
        Public Const m_flDefuseLength as Integer = &H29A8
        Public Const m_flFallbackWear as Integer = &H31C0
        Public Const m_flFlashDuration as Integer = &HA3E0
        Public Const m_flFlashMaxAlpha as Integer = &HA3DC
        Public Const m_flLastBoneSetupTime as Integer = &H2924
        Public Const m_flLowerBodyYawTarget as Integer = &H3A74
        Public Const m_flNextAttack as Integer = &H2D70
        Public Const m_flNextPrimaryAttack as Integer = &H3218
        Public Const m_flSimulationTime as Integer = &H268
        Public Const m_flTimerLength as Integer = &H2994
        Public Const m_hActiveWeapon as Integer = &H2EF8
        Public Const m_hMyWeapons as Integer = &H2DF8
        Public Const m_hObserverTarget as Integer = &H3388
        Public Const m_hOwner as Integer = &H29CC
        Public Const m_hOwnerEntity as Integer = &H14C
        Public Const m_iAccountID as Integer = &H2FC8
        Public Const m_iClip1 as Integer = &H3244
        Public Const m_iCompetitiveRanking as Integer = &H1A84
        Public Const m_iCompetitiveWins as Integer = &H1B88
        Public Const m_iCrosshairId as Integer = &HB394
        Public Const m_iEntityQuality as Integer = &H2FAC
        Public Const m_iFOV as Integer = &H31E4
        Public Const m_iFOVStart as Integer = &H31E8
        Public Const m_iGlowIndex as Integer = &HA3F8
        Public Const m_iHealth as Integer = &H100
        Public Const m_iItemDefinitionIndex as Integer = &H2FAA
        Public Const m_iItemIDHigh as Integer = &H2FC0
        Public Const m_iMostRecentModelBoneCounter  as Integer = &H2690
        Public Const m_iObserverMode as Integer = &H3374
        Public Const m_iShotsFired as Integer = &HA370
        Public Const m_iState as Integer = &H3238
        Public Const m_iTeamNum as Integer = &HF4
        Public Const m_lifeState as Integer = &H25F
        Public Const m_nFallbackPaintKit as Integer = &H31B8
        Public Const m_nFallbackSeed as Integer = &H31BC
        Public Const m_nFallbackStatTrak as Integer = &H31C4
        Public Const m_nForceBone as Integer = &H268C
        Public Const m_nTickBase as Integer = &H342C
        Public Const m_rgflCoordinateFrame as Integer = &H444
        Public Const m_szCustomName as Integer = &H303C
        Public Const m_szLastPlaceName as Integer = &H35B0
        Public Const m_thirdPersonViewAngles as Integer = &H31D8
        Public Const m_vecOrigin as Integer = &H138
        Public Const m_vecVelocity as Integer = &H114
        Public Const m_vecViewOffset as Integer = &H108
        Public Const m_viewPunchAngle as Integer = &H3020
    End Class
    Public Shared Class signatures
        Public Const clientstate_choked_commands as Integer = &H4D28
        Public Const clientstate_delta_ticks as Integer = &H174
        Public Const clientstate_last_outgoing_command as Integer = &H4D24
        Public Const clientstate_net_channel as Integer = &H9C
        Public Const convar_name_hash_table as Integer = &H2F0F8
        Public Const dwClientState as Integer = &H58BCFC
        Public Const dwClientState_GetLocalPlayer as Integer = &H180
        Public Const dwClientState_IsHLTV as Integer = &H4D40
        Public Const dwClientState_Map as Integer = &H28C
        Public Const dwClientState_MapDirectory as Integer = &H188
        Public Const dwClientState_MaxPlayer as Integer = &H388
        Public Const dwClientState_PlayerInfo as Integer = &H52B8
        Public Const dwClientState_State as Integer = &H108
        Public Const dwClientState_ViewAngles as Integer = &H4D88
        Public Const dwEntityList as Integer = &H4CDB00C
        Public Const dwForceAttack as Integer = &H310C710
        Public Const dwForceAttack2 as Integer = &H310C71C
        Public Const dwForceBackward as Integer = &H310C6C8
        Public Const dwForceForward as Integer = &H310C6D4
        Public Const dwForceJump as Integer = &H517E1C4
        Public Const dwForceLeft as Integer = &H310C6EC
        Public Const dwForceRight as Integer = &H310C6E0
        Public Const dwGameDir as Integer = &H631F70
        Public Const dwGameRulesProxy as Integer = &H51F0504
        Public Const dwGetAllClasses as Integer = &HCEE9D4
        Public Const dwGlobalVars as Integer = &H58BA00
        Public Const dwGlowObjectManager as Integer = &H521AF50
        Public Const dwInput as Integer = &H5125DA0
        Public Const dwInterfaceLinkList as Integer = &H8A7E14
        Public Const dwLocalPlayer as Integer = &HCCA6A4
        Public Const dwMouseEnable as Integer = &HCD01F0
        Public Const dwMouseEnablePtr as Integer = &HCD01C0
        Public Const dwPlayerResource as Integer = &H310AA6C
        Public Const dwRadarBase as Integer = &H510FD4C
        Public Const dwSensitivity as Integer = &HCD008C
        Public Const dwSensitivityPtr as Integer = &HCD0060
        Public Const dwSetClanTag as Integer = &H896A0
        Public Const dwViewMatrix as Integer = &H4CCCA24
        Public Const dwWeaponTable as Integer = &H5126864
        Public Const dwWeaponTableIndex as Integer = &H323C
        Public Const dwYawPtr as Integer = &HCCFE50
        Public Const dwZoomSensitivityRatioPtr as Integer = &HCD5090
        Public Const dwbSendPackets as Integer = &HD230A
        Public Const dwppDirect3DDevice9 as Integer = &HA3FC0
        Public Const force_update_spectator_glow as Integer = &H38D172
        Public Const interface_engine_cvar as Integer = &H3E9EC
        Public Const is_c4_owner as Integer = &H399190
        Public Const m_bDormant as Integer = &HED
        Public Const m_pStudioHdr as Integer = &H294C
        Public Const m_pitchClassPtr as Integer = &H5110000
        Public Const m_yawClassPtr as Integer = &HCCFE50
        Public Const model_ambient_min as Integer = &H58ED1C
        Public Const set_abs_angles as Integer = &H1C7280
        Public Const set_abs_origin as Integer = &H1C70C0
    End Class
End Namespace
