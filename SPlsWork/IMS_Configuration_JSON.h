namespace IMS_Configuration;
        // class declarations
         class Configuration;
         class Display;
         class PresentationInput;
         class ATC;
         class Preset;
         class VTC;
         class PowerSequencer;
         class SSI_Display_Usage;
         class SSI_Device_Usage;
         class SSI_Equipment_Status;
         class Lighting;
         class RootObject;
         class RESTfulApi;
         class ApiError;
     class Configuration 
    {
        // class delegates

        // class events

        // class functions
        FUNCTION Reader ();
        FUNCTION Writer ();
        STRING_FUNCTION ToString ();
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();

        // class variables
        INTEGER __class_id__;

        // class properties
        RootObject Obj;
        STRING filePath[];
    };

     class Display 
    {
        // class delegates

        // class events

        // class functions
        STRING_FUNCTION ToString ();
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();

        // class variables
        INTEGER __class_id__;

        // class properties
        STRING Name[];
        STRING Type[];
        INTEGER Screen_Enabled;
        INTEGER Warming_Time;
        SSI_Display_Usage SSI_Display_Usage;
        SSI_Equipment_Status SSI_Equipment_Status;
    };

     class PresentationInput 
    {
        // class delegates

        // class events

        // class functions
        STRING_FUNCTION ToString ();
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();

        // class variables
        INTEGER __class_id__;

        // class properties
        STRING Name[];
        STRING Type[];
        STRING Generic_Page_Text[];
        INTEGER Switcher_Value;
        SSI_Device_Usage SSI_Device_Usage;
        SSI_Equipment_Status SSI_Equipment_Status;
    };

     class ATC 
    {
        // class delegates

        // class events

        // class functions
        STRING_FUNCTION ToString ();
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();

        // class variables
        INTEGER __class_id__;

        // class properties
        STRING Extension[];
        STRING Help_Number[];
        STRING Help_Button_Text[];
        STRING Connected_Dial_Text[];
        STRING Disconnected_Dial_Text[];
        STRING Connected_Hangup_Text[];
        STRING Disconnected_Hangup_Text[];
        SSI_Device_Usage SSI_Device_Usage;
        SSI_Equipment_Status SSI_Equipment_Status;
    };

     class Preset 
    {
        // class delegates

        // class events

        // class functions
        STRING_FUNCTION ToString ();
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();

        // class variables
        INTEGER __class_id__;

        // class properties
        STRING Type[];
        STRING Id[];
        STRING Name[];
    };

     class VTC 
    {
        // class delegates

        // class events

        // class functions
        FUNCTION PresetToArray ();
        STRING_FUNCTION ToString ();
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();

        // class variables
        INTEGER __class_id__;

        // class properties
        STRING Extension[];
        Preset PresetsArray[];
        STRING Help_Number[];
        STRING Help_Button_Text[];
        STRING Connected_Dial_Text[];
        STRING Disconnected_Dial_Text[];
        STRING Connected_Hangup_Text[];
        STRING Disconnected_Hangup_Text[];
        SSI_Device_Usage SSI_Device_Usage;
        SSI_Equipment_Status SSI_Equipment_Status;
    };

     class PowerSequencer 
    {
        // class delegates

        // class events

        // class functions
        STRING_FUNCTION ToString ();
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();

        // class variables
        INTEGER __class_id__;

        // class properties
        STRING Channel_1_Name[];
        STRING Channel_2_Name[];
        STRING Channel_3_Name[];
        STRING Channel_4_Name[];
        STRING Channel_5_Name[];
        STRING Channel_6_Name[];
        STRING Channel_7_Name[];
        STRING Channel_8_Name[];
        SSI_Equipment_Status SSI_Equipment_Status;
    };

     class SSI_Display_Usage 
    {
        // class delegates

        // class events

        // class functions
        STRING_FUNCTION ToString ();
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();

        // class variables
        INTEGER __class_id__;

        // class properties
        STRING Display_Name[];
    };

     class SSI_Device_Usage 
    {
        // class delegates

        // class events

        // class functions
        STRING_FUNCTION ToString ();
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();

        // class variables
        INTEGER __class_id__;

        // class properties
        STRING Device_Type[];
        STRING Device_Name[];
    };

     class SSI_Equipment_Status 
    {
        // class delegates

        // class events

        // class functions
        STRING_FUNCTION ToString ();
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();

        // class variables
        INTEGER __class_id__;

        // class properties
        STRING Severity_Message[];
        STRING Error_Text[];
        STRING Ok_Text[];
    };

     class Lighting 
    {
        // class delegates

        // class events

        // class functions
        FUNCTION PresetToArray ();
        STRING_FUNCTION ToString ();
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();

        // class variables
        INTEGER __class_id__;

        // class properties
        Preset PresetsArray[];
        SSI_Equipment_Status SSI_Equipment_Status;
    };

     class RootObject 
    {
        // class delegates

        // class events

        // class functions
        FUNCTION DisplaysToArray ();
        FUNCTION PresentationToArray ();
        FUNCTION PowerSequencerToArray ();
        STRING_FUNCTION ToString ();
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();

        // class variables
        INTEGER __class_id__;

        // class properties
        STRING Room_Name[];
        STRING Welcome_Text[];
        STRING Warming_Text[];
        STRING Cooling_Text[];
        INTEGER Startup_Time;
        INTEGER Shutdown_Time_Display_Active;
        INTEGER Shutdown_Time_Display_Inactive;
        Display DisplayArray[];
        PresentationInput PresentationInputArray[];
        ATC ATC;
        VTC VTC;
        Lighting Lighting;
        PowerSequencer PowerSequencerArray[];
    };

     class RESTfulApi 
    {
        // class delegates

        // class events

        // class functions
        FUNCTION Start ();
        FUNCTION Stop ();
        STRING_FUNCTION ToString ();
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();

        // class variables
        INTEGER __class_id__;

        // class properties
    };

     class ApiError 
    {
        // class delegates

        // class events

        // class functions
        STRING_FUNCTION ToString ();
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();

        // class variables
        INTEGER __class_id__;

        // class properties
        STRING Message[];
        SIGNED_LONG_INTEGER Status;
    };

