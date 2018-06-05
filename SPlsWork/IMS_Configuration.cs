using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Linq;
using Crestron;
using Crestron.Logos.SplusLibrary;
using Crestron.Logos.SplusObjects;
using Crestron.SimplSharp;
using IMS_Configuration;

namespace UserModule_IMS_CONFIGURATION
{
    public class UserModuleClass_IMS_CONFIGURATION : SplusObject
    {
        static CCriticalSection g_criticalSection = new CCriticalSection();
        
        Crestron.Logos.SplusObjects.DigitalInput PULL_CONFIG;
        Crestron.Logos.SplusObjects.AnalogOutput STARTUP_TIME;
        Crestron.Logos.SplusObjects.AnalogOutput SHUTDOWN_TIME_ACTIVE;
        Crestron.Logos.SplusObjects.AnalogOutput SHUTDOWN_TIME_INACTIVE;
        Crestron.Logos.SplusObjects.StringOutput ROOM_NAME;
        Crestron.Logos.SplusObjects.StringOutput WELCOME_TEXT;
        Crestron.Logos.SplusObjects.StringOutput SHUTDOWN_TEXT;
        Crestron.Logos.SplusObjects.StringOutput WARMING_TEXT;
        Crestron.Logos.SplusObjects.StringOutput COOLING_TEXT;
        Crestron.Logos.SplusObjects.StringOutput DISPLAY1_NAME;
        Crestron.Logos.SplusObjects.StringOutput DISPLAY1_TYPE;
        Crestron.Logos.SplusObjects.DigitalOutput DISPLAY1_SCREEN_ENABLED;
        Crestron.Logos.SplusObjects.AnalogOutput DISPLAY1_WARMING_TIME;
        Crestron.Logos.SplusObjects.StringOutput DISPLAY1_SSI_USAGE_NAME;
        Crestron.Logos.SplusObjects.StringOutput DISPLAY1_SSI_SEVERITY_MESSAGE;
        Crestron.Logos.SplusObjects.StringOutput DISPLAY1_SSI_ERROR_TEXT;
        Crestron.Logos.SplusObjects.StringOutput DISPLAY1_SSI_OK_TEXT;
        Crestron.Logos.SplusObjects.StringOutput DISPLAY2_NAME;
        Crestron.Logos.SplusObjects.StringOutput DISPLAY2_TYPE;
        Crestron.Logos.SplusObjects.DigitalOutput DISPLAY2_SCREEN_ENABLED;
        Crestron.Logos.SplusObjects.AnalogOutput DISPLAY2_WARMING_TIME;
        Crestron.Logos.SplusObjects.StringOutput DISPLAY2_SSI_USAGE_NAME;
        Crestron.Logos.SplusObjects.StringOutput DISPLAY2_SSI_SEVERITY_MESSAGE;
        Crestron.Logos.SplusObjects.StringOutput DISPLAY2_SSI_ERROR_TEXT;
        Crestron.Logos.SplusObjects.StringOutput DISPLAY2_SSI_OK_TEXT;
        Crestron.Logos.SplusObjects.StringOutput PRESENTATION1_NAME;
        Crestron.Logos.SplusObjects.StringOutput PRESENTATION1_TYPE;
        Crestron.Logos.SplusObjects.StringOutput PRESENTATION1_GENERIC_PAGE_TEXT;
        Crestron.Logos.SplusObjects.AnalogOutput PRESENTATION1_SWITCHER_VALUE;
        Crestron.Logos.SplusObjects.StringOutput PRESENTATION1_SSI_DEVICE_USAGE_TYPE;
        Crestron.Logos.SplusObjects.StringOutput PRESENTATION1_SSI_DEVICE_USAGE_NAME;
        Crestron.Logos.SplusObjects.StringOutput PRESENTATION1_SSI_SEVERITY_MESSAGE;
        Crestron.Logos.SplusObjects.StringOutput PRESENTATION1_SSI_ERROR_TEXT;
        Crestron.Logos.SplusObjects.StringOutput PRESENTATION1_SSI_OK_TEXT;
        Crestron.Logos.SplusObjects.StringOutput PRESENTATION2_NAME;
        Crestron.Logos.SplusObjects.StringOutput PRESENTATION2_TYPE;
        Crestron.Logos.SplusObjects.StringOutput PRESENTATION2_GENERIC_PAGE_TEXT;
        Crestron.Logos.SplusObjects.AnalogOutput PRESENTATION2_SWITCHER_VALUE;
        Crestron.Logos.SplusObjects.StringOutput PRESENTATION2_SSI_DEVICE_USAGE_TYPE;
        Crestron.Logos.SplusObjects.StringOutput PRESENTATION2_SSI_DEVICE_USAGE_NAME;
        Crestron.Logos.SplusObjects.StringOutput PRESENTATION2_SSI_SEVERITY_MESSAGE;
        Crestron.Logos.SplusObjects.StringOutput PRESENTATION2_SSI_ERROR_TEXT;
        Crestron.Logos.SplusObjects.StringOutput PRESENTATION2_SSI_OK_TEXT;
        Crestron.Logos.SplusObjects.StringOutput PRESENTATION3_NAME;
        Crestron.Logos.SplusObjects.StringOutput PRESENTATION3_TYPE;
        Crestron.Logos.SplusObjects.StringOutput PRESENTATION3_GENERIC_PAGE_TEXT;
        Crestron.Logos.SplusObjects.AnalogOutput PRESENTATION3_SWITCHER_VALUE;
        Crestron.Logos.SplusObjects.StringOutput PRESENTATION3_SSI_DEVICE_USAGE_TYPE;
        Crestron.Logos.SplusObjects.StringOutput PRESENTATION3_SSI_DEVICE_USAGE_NAME;
        Crestron.Logos.SplusObjects.StringOutput PRESENTATION3_SSI_SEVERITY_MESSAGE;
        Crestron.Logos.SplusObjects.StringOutput PRESENTATION3_SSI_ERROR_TEXT;
        Crestron.Logos.SplusObjects.StringOutput PRESENTATION3_SSI_OK_TEXT;
        Crestron.Logos.SplusObjects.StringOutput PRESENTATION4_NAME;
        Crestron.Logos.SplusObjects.StringOutput PRESENTATION4_TYPE;
        Crestron.Logos.SplusObjects.StringOutput PRESENTATION4_GENERIC_PAGE_TEXT;
        Crestron.Logos.SplusObjects.AnalogOutput PRESENTATION4_SWITCHER_VALUE;
        Crestron.Logos.SplusObjects.StringOutput PRESENTATION4_SSI_DEVICE_USAGE_TYPE;
        Crestron.Logos.SplusObjects.StringOutput PRESENTATION4_SSI_DEVICE_USAGE_NAME;
        Crestron.Logos.SplusObjects.StringOutput PRESENTATION4_SSI_SEVERITY_MESSAGE;
        Crestron.Logos.SplusObjects.StringOutput PRESENTATION4_SSI_ERROR_TEXT;
        Crestron.Logos.SplusObjects.StringOutput PRESENTATION4_SSI_OK_TEXT;
        Crestron.Logos.SplusObjects.StringOutput PRESENTATION5_NAME;
        Crestron.Logos.SplusObjects.StringOutput PRESENTATION5_TYPE;
        Crestron.Logos.SplusObjects.StringOutput PRESENTATION5_GENERIC_PAGE_TEXT;
        Crestron.Logos.SplusObjects.AnalogOutput PRESENTATION5_SWITCHER_VALUE;
        Crestron.Logos.SplusObjects.StringOutput PRESENTATION5_SSI_DEVICE_USAGE_TYPE;
        Crestron.Logos.SplusObjects.StringOutput PRESENTATION5_SSI_DEVICE_USAGE_NAME;
        Crestron.Logos.SplusObjects.StringOutput PRESENTATION5_SSI_SEVERITY_MESSAGE;
        Crestron.Logos.SplusObjects.StringOutput PRESENTATION5_SSI_ERROR_TEXT;
        Crestron.Logos.SplusObjects.StringOutput PRESENTATION5_SSI_OK_TEXT;
        Crestron.Logos.SplusObjects.StringOutput PRESENTATION6_NAME;
        Crestron.Logos.SplusObjects.StringOutput PRESENTATION6_TYPE;
        Crestron.Logos.SplusObjects.StringOutput PRESENTATION6_GENERIC_PAGE_TEXT;
        Crestron.Logos.SplusObjects.AnalogOutput PRESENTATION6_SWITCHER_VALUE;
        Crestron.Logos.SplusObjects.StringOutput PRESENTATION6_SSI_DEVICE_USAGE_TYPE;
        Crestron.Logos.SplusObjects.StringOutput PRESENTATION6_SSI_DEVICE_USAGE_NAME;
        Crestron.Logos.SplusObjects.StringOutput PRESENTATION6_SSI_SEVERITY_MESSAGE;
        Crestron.Logos.SplusObjects.StringOutput PRESENTATION6_SSI_ERROR_TEXT;
        Crestron.Logos.SplusObjects.StringOutput PRESENTATION6_SSI_OK_TEXT;
        Crestron.Logos.SplusObjects.StringOutput ATC_EXTENSION;
        Crestron.Logos.SplusObjects.StringOutput ATC_HELP_NUMBER;
        Crestron.Logos.SplusObjects.StringOutput ATC_HELP_BTN_TEXT;
        Crestron.Logos.SplusObjects.StringOutput ATC_CONNECTED_DIAL_TEXT;
        Crestron.Logos.SplusObjects.StringOutput ATC_DISCONNECTED_DIAL_TEXT;
        Crestron.Logos.SplusObjects.StringOutput ATC_CONNECTED_HANGUP_TEXT;
        Crestron.Logos.SplusObjects.StringOutput ATC_DISCONNECTED_HANGUP_TEXT;
        Crestron.Logos.SplusObjects.StringOutput ATC_SSI_DEVICE_USAGE_TYPE;
        Crestron.Logos.SplusObjects.StringOutput ATC_SSI_DEVICE_USAGE_NAME;
        Crestron.Logos.SplusObjects.StringOutput ATC_SSI_SEVERITY_MESSAGE;
        Crestron.Logos.SplusObjects.StringOutput ATC_SSI_ERROR_TEXT;
        Crestron.Logos.SplusObjects.StringOutput ATC_SSI_OK_TEXT;
        Crestron.Logos.SplusObjects.StringOutput VTC_EXTENSION;
        Crestron.Logos.SplusObjects.StringOutput VTC_HELP_NUMBER;
        Crestron.Logos.SplusObjects.StringOutput VTC_HELP_BTN_TEXT;
        Crestron.Logos.SplusObjects.StringOutput VTC_CONNECTED_DIAL_TEXT;
        Crestron.Logos.SplusObjects.StringOutput VTC_DISCONNECTED_DIAL_TEXT;
        Crestron.Logos.SplusObjects.StringOutput VTC_CONNECTED_HANGUP_TEXT;
        Crestron.Logos.SplusObjects.StringOutput VTC_DISCONNECTED_HANGUP_TEXT;
        Crestron.Logos.SplusObjects.StringOutput VTC_CAM_PRESET1_ID;
        Crestron.Logos.SplusObjects.StringOutput VTC_CAM_PRESET1_NAME;
        Crestron.Logos.SplusObjects.StringOutput VTC_CAM_PRESET2_ID;
        Crestron.Logos.SplusObjects.StringOutput VTC_CAM_PRESET2_NAME;
        Crestron.Logos.SplusObjects.StringOutput VTC_CAM_PRESET3_ID;
        Crestron.Logos.SplusObjects.StringOutput VTC_CAM_PRESET3_NAME;
        Crestron.Logos.SplusObjects.StringOutput VTC_CAM_PRESET4_ID;
        Crestron.Logos.SplusObjects.StringOutput VTC_CAM_PRESET4_NAME;
        Crestron.Logos.SplusObjects.StringOutput VTC_CAM_PRESET5_ID;
        Crestron.Logos.SplusObjects.StringOutput VTC_CAM_PRESET5_NAME;
        Crestron.Logos.SplusObjects.StringOutput VTC_CAM_PRESET6_ID;
        Crestron.Logos.SplusObjects.StringOutput VTC_CAM_PRESET6_NAME;
        Crestron.Logos.SplusObjects.StringOutput VTC_SSI_DEVICE_USAGE_TYPE;
        Crestron.Logos.SplusObjects.StringOutput VTC_SSI_DEVICE_USAGE_NAME;
        Crestron.Logos.SplusObjects.StringOutput VTC_SSI_SEVERITY_MESSAGE;
        Crestron.Logos.SplusObjects.StringOutput VTC_SSI_ERROR_TEXT;
        Crestron.Logos.SplusObjects.StringOutput VTC_SSI_OK_TEXT;
        Crestron.Logos.SplusObjects.StringOutput LIGHTING_PRESET1_ID;
        Crestron.Logos.SplusObjects.StringOutput LIGHTING_PRESET1_NAME;
        Crestron.Logos.SplusObjects.StringOutput LIGHTING_PRESET2_ID;
        Crestron.Logos.SplusObjects.StringOutput LIGHTING_PRESET2_NAME;
        Crestron.Logos.SplusObjects.StringOutput LIGHTING_PRESET3_ID;
        Crestron.Logos.SplusObjects.StringOutput LIGHTING_PRESET3_NAME;
        Crestron.Logos.SplusObjects.StringOutput LIGHTING_PRESET4_ID;
        Crestron.Logos.SplusObjects.StringOutput LIGHTING_PRESET4_NAME;
        Crestron.Logos.SplusObjects.StringOutput LIGHTING_PRESET5_ID;
        Crestron.Logos.SplusObjects.StringOutput LIGHTING_PRESET5_NAME;
        Crestron.Logos.SplusObjects.StringOutput LIGHTING_PRESET6_ID;
        Crestron.Logos.SplusObjects.StringOutput LIGHTING_PRESET6_NAME;
        Crestron.Logos.SplusObjects.StringOutput LIGHTING_SSI_SEVERITY_MESSAGE;
        Crestron.Logos.SplusObjects.StringOutput LIGHTING_SSI_ERROR_TEXT;
        Crestron.Logos.SplusObjects.StringOutput LIGHTING_SSI_OK_TEXT;
        Crestron.Logos.SplusObjects.StringOutput SEQUENCER1_CH1_NAME;
        Crestron.Logos.SplusObjects.StringOutput SEQUENCER1_CH2_NAME;
        Crestron.Logos.SplusObjects.StringOutput SEQUENCER1_CH3_NAME;
        Crestron.Logos.SplusObjects.StringOutput SEQUENCER1_CH4_NAME;
        Crestron.Logos.SplusObjects.StringOutput SEQUENCER1_CH5_NAME;
        Crestron.Logos.SplusObjects.StringOutput SEQUENCER1_CH6_NAME;
        Crestron.Logos.SplusObjects.StringOutput SEQUENCER1_CH7_NAME;
        Crestron.Logos.SplusObjects.StringOutput SEQUENCER1_CH8_NAME;
        Crestron.Logos.SplusObjects.StringOutput SEQUENCER1_SSI_SEVERITY_MESSAGE;
        Crestron.Logos.SplusObjects.StringOutput SEQUENCER1_SSI_ERROR_TEXT;
        Crestron.Logos.SplusObjects.StringOutput SEQUENCER1_SSI_OK_TEXT;
        Crestron.Logos.SplusObjects.StringOutput SEQUENCER2_CH1_NAME;
        Crestron.Logos.SplusObjects.StringOutput SEQUENCER2_CH2_NAME;
        Crestron.Logos.SplusObjects.StringOutput SEQUENCER2_CH3_NAME;
        Crestron.Logos.SplusObjects.StringOutput SEQUENCER2_CH4_NAME;
        Crestron.Logos.SplusObjects.StringOutput SEQUENCER2_CH5_NAME;
        Crestron.Logos.SplusObjects.StringOutput SEQUENCER2_CH6_NAME;
        Crestron.Logos.SplusObjects.StringOutput SEQUENCER2_CH7_NAME;
        Crestron.Logos.SplusObjects.StringOutput SEQUENCER2_CH8_NAME;
        Crestron.Logos.SplusObjects.StringOutput SEQUENCER2_SSI_SEVERITY_MESSAGE;
        Crestron.Logos.SplusObjects.StringOutput SEQUENCER2_SSI_ERROR_TEXT;
        Crestron.Logos.SplusObjects.StringOutput SEQUENCER2_SSI_OK_TEXT;
        StringParameter PATH__DOLLAR__;
        IMS_Configuration.Configuration CONFIG;
        IMS_Configuration.RESTfulApi API;
        object PULL_CONFIG_OnPush_0 ( Object __EventInfo__ )
        
