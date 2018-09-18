export interface RootConfig {
    Room_Name: string;
    Welcome_Text: string;
    Shutdown_Text: string;
    Warming_Text: string;
    Cooling_Text: string;
    Startup_Time: number;
    Shutdown_Time_Display_Active: number;
    Shutdown_Time_Display_Inactive: number;
    Microphone_Mute_Enable: boolean;
    Microphone_Muted_Text: string;
    Microphone_Muted_Not_Text: string;
    Presentation_Page_Text: string;
    Displays?: (DisplaysEntity)[] | null;
    Cameras?: (CamerasEntity)[] | null;
    Generic_Device?: (GenericDeviceEntity)[] | null;
    Presentation_Inputs?: (PresentationInputsEntity)[] | null;
    ATC: ATCEntity;
    VTC: VTCEntity;
    Power_Sequencer?: (PowerSequencerEntity)[] | null;
    Lighting: LightingEntity;
  }

  export interface DisplaysEntity {
    Name: string;
    Type: string;
    Screen_Enabled: boolean;
    Switcher_Value: number;
    Icon_Value: number;
    Warming_Time: number;
    SSI_Display_Usage: SSIDisplayUsageEntity;
    SSI_Equipment_Status: SSIEquipmentStatusEntity;
  }

  export interface PresentationInputsEntity {
    Name: string;
    Type: string;
    Switcher_Value: number;
    Icon_Value: number;
    Generic_Page_Text: string;
    SSI_Device_Usage: SSIDeviceUsageEntity;
    SSI_Equipment_Status: SSIEquipmentStatusEntity;
  }
  export interface SSIEquipmentStatusEntity {
    Severity_Message: string;
    Error_Text: string;
    Ok_Text: string;
  }

  export interface SSIDisplayUsageEntity {
    Display_Name: string;
  }

  export interface SSIDeviceUsageEntity {
    Device_Type: string;
    Device_Name: string;
  }

  export interface ATCEntity {
    Extension: string;
    Help_Number: string;
    Help_Button_Text: string;
    Connected_Dial_Text: string;
    Disconnected_Dial_Text: string;
    Connected_Hangup_Text: string;
    Disconnected_Hangup_Text: string;
    SSI_Device_Usage: SSIDeviceUsageEntity;
    SSI_Equipment_Status: SSIEquipmentStatusEntity;
  }
  export interface VTCEntity {
    Extension: string;
    Help_Number: string;
    Help_Button_Text: string;
    Connected_Dial_Text: string;
    Disconnected_Dial_Text: string;
    Connected_Hangup_Text: string;
    Disconnected_Hangup_Text: string;
    SSI_Device_Usage: SSIDeviceUsageEntity;
    SSI_Equipment_Status: SSIEquipmentStatusEntity;
  }
  export interface PresetsEntity {
    Id: string;
    Type: string;
    Name: string;
    controls?: (any)[] | null;
  }

  export interface LightingEntity {
    Presets?: (PresetsEntity)[] | null;
    SSI_Equipment_Status: SSIEquipmentStatusEntity;
  }

  export interface PowerSequencerEntity {
    Channel_1_Name: string;
    Channel_2_Name: string;
    Channel_3_Name: string;
    Channel_4_Name: string;
    Channel_5_Name: string;
    Channel_6_Name: string;
    Channel_7_Name: string;
    Channel_8_Name: string;
    SSI_Equipment_Status: SSIEquipmentStatusEntity;
  }

  export interface CamerasEntity {
    Presets?: (PresetsEntity)[] | null;
    Switcher_Value: number;
    SSI_Device_Usage: SSIDeviceUsageEntity;
    SSI_Equipment_Status: SSIEquipmentStatusEntity;
  }

  export interface GenericDeviceEntity {
    Type: string;
    Name: string;
    ValueName1: string;
    Value1: string;
    ValueName2: string;
    Value2: string;
    ValueName3: string;
    Value3: string;
    ValueName4: string;
    Value4: string;
    SSI_Device_Usage: SSIDisplayUsageEntity;
    SSI_Equipment_Status: SSIEquipmentStatusEntity;
  }