            { 
            Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
            try
            {
                SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
                
                __context__.SourceCodeLine = 249;
                CONFIG . Reader ( ) ; 
                __context__.SourceCodeLine = 251;
                ROOM_NAME  .UpdateValue ( CONFIG . Obj . Room_Name  ) ; 
                __context__.SourceCodeLine = 252;
                WELCOME_TEXT  .UpdateValue ( CONFIG . Obj . Welcome_Text  ) ; 
                __context__.SourceCodeLine = 253;
                SHUTDOWN_TEXT  .UpdateValue ( CONFIG . Obj . Shutdown_Text  ) ; 
                __context__.SourceCodeLine = 254;
                STARTUP_TIME  .Value = (ushort) ( CONFIG.Obj.Startup_Time ) ; 
                __context__.SourceCodeLine = 255;
                SHUTDOWN_TIME_ACTIVE  .Value = (ushort) ( CONFIG.Obj.Shutdown_Time_Display_Active ) ; 
                __context__.SourceCodeLine = 256;
                SHUTDOWN_TIME_INACTIVE  .Value = (ushort) ( CONFIG.Obj.Shutdown_Time_Display_Inactive ) ; 
                __context__.SourceCodeLine = 257;
                WARMING_TEXT  .UpdateValue ( CONFIG . Obj . Warming_Text  ) ; 
                __context__.SourceCodeLine = 258;
                COOLING_TEXT  .UpdateValue ( CONFIG . Obj . Cooling_Text  ) ; 
                __context__.SourceCodeLine = 261;
                CONFIG . Obj . DisplaysToArray ( ) ; 
                __context__.SourceCodeLine = 262;
                try 
                    { 
                    __context__.SourceCodeLine = 263;
                    DISPLAY1_NAME  .UpdateValue ( CONFIG . Obj . DisplayArray [ 0] . Name  ) ; 
                    __context__.SourceCodeLine = 264;
                    DISPLAY1_TYPE  .UpdateValue ( CONFIG . Obj . DisplayArray [ 0] . Type  ) ; 
                    __context__.SourceCodeLine = 265;
                    DISPLAY1_SCREEN_ENABLED  .Value = (ushort) ( CONFIG.Obj.DisplayArray[ 0 ].Screen_Enabled ) ; 
                    __context__.SourceCodeLine = 266;
                    DISPLAY1_WARMING_TIME  .Value = (ushort) ( CONFIG.Obj.DisplayArray[ 0 ].Warming_Time ) ; 
                    __context__.SourceCodeLine = 267;
                    DISPLAY1_SSI_USAGE_NAME  .UpdateValue ( CONFIG . Obj . DisplayArray [ 0] . SSI_Display_Usage . Display_Name  ) ; 
                    __context__.SourceCodeLine = 268;
                    DISPLAY1_SSI_SEVERITY_MESSAGE  .UpdateValue ( CONFIG . Obj . DisplayArray [ 0] . SSI_Equipment_Status . Severity_Message  ) ; 
                    __context__.SourceCodeLine = 269;
                    DISPLAY1_SSI_ERROR_TEXT  .UpdateValue ( CONFIG . Obj . DisplayArray [ 0] . SSI_Equipment_Status . Error_Text  ) ; 
                    __context__.SourceCodeLine = 270;
                    DISPLAY1_SSI_OK_TEXT  .UpdateValue ( CONFIG . Obj . DisplayArray [ 0] . SSI_Equipment_Status . Ok_Text  ) ; 
                    } 
                
                catch (Exception __splus_exception__)
                    { 
                    SimplPlusException __splus_exceptionobj__ = new SimplPlusException(__splus_exception__, this );
                    
                    
                    }
                    
                    __context__.SourceCodeLine = 271;
                    ; 
                    __context__.SourceCodeLine = 274;
                    try 
                        { 
                        __context__.SourceCodeLine = 275;
                        DISPLAY2_NAME  .UpdateValue ( CONFIG . Obj . DisplayArray [ 1] . Name  ) ; 
                        __context__.SourceCodeLine = 276;
                        DISPLAY2_TYPE  .UpdateValue ( CONFIG . Obj . DisplayArray [ 1] . Type  ) ; 
                        __context__.SourceCodeLine = 277;
                        DISPLAY2_SCREEN_ENABLED  .Value = (ushort) ( CONFIG.Obj.DisplayArray[ 1 ].Screen_Enabled ) ; 
                        __context__.SourceCodeLine = 278;
                        DISPLAY2_WARMING_TIME  .Value = (ushort) ( CONFIG.Obj.DisplayArray[ 1 ].Warming_Time ) ; 
                        __context__.SourceCodeLine = 279;
                        DISPLAY2_SSI_USAGE_NAME  .UpdateValue ( CONFIG . Obj . DisplayArray [ 1] . SSI_Display_Usage . Display_Name  ) ; 
                        __context__.SourceCodeLine = 280;
                        DISPLAY2_SSI_SEVERITY_MESSAGE  .UpdateValue ( CONFIG . Obj . DisplayArray [ 1] . SSI_Equipment_Status . Severity_Message  ) ; 
                        __context__.SourceCodeLine = 281;
                        DISPLAY2_SSI_ERROR_TEXT  .UpdateValue ( CONFIG . Obj . DisplayArray [ 1] . SSI_Equipment_Status . Error_Text  ) ; 
                        __context__.SourceCodeLine = 282;
                        DISPLAY2_SSI_OK_TEXT  .UpdateValue ( CONFIG . Obj . DisplayArray [ 1] . SSI_Equipment_Status . Ok_Text  ) ; 
                        } 
                    
                    catch (Exception __splus_exception__)
                        { 
                        SimplPlusException __splus_exceptionobj__ = new SimplPlusException(__splus_exception__, this );
                        
                        
                        }
                        
                        __context__.SourceCodeLine = 283;
                        ; 
                        __context__.SourceCodeLine = 286;
                        try 
                            { 
                            __context__.SourceCodeLine = 287;
                            CONFIG . Obj . PresentationToArray ( ) ; 
                            __context__.SourceCodeLine = 288;
                            PRESENTATION1_NAME  .UpdateValue ( CONFIG . Obj . PresentationInputArray [ 0] . Name  ) ; 
                            __context__.SourceCodeLine = 289;
                            PRESENTATION1_TYPE  .UpdateValue ( CONFIG . Obj . PresentationInputArray [ 0] . Type  ) ; 
                            __context__.SourceCodeLine = 290;
                            PRESENTATION1_TYPE  .UpdateValue ( CONFIG . Obj . PresentationInputArray [ 0] . Generic_Page_Text  ) ; 
                            __context__.SourceCodeLine = 291;
                            PRESENTATION1_SWITCHER_VALUE  .Value = (ushort) ( CONFIG.Obj.PresentationInputArray[ 0 ].Switcher_Value ) ; 
                            __context__.SourceCodeLine = 292;
                            PRESENTATION1_SSI_DEVICE_USAGE_TYPE  .UpdateValue ( CONFIG . Obj . PresentationInputArray [ 0] . SSI_Device_Usage . Device_Type  ) ; 
                            __context__.SourceCodeLine = 293;
                            PRESENTATION1_SSI_DEVICE_USAGE_NAME  .UpdateValue ( CONFIG . Obj . PresentationInputArray [ 0] . SSI_Device_Usage . Device_Name  ) ; 
                            __context__.SourceCodeLine = 294;
                            PRESENTATION1_SSI_SEVERITY_MESSAGE  .UpdateValue ( CONFIG . Obj . PresentationInputArray [ 0] . SSI_Equipment_Status . Severity_Message  ) ; 
                            __context__.SourceCodeLine = 295;
                            PRESENTATION1_SSI_ERROR_TEXT  .UpdateValue ( CONFIG . Obj . PresentationInputArray [ 0] . SSI_Equipment_Status . Error_Text  ) ; 
                            __context__.SourceCodeLine = 296;
                            PRESENTATION1_SSI_OK_TEXT  .UpdateValue ( CONFIG . Obj . PresentationInputArray [ 0] . SSI_Equipment_Status . Ok_Text  ) ; 
                            } 
                        
                        catch (Exception __splus_exception__)
                            { 
                            SimplPlusException __splus_exceptionobj__ = new SimplPlusException(__splus_exception__, this );
                            
                            
                            }
                            
                            __context__.SourceCodeLine = 297;
                            ; 
                            __context__.SourceCodeLine = 300;
                            try 
                                { 
                                __context__.SourceCodeLine = 301;
                                PRESENTATION2_NAME  .UpdateValue ( CONFIG . Obj . PresentationInputArray [ 1] . Name  ) ; 
                                __context__.SourceCodeLine = 302;
                                PRESENTATION2_TYPE  .UpdateValue ( CONFIG . Obj . PresentationInputArray [ 1] . Type  ) ; 
                                __context__.SourceCodeLine = 303;
                                PRESENTATION2_TYPE  .UpdateValue ( CONFIG . Obj . PresentationInputArray [ 1] . Generic_Page_Text  ) ; 
                                __context__.SourceCodeLine = 304;
                                PRESENTATION2_SWITCHER_VALUE  .Value = (ushort) ( CONFIG.Obj.PresentationInputArray[ 1 ].Switcher_Value ) ; 
                                __context__.SourceCodeLine = 305;
                                PRESENTATION2_SSI_DEVICE_USAGE_TYPE  .UpdateValue ( CONFIG . Obj . PresentationInputArray [ 1] . SSI_Device_Usage . Device_Type  ) ; 
                                __context__.SourceCodeLine = 306;
                                PRESENTATION2_SSI_DEVICE_USAGE_NAME  .UpdateValue ( CONFIG . Obj . PresentationInputArray [ 1] . SSI_Device_Usage . Device_Name  ) ; 
                                __context__.SourceCodeLine = 307;
                                PRESENTATION2_SSI_SEVERITY_MESSAGE  .UpdateValue ( CONFIG . Obj . PresentationInputArray [ 1] . SSI_Equipment_Status . Severity_Message  ) ; 
                                __context__.SourceCodeLine = 308;
                                PRESENTATION2_SSI_ERROR_TEXT  .UpdateValue ( CONFIG . Obj . PresentationInputArray [ 1] . SSI_Equipment_Status . Error_Text  ) ; 
                                __context__.SourceCodeLine = 309;
                                PRESENTATION2_SSI_OK_TEXT  .UpdateValue ( CONFIG . Obj . PresentationInputArray [ 1] . SSI_Equipment_Status . Ok_Text  ) ; 
                                } 
                            
                            catch (Exception __splus_exception__)
                                { 
                                SimplPlusException __splus_exceptionobj__ = new SimplPlusException(__splus_exception__, this );
                                
                                
                                }
                                
                                __context__.SourceCodeLine = 310;
                                ; 
                                __context__.SourceCodeLine = 313;
                                try 
                                    { 
                                    __context__.SourceCodeLine = 314;
                                    PRESENTATION3_NAME  .UpdateValue ( CONFIG . Obj . PresentationInputArray [ 2] . Name  ) ; 
                                    __context__.SourceCodeLine = 315;
                                    PRESENTATION3_TYPE  .UpdateValue ( CONFIG . Obj . PresentationInputArray [ 2] . Type  ) ; 
                                    __context__.SourceCodeLine = 316;
                                    PRESENTATION3_TYPE  .UpdateValue ( CONFIG . Obj . PresentationInputArray [ 2] . Generic_Page_Text  ) ; 
                                    __context__.SourceCodeLine = 317;
                                    PRESENTATION3_SWITCHER_VALUE  .Value = (ushort) ( CONFIG.Obj.PresentationInputArray[ 2 ].Switcher_Value ) ; 
                                    __context__.SourceCodeLine = 318;
                                    PRESENTATION3_SSI_DEVICE_USAGE_TYPE  .UpdateValue ( CONFIG . Obj . PresentationInputArray [ 2] . SSI_Device_Usage . Device_Type  ) ; 
                                    __context__.SourceCodeLine = 319;
                                    PRESENTATION3_SSI_DEVICE_USAGE_NAME  .UpdateValue ( CONFIG . Obj . PresentationInputArray [ 2] . SSI_Device_Usage . Device_Name  ) ; 
                                    __context__.SourceCodeLine = 320;
                                    PRESENTATION3_SSI_SEVERITY_MESSAGE  .UpdateValue ( CONFIG . Obj . PresentationInputArray [ 2] . SSI_Equipment_Status . Severity_Message  ) ; 
                                    __context__.SourceCodeLine = 321;
                                    PRESENTATION3_SSI_ERROR_TEXT  .UpdateValue ( CONFIG . Obj . PresentationInputArray [ 2] . SSI_Equipment_Status . Error_Text  ) ; 
                                    __context__.SourceCodeLine = 322;
                                    PRESENTATION3_SSI_OK_TEXT  .UpdateValue ( CONFIG . Obj . PresentationInputArray [ 2] . SSI_Equipment_Status . Ok_Text  ) ; 
                                    } 
                                
                                catch (Exception __splus_exception__)
                                    { 
                                    SimplPlusException __splus_exceptionobj__ = new SimplPlusException(__splus_exception__, this );
                                    
                                    
                                    }
                                    
                                    __context__.SourceCodeLine = 323;
                                    ; 
                                    __context__.SourceCodeLine = 325;
                                    try 
                                        { 
                                        __context__.SourceCodeLine = 326;
                                        PRESENTATION4_NAME  .UpdateValue ( CONFIG . Obj . PresentationInputArray [ 3] . Name  ) ; 
                                        __context__.SourceCodeLine = 327;
                                        PRESENTATION4_TYPE  .UpdateValue ( CONFIG . Obj . PresentationInputArray [ 3] . Type  ) ; 
                                        __context__.SourceCodeLine = 328;
                                        PRESENTATION4_TYPE  .UpdateValue ( CONFIG . Obj . PresentationInputArray [ 3] . Generic_Page_Text  ) ; 
                                        __context__.SourceCodeLine = 329;
                                        PRESENTATION4_SWITCHER_VALUE  .Value = (ushort) ( CONFIG.Obj.PresentationInputArray[ 3 ].Switcher_Value ) ; 
                                        __context__.SourceCodeLine = 330;
                                        PRESENTATION4_SSI_DEVICE_USAGE_TYPE  .UpdateValue ( CONFIG . Obj . PresentationInputArray [ 3] . SSI_Device_Usage . Device_Type  ) ; 
                                        __context__.SourceCodeLine = 331;
                                        PRESENTATION4_SSI_DEVICE_USAGE_NAME  .UpdateValue ( CONFIG . Obj . PresentationInputArray [ 3] . SSI_Device_Usage . Device_Name  ) ; 
                                        __context__.SourceCodeLine = 332;
                                        PRESENTATION4_SSI_SEVERITY_MESSAGE  .UpdateValue ( CONFIG . Obj . PresentationInputArray [ 3] . SSI_Equipment_Status . Severity_Message  ) ; 
                                        __context__.SourceCodeLine = 333;
                                        PRESENTATION4_SSI_ERROR_TEXT  .UpdateValue ( CONFIG . Obj . PresentationInputArray [ 3] . SSI_Equipment_Status . Error_Text  ) ; 
                                        __context__.SourceCodeLine = 334;
                                        PRESENTATION4_SSI_OK_TEXT  .UpdateValue ( CONFIG . Obj . PresentationInputArray [ 3] . SSI_Equipment_Status . Ok_Text  ) ; 
                                        } 
                                    
                                    catch (Exception __splus_exception__)
                                        { 
                                        SimplPlusException __splus_exceptionobj__ = new SimplPlusException(__splus_exception__, this );
                                        
                                        
                                        }
                                        
                                        __context__.SourceCodeLine = 337;
                                        try 
                                            { 
                                            __context__.SourceCodeLine = 338;
                                            PRESENTATION5_NAME  .UpdateValue ( CONFIG . Obj . PresentationInputArray [ 4] . Name  ) ; 
                                            __context__.SourceCodeLine = 339;
                                            PRESENTATION5_TYPE  .UpdateValue ( CONFIG . Obj . PresentationInputArray [ 4] . Type  ) ; 
                                            __context__.SourceCodeLine = 340;
                                            PRESENTATION5_TYPE  .UpdateValue ( CONFIG . Obj . PresentationInputArray [ 4] . Generic_Page_Text  ) ; 
                                            __context__.SourceCodeLine = 341;
                                            PRESENTATION5_SWITCHER_VALUE  .Value = (ushort) ( CONFIG.Obj.PresentationInputArray[ 4 ].Switcher_Value ) ; 
                                            __context__.SourceCodeLine = 342;
                                            PRESENTATION5_SSI_DEVICE_USAGE_TYPE  .UpdateValue ( CONFIG . Obj . PresentationInputArray [ 4] . SSI_Device_Usage . Device_Type  ) ; 
                                            __context__.SourceCodeLine = 343;
                                            PRESENTATION5_SSI_DEVICE_USAGE_NAME  .UpdateValue ( CONFIG . Obj . PresentationInputArray [ 4] . SSI_Device_Usage . Device_Name  ) ; 
                                            __context__.SourceCodeLine = 344;
                                            PRESENTATION5_SSI_SEVERITY_MESSAGE  .UpdateValue ( CONFIG . Obj . PresentationInputArray [ 4] . SSI_Equipment_Status . Severity_Message  ) ; 
                                            __context__.SourceCodeLine = 345;
                                            PRESENTATION5_SSI_ERROR_TEXT  .UpdateValue ( CONFIG . Obj . PresentationInputArray [ 4] . SSI_Equipment_Status . Error_Text  ) ; 
                                            __context__.SourceCodeLine = 346;
                                            PRESENTATION5_SSI_OK_TEXT  .UpdateValue ( CONFIG . Obj . PresentationInputArray [ 4] . SSI_Equipment_Status . Ok_Text  ) ; 
                                            } 
                                        
                                        catch (Exception __splus_exception__)
                                            { 
                                            SimplPlusException __splus_exceptionobj__ = new SimplPlusException(__splus_exception__, this );
                                            
                                            
                                            }
                                            
                                            __context__.SourceCodeLine = 349;
                                            try 
                                                { 
                                                __context__.SourceCodeLine = 350;
                                                PRESENTATION6_NAME  .UpdateValue ( CONFIG . Obj . PresentationInputArray [ 5] . Name  ) ; 
                                                __context__.SourceCodeLine = 351;
                                                PRESENTATION6_TYPE  .UpdateValue ( CONFIG . Obj . PresentationInputArray [ 5] . Type  ) ; 
                                                __context__.SourceCodeLine = 352;
                                                PRESENTATION6_TYPE  .UpdateValue ( CONFIG . Obj . PresentationInputArray [ 5] . Generic_Page_Text  ) ; 
                                                __context__.SourceCodeLine = 353;
                                                PRESENTATION6_SWITCHER_VALUE  .Value = (ushort) ( CONFIG.Obj.PresentationInputArray[ 5 ].Switcher_Value ) ; 
                                                __context__.SourceCodeLine = 354;
                                                PRESENTATION6_SSI_DEVICE_USAGE_TYPE  .UpdateValue ( CONFIG . Obj . PresentationInputArray [ 5] . SSI_Device_Usage . Device_Type  ) ; 
                                                __context__.SourceCodeLine = 355;
                                                PRESENTATION6_SSI_DEVICE_USAGE_NAME  .UpdateValue ( CONFIG . Obj . PresentationInputArray [ 5] . SSI_Device_Usage . Device_Name  ) ; 
                                                __context__.SourceCodeLine = 356;
                                                PRESENTATION6_SSI_SEVERITY_MESSAGE  .UpdateValue ( CONFIG . Obj . PresentationInputArray [ 5] . SSI_Equipment_Status . Severity_Message  ) ; 
                                                __context__.SourceCodeLine = 357;
                                                PRESENTATION6_SSI_ERROR_TEXT  .UpdateValue ( CONFIG . Obj . PresentationInputArray [ 5] . SSI_Equipment_Status . Error_Text  ) ; 
                                                __context__.SourceCodeLine = 358;
                                                PRESENTATION6_SSI_OK_TEXT  .UpdateValue ( CONFIG . Obj . PresentationInputArray [ 5] . SSI_Equipment_Status . Ok_Text  ) ; 
                                                } 
                                            
                                            catch (Exception __splus_exception__)
                                                { 
                                                SimplPlusException __splus_exceptionobj__ = new SimplPlusException(__splus_exception__, this );
                                                
                                                
                                                }
                                                
                                                __context__.SourceCodeLine = 361;
                                                ATC_EXTENSION  .UpdateValue ( CONFIG . Obj . ATC . Extension  ) ; 
                                                __context__.SourceCodeLine = 362;
                                                ATC_HELP_NUMBER  .UpdateValue ( CONFIG . Obj . ATC . Help_Number  ) ; 
                                                __context__.SourceCodeLine = 363;
                                                ATC_HELP_BTN_TEXT  .UpdateValue ( CONFIG . Obj . ATC . Help_Button_Text  ) ; 
                                                __context__.SourceCodeLine = 364;
                                                ATC_CONNECTED_DIAL_TEXT  .UpdateValue ( CONFIG . Obj . ATC . Connected_Dial_Text  ) ; 
                                                __context__.SourceCodeLine = 365;
                                                ATC_DISCONNECTED_DIAL_TEXT  .UpdateValue ( CONFIG . Obj . ATC . Disconnected_Dial_Text  ) ; 
                                                __context__.SourceCodeLine = 366;
                                                ATC_CONNECTED_HANGUP_TEXT  .UpdateValue ( CONFIG . Obj . ATC . Connected_Hangup_Text  ) ; 
                                                __context__.SourceCodeLine = 367;
                                                ATC_DISCONNECTED_HANGUP_TEXT  .UpdateValue ( CONFIG . Obj . ATC . Disconnected_Hangup_Text  ) ; 
                                                __context__.SourceCodeLine = 368;
                                                ATC_SSI_DEVICE_USAGE_TYPE  .UpdateValue ( CONFIG . Obj . ATC . SSI_Device_Usage . Device_Type  ) ; 
                                                __context__.SourceCodeLine = 369;
                                                ATC_SSI_DEVICE_USAGE_NAME  .UpdateValue ( CONFIG . Obj . ATC . SSI_Device_Usage . Device_Name  ) ; 
                                                __context__.SourceCodeLine = 370;
                                                ATC_SSI_SEVERITY_MESSAGE  .UpdateValue ( CONFIG . Obj . ATC . SSI_Equipment_Status . Severity_Message  ) ; 
                                                __context__.SourceCodeLine = 371;
                                                ATC_SSI_ERROR_TEXT  .UpdateValue ( CONFIG . Obj . ATC . SSI_Equipment_Status . Error_Text  ) ; 
                                                __context__.SourceCodeLine = 372;
                                                ATC_SSI_OK_TEXT  .UpdateValue ( CONFIG . Obj . ATC . SSI_Equipment_Status . Ok_Text  ) ; 
                                                __context__.SourceCodeLine = 374;
                                                VTC_EXTENSION  .UpdateValue ( CONFIG . Obj . VTC . Extension  ) ; 
                                                __context__.SourceCodeLine = 375;
                                                VTC_HELP_NUMBER  .UpdateValue ( CONFIG . Obj . VTC . Help_Number  ) ; 
                                                __context__.SourceCodeLine = 376;
                                                VTC_HELP_BTN_TEXT  .UpdateValue ( CONFIG . Obj . VTC . Help_Button_Text  ) ; 
                                                __context__.SourceCodeLine = 377;
                                                VTC_CONNECTED_DIAL_TEXT  .UpdateValue ( CONFIG . Obj . VTC . Connected_Dial_Text  ) ; 
                                                __context__.SourceCodeLine = 378;
                                                VTC_DISCONNECTED_DIAL_TEXT  .UpdateValue ( CONFIG . Obj . VTC . Disconnected_Dial_Text  ) ; 
                                                __context__.SourceCodeLine = 379;
                                                VTC_CONNECTED_HANGUP_TEXT  .UpdateValue ( CONFIG . Obj . VTC . Connected_Hangup_Text  ) ; 
                                                __context__.SourceCodeLine = 380;
                                                VTC_DISCONNECTED_HANGUP_TEXT  .UpdateValue ( CONFIG . Obj . VTC . Disconnected_Hangup_Text  ) ; 
                                                __context__.SourceCodeLine = 381;
                                                CONFIG . Obj . VTC . PresetToArray ( ) ; 
                                                __context__.SourceCodeLine = 382;
                                                try 
                                                    { 
                                                    __context__.SourceCodeLine = 383;
                                                    VTC_CAM_PRESET1_ID  .UpdateValue ( CONFIG . Obj . VTC . PresetsArray [ 0] . Id  ) ; 
                                                    __context__.SourceCodeLine = 384;
                                                    VTC_CAM_PRESET1_NAME  .UpdateValue ( CONFIG . Obj . VTC . PresetsArray [ 0] . Name  ) ; 
                                                    } 
                                                
                                                catch (Exception __splus_exception__)
                                                    { 
                                                    SimplPlusException __splus_exceptionobj__ = new SimplPlusException(__splus_exception__, this );
                                                    
                                                    
                                                    }
                                                    
                                                    __context__.SourceCodeLine = 385;
                                                    ; 
                                                    __context__.SourceCodeLine = 386;
                                                    try 
                                                        { 
                                                        __context__.SourceCodeLine = 387;
                                                        VTC_CAM_PRESET2_ID  .UpdateValue ( CONFIG . Obj . VTC . PresetsArray [ 1] . Id  ) ; 
                                                        __context__.SourceCodeLine = 388;
                                                        VTC_CAM_PRESET2_NAME  .UpdateValue ( CONFIG . Obj . VTC . PresetsArray [ 1] . Name  ) ; 
                                                        } 
                                                    
                                                    catch (Exception __splus_exception__)
                                                        { 
                                                        SimplPlusException __splus_exceptionobj__ = new SimplPlusException(__splus_exception__, this );
                                                        
                                                        
                                                        }
                                                        
                                                        __context__.SourceCodeLine = 389;
                                                        ; 
                                                        __context__.SourceCodeLine = 390;
                                                        try 
                                                            { 
                                                            __context__.SourceCodeLine = 391;
                                                            VTC_CAM_PRESET3_ID  .UpdateValue ( CONFIG . Obj . VTC . PresetsArray [ 2] . Id  ) ; 
                                                            __context__.SourceCodeLine = 392;
                                                            VTC_CAM_PRESET3_NAME  .UpdateValue ( CONFIG . Obj . VTC . PresetsArray [ 2] . Name  ) ; 
                                                            } 
                                                        
                                                        catch (Exception __splus_exception__)
                                                            { 
                                                            SimplPlusException __splus_exceptionobj__ = new SimplPlusException(__splus_exception__, this );
                                                            
                                                            
                                                            }
                                                            
                                                            __context__.SourceCodeLine = 393;
                                                            ; 
                                                            __context__.SourceCodeLine = 394;
                                                            try 
                                                                { 
                                                                __context__.SourceCodeLine = 395;
                                                                VTC_CAM_PRESET4_ID  .UpdateValue ( CONFIG . Obj . VTC . PresetsArray [ 3] . Id  ) ; 
                                                                __context__.SourceCodeLine = 396;
                                                                VTC_CAM_PRESET4_NAME  .UpdateValue ( CONFIG . Obj . VTC . PresetsArray [ 3] . Name  ) ; 
                                                                } 
                                                            
                                                            catch (Exception __splus_exception__)
                                                                { 
                                                                SimplPlusException __splus_exceptionobj__ = new SimplPlusException(__splus_exception__, this );
                                                                
                                                                
                                                                }
                                                                
                                                                __context__.SourceCodeLine = 397;
                                                                ; 
                                                                __context__.SourceCodeLine = 398;
                                                                try 
                                                                    { 
                                                                    __context__.SourceCodeLine = 399;
                                                                    VTC_CAM_PRESET5_ID  .UpdateValue ( CONFIG . Obj . VTC . PresetsArray [ 4] . Id  ) ; 
                                                                    __context__.SourceCodeLine = 400;
                                                                    VTC_CAM_PRESET5_NAME  .UpdateValue ( CONFIG . Obj . VTC . PresetsArray [ 4] . Name  ) ; 
                                                                    } 
                                                                
                                                                catch (Exception __splus_exception__)
                                                                    { 
                                                                    SimplPlusException __splus_exceptionobj__ = new SimplPlusException(__splus_exception__, this );
                                                                    
                                                                    
                                                                    }
                                                                    
                                                                    __context__.SourceCodeLine = 401;
                                                                    ; 
                                                                    __context__.SourceCodeLine = 402;
                                                                    try 
                                                                        { 
                                                                        __context__.SourceCodeLine = 403;
                                                                        VTC_CAM_PRESET6_ID  .UpdateValue ( CONFIG . Obj . VTC . PresetsArray [ 5] . Id  ) ; 
                                                                        __context__.SourceCodeLine = 404;
                                                                        VTC_CAM_PRESET6_NAME  .UpdateValue ( CONFIG . Obj . VTC . PresetsArray [ 5] . Name  ) ; 
                                                                        } 
                                                                    
                                                                    catch (Exception __splus_exception__)
                                                                        { 
                                                                        SimplPlusException __splus_exceptionobj__ = new SimplPlusException(__splus_exception__, this );
                                                                        
                                                                        
                                                                        }
                                                                        
                                                                        __context__.SourceCodeLine = 405;
                                                                        ; 
                                                                        __context__.SourceCodeLine = 406;
                                                                        VTC_SSI_DEVICE_USAGE_TYPE  .UpdateValue ( CONFIG . Obj . VTC . SSI_Device_Usage . Device_Type  ) ; 
                                                                        __context__.SourceCodeLine = 407;
                                                                        VTC_SSI_DEVICE_USAGE_NAME  .UpdateValue ( CONFIG . Obj . VTC . SSI_Device_Usage . Device_Name  ) ; 
                                                                        __context__.SourceCodeLine = 408;
                                                                        VTC_SSI_SEVERITY_MESSAGE  .UpdateValue ( CONFIG . Obj . VTC . SSI_Equipment_Status . Severity_Message  ) ; 
                                                                        __context__.SourceCodeLine = 409;
                                                                        VTC_SSI_ERROR_TEXT  .UpdateValue ( CONFIG . Obj . VTC . SSI_Equipment_Status . Error_Text  ) ; 
                                                                        __context__.SourceCodeLine = 410;
                                                                        VTC_SSI_OK_TEXT  .UpdateValue ( CONFIG . Obj . VTC . SSI_Equipment_Status . Ok_Text  ) ; 
                                                                        __context__.SourceCodeLine = 413;
                                                                        CONFIG . Obj . Lighting . PresetToArray ( ) ; 
                                                                        __context__.SourceCodeLine = 414;
                                                                        try 
                                                                            { 
                                                                            __context__.SourceCodeLine = 415;
                                                                            LIGHTING_PRESET1_ID  .UpdateValue ( CONFIG . Obj . Lighting . PresetsArray [ 0] . Id  ) ; 
                                                                            __context__.SourceCodeLine = 416;
                                                                            LIGHTING_PRESET1_NAME  .UpdateValue ( CONFIG . Obj . Lighting . PresetsArray [ 0] . Name  ) ; 
                                                                            } 
                                                                        
                                                                        catch (Exception __splus_exception__)
                                                                            { 
                                                                            SimplPlusException __splus_exceptionobj__ = new SimplPlusException(__splus_exception__, this );
                                                                            
                                                                            
                                                                            }
                                                                            
                                                                            __context__.SourceCodeLine = 417;
                                                                            ; 
                                                                            __context__.SourceCodeLine = 418;
                                                                            try 
                                                                                { 
                                                                                __context__.SourceCodeLine = 419;
                                                                                LIGHTING_PRESET2_ID  .UpdateValue ( CONFIG . Obj . Lighting . PresetsArray [ 1] . Id  ) ; 
                                                                                __context__.SourceCodeLine = 420;
                                                                                LIGHTING_PRESET2_NAME  .UpdateValue ( CONFIG . Obj . Lighting . PresetsArray [ 1] . Name  ) ; 
                                                                                } 
                                                                            
                                                                            catch (Exception __splus_exception__)
                                                                                { 
                                                                                SimplPlusException __splus_exceptionobj__ = new SimplPlusException(__splus_exception__, this );
                                                                                
                                                                                
                                                                                }
                                                                                
                                                                                __context__.SourceCodeLine = 421;
                                                                                ; 
                                                                                __context__.SourceCodeLine = 422;
                                                                                try 
                                                                                    { 
                                                                                    __context__.SourceCodeLine = 423;
                                                                                    LIGHTING_PRESET3_ID  .UpdateValue ( CONFIG . Obj . Lighting . PresetsArray [ 2] . Id  ) ; 
                                                                                    __context__.SourceCodeLine = 424;
                                                                                    LIGHTING_PRESET3_NAME  .UpdateValue ( CONFIG . Obj . Lighting . PresetsArray [ 2] . Name  ) ; 
                                                                                    } 
                                                                                
                                                                                catch (Exception __splus_exception__)
                                                                                    { 
                                                                                    SimplPlusException __splus_exceptionobj__ = new SimplPlusException(__splus_exception__, this );
                                                                                    
                                                                                    
                                                                                    }
                                                                                    
                                                                                    __context__.SourceCodeLine = 425;
                                                                                    ; 
                                                                                    __context__.SourceCodeLine = 426;
                                                                                    try 
                                                                                        { 
                                                                                        __context__.SourceCodeLine = 427;
                                                                                        LIGHTING_PRESET4_ID  .UpdateValue ( CONFIG . Obj . Lighting . PresetsArray [ 3] . Id  ) ; 
                                                                                        __context__.SourceCodeLine = 428;
                                                                                        LIGHTING_PRESET4_NAME  .UpdateValue ( CONFIG . Obj . Lighting . PresetsArray [ 3] . Name  ) ; 
                                                                                        } 
                                                                                    
                                                                                    catch (Exception __splus_exception__)
                                                                                        { 
                                                                                        SimplPlusException __splus_exceptionobj__ = new SimplPlusException(__splus_exception__, this );
                                                                                        
                                                                                        
                                                                                        }
                                                                                        
                                                                                        __context__.SourceCodeLine = 429;
                                                                                        ; 
                                                                                        __context__.SourceCodeLine = 430;
                                                                                        try 
                                                                                            { 
                                                                                            __context__.SourceCodeLine = 431;
                                                                                            LIGHTING_PRESET5_ID  .UpdateValue ( CONFIG . Obj . Lighting . PresetsArray [ 4] . Id  ) ; 
                                                                                            __context__.SourceCodeLine = 432;
                                                                                            LIGHTING_PRESET5_NAME  .UpdateValue ( CONFIG . Obj . Lighting . PresetsArray [ 4] . Name  ) ; 
                                                                                            } 
                                                                                        
                                                                                        catch (Exception __splus_exception__)
                                                                                            { 
                                                                                            SimplPlusException __splus_exceptionobj__ = new SimplPlusException(__splus_exception__, this );
                                                                                            
                                                                                            
                                                                                            }
                                                                                            
                                                                                            __context__.SourceCodeLine = 433;
                                                                                            ; 
                                                                                            __context__.SourceCodeLine = 434;
                                                                                            try 
                                                                                                { 
                                                                                                __context__.SourceCodeLine = 435;
                                                                                                LIGHTING_PRESET6_ID  .UpdateValue ( CONFIG . Obj . Lighting . PresetsArray [ 5] . Id  ) ; 
                                                                                                __context__.SourceCodeLine = 436;
                                                                                                LIGHTING_PRESET6_NAME  .UpdateValue ( CONFIG . Obj . Lighting . PresetsArray [ 5] . Name  ) ; 
                                                                                                } 
                                                                                            
                                                                                            catch (Exception __splus_exception__)
                                                                                                { 
                                                                                                SimplPlusException __splus_exceptionobj__ = new SimplPlusException(__splus_exception__, this );
                                                                                                
                                                                                                
                                                                                                }
                                                                                                
                                                                                                __context__.SourceCodeLine = 437;
                                                                                                ; 
                                                                                                __context__.SourceCodeLine = 438;
                                                                                                LIGHTING_SSI_SEVERITY_MESSAGE  .UpdateValue ( CONFIG . Obj . Lighting . SSI_Equipment_Status . Severity_Message  ) ; 
                                                                                                __context__.SourceCodeLine = 439;
                                                                                                LIGHTING_SSI_ERROR_TEXT  .UpdateValue ( CONFIG . Obj . Lighting . SSI_Equipment_Status . Error_Text  ) ; 
                                                                                                __context__.SourceCodeLine = 440;
                                                                                                LIGHTING_SSI_OK_TEXT  .UpdateValue ( CONFIG . Obj . Lighting . SSI_Equipment_Status . Ok_Text  ) ; 
                                                                                                __context__.SourceCodeLine = 443;
                                                                                                CONFIG . Obj . PowerSequencerToArray ( ) ; 
                                                                                                __context__.SourceCodeLine = 444;
                                                                                                try 
                                                                                                    { 
                                                                                                    __context__.SourceCodeLine = 445;
                                                                                                    SEQUENCER1_CH1_NAME  .UpdateValue ( CONFIG . Obj . PowerSequencerArray [ 0] . Channel_1_Name  ) ; 
                                                                                                    __context__.SourceCodeLine = 446;
                                                                                                    SEQUENCER1_CH2_NAME  .UpdateValue ( CONFIG . Obj . PowerSequencerArray [ 0] . Channel_2_Name  ) ; 
                                                                                                    __context__.SourceCodeLine = 447;
                                                                                                    SEQUENCER1_CH3_NAME  .UpdateValue ( CONFIG . Obj . PowerSequencerArray [ 0] . Channel_1_Name  ) ; 
                                                                                                    __context__.SourceCodeLine = 448;
                                                                                                    SEQUENCER1_CH4_NAME  .UpdateValue ( CONFIG . Obj . PowerSequencerArray [ 0] . Channel_1_Name  ) ; 
                                                                                                    __context__.SourceCodeLine = 449;
                                                                                                    SEQUENCER1_CH5_NAME  .UpdateValue ( CONFIG . Obj . PowerSequencerArray [ 0] . Channel_1_Name  ) ; 
                                                                                                    __context__.SourceCodeLine = 450;
                                                                                                    SEQUENCER1_CH6_NAME  .UpdateValue ( CONFIG . Obj . PowerSequencerArray [ 0] . Channel_1_Name  ) ; 
                                                                                                    __context__.SourceCodeLine = 451;
                                                                                                    SEQUENCER1_CH7_NAME  .UpdateValue ( CONFIG . Obj . PowerSequencerArray [ 0] . Channel_1_Name  ) ; 
                                                                                                    __context__.SourceCodeLine = 452;
                                                                                                    SEQUENCER1_CH8_NAME  .UpdateValue ( CONFIG . Obj . PowerSequencerArray [ 0] . Channel_1_Name  ) ; 
                                                                                                    } 
                                                                                                
                                                                                                catch (Exception __splus_exception__)
                                                                                                    { 
                                                                                                    SimplPlusException __splus_exceptionobj__ = new SimplPlusException(__splus_exception__, this );
                                                                                                    
                                                                                                    
                                                                                                    }
                                                                                                    
                                                                                                    __context__.SourceCodeLine = 453;
                                                                                                    ; 
                                                                                                    __context__.SourceCodeLine = 454;
                                                                                                    SEQUENCER1_SSI_SEVERITY_MESSAGE  .UpdateValue ( CONFIG . Obj . PowerSequencerArray [ 0] . SSI_Equipment_Status . Severity_Message  ) ; 
                                                                                                    __context__.SourceCodeLine = 455;
                                                                                                    SEQUENCER1_SSI_ERROR_TEXT  .UpdateValue ( CONFIG . Obj . PowerSequencerArray [ 0] . SSI_Equipment_Status . Error_Text  ) ; 
                                                                                                    __context__.SourceCodeLine = 456;
                                                                                                    SEQUENCER1_SSI_OK_TEXT  .UpdateValue ( CONFIG . Obj . PowerSequencerArray [ 0] . SSI_Equipment_Status . Ok_Text  ) ; 
                                                                                                    __context__.SourceCodeLine = 460;
                                                                                                    try 
                                                                                                        { 
                                                                                                        __context__.SourceCodeLine = 461;
                                                                                                        SEQUENCER2_CH1_NAME  .UpdateValue ( CONFIG . Obj . PowerSequencerArray [ 1] . Channel_1_Name  ) ; 
                                                                                                        __context__.SourceCodeLine = 462;
                                                                                                        SEQUENCER2_CH2_NAME  .UpdateValue ( CONFIG . Obj . PowerSequencerArray [ 1] . Channel_1_Name  ) ; 
                                                                                                        __context__.SourceCodeLine = 463;
                                                                                                        SEQUENCER2_CH3_NAME  .UpdateValue ( CONFIG . Obj . PowerSequencerArray [ 1] . Channel_1_Name  ) ; 
                                                                                                        __context__.SourceCodeLine = 464;
                                                                                                        SEQUENCER2_CH4_NAME  .UpdateValue ( CONFIG . Obj . PowerSequencerArray [ 1] . Channel_1_Name  ) ; 
                                                                                                        __context__.SourceCodeLine = 465;
                                                                                                        SEQUENCER2_CH5_NAME  .UpdateValue ( CONFIG . Obj . PowerSequencerArray [ 1] . Channel_1_Name  ) ; 
                                                                                                        __context__.SourceCodeLine = 466;
                                                                                                        SEQUENCER2_CH6_NAME  .UpdateValue ( CONFIG . Obj . PowerSequencerArray [ 1] . Channel_1_Name  ) ; 
                                                                                                        __context__.SourceCodeLine = 467;
                                                                                                        SEQUENCER2_CH7_NAME  .UpdateValue ( CONFIG . Obj . PowerSequencerArray [ 1] . Channel_1_Name  ) ; 
                                                                                                        __context__.SourceCodeLine = 468;
                                                                                                        SEQUENCER2_CH8_NAME  .UpdateValue ( CONFIG . Obj . PowerSequencerArray [ 1] . Channel_1_Name  ) ; 
                                                                                                        } 
                                                                                                    
                                                                                                    catch (Exception __splus_exception__)
                                                                                                        { 
                                                                                                        SimplPlusException __splus_exceptionobj__ = new SimplPlusException(__splus_exception__, this );
                                                                                                        
                                                                                                        
                                                                                                        }
                                                                                                        
                                                                                                        __context__.SourceCodeLine = 469;
                                                                                                        ; 
                                                                                                        __context__.SourceCodeLine = 470;
                                                                                                        SEQUENCER2_SSI_SEVERITY_MESSAGE  .UpdateValue ( CONFIG . Obj . PowerSequencerArray [ 1] . SSI_Equipment_Status . Severity_Message  ) ; 
                                                                                                        __context__.SourceCodeLine = 471;
                                                                                                        SEQUENCER2_SSI_ERROR_TEXT  .UpdateValue ( CONFIG . Obj . PowerSequencerArray [ 1] . SSI_Equipment_Status . Error_Text  ) ; 
                                                                                                        __context__.SourceCodeLine = 472;
                                                                                                        SEQUENCER2_SSI_OK_TEXT  .UpdateValue ( CONFIG . Obj . PowerSequencerArray [ 1] . SSI_Equipment_Status . Ok_Text  ) ; 
                                                                                                        
                                                                                                        
                                                                                                    }
                                                                                                    catch(Exception e) { ObjectCatchHandler(e); }
                                                                                                    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
                                                                                                    return this;
                                                                                                    
                                                                                                }
                                                                                                
                                                                                            public override object FunctionMain (  object __obj__ ) 
                                                                                                { 
                                                                                                try
                                                                                                {
                                                                                                    SplusExecutionContext __context__ = SplusFunctionMainStartCode();
                                                                                                    
                                                                                                    __context__.SourceCodeLine = 528;
                                                                                                    API . Start ( ) ; 
                                                                                                    __context__.SourceCodeLine = 529;
                                                                                                     Configuration.filePath  =( PATH__DOLLAR__  )  .ToString()  ;  
 
                                                                                                    
                                                                                                    
                                                                                                }
                                                                                                catch(Exception e) { ObjectCatchHandler(e); }
                                                                                                finally { ObjectFinallyHandler(); }
                                                                                                return __obj__;
                                                                                                }
                                                                                                
                                                                                            
                                                                                            public override void LogosSplusInitialize()
                                                                                            {
                                                                                                SocketInfo __socketinfo__ = new SocketInfo( 1, this );
                                                                                                InitialParametersClass.ResolveHostName = __socketinfo__.ResolveHostName;
                                                                                                _SplusNVRAM = new SplusNVRAM( this );
                                                                                                
                                                                                                PULL_CONFIG = new Crestron.Logos.SplusObjects.DigitalInput( PULL_CONFIG__DigitalInput__, this );
                                                                                                m_DigitalInputList.Add( PULL_CONFIG__DigitalInput__, PULL_CONFIG );
                                                                                                
                                                                                                DISPLAY1_SCREEN_ENABLED = new Crestron.Logos.SplusObjects.DigitalOutput( DISPLAY1_SCREEN_ENABLED__DigitalOutput__, this );
                                                                                                m_DigitalOutputList.Add( DISPLAY1_SCREEN_ENABLED__DigitalOutput__, DISPLAY1_SCREEN_ENABLED );
                                                                                                
                                                                                                DISPLAY2_SCREEN_ENABLED = new Crestron.Logos.SplusObjects.DigitalOutput( DISPLAY2_SCREEN_ENABLED__DigitalOutput__, this );
                                                                                                m_DigitalOutputList.Add( DISPLAY2_SCREEN_ENABLED__DigitalOutput__, DISPLAY2_SCREEN_ENABLED );
                                                                                                
                                                                                                STARTUP_TIME = new Crestron.Logos.SplusObjects.AnalogOutput( STARTUP_TIME__AnalogSerialOutput__, this );
                                                                                                m_AnalogOutputList.Add( STARTUP_TIME__AnalogSerialOutput__, STARTUP_TIME );
                                                                                                
                                                                                                SHUTDOWN_TIME_ACTIVE = new Crestron.Logos.SplusObjects.AnalogOutput( SHUTDOWN_TIME_ACTIVE__AnalogSerialOutput__, this );
                                                                                                m_AnalogOutputList.Add( SHUTDOWN_TIME_ACTIVE__AnalogSerialOutput__, SHUTDOWN_TIME_ACTIVE );
                                                                                                
                                                                                                SHUTDOWN_TIME_INACTIVE = new Crestron.Logos.SplusObjects.AnalogOutput( SHUTDOWN_TIME_INACTIVE__AnalogSerialOutput__, this );
                                                                                                m_AnalogOutputList.Add( SHUTDOWN_TIME_INACTIVE__AnalogSerialOutput__, SHUTDOWN_TIME_INACTIVE );
                                                                                                
                                                                                                DISPLAY1_WARMING_TIME = new Crestron.Logos.SplusObjects.AnalogOutput( DISPLAY1_WARMING_TIME__AnalogSerialOutput__, this );
                                                                                                m_AnalogOutputList.Add( DISPLAY1_WARMING_TIME__AnalogSerialOutput__, DISPLAY1_WARMING_TIME );
                                                                                                
                                                                                                DISPLAY2_WARMING_TIME = new Crestron.Logos.SplusObjects.AnalogOutput( DISPLAY2_WARMING_TIME__AnalogSerialOutput__, this );
                                                                                                m_AnalogOutputList.Add( DISPLAY2_WARMING_TIME__AnalogSerialOutput__, DISPLAY2_WARMING_TIME );
                                                                                                
                                                                                                PRESENTATION1_SWITCHER_VALUE = new Crestron.Logos.SplusObjects.AnalogOutput( PRESENTATION1_SWITCHER_VALUE__AnalogSerialOutput__, this );
                                                                                                m_AnalogOutputList.Add( PRESENTATION1_SWITCHER_VALUE__AnalogSerialOutput__, PRESENTATION1_SWITCHER_VALUE );
                                                                                                
                                                                                                PRESENTATION2_SWITCHER_VALUE = new Crestron.Logos.SplusObjects.AnalogOutput( PRESENTATION2_SWITCHER_VALUE__AnalogSerialOutput__, this );
                                                                                                m_AnalogOutputList.Add( PRESENTATION2_SWITCHER_VALUE__AnalogSerialOutput__, PRESENTATION2_SWITCHER_VALUE );
                                                                                                
                                                                                                PRESENTATION3_SWITCHER_VALUE = new Crestron.Logos.SplusObjects.AnalogOutput( PRESENTATION3_SWITCHER_VALUE__AnalogSerialOutput__, this );
                                                                                                m_AnalogOutputList.Add( PRESENTATION3_SWITCHER_VALUE__AnalogSerialOutput__, PRESENTATION3_SWITCHER_VALUE );
                                                                                                
                                                                                                PRESENTATION4_SWITCHER_VALUE = new Crestron.Logos.SplusObjects.AnalogOutput( PRESENTATION4_SWITCHER_VALUE__AnalogSerialOutput__, this );
                                                                                                m_AnalogOutputList.Add( PRESENTATION4_SWITCHER_VALUE__AnalogSerialOutput__, PRESENTATION4_SWITCHER_VALUE );
                                                                                                
                                                                                                PRESENTATION5_SWITCHER_VALUE = new Crestron.Logos.SplusObjects.AnalogOutput( PRESENTATION5_SWITCHER_VALUE__AnalogSerialOutput__, this );
                                                                                                m_AnalogOutputList.Add( PRESENTATION5_SWITCHER_VALUE__AnalogSerialOutput__, PRESENTATION5_SWITCHER_VALUE );
                                                                                                
                                                                                                PRESENTATION6_SWITCHER_VALUE = new Crestron.Logos.SplusObjects.AnalogOutput( PRESENTATION6_SWITCHER_VALUE__AnalogSerialOutput__, this );
                                                                                                m_AnalogOutputList.Add( PRESENTATION6_SWITCHER_VALUE__AnalogSerialOutput__, PRESENTATION6_SWITCHER_VALUE );
                                                                                                
                                                                                                ROOM_NAME = new Crestron.Logos.SplusObjects.StringOutput( ROOM_NAME__AnalogSerialOutput__, this );
                                                                                                m_StringOutputList.Add( ROOM_NAME__AnalogSerialOutput__, ROOM_NAME );
                                                                                                
                                                                                                WELCOME_TEXT = new Crestron.Logos.SplusObjects.StringOutput( WELCOME_TEXT__AnalogSerialOutput__, this );
                                                                                                m_StringOutputList.Add( WELCOME_TEXT__AnalogSerialOutput__, WELCOME_TEXT );
                                                                                                
                                                                                                SHUTDOWN_TEXT = new Crestron.Logos.SplusObjects.StringOutput( SHUTDOWN_TEXT__AnalogSerialOutput__, this );
                                                                                                m_StringOutputList.Add( SHUTDOWN_TEXT__AnalogSerialOutput__, SHUTDOWN_TEXT );
                                                                                                
                                                                                                WARMING_TEXT = new Crestron.Logos.SplusObjects.StringOutput( WARMING_TEXT__AnalogSerialOutput__, this );
                                                                                                m_StringOutputList.Add( WARMING_TEXT__AnalogSerialOutput__, WARMING_TEXT );
                                                                                                
                                                                                                COOLING_TEXT = new Crestron.Logos.SplusObjects.StringOutput( COOLING_TEXT__AnalogSerialOutput__, this );
                                                                                                m_StringOutputList.Add( COOLING_TEXT__AnalogSerialOutput__, COOLING_TEXT );
                                                                                                
                                                                                                DISPLAY1_NAME = new Crestron.Logos.SplusObjects.StringOutput( DISPLAY1_NAME__AnalogSerialOutput__, this );
                                                                                                m_StringOutputList.Add( DISPLAY1_NAME__AnalogSerialOutput__, DISPLAY1_NAME );
                                                                                                
                                                                                                DISPLAY1_TYPE = new Crestron.Logos.SplusObjects.StringOutput( DISPLAY1_TYPE__AnalogSerialOutput__, this );
                                                                                                m_StringOutputList.Add( DISPLAY1_TYPE__AnalogSerialOutput__, DISPLAY1_TYPE );
                                                                                                
                                                                                                DISPLAY1_SSI_USAGE_NAME = new Crestron.Logos.SplusObjects.StringOutput( DISPLAY1_SSI_USAGE_NAME__AnalogSerialOutput__, this );
                                                                                                m_StringOutputList.Add( DISPLAY1_SSI_USAGE_NAME__AnalogSerialOutput__, DISPLAY1_SSI_USAGE_NAME );
                                                                                                
                                                                                                DISPLAY1_SSI_SEVERITY_MESSAGE = new Crestron.Logos.SplusObjects.StringOutput( DISPLAY1_SSI_SEVERITY_MESSAGE__AnalogSerialOutput__, this );
                                                                                                m_StringOutputList.Add( DISPLAY1_SSI_SEVERITY_MESSAGE__AnalogSerialOutput__, DISPLAY1_SSI_SEVERITY_MESSAGE );
                                                                                                
                                                                                                DISPLAY1_SSI_ERROR_TEXT = new Crestron.Logos.SplusObjects.StringOutput( DISPLAY1_SSI_ERROR_TEXT__AnalogSerialOutput__, this );
                                                                                                m_StringOutputList.Add( DISPLAY1_SSI_ERROR_TEXT__AnalogSerialOutput__, DISPLAY1_SSI_ERROR_TEXT );
                                                                                                
                                                                                                DISPLAY1_SSI_OK_TEXT = new Crestron.Logos.SplusObjects.StringOutput( DISPLAY1_SSI_OK_TEXT__AnalogSerialOutput__, this );
                                                                                                m_StringOutputList.Add( DISPLAY1_SSI_OK_TEXT__AnalogSerialOutput__, DISPLAY1_SSI_OK_TEXT );
                                                                                                
                                                                                                DISPLAY2_NAME = new Crestron.Logos.SplusObjects.StringOutput( DISPLAY2_NAME__AnalogSerialOutput__, this );
                                                                                                m_StringOutputList.Add( DISPLAY2_NAME__AnalogSerialOutput__, DISPLAY2_NAME );
                                                                                                
                                                                                                DISPLAY2_TYPE = new Crestron.Logos.SplusObjects.StringOutput( DISPLAY2_TYPE__AnalogSerialOutput__, this );
                                                                                                m_StringOutputList.Add( DISPLAY2_TYPE__AnalogSerialOutput__, DISPLAY2_TYPE );
                                                                                                
                                                                                                DISPLAY2_SSI_USAGE_NAME = new Crestron.Logos.SplusObjects.StringOutput( DISPLAY2_SSI_USAGE_NAME__AnalogSerialOutput__, this );
                                                                                                m_StringOutputList.Add( DISPLAY2_SSI_USAGE_NAME__AnalogSerialOutput__, DISPLAY2_SSI_USAGE_NAME );
                                                                                                
                                                                                                DISPLAY2_SSI_SEVERITY_MESSAGE = new Crestron.Logos.SplusObjects.StringOutput( DISPLAY2_SSI_SEVERITY_MESSAGE__AnalogSerialOutput__, this );
                                                                                                m_StringOutputList.Add( DISPLAY2_SSI_SEVERITY_MESSAGE__AnalogSerialOutput__, DISPLAY2_SSI_SEVERITY_MESSAGE );
                                                                                                
                                                                                                DISPLAY2_SSI_ERROR_TEXT = new Crestron.Logos.SplusObjects.StringOutput( DISPLAY2_SSI_ERROR_TEXT__AnalogSerialOutput__, this );
                                                                                                m_StringOutputList.Add( DISPLAY2_SSI_ERROR_TEXT__AnalogSerialOutput__, DISPLAY2_SSI_ERROR_TEXT );
                                                                                                
                                                                                                DISPLAY2_SSI_OK_TEXT = new Crestron.Logos.SplusObjects.StringOutput( DISPLAY2_SSI_OK_TEXT__AnalogSerialOutput__, this );
                                                                                                m_StringOutputList.Add( DISPLAY2_SSI_OK_TEXT__AnalogSerialOutput__, DISPLAY2_SSI_OK_TEXT );
                                                                                                
                                                                                                PRESENTATION1_NAME = new Crestron.Logos.SplusObjects.StringOutput( PRESENTATION1_NAME__AnalogSerialOutput__, this );
                                                                                                m_StringOutputList.Add( PRESENTATION1_NAME__AnalogSerialOutput__, PRESENTATION1_NAME );
                                                                                                
                                                                                                PRESENTATION1_TYPE = new Crestron.Logos.SplusObjects.StringOutput( PRESENTATION1_TYPE__AnalogSerialOutput__, this );
                                                                                                m_StringOutputList.Add( PRESENTATION1_TYPE__AnalogSerialOutput__, PRESENTATION1_TYPE );
                                                                                                
                                                                                                PRESENTATION1_GENERIC_PAGE_TEXT = new Crestron.Logos.SplusObjects.StringOutput( PRESENTATION1_GENERIC_PAGE_TEXT__AnalogSerialOutput__, this );
                                                                                                m_StringOutputList.Add( PRESENTATION1_GENERIC_PAGE_TEXT__AnalogSerialOutput__, PRESENTATION1_GENERIC_PAGE_TEXT );
                                                                                                
                                                                                                PRESENTATION1_SSI_DEVICE_USAGE_TYPE = new Crestron.Logos.SplusObjects.StringOutput( PRESENTATION1_SSI_DEVICE_USAGE_TYPE__AnalogSerialOutput__, this );
                                                                                                m_StringOutputList.Add( PRESENTATION1_SSI_DEVICE_USAGE_TYPE__AnalogSerialOutput__, PRESENTATION1_SSI_DEVICE_USAGE_TYPE );
                                                                                                
                                                                                                PRESENTATION1_SSI_DEVICE_USAGE_NAME = new Crestron.Logos.SplusObjects.StringOutput( PRESENTATION1_SSI_DEVICE_USAGE_NAME__AnalogSerialOutput__, this );
                                                                                                m_StringOutputList.Add( PRESENTATION1_SSI_DEVICE_USAGE_NAME__AnalogSerialOutput__, PRESENTATION1_SSI_DEVICE_USAGE_NAME );
                                                                                                
                                                                                                PRESENTATION1_SSI_SEVERITY_MESSAGE = new Crestron.Logos.SplusObjects.StringOutput( PRESENTATION1_SSI_SEVERITY_MESSAGE__AnalogSerialOutput__, this );
                                                                                                m_StringOutputList.Add( PRESENTATION1_SSI_SEVERITY_MESSAGE__AnalogSerialOutput__, PRESENTATION1_SSI_SEVERITY_MESSAGE );
                                                                                                
                                                                                                PRESENTATION1_SSI_ERROR_TEXT = new Crestron.Logos.SplusObjects.StringOutput( PRESENTATION1_SSI_ERROR_TEXT__AnalogSerialOutput__, this );
                                                                                                m_StringOutputList.Add( PRESENTATION1_SSI_ERROR_TEXT__AnalogSerialOutput__, PRESENTATION1_SSI_ERROR_TEXT );
                                                                                                
                                                                                                PRESENTATION1_SSI_OK_TEXT = new Crestron.Logos.SplusObjects.StringOutput( PRESENTATION1_SSI_OK_TEXT__AnalogSerialOutput__, this );
                                                                                                m_StringOutputList.Add( PRESENTATION1_SSI_OK_TEXT__AnalogSerialOutput__, PRESENTATION1_SSI_OK_TEXT );
                                                                                                
                                                                                                PRESENTATION2_NAME = new Crestron.Logos.SplusObjects.StringOutput( PRESENTATION2_NAME__AnalogSerialOutput__, this );
                                                                                                m_StringOutputList.Add( PRESENTATION2_NAME__AnalogSerialOutput__, PRESENTATION2_NAME );
                                                                                                
                                                                                                PRESENTATION2_TYPE = new Crestron.Logos.SplusObjects.StringOutput( PRESENTATION2_TYPE__AnalogSerialOutput__, this );
                                                                                                m_StringOutputList.Add( PRESENTATION2_TYPE__AnalogSerialOutput__, PRESENTATION2_TYPE );
                                                                                                
                                                                                                PRESENTATION2_GENERIC_PAGE_TEXT = new Crestron.Logos.SplusObjects.StringOutput( PRESENTATION2_GENERIC_PAGE_TEXT__AnalogSerialOutput__, this );
                                                                                                m_StringOutputList.Add( PRESENTATION2_GENERIC_PAGE_TEXT__AnalogSerialOutput__, PRESENTATION2_GENERIC_PAGE_TEXT );
                                                                                                
                                                                                                PRESENTATION2_SSI_DEVICE_USAGE_TYPE = new Crestron.Logos.SplusObjects.StringOutput( PRESENTATION2_SSI_DEVICE_USAGE_TYPE__AnalogSerialOutput__, this );
                                                                                                m_StringOutputList.Add( PRESENTATION2_SSI_DEVICE_USAGE_TYPE__AnalogSerialOutput__, PRESENTATION2_SSI_DEVICE_USAGE_TYPE );
                                                                                                
                                                                                                PRESENTATION2_SSI_DEVICE_USAGE_NAME = new Crestron.Logos.SplusObjects.StringOutput( PRESENTATION2_SSI_DEVICE_USAGE_NAME__AnalogSerialOutput__, this );
                                                                                                m_StringOutputList.Add( PRESENTATION2_SSI_DEVICE_USAGE_NAME__AnalogSerialOutput__, PRESENTATION2_SSI_DEVICE_USAGE_NAME );
                                                                                                
                                                                                                PRESENTATION2_SSI_SEVERITY_MESSAGE = new Crestron.Logos.SplusObjects.StringOutput( PRESENTATION2_SSI_SEVERITY_MESSAGE__AnalogSerialOutput__, this );
                                                                                                m_StringOutputList.Add( PRESENTATION2_SSI_SEVERITY_MESSAGE__AnalogSerialOutput__, PRESENTATION2_SSI_SEVERITY_MESSAGE );
                                                                                                
                                                                                                PRESENTATION2_SSI_ERROR_TEXT = new Crestron.Logos.SplusObjects.StringOutput( PRESENTATION2_SSI_ERROR_TEXT__AnalogSerialOutput__, this );
                                                                                                m_StringOutputList.Add( PRESENTATION2_SSI_ERROR_TEXT__AnalogSerialOutput__, PRESENTATION2_SSI_ERROR_TEXT );
                                                                                                
                                                                                                PRESENTATION2_SSI_OK_TEXT = new Crestron.Logos.SplusObjects.StringOutput( PRESENTATION2_SSI_OK_TEXT__AnalogSerialOutput__, this );
                                                                                                m_StringOutputList.Add( PRESENTATION2_SSI_OK_TEXT__AnalogSerialOutput__, PRESENTATION2_SSI_OK_TEXT );
                                                                                                
                                                                                                PRESENTATION3_NAME = new Crestron.Logos.SplusObjects.StringOutput( PRESENTATION3_NAME__AnalogSerialOutput__, this );
                                                                                                m_StringOutputList.Add( PRESENTATION3_NAME__AnalogSerialOutput__, PRESENTATION3_NAME );
                                                                                                
                                                                                                PRESENTATION3_TYPE = new Crestron.Logos.SplusObjects.StringOutput( PRESENTATION3_TYPE__AnalogSerialOutput__, this );
                                                                                                m_StringOutputList.Add( PRESENTATION3_TYPE__AnalogSerialOutput__, PRESENTATION3_TYPE );
                                                                                                
                                                                                                PRESENTATION3_GENERIC_PAGE_TEXT = new Crestron.Logos.SplusObjects.StringOutput( PRESENTATION3_GENERIC_PAGE_TEXT__AnalogSerialOutput__, this );
                                                                                                m_StringOutputList.Add( PRESENTATION3_GENERIC_PAGE_TEXT__AnalogSerialOutput__, PRESENTATION3_GENERIC_PAGE_TEXT );
                                                                                                
                                                                                                PRESENTATION3_SSI_DEVICE_USAGE_TYPE = new Crestron.Logos.SplusObjects.StringOutput( PRESENTATION3_SSI_DEVICE_USAGE_TYPE__AnalogSerialOutput__, this );
                                                                                                m_StringOutputList.Add( PRESENTATION3_SSI_DEVICE_USAGE_TYPE__AnalogSerialOutput__, PRESENTATION3_SSI_DEVICE_USAGE_TYPE );
                                                                                                
                                                                                                PRESENTATION3_SSI_DEVICE_USAGE_NAME = new Crestron.Logos.SplusObjects.StringOutput( PRESENTATION3_SSI_DEVICE_USAGE_NAME__AnalogSerialOutput__, this );
                                                                                                m_StringOutputList.Add( PRESENTATION3_SSI_DEVICE_USAGE_NAME__AnalogSerialOutput__, PRESENTATION3_SSI_DEVICE_USAGE_NAME );
                                                                                                
                                                                                                PRESENTATION3_SSI_SEVERITY_MESSAGE = new Crestron.Logos.SplusObjects.StringOutput( PRESENTATION3_SSI_SEVERITY_MESSAGE__AnalogSerialOutput__, this );
                                                                                                m_StringOutputList.Add( PRESENTATION3_SSI_SEVERITY_MESSAGE__AnalogSerialOutput__, PRESENTATION3_SSI_SEVERITY_MESSAGE );
                                                                                                
                                                                                                PRESENTATION3_SSI_ERROR_TEXT = new Crestron.Logos.SplusObjects.StringOutput( PRESENTATION3_SSI_ERROR_TEXT__AnalogSerialOutput__, this );
                                                                                                m_StringOutputList.Add( PRESENTATION3_SSI_ERROR_TEXT__AnalogSerialOutput__, PRESENTATION3_SSI_ERROR_TEXT );
                                                                                                
                                                                                                PRESENTATION3_SSI_OK_TEXT = new Crestron.Logos.SplusObjects.StringOutput( PRESENTATION3_SSI_OK_TEXT__AnalogSerialOutput__, this );
                                                                                                m_StringOutputList.Add( PRESENTATION3_SSI_OK_TEXT__AnalogSerialOutput__, PRESENTATION3_SSI_OK_TEXT );
                                                                                                
                                                                                                PRESENTATION4_NAME = new Crestron.Logos.SplusObjects.StringOutput( PRESENTATION4_NAME__AnalogSerialOutput__, this );
                                                                                                m_StringOutputList.Add( PRESENTATION4_NAME__AnalogSerialOutput__, PRESENTATION4_NAME );
                                                                                                
                                                                                                PRESENTATION4_TYPE = new Crestron.Logos.SplusObjects.StringOutput( PRESENTATION4_TYPE__AnalogSerialOutput__, this );
                                                                                                m_StringOutputList.Add( PRESENTATION4_TYPE__AnalogSerialOutput__, PRESENTATION4_TYPE );
                                                                                                
                                                                                                PRESENTATION4_GENERIC_PAGE_TEXT = new Crestron.Logos.SplusObjects.StringOutput( PRESENTATION4_GENERIC_PAGE_TEXT__AnalogSerialOutput__, this );
                                                                                                m_StringOutputList.Add( PRESENTATION4_GENERIC_PAGE_TEXT__AnalogSerialOutput__, PRESENTATION4_GENERIC_PAGE_TEXT );
                                                                                                
                                                                                                PRESENTATION4_SSI_DEVICE_USAGE_TYPE = new Crestron.Logos.SplusObjects.StringOutput( PRESENTATION4_SSI_DEVICE_USAGE_TYPE__AnalogSerialOutput__, this );
                                                                                                m_StringOutputList.Add( PRESENTATION4_SSI_DEVICE_USAGE_TYPE__AnalogSerialOutput__, PRESENTATION4_SSI_DEVICE_USAGE_TYPE );
                                                                                                
                                                                                                PRESENTATION4_SSI_DEVICE_USAGE_NAME = new Crestron.Logos.SplusObjects.StringOutput( PRESENTATION4_SSI_DEVICE_USAGE_NAME__AnalogSerialOutput__, this );
                                                                                                m_StringOutputList.Add( PRESENTATION4_SSI_DEVICE_USAGE_NAME__AnalogSerialOutput__, PRESENTATION4_SSI_DEVICE_USAGE_NAME );
                                                                                                
                                                                                                PRESENTATION4_SSI_SEVERITY_MESSAGE = new Crestron.Logos.SplusObjects.StringOutput( PRESENTATION4_SSI_SEVERITY_MESSAGE__AnalogSerialOutput__, this );
                                                                                                m_StringOutputList.Add( PRESENTATION4_SSI_SEVERITY_MESSAGE__AnalogSerialOutput__, PRESENTATION4_SSI_SEVERITY_MESSAGE );
                                                                                                
                                                                                                PRESENTATION4_SSI_ERROR_TEXT = new Crestron.Logos.SplusObjects.StringOutput( PRESENTATION4_SSI_ERROR_TEXT__AnalogSerialOutput__, this );
                                                                                                m_StringOutputList.Add( PRESENTATION4_SSI_ERROR_TEXT__AnalogSerialOutput__, PRESENTATION4_SSI_ERROR_TEXT );
                                                                                                
                                                                                                PRESENTATION4_SSI_OK_TEXT = new Crestron.Logos.SplusObjects.StringOutput( PRESENTATION4_SSI_OK_TEXT__AnalogSerialOutput__, this );
                                                                                                m_StringOutputList.Add( PRESENTATION4_SSI_OK_TEXT__AnalogSerialOutput__, PRESENTATION4_SSI_OK_TEXT );
                                                                                                
                                                                                                PRESENTATION5_NAME = new Crestron.Logos.SplusObjects.StringOutput( PRESENTATION5_NAME__AnalogSerialOutput__, this );
                                                                                                m_StringOutputList.Add( PRESENTATION5_NAME__AnalogSerialOutput__, PRESENTATION5_NAME );
                                                                                                
                                                                                                PRESENTATION5_TYPE = new Crestron.Logos.SplusObjects.StringOutput( PRESENTATION5_TYPE__AnalogSerialOutput__, this );
                                                                                                m_StringOutputList.Add( PRESENTATION5_TYPE__AnalogSerialOutput__, PRESENTATION5_TYPE );
                                                                                                
                                                                                                PRESENTATION5_GENERIC_PAGE_TEXT = new Crestron.Logos.SplusObjects.StringOutput( PRESENTATION5_GENERIC_PAGE_TEXT__AnalogSerialOutput__, this );
                                                                                                m_StringOutputList.Add( PRESENTATION5_GENERIC_PAGE_TEXT__AnalogSerialOutput__, PRESENTATION5_GENERIC_PAGE_TEXT );
                                                                                                
                                                                                                PRESENTATION5_SSI_DEVICE_USAGE_TYPE = new Crestron.Logos.SplusObjects.StringOutput( PRESENTATION5_SSI_DEVICE_USAGE_TYPE__AnalogSerialOutput__, this );
                                                                                                m_StringOutputList.Add( PRESENTATION5_SSI_DEVICE_USAGE_TYPE__AnalogSerialOutput__, PRESENTATION5_SSI_DEVICE_USAGE_TYPE );
                                                                                                
                                                                                                PRESENTATION5_SSI_DEVICE_USAGE_NAME = new Crestron.Logos.SplusObjects.StringOutput( PRESENTATION5_SSI_DEVICE_USAGE_NAME__AnalogSerialOutput__, this );
                                                                                                m_StringOutputList.Add( PRESENTATION5_SSI_DEVICE_USAGE_NAME__AnalogSerialOutput__, PRESENTATION5_SSI_DEVICE_USAGE_NAME );
                                                                                                
                                                                                                PRESENTATION5_SSI_SEVERITY_MESSAGE = new Crestron.Logos.SplusObjects.StringOutput( PRESENTATION5_SSI_SEVERITY_MESSAGE__AnalogSerialOutput__, this );
                                                                                                m_StringOutputList.Add( PRESENTATION5_SSI_SEVERITY_MESSAGE__AnalogSerialOutput__, PRESENTATION5_SSI_SEVERITY_MESSAGE );
                                                                                                
                                                                                                PRESENTATION5_SSI_ERROR_TEXT = new Crestron.Logos.SplusObjects.StringOutput( PRESENTATION5_SSI_ERROR_TEXT__AnalogSerialOutput__, this );
                                                                                                m_StringOutputList.Add( PRESENTATION5_SSI_ERROR_TEXT__AnalogSerialOutput__, PRESENTATION5_SSI_ERROR_TEXT );
                                                                                                
                                                                                                PRESENTATION5_SSI_OK_TEXT = new Crestron.Logos.SplusObjects.StringOutput( PRESENTATION5_SSI_OK_TEXT__AnalogSerialOutput__, this );
                                                                                                m_StringOutputList.Add( PRESENTATION5_SSI_OK_TEXT__AnalogSerialOutput__, PRESENTATION5_SSI_OK_TEXT );
                                                                                                
                                                                                                PRESENTATION6_NAME = new Crestron.Logos.SplusObjects.StringOutput( PRESENTATION6_NAME__AnalogSerialOutput__, this );
                                                                                                m_StringOutputList.Add( PRESENTATION6_NAME__AnalogSerialOutput__, PRESENTATION6_NAME );
                                                                                                
                                                                                                PRESENTATION6_TYPE = new Crestron.Logos.SplusObjects.StringOutput( PRESENTATION6_TYPE__AnalogSerialOutput__, this );
                                                                                                m_StringOutputList.Add( PRESENTATION6_TYPE__AnalogSerialOutput__, PRESENTATION6_TYPE );
                                                                                                
                                                                                                PRESENTATION6_GENERIC_PAGE_TEXT = new Crestron.Logos.SplusObjects.StringOutput( PRESENTATION6_GENERIC_PAGE_TEXT__AnalogSerialOutput__, this );
                                                                                                m_StringOutputList.Add( PRESENTATION6_GENERIC_PAGE_TEXT__AnalogSerialOutput__, PRESENTATION6_GENERIC_PAGE_TEXT );
                                                                                                
                                                                                                PRESENTATION6_SSI_DEVICE_USAGE_TYPE = new Crestron.Logos.SplusObjects.StringOutput( PRESENTATION6_SSI_DEVICE_USAGE_TYPE__AnalogSerialOutput__, this );
                                                                                                m_StringOutputList.Add( PRESENTATION6_SSI_DEVICE_USAGE_TYPE__AnalogSerialOutput__, PRESENTATION6_SSI_DEVICE_USAGE_TYPE );
                                                                                                
                                                                                                PRESENTATION6_SSI_DEVICE_USAGE_NAME = new Crestron.Logos.SplusObjects.StringOutput( PRESENTATION6_SSI_DEVICE_USAGE_NAME__AnalogSerialOutput__, this );
                                                                                                m_StringOutputList.Add( PRESENTATION6_SSI_DEVICE_USAGE_NAME__AnalogSerialOutput__, PRESENTATION6_SSI_DEVICE_USAGE_NAME );
                                                                                                
                                                                                                PRESENTATION6_SSI_SEVERITY_MESSAGE = new Crestron.Logos.SplusObjects.StringOutput( PRESENTATION6_SSI_SEVERITY_MESSAGE__AnalogSerialOutput__, this );
                                                                                                m_StringOutputList.Add( PRESENTATION6_SSI_SEVERITY_MESSAGE__AnalogSerialOutput__, PRESENTATION6_SSI_SEVERITY_MESSAGE );
                                                                                                
                                                                                                PRESENTATION6_SSI_ERROR_TEXT = new Crestron.Logos.SplusObjects.StringOutput( PRESENTATION6_SSI_ERROR_TEXT__AnalogSerialOutput__, this );
                                                                                                m_StringOutputList.Add( PRESENTATION6_SSI_ERROR_TEXT__AnalogSerialOutput__, PRESENTATION6_SSI_ERROR_TEXT );
                                                                                                
                                                                                                PRESENTATION6_SSI_OK_TEXT = new Crestron.Logos.SplusObjects.StringOutput( PRESENTATION6_SSI_OK_TEXT__AnalogSerialOutput__, this );
                                                                                                m_StringOutputList.Add( PRESENTATION6_SSI_OK_TEXT__AnalogSerialOutput__, PRESENTATION6_SSI_OK_TEXT );
                                                                                                
                                                                                                ATC_EXTENSION = new Crestron.Logos.SplusObjects.StringOutput( ATC_EXTENSION__AnalogSerialOutput__, this );
                                                                                                m_StringOutputList.Add( ATC_EXTENSION__AnalogSerialOutput__, ATC_EXTENSION );
                                                                                                
                                                                                                ATC_HELP_NUMBER = new Crestron.Logos.SplusObjects.StringOutput( ATC_HELP_NUMBER__AnalogSerialOutput__, this );
                                                                                                m_StringOutputList.Add( ATC_HELP_NUMBER__AnalogSerialOutput__, ATC_HELP_NUMBER );
                                                                                                
                                                                                                ATC_HELP_BTN_TEXT = new Crestron.Logos.SplusObjects.StringOutput( ATC_HELP_BTN_TEXT__AnalogSerialOutput__, this );
                                                                                                m_StringOutputList.Add( ATC_HELP_BTN_TEXT__AnalogSerialOutput__, ATC_HELP_BTN_TEXT );
                                                                                                
                                                                                                ATC_CONNECTED_DIAL_TEXT = new Crestron.Logos.SplusObjects.StringOutput( ATC_CONNECTED_DIAL_TEXT__AnalogSerialOutput__, this );
                                                                                                m_StringOutputList.Add( ATC_CONNECTED_DIAL_TEXT__AnalogSerialOutput__, ATC_CONNECTED_DIAL_TEXT );
                                                                                                
                                                                                                ATC_DISCONNECTED_DIAL_TEXT = new Crestron.Logos.SplusObjects.StringOutput( ATC_DISCONNECTED_DIAL_TEXT__AnalogSerialOutput__, this );
                                                                                                m_StringOutputList.Add( ATC_DISCONNECTED_DIAL_TEXT__AnalogSerialOutput__, ATC_DISCONNECTED_DIAL_TEXT );
                                                                                                
                                                                                                ATC_CONNECTED_HANGUP_TEXT = new Crestron.Logos.SplusObjects.StringOutput( ATC_CONNECTED_HANGUP_TEXT__AnalogSerialOutput__, this );
                                                                                                m_StringOutputList.Add( ATC_CONNECTED_HANGUP_TEXT__AnalogSerialOutput__, ATC_CONNECTED_HANGUP_TEXT );
                                                                                                
                                                                                                ATC_DISCONNECTED_HANGUP_TEXT = new Crestron.Logos.SplusObjects.StringOutput( ATC_DISCONNECTED_HANGUP_TEXT__AnalogSerialOutput__, this );
                                                                                                m_StringOutputList.Add( ATC_DISCONNECTED_HANGUP_TEXT__AnalogSerialOutput__, ATC_DISCONNECTED_HANGUP_TEXT );
                                                                                                
                                                                                                ATC_SSI_DEVICE_USAGE_TYPE = new Crestron.Logos.SplusObjects.StringOutput( ATC_SSI_DEVICE_USAGE_TYPE__AnalogSerialOutput__, this );
                                                                                                m_StringOutputList.Add( ATC_SSI_DEVICE_USAGE_TYPE__AnalogSerialOutput__, ATC_SSI_DEVICE_USAGE_TYPE );
                                                                                                
                                                                                                ATC_SSI_DEVICE_USAGE_NAME = new Crestron.Logos.SplusObjects.StringOutput( ATC_SSI_DEVICE_USAGE_NAME__AnalogSerialOutput__, this );
                                                                                                m_StringOutputList.Add( ATC_SSI_DEVICE_USAGE_NAME__AnalogSerialOutput__, ATC_SSI_DEVICE_USAGE_NAME );
                                                                                                
                                                                                                ATC_SSI_SEVERITY_MESSAGE = new Crestron.Logos.SplusObjects.StringOutput( ATC_SSI_SEVERITY_MESSAGE__AnalogSerialOutput__, this );
                                                                                                m_StringOutputList.Add( ATC_SSI_SEVERITY_MESSAGE__AnalogSerialOutput__, ATC_SSI_SEVERITY_MESSAGE );
                                                                                                
                                                                                                ATC_SSI_ERROR_TEXT = new Crestron.Logos.SplusObjects.StringOutput( ATC_SSI_ERROR_TEXT__AnalogSerialOutput__, this );
                                                                                                m_StringOutputList.Add( ATC_SSI_ERROR_TEXT__AnalogSerialOutput__, ATC_SSI_ERROR_TEXT );
                                                                                                
                                                                                                ATC_SSI_OK_TEXT = new Crestron.Logos.SplusObjects.StringOutput( ATC_SSI_OK_TEXT__AnalogSerialOutput__, this );
                                                                                                m_StringOutputList.Add( ATC_SSI_OK_TEXT__AnalogSerialOutput__, ATC_SSI_OK_TEXT );
                                                                                                
                                                                                                VTC_EXTENSION = new Crestron.Logos.SplusObjects.StringOutput( VTC_EXTENSION__AnalogSerialOutput__, this );
                                                                                                m_StringOutputList.Add( VTC_EXTENSION__AnalogSerialOutput__, VTC_EXTENSION );
                                                                                                
                                                                                                VTC_HELP_NUMBER = new Crestron.Logos.SplusObjects.StringOutput( VTC_HELP_NUMBER__AnalogSerialOutput__, this );
                                                                                                m_StringOutputList.Add( VTC_HELP_NUMBER__AnalogSerialOutput__, VTC_HELP_NUMBER );
                                                                                                
                                                                                                VTC_HELP_BTN_TEXT = new Crestron.Logos.SplusObjects.StringOutput( VTC_HELP_BTN_TEXT__AnalogSerialOutput__, this );
                                                                                                m_StringOutputList.Add( VTC_HELP_BTN_TEXT__AnalogSerialOutput__, VTC_HELP_BTN_TEXT );
                                                                                                
                                                                                                VTC_CONNECTED_DIAL_TEXT = new Crestron.Logos.SplusObjects.StringOutput( VTC_CONNECTED_DIAL_TEXT__AnalogSerialOutput__, this );
                                                                                                m_StringOutputList.Add( VTC_CONNECTED_DIAL_TEXT__AnalogSerialOutput__, VTC_CONNECTED_DIAL_TEXT );
                                                                                                
                                                                                                VTC_DISCONNECTED_DIAL_TEXT = new Crestron.Logos.SplusObjects.StringOutput( VTC_DISCONNECTED_DIAL_TEXT__AnalogSerialOutput__, this );
                                                                                                m_StringOutputList.Add( VTC_DISCONNECTED_DIAL_TEXT__AnalogSerialOutput__, VTC_DISCONNECTED_DIAL_TEXT );
                                                                                                
                                                                                                VTC_CONNECTED_HANGUP_TEXT = new Crestron.Logos.SplusObjects.StringOutput( VTC_CONNECTED_HANGUP_TEXT__AnalogSerialOutput__, this );
                                                                                                m_StringOutputList.Add( VTC_CONNECTED_HANGUP_TEXT__AnalogSerialOutput__, VTC_CONNECTED_HANGUP_TEXT );
                                                                                                
                                                                                                VTC_DISCONNECTED_HANGUP_TEXT = new Crestron.Logos.SplusObjects.StringOutput( VTC_DISCONNECTED_HANGUP_TEXT__AnalogSerialOutput__, this );
                                                                                                m_StringOutputList.Add( VTC_DISCONNECTED_HANGUP_TEXT__AnalogSerialOutput__, VTC_DISCONNECTED_HANGUP_TEXT );
                                                                                                
                                                                                                VTC_CAM_PRESET1_ID = new Crestron.Logos.SplusObjects.StringOutput( VTC_CAM_PRESET1_ID__AnalogSerialOutput__, this );
                                                                                                m_StringOutputList.Add( VTC_CAM_PRESET1_ID__AnalogSerialOutput__, VTC_CAM_PRESET1_ID );
                                                                                                
                                                                                                VTC_CAM_PRESET1_NAME = new Crestron.Logos.SplusObjects.StringOutput( VTC_CAM_PRESET1_NAME__AnalogSerialOutput__, this );
                                                                                                m_StringOutputList.Add( VTC_CAM_PRESET1_NAME__AnalogSerialOutput__, VTC_CAM_PRESET1_NAME );
                                                                                                
                                                                                                VTC_CAM_PRESET2_ID = new Crestron.Logos.SplusObjects.StringOutput( VTC_CAM_PRESET2_ID__AnalogSerialOutput__, this );
                                                                                                m_StringOutputList.Add( VTC_CAM_PRESET2_ID__AnalogSerialOutput__, VTC_CAM_PRESET2_ID );
                                                                                                
                                                                                                VTC_CAM_PRESET2_NAME = new Crestron.Logos.SplusObjects.StringOutput( VTC_CAM_PRESET2_NAME__AnalogSerialOutput__, this );
                                                                                                m_StringOutputList.Add( VTC_CAM_PRESET2_NAME__AnalogSerialOutput__, VTC_CAM_PRESET2_NAME );
                                                                                                
                                                                                                VTC_CAM_PRESET3_ID = new Crestron.Logos.SplusObjects.StringOutput( VTC_CAM_PRESET3_ID__AnalogSerialOutput__, this );
                                                                                                m_StringOutputList.Add( VTC_CAM_PRESET3_ID__AnalogSerialOutput__, VTC_CAM_PRESET3_ID );
                                                                                                
                                                                                                VTC_CAM_PRESET3_NAME = new Crestron.Logos.SplusObjects.StringOutput( VTC_CAM_PRESET3_NAME__AnalogSerialOutput__, this );
                                                                                                m_StringOutputList.Add( VTC_CAM_PRESET3_NAME__AnalogSerialOutput__, VTC_CAM_PRESET3_NAME );
                                                                                                
                                                                                                VTC_CAM_PRESET4_ID = new Crestron.Logos.SplusObjects.StringOutput( VTC_CAM_PRESET4_ID__AnalogSerialOutput__, this );
                                                                                                m_StringOutputList.Add( VTC_CAM_PRESET4_ID__AnalogSerialOutput__, VTC_CAM_PRESET4_ID );
                                                                                                
                                                                                                VTC_CAM_PRESET4_NAME = new Crestron.Logos.SplusObjects.StringOutput( VTC_CAM_PRESET4_NAME__AnalogSerialOutput__, this );
                                                                                                m_StringOutputList.Add( VTC_CAM_PRESET4_NAME__AnalogSerialOutput__, VTC_CAM_PRESET4_NAME );
                                                                                                
                                                                                                VTC_CAM_PRESET5_ID = new Crestron.Logos.SplusObjects.StringOutput( VTC_CAM_PRESET5_ID__AnalogSerialOutput__, this );
                                                                                                m_StringOutputList.Add( VTC_CAM_PRESET5_ID__AnalogSerialOutput__, VTC_CAM_PRESET5_ID );
                                                                                                
                                                                                                VTC_CAM_PRESET5_NAME = new Crestron.Logos.SplusObjects.StringOutput( VTC_CAM_PRESET5_NAME__AnalogSerialOutput__, this );
                                                                                                m_StringOutputList.Add( VTC_CAM_PRESET5_NAME__AnalogSerialOutput__, VTC_CAM_PRESET5_NAME );
                                                                                                
                                                                                                VTC_CAM_PRESET6_ID = new Crestron.Logos.SplusObjects.StringOutput( VTC_CAM_PRESET6_ID__AnalogSerialOutput__, this );
                                                                                                m_StringOutputList.Add( VTC_CAM_PRESET6_ID__AnalogSerialOutput__, VTC_CAM_PRESET6_ID );
                                                                                                
                                                                                                VTC_CAM_PRESET6_NAME = new Crestron.Logos.SplusObjects.StringOutput( VTC_CAM_PRESET6_NAME__AnalogSerialOutput__, this );
                                                                                                m_StringOutputList.Add( VTC_CAM_PRESET6_NAME__AnalogSerialOutput__, VTC_CAM_PRESET6_NAME );
                                                                                                
                                                                                                VTC_SSI_DEVICE_USAGE_TYPE = new Crestron.Logos.SplusObjects.StringOutput( VTC_SSI_DEVICE_USAGE_TYPE__AnalogSerialOutput__, this );
                                                                                                m_StringOutputList.Add( VTC_SSI_DEVICE_USAGE_TYPE__AnalogSerialOutput__, VTC_SSI_DEVICE_USAGE_TYPE );
                                                                                                
                                                                                                VTC_SSI_DEVICE_USAGE_NAME = new Crestron.Logos.SplusObjects.StringOutput( VTC_SSI_DEVICE_USAGE_NAME__AnalogSerialOutput__, this );
                                                                                                m_StringOutputList.Add( VTC_SSI_DEVICE_USAGE_NAME__AnalogSerialOutput__, VTC_SSI_DEVICE_USAGE_NAME );
                                                                                                
                                                                                                VTC_SSI_SEVERITY_MESSAGE = new Crestron.Logos.SplusObjects.StringOutput( VTC_SSI_SEVERITY_MESSAGE__AnalogSerialOutput__, this );
                                                                                                m_StringOutputList.Add( VTC_SSI_SEVERITY_MESSAGE__AnalogSerialOutput__, VTC_SSI_SEVERITY_MESSAGE );
                                                                                                
                                                                                                VTC_SSI_ERROR_TEXT = new Crestron.Logos.SplusObjects.StringOutput( VTC_SSI_ERROR_TEXT__AnalogSerialOutput__, this );
                                                                                                m_StringOutputList.Add( VTC_SSI_ERROR_TEXT__AnalogSerialOutput__, VTC_SSI_ERROR_TEXT );
                                                                                                
                                                                                                VTC_SSI_OK_TEXT = new Crestron.Logos.SplusObjects.StringOutput( VTC_SSI_OK_TEXT__AnalogSerialOutput__, this );
                                                                                                m_StringOutputList.Add( VTC_SSI_OK_TEXT__AnalogSerialOutput__, VTC_SSI_OK_TEXT );
                                                                                                
                                                                                                LIGHTING_PRESET1_ID = new Crestron.Logos.SplusObjects.StringOutput( LIGHTING_PRESET1_ID__AnalogSerialOutput__, this );
                                                                                                m_StringOutputList.Add( LIGHTING_PRESET1_ID__AnalogSerialOutput__, LIGHTING_PRESET1_ID );
                                                                                                
                                                                                                LIGHTING_PRESET1_NAME = new Crestron.Logos.SplusObjects.StringOutput( LIGHTING_PRESET1_NAME__AnalogSerialOutput__, this );
                                                                                                m_StringOutputList.Add( LIGHTING_PRESET1_NAME__AnalogSerialOutput__, LIGHTING_PRESET1_NAME );
                                                                                                
                                                                                                LIGHTING_PRESET2_ID = new Crestron.Logos.SplusObjects.StringOutput( LIGHTING_PRESET2_ID__AnalogSerialOutput__, this );
                                                                                                m_StringOutputList.Add( LIGHTING_PRESET2_ID__AnalogSerialOutput__, LIGHTING_PRESET2_ID );
                                                                                                
                                                                                                LIGHTING_PRESET2_NAME = new Crestron.Logos.SplusObjects.StringOutput( LIGHTING_PRESET2_NAME__AnalogSerialOutput__, this );
                                                                                                m_StringOutputList.Add( LIGHTING_PRESET2_NAME__AnalogSerialOutput__, LIGHTING_PRESET2_NAME );
                                                                                                
                                                                                                LIGHTING_PRESET3_ID = new Crestron.Logos.SplusObjects.StringOutput( LIGHTING_PRESET3_ID__AnalogSerialOutput__, this );
                                                                                                m_StringOutputList.Add( LIGHTING_PRESET3_ID__AnalogSerialOutput__, LIGHTING_PRESET3_ID );
                                                                                                
                                                                                                LIGHTING_PRESET3_NAME = new Crestron.Logos.SplusObjects.StringOutput( LIGHTING_PRESET3_NAME__AnalogSerialOutput__, this );
                                                                                                m_StringOutputList.Add( LIGHTING_PRESET3_NAME__AnalogSerialOutput__, LIGHTING_PRESET3_NAME );
                                                                                                
                                                                                                LIGHTING_PRESET4_ID = new Crestron.Logos.SplusObjects.StringOutput( LIGHTING_PRESET4_ID__AnalogSerialOutput__, this );
                                                                                                m_StringOutputList.Add( LIGHTING_PRESET4_ID__AnalogSerialOutput__, LIGHTING_PRESET4_ID );
                                                                                                
                                                                                                LIGHTING_PRESET4_NAME = new Crestron.Logos.SplusObjects.StringOutput( LIGHTING_PRESET4_NAME__AnalogSerialOutput__, this );
                                                                                                m_StringOutputList.Add( LIGHTING_PRESET4_NAME__AnalogSerialOutput__, LIGHTING_PRESET4_NAME );
                                                                                                
                                                                                                LIGHTING_PRESET5_ID = new Crestron.Logos.SplusObjects.StringOutput( LIGHTING_PRESET5_ID__AnalogSerialOutput__, this );
                                                                                                m_StringOutputList.Add( LIGHTING_PRESET5_ID__AnalogSerialOutput__, LIGHTING_PRESET5_ID );
                                                                                                
                                                                                                LIGHTING_PRESET5_NAME = new Crestron.Logos.SplusObjects.StringOutput( LIGHTING_PRESET5_NAME__AnalogSerialOutput__, this );
                                                                                                m_StringOutputList.Add( LIGHTING_PRESET5_NAME__AnalogSerialOutput__, LIGHTING_PRESET5_NAME );
                                                                                                
                                                                                                LIGHTING_PRESET6_ID = new Crestron.Logos.SplusObjects.StringOutput( LIGHTING_PRESET6_ID__AnalogSerialOutput__, this );
                                                                                                m_StringOutputList.Add( LIGHTING_PRESET6_ID__AnalogSerialOutput__, LIGHTING_PRESET6_ID );
                                                                                                
                                                                                                LIGHTING_PRESET6_NAME = new Crestron.Logos.SplusObjects.StringOutput( LIGHTING_PRESET6_NAME__AnalogSerialOutput__, this );
                                                                                                m_StringOutputList.Add( LIGHTING_PRESET6_NAME__AnalogSerialOutput__, LIGHTING_PRESET6_NAME );
                                                                                                
                                                                                                LIGHTING_SSI_SEVERITY_MESSAGE = new Crestron.Logos.SplusObjects.StringOutput( LIGHTING_SSI_SEVERITY_MESSAGE__AnalogSerialOutput__, this );
                                                                                                m_StringOutputList.Add( LIGHTING_SSI_SEVERITY_MESSAGE__AnalogSerialOutput__, LIGHTING_SSI_SEVERITY_MESSAGE );
                                                                                                
                                                                                                LIGHTING_SSI_ERROR_TEXT = new Crestron.Logos.SplusObjects.StringOutput( LIGHTING_SSI_ERROR_TEXT__AnalogSerialOutput__, this );
                                                                                                m_StringOutputList.Add( LIGHTING_SSI_ERROR_TEXT__AnalogSerialOutput__, LIGHTING_SSI_ERROR_TEXT );
                                                                                                
                                                                                                LIGHTING_SSI_OK_TEXT = new Crestron.Logos.SplusObjects.StringOutput( LIGHTING_SSI_OK_TEXT__AnalogSerialOutput__, this );
                                                                                                m_StringOutputList.Add( LIGHTING_SSI_OK_TEXT__AnalogSerialOutput__, LIGHTING_SSI_OK_TEXT );
                                                                                                
                                                                                                SEQUENCER1_CH1_NAME = new Crestron.Logos.SplusObjects.StringOutput( SEQUENCER1_CH1_NAME__AnalogSerialOutput__, this );
                                                                                                m_StringOutputList.Add( SEQUENCER1_CH1_NAME__AnalogSerialOutput__, SEQUENCER1_CH1_NAME );
                                                                                                
                                                                                                SEQUENCER1_CH2_NAME = new Crestron.Logos.SplusObjects.StringOutput( SEQUENCER1_CH2_NAME__AnalogSerialOutput__, this );
                                                                                                m_StringOutputList.Add( SEQUENCER1_CH2_NAME__AnalogSerialOutput__, SEQUENCER1_CH2_NAME );
                                                                                                
                                                                                                SEQUENCER1_CH3_NAME = new Crestron.Logos.SplusObjects.StringOutput( SEQUENCER1_CH3_NAME__AnalogSerialOutput__, this );
                                                                                                m_StringOutputList.Add( SEQUENCER1_CH3_NAME__AnalogSerialOutput__, SEQUENCER1_CH3_NAME );
                                                                                                
                                                                                                SEQUENCER1_CH4_NAME = new Crestron.Logos.SplusObjects.StringOutput( SEQUENCER1_CH4_NAME__AnalogSerialOutput__, this );
                                                                                                m_StringOutputList.Add( SEQUENCER1_CH4_NAME__AnalogSerialOutput__, SEQUENCER1_CH4_NAME );
                                                                                                
                                                                                                SEQUENCER1_CH5_NAME = new Crestron.Logos.SplusObjects.StringOutput( SEQUENCER1_CH5_NAME__AnalogSerialOutput__, this );
                                                                                                m_StringOutputList.Add( SEQUENCER1_CH5_NAME__AnalogSerialOutput__, SEQUENCER1_CH5_NAME );
                                                                                                
                                                                                                SEQUENCER1_CH6_NAME = new Crestron.Logos.SplusObjects.StringOutput( SEQUENCER1_CH6_NAME__AnalogSerialOutput__, this );
                                                                                                m_StringOutputList.Add( SEQUENCER1_CH6_NAME__AnalogSerialOutput__, SEQUENCER1_CH6_NAME );
                                                                                                
                                                                                                SEQUENCER1_CH7_NAME = new Crestron.Logos.SplusObjects.StringOutput( SEQUENCER1_CH7_NAME__AnalogSerialOutput__, this );
                                                                                                m_StringOutputList.Add( SEQUENCER1_CH7_NAME__AnalogSerialOutput__, SEQUENCER1_CH7_NAME );
                                                                                                
                                                                                                SEQUENCER1_CH8_NAME = new Crestron.Logos.SplusObjects.StringOutput( SEQUENCER1_CH8_NAME__AnalogSerialOutput__, this );
                                                                                                m_StringOutputList.Add( SEQUENCER1_CH8_NAME__AnalogSerialOutput__, SEQUENCER1_CH8_NAME );
                                                                                                
                                                                                                SEQUENCER1_SSI_SEVERITY_MESSAGE = new Crestron.Logos.SplusObjects.StringOutput( SEQUENCER1_SSI_SEVERITY_MESSAGE__AnalogSerialOutput__, this );
                                                                                                m_StringOutputList.Add( SEQUENCER1_SSI_SEVERITY_MESSAGE__AnalogSerialOutput__, SEQUENCER1_SSI_SEVERITY_MESSAGE );
                                                                                                
                                                                                                SEQUENCER1_SSI_ERROR_TEXT = new Crestron.Logos.SplusObjects.StringOutput( SEQUENCER1_SSI_ERROR_TEXT__AnalogSerialOutput__, this );
                                                                                                m_StringOutputList.Add( SEQUENCER1_SSI_ERROR_TEXT__AnalogSerialOutput__, SEQUENCER1_SSI_ERROR_TEXT );
                                                                                                
                                                                                                SEQUENCER1_SSI_OK_TEXT = new Crestron.Logos.SplusObjects.StringOutput( SEQUENCER1_SSI_OK_TEXT__AnalogSerialOutput__, this );
                                                                                                m_StringOutputList.Add( SEQUENCER1_SSI_OK_TEXT__AnalogSerialOutput__, SEQUENCER1_SSI_OK_TEXT );
                                                                                                
                                                                                                SEQUENCER2_CH1_NAME = new Crestron.Logos.SplusObjects.StringOutput( SEQUENCER2_CH1_NAME__AnalogSerialOutput__, this );
                                                                                                m_StringOutputList.Add( SEQUENCER2_CH1_NAME__AnalogSerialOutput__, SEQUENCER2_CH1_NAME );
                                                                                                
                                                                                                SEQUENCER2_CH2_NAME = new Crestron.Logos.SplusObjects.StringOutput( SEQUENCER2_CH2_NAME__AnalogSerialOutput__, this );
                                                                                                m_StringOutputList.Add( SEQUENCER2_CH2_NAME__AnalogSerialOutput__, SEQUENCER2_CH2_NAME );
                                                                                                
                                                                                                SEQUENCER2_CH3_NAME = new Crestron.Logos.SplusObjects.StringOutput( SEQUENCER2_CH3_NAME__AnalogSerialOutput__, this );
                                                                                                m_StringOutputList.Add( SEQUENCER2_CH3_NAME__AnalogSerialOutput__, SEQUENCER2_CH3_NAME );
                                                                                                
                                                                                                SEQUENCER2_CH4_NAME = new Crestron.Logos.SplusObjects.StringOutput( SEQUENCER2_CH4_NAME__AnalogSerialOutput__, this );
                                                                                                m_StringOutputList.Add( SEQUENCER2_CH4_NAME__AnalogSerialOutput__, SEQUENCER2_CH4_NAME );
                                                                                                
                                                                                                SEQUENCER2_CH5_NAME = new Crestron.Logos.SplusObjects.StringOutput( SEQUENCER2_CH5_NAME__AnalogSerialOutput__, this );
                                                                                                m_StringOutputList.Add( SEQUENCER2_CH5_NAME__AnalogSerialOutput__, SEQUENCER2_CH5_NAME );
                                                                                                
                                                                                                SEQUENCER2_CH6_NAME = new Crestron.Logos.SplusObjects.StringOutput( SEQUENCER2_CH6_NAME__AnalogSerialOutput__, this );
                                                                                                m_StringOutputList.Add( SEQUENCER2_CH6_NAME__AnalogSerialOutput__, SEQUENCER2_CH6_NAME );
                                                                                                
                                                                                                SEQUENCER2_CH7_NAME = new Crestron.Logos.SplusObjects.StringOutput( SEQUENCER2_CH7_NAME__AnalogSerialOutput__, this );
                                                                                                m_StringOutputList.Add( SEQUENCER2_CH7_NAME__AnalogSerialOutput__, SEQUENCER2_CH7_NAME );
                                                                                                
                                                                                                SEQUENCER2_CH8_NAME = new Crestron.Logos.SplusObjects.StringOutput( SEQUENCER2_CH8_NAME__AnalogSerialOutput__, this );
                                                                                                m_StringOutputList.Add( SEQUENCER2_CH8_NAME__AnalogSerialOutput__, SEQUENCER2_CH8_NAME );
                                                                                                
                                                                                                SEQUENCER2_SSI_SEVERITY_MESSAGE = new Crestron.Logos.SplusObjects.StringOutput( SEQUENCER2_SSI_SEVERITY_MESSAGE__AnalogSerialOutput__, this );
                                                                                                m_StringOutputList.Add( SEQUENCER2_SSI_SEVERITY_MESSAGE__AnalogSerialOutput__, SEQUENCER2_SSI_SEVERITY_MESSAGE );
                                                                                                
                                                                                                SEQUENCER2_SSI_ERROR_TEXT = new Crestron.Logos.SplusObjects.StringOutput( SEQUENCER2_SSI_ERROR_TEXT__AnalogSerialOutput__, this );
                                                                                                m_StringOutputList.Add( SEQUENCER2_SSI_ERROR_TEXT__AnalogSerialOutput__, SEQUENCER2_SSI_ERROR_TEXT );
                                                                                                
                                                                                                SEQUENCER2_SSI_OK_TEXT = new Crestron.Logos.SplusObjects.StringOutput( SEQUENCER2_SSI_OK_TEXT__AnalogSerialOutput__, this );
                                                                                                m_StringOutputList.Add( SEQUENCER2_SSI_OK_TEXT__AnalogSerialOutput__, SEQUENCER2_SSI_OK_TEXT );
                                                                                                
                                                                                                PATH__DOLLAR__ = new StringParameter( PATH__DOLLAR____Parameter__, this );
                                                                                                m_ParameterList.Add( PATH__DOLLAR____Parameter__, PATH__DOLLAR__ );
                                                                                                
                                                                                                
                                                                                                PULL_CONFIG.OnDigitalPush.Add( new InputChangeHandlerWrapper( PULL_CONFIG_OnPush_0, false ) );
                                                                                                
                                                                                                _SplusNVRAM.PopulateCustomAttributeList( true );
                                                                                                
                                                                                                NVRAM = _SplusNVRAM;
                                                                                                
                                                                                            }
                                                                                            
                                                                                            public override void LogosSimplSharpInitialize()
                                                                                            {
                                                                                                CONFIG  = new IMS_Configuration.Configuration();
                                                                                                API  = new IMS_Configuration.RESTfulApi();
                                                                                                
                                                                                                
                                                                                            }
                                                                                            
                                                                                            public UserModuleClass_IMS_CONFIGURATION ( string InstanceName, string ReferenceID, Crestron.Logos.SplusObjects.CrestronStringEncoding nEncodingType ) : base( InstanceName, ReferenceID, nEncodingType ) {}
                                                                                            
                                                                                            
                                                                                            
                                                                                            
                                                                                            const uint PULL_CONFIG__DigitalInput__ = 0;
                                                                                            const uint STARTUP_TIME__AnalogSerialOutput__ = 0;
                                                                                            const uint SHUTDOWN_TIME_ACTIVE__AnalogSerialOutput__ = 1;
                                                                                            const uint SHUTDOWN_TIME_INACTIVE__AnalogSerialOutput__ = 2;
                                                                                            const uint ROOM_NAME__AnalogSerialOutput__ = 3;
                                                                                            const uint WELCOME_TEXT__AnalogSerialOutput__ = 4;
                                                                                            const uint SHUTDOWN_TEXT__AnalogSerialOutput__ = 5;
                                                                                            const uint WARMING_TEXT__AnalogSerialOutput__ = 6;
                                                                                            const uint COOLING_TEXT__AnalogSerialOutput__ = 7;
                                                                                            const uint DISPLAY1_NAME__AnalogSerialOutput__ = 8;
                                                                                            const uint DISPLAY1_TYPE__AnalogSerialOutput__ = 9;
                                                                                            const uint DISPLAY1_SCREEN_ENABLED__DigitalOutput__ = 0;
                                                                                            const uint DISPLAY1_WARMING_TIME__AnalogSerialOutput__ = 10;
                                                                                            const uint DISPLAY1_SSI_USAGE_NAME__AnalogSerialOutput__ = 11;
                                                                                            const uint DISPLAY1_SSI_SEVERITY_MESSAGE__AnalogSerialOutput__ = 12;
                                                                                            const uint DISPLAY1_SSI_ERROR_TEXT__AnalogSerialOutput__ = 13;
                                                                                            const uint DISPLAY1_SSI_OK_TEXT__AnalogSerialOutput__ = 14;
                                                                                            const uint DISPLAY2_NAME__AnalogSerialOutput__ = 15;
                                                                                            const uint DISPLAY2_TYPE__AnalogSerialOutput__ = 16;
                                                                                            const uint DISPLAY2_SCREEN_ENABLED__DigitalOutput__ = 1;
                                                                                            const uint DISPLAY2_WARMING_TIME__AnalogSerialOutput__ = 17;
                                                                                            const uint DISPLAY2_SSI_USAGE_NAME__AnalogSerialOutput__ = 18;
                                                                                            const uint DISPLAY2_SSI_SEVERITY_MESSAGE__AnalogSerialOutput__ = 19;
                                                                                            const uint DISPLAY2_SSI_ERROR_TEXT__AnalogSerialOutput__ = 20;
                                                                                            const uint DISPLAY2_SSI_OK_TEXT__AnalogSerialOutput__ = 21;
                                                                                            const uint PRESENTATION1_NAME__AnalogSerialOutput__ = 22;
                                                                                            const uint PRESENTATION1_TYPE__AnalogSerialOutput__ = 23;
                                                                                            const uint PRESENTATION1_GENERIC_PAGE_TEXT__AnalogSerialOutput__ = 24;
                                                                                            const uint PRESENTATION1_SWITCHER_VALUE__AnalogSerialOutput__ = 25;
                                                                                            const uint PRESENTATION1_SSI_DEVICE_USAGE_TYPE__AnalogSerialOutput__ = 26;
                                                                                            const uint PRESENTATION1_SSI_DEVICE_USAGE_NAME__AnalogSerialOutput__ = 27;
                                                                                            const uint PRESENTATION1_SSI_SEVERITY_MESSAGE__AnalogSerialOutput__ = 28;
                                                                                            const uint PRESENTATION1_SSI_ERROR_TEXT__AnalogSerialOutput__ = 29;
                                                                                            const uint PRESENTATION1_SSI_OK_TEXT__AnalogSerialOutput__ = 30;
                                                                                            const uint PRESENTATION2_NAME__AnalogSerialOutput__ = 31;
                                                                                            const uint PRESENTATION2_TYPE__AnalogSerialOutput__ = 32;
                                                                                            const uint PRESENTATION2_GENERIC_PAGE_TEXT__AnalogSerialOutput__ = 33;
                                                                                            const uint PRESENTATION2_SWITCHER_VALUE__AnalogSerialOutput__ = 34;
                                                                                            const uint PRESENTATION2_SSI_DEVICE_USAGE_TYPE__AnalogSerialOutput__ = 35;
                                                                                            const uint PRESENTATION2_SSI_DEVICE_USAGE_NAME__AnalogSerialOutput__ = 36;
                                                                                            const uint PRESENTATION2_SSI_SEVERITY_MESSAGE__AnalogSerialOutput__ = 37;
                                                                                            const uint PRESENTATION2_SSI_ERROR_TEXT__AnalogSerialOutput__ = 38;
                                                                                            const uint PRESENTATION2_SSI_OK_TEXT__AnalogSerialOutput__ = 39;
                                                                                            const uint PRESENTATION3_NAME__AnalogSerialOutput__ = 40;
                                                                                            const uint PRESENTATION3_TYPE__AnalogSerialOutput__ = 41;
                                                                                            const uint PRESENTATION3_GENERIC_PAGE_TEXT__AnalogSerialOutput__ = 42;
                                                                                            const uint PRESENTATION3_SWITCHER_VALUE__AnalogSerialOutput__ = 43;
                                                                                            const uint PRESENTATION3_SSI_DEVICE_USAGE_TYPE__AnalogSerialOutput__ = 44;
                                                                                            const uint PRESENTATION3_SSI_DEVICE_USAGE_NAME__AnalogSerialOutput__ = 45;
                                                                                            const uint PRESENTATION3_SSI_SEVERITY_MESSAGE__AnalogSerialOutput__ = 46;
                                                                                            const uint PRESENTATION3_SSI_ERROR_TEXT__AnalogSerialOutput__ = 47;
                                                                                            const uint PRESENTATION3_SSI_OK_TEXT__AnalogSerialOutput__ = 48;
                                                                                            const uint PRESENTATION4_NAME__AnalogSerialOutput__ = 49;
                                                                                            const uint PRESENTATION4_TYPE__AnalogSerialOutput__ = 50;
                                                                                            const uint PRESENTATION4_GENERIC_PAGE_TEXT__AnalogSerialOutput__ = 51;
                                                                                            const uint PRESENTATION4_SWITCHER_VALUE__AnalogSerialOutput__ = 52;
                                                                                            const uint PRESENTATION4_SSI_DEVICE_USAGE_TYPE__AnalogSerialOutput__ = 53;
                                                                                            const uint PRESENTATION4_SSI_DEVICE_USAGE_NAME__AnalogSerialOutput__ = 54;
                                                                                            const uint PRESENTATION4_SSI_SEVERITY_MESSAGE__AnalogSerialOutput__ = 55;
                                                                                            const uint PRESENTATION4_SSI_ERROR_TEXT__AnalogSerialOutput__ = 56;
                                                                                            const uint PRESENTATION4_SSI_OK_TEXT__AnalogSerialOutput__ = 57;
                                                                                            const uint PRESENTATION5_NAME__AnalogSerialOutput__ = 58;
                                                                                            const uint PRESENTATION5_TYPE__AnalogSerialOutput__ = 59;
                                                                                            const uint PRESENTATION5_GENERIC_PAGE_TEXT__AnalogSerialOutput__ = 60;
                                                                                            const uint PRESENTATION5_SWITCHER_VALUE__AnalogSerialOutput__ = 61;
                                                                                            const uint PRESENTATION5_SSI_DEVICE_USAGE_TYPE__AnalogSerialOutput__ = 62;
                                                                                            const uint PRESENTATION5_SSI_DEVICE_USAGE_NAME__AnalogSerialOutput__ = 63;
                                                                                            const uint PRESENTATION5_SSI_SEVERITY_MESSAGE__AnalogSerialOutput__ = 64;
                                                                                            const uint PRESENTATION5_SSI_ERROR_TEXT__AnalogSerialOutput__ = 65;
                                                                                            const uint PRESENTATION5_SSI_OK_TEXT__AnalogSerialOutput__ = 66;
                                                                                            const uint PRESENTATION6_NAME__AnalogSerialOutput__ = 67;
                                                                                            const uint PRESENTATION6_TYPE__AnalogSerialOutput__ = 68;
                                                                                            const uint PRESENTATION6_GENERIC_PAGE_TEXT__AnalogSerialOutput__ = 69;
                                                                                            const uint PRESENTATION6_SWITCHER_VALUE__AnalogSerialOutput__ = 70;
                                                                                            const uint PRESENTATION6_SSI_DEVICE_USAGE_TYPE__AnalogSerialOutput__ = 71;
                                                                                            const uint PRESENTATION6_SSI_DEVICE_USAGE_NAME__AnalogSerialOutput__ = 72;
                                                                                            const uint PRESENTATION6_SSI_SEVERITY_MESSAGE__AnalogSerialOutput__ = 73;
                                                                                            const uint PRESENTATION6_SSI_ERROR_TEXT__AnalogSerialOutput__ = 74;
                                                                                            const uint PRESENTATION6_SSI_OK_TEXT__AnalogSerialOutput__ = 75;
                                                                                            const uint ATC_EXTENSION__AnalogSerialOutput__ = 76;
                                                                                            const uint ATC_HELP_NUMBER__AnalogSerialOutput__ = 77;
                                                                                            const uint ATC_HELP_BTN_TEXT__AnalogSerialOutput__ = 78;
                                                                                            const uint ATC_CONNECTED_DIAL_TEXT__AnalogSerialOutput__ = 79;
                                                                                            const uint ATC_DISCONNECTED_DIAL_TEXT__AnalogSerialOutput__ = 80;
                                                                                            const uint ATC_CONNECTED_HANGUP_TEXT__AnalogSerialOutput__ = 81;
                                                                                            const uint ATC_DISCONNECTED_HANGUP_TEXT__AnalogSerialOutput__ = 82;
                                                                                            const uint ATC_SSI_DEVICE_USAGE_TYPE__AnalogSerialOutput__ = 83;
                                                                                            const uint ATC_SSI_DEVICE_USAGE_NAME__AnalogSerialOutput__ = 84;
                                                                                            const uint ATC_SSI_SEVERITY_MESSAGE__AnalogSerialOutput__ = 85;
                                                                                            const uint ATC_SSI_ERROR_TEXT__AnalogSerialOutput__ = 86;
                                                                                            const uint ATC_SSI_OK_TEXT__AnalogSerialOutput__ = 87;
                                                                                            const uint VTC_EXTENSION__AnalogSerialOutput__ = 88;
                                                                                            const uint VTC_HELP_NUMBER__AnalogSerialOutput__ = 89;
                                                                                            const uint VTC_HELP_BTN_TEXT__AnalogSerialOutput__ = 90;
                                                                                            const uint VTC_CONNECTED_DIAL_TEXT__AnalogSerialOutput__ = 91;
                                                                                            const uint VTC_DISCONNECTED_DIAL_TEXT__AnalogSerialOutput__ = 92;
                                                                                            const uint VTC_CONNECTED_HANGUP_TEXT__AnalogSerialOutput__ = 93;
                                                                                            const uint VTC_DISCONNECTED_HANGUP_TEXT__AnalogSerialOutput__ = 94;
                                                                                            const uint VTC_CAM_PRESET1_ID__AnalogSerialOutput__ = 95;
                                                                                            const uint VTC_CAM_PRESET1_NAME__AnalogSerialOutput__ = 96;
                                                                                            const uint VTC_CAM_PRESET2_ID__AnalogSerialOutput__ = 97;
                                                                                            const uint VTC_CAM_PRESET2_NAME__AnalogSerialOutput__ = 98;
                                                                                            const uint VTC_CAM_PRESET3_ID__AnalogSerialOutput__ = 99;
                                                                                            const uint VTC_CAM_PRESET3_NAME__AnalogSerialOutput__ = 100;
                                                                                            const uint VTC_CAM_PRESET4_ID__AnalogSerialOutput__ = 101;
                                                                                            const uint VTC_CAM_PRESET4_NAME__AnalogSerialOutput__ = 102;
                                                                                            const uint VTC_CAM_PRESET5_ID__AnalogSerialOutput__ = 103;
                                                                                            const uint VTC_CAM_PRESET5_NAME__AnalogSerialOutput__ = 104;
                                                                                            const uint VTC_CAM_PRESET6_ID__AnalogSerialOutput__ = 105;
                                                                                            const uint VTC_CAM_PRESET6_NAME__AnalogSerialOutput__ = 106;
                                                                                            const uint VTC_SSI_DEVICE_USAGE_TYPE__AnalogSerialOutput__ = 107;
                                                                                            const uint VTC_SSI_DEVICE_USAGE_NAME__AnalogSerialOutput__ = 108;
                                                                                            const uint VTC_SSI_SEVERITY_MESSAGE__AnalogSerialOutput__ = 109;
                                                                                            const uint VTC_SSI_ERROR_TEXT__AnalogSerialOutput__ = 110;
                                                                                            const uint VTC_SSI_OK_TEXT__AnalogSerialOutput__ = 111;
                                                                                            const uint LIGHTING_PRESET1_ID__AnalogSerialOutput__ = 112;
                                                                                            const uint LIGHTING_PRESET1_NAME__AnalogSerialOutput__ = 113;
                                                                                            const uint LIGHTING_PRESET2_ID__AnalogSerialOutput__ = 114;
                                                                                            const uint LIGHTING_PRESET2_NAME__AnalogSerialOutput__ = 115;
                                                                                            const uint LIGHTING_PRESET3_ID__AnalogSerialOutput__ = 116;
                                                                                            const uint LIGHTING_PRESET3_NAME__AnalogSerialOutput__ = 117;
                                                                                            const uint LIGHTING_PRESET4_ID__AnalogSerialOutput__ = 118;
                                                                                            const uint LIGHTING_PRESET4_NAME__AnalogSerialOutput__ = 119;
                                                                                            const uint LIGHTING_PRESET5_ID__AnalogSerialOutput__ = 120;
                                                                                            const uint LIGHTING_PRESET5_NAME__AnalogSerialOutput__ = 121;
                                                                                            const uint LIGHTING_PRESET6_ID__AnalogSerialOutput__ = 122;
                                                                                            const uint LIGHTING_PRESET6_NAME__AnalogSerialOutput__ = 123;
                                                                                            const uint LIGHTING_SSI_SEVERITY_MESSAGE__AnalogSerialOutput__ = 124;
                                                                                            const uint LIGHTING_SSI_ERROR_TEXT__AnalogSerialOutput__ = 125;
                                                                                            const uint LIGHTING_SSI_OK_TEXT__AnalogSerialOutput__ = 126;
                                                                                            const uint SEQUENCER1_CH1_NAME__AnalogSerialOutput__ = 127;
                                                                                            const uint SEQUENCER1_CH2_NAME__AnalogSerialOutput__ = 128;
                                                                                            const uint SEQUENCER1_CH3_NAME__AnalogSerialOutput__ = 129;
                                                                                            const uint SEQUENCER1_CH4_NAME__AnalogSerialOutput__ = 130;
                                                                                            const uint SEQUENCER1_CH5_NAME__AnalogSerialOutput__ = 131;
                                                                                            const uint SEQUENCER1_CH6_NAME__AnalogSerialOutput__ = 132;
                                                                                            const uint SEQUENCER1_CH7_NAME__AnalogSerialOutput__ = 133;
                                                                                            const uint SEQUENCER1_CH8_NAME__AnalogSerialOutput__ = 134;
                                                                                            const uint SEQUENCER1_SSI_SEVERITY_MESSAGE__AnalogSerialOutput__ = 135;
                                                                                            const uint SEQUENCER1_SSI_ERROR_TEXT__AnalogSerialOutput__ = 136;
                                                                                            const uint SEQUENCER1_SSI_OK_TEXT__AnalogSerialOutput__ = 137;
                                                                                            const uint SEQUENCER2_CH1_NAME__AnalogSerialOutput__ = 138;
                                                                                            const uint SEQUENCER2_CH2_NAME__AnalogSerialOutput__ = 139;
                                                                                            const uint SEQUENCER2_CH3_NAME__AnalogSerialOutput__ = 140;
                                                                                            const uint SEQUENCER2_CH4_NAME__AnalogSerialOutput__ = 141;
                                                                                            const uint SEQUENCER2_CH5_NAME__AnalogSerialOutput__ = 142;
                                                                                            const uint SEQUENCER2_CH6_NAME__AnalogSerialOutput__ = 143;
                                                                                            const uint SEQUENCER2_CH7_NAME__AnalogSerialOutput__ = 144;
                                                                                            const uint SEQUENCER2_CH8_NAME__AnalogSerialOutput__ = 145;
                                                                                            const uint SEQUENCER2_SSI_SEVERITY_MESSAGE__AnalogSerialOutput__ = 146;
                                                                                            const uint SEQUENCER2_SSI_ERROR_TEXT__AnalogSerialOutput__ = 147;
                                                                                            const uint SEQUENCER2_SSI_OK_TEXT__AnalogSerialOutput__ = 148;
                                                                                            const uint PATH__DOLLAR____Parameter__ = 10;
                                                                                            
                                                                                            [SplusStructAttribute(-1, true, false)]
                                                                                            public class SplusNVRAM : SplusStructureBase
                                                                                            {
                                                                                            
                                                                                                public SplusNVRAM( SplusObject __caller__ ) : base( __caller__ ) {}
                                                                                                
                                                                                                
                                                                                            }
                                                                                            
                                                                                            SplusNVRAM _SplusNVRAM = null;
                                                                                            
                                                                                            public class __CEvent__ : CEvent
                                                                                            {
                                                                                                public __CEvent__() {}
                                                                                                public void Close() { base.Close(); }
                                                                                                public int Reset() { return base.Reset() ? 1 : 0; }
                                                                                                public int Set() { return base.Set() ? 1 : 0; }
                                                                                                public int Wait( int timeOutInMs ) { return base.Wait( timeOutInMs ) ? 1 : 0; }
                                                                                            }
                                                                                            public class __CMutex__ : CMutex
                                                                                            {
                                                                                                public __CMutex__() {}
                                                                                                public void Close() { base.Close(); }
                                                                                                public void ReleaseMutex() { base.ReleaseMutex(); }
                                                                                                public int WaitForMutex() { return base.WaitForMutex() ? 1 : 0; }
                                                                                            }
                                                                                             public int IsNull( object obj ){ return (obj == null) ? 1 : 0; }
                                                                                        }
                                                                                        
                                                                                        
                                                                                    }
                                                                                    