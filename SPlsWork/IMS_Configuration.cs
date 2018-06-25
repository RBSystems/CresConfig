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
        Crestron.Logos.SplusObjects.StringInput FILENAME__DOLLAR__;
        Crestron.Logos.SplusObjects.AnalogOutput STARTUP_TIME;
        Crestron.Logos.SplusObjects.AnalogOutput SHUTDOWN_TIME_ACTIVE;
        Crestron.Logos.SplusObjects.AnalogOutput SHUTDOWN_TIME_INACTIVE;
        Crestron.Logos.SplusObjects.StringOutput ROOM_NAME;
        Crestron.Logos.SplusObjects.StringOutput WELCOME_TEXT;
        Crestron.Logos.SplusObjects.StringOutput SHUTDOWN_TEXT;
        Crestron.Logos.SplusObjects.StringOutput WARMING_TEXT;
        Crestron.Logos.SplusObjects.StringOutput COOLING_TEXT;
        Crestron.Logos.SplusObjects.DigitalOutput MICROPHONE_MUTE_ENABLE;
        Crestron.Logos.SplusObjects.StringOutput MICROPHONE_MUTED_TEXT;
        Crestron.Logos.SplusObjects.StringOutput MICROPHONE_MUTED_NOT_TEXT;
        Crestron.Logos.SplusObjects.StringOutput PRESENTATION_PAGE_TEXT;
        Crestron.Logos.SplusObjects.StringOutput DISPLAY1_NAME;
        Crestron.Logos.SplusObjects.StringOutput DISPLAY1_TYPE;
        Crestron.Logos.SplusObjects.DigitalOutput DISPLAY1_SCREEN_ENABLED;
        Crestron.Logos.SplusObjects.AnalogOutput DISPLAY1_SWITCHER_VALUE;
        Crestron.Logos.SplusObjects.AnalogOutput DISPLAY1_ICON_VALUE;
        Crestron.Logos.SplusObjects.AnalogOutput DISPLAY1_WARMING_TIME;
        Crestron.Logos.SplusObjects.StringOutput DISPLAY1_SSI_USAGE_NAME;
        Crestron.Logos.SplusObjects.StringOutput DISPLAY1_SSI_SEVERITY_MESSAGE;
        Crestron.Logos.SplusObjects.StringOutput DISPLAY1_SSI_ERROR_TEXT;
        Crestron.Logos.SplusObjects.StringOutput DISPLAY1_SSI_OK_TEXT;
        Crestron.Logos.SplusObjects.StringOutput DISPLAY2_NAME;
        Crestron.Logos.SplusObjects.StringOutput DISPLAY2_TYPE;
        Crestron.Logos.SplusObjects.DigitalOutput DISPLAY2_SCREEN_ENABLED;
        Crestron.Logos.SplusObjects.AnalogOutput DISPLAY2_SWITCHER_VALUE;
        Crestron.Logos.SplusObjects.AnalogOutput DISPLAY2_ICON_VALUE;
        Crestron.Logos.SplusObjects.AnalogOutput DISPLAY2_WARMING_TIME;
        Crestron.Logos.SplusObjects.StringOutput DISPLAY2_SSI_USAGE_NAME;
        Crestron.Logos.SplusObjects.StringOutput DISPLAY2_SSI_SEVERITY_MESSAGE;
        Crestron.Logos.SplusObjects.StringOutput DISPLAY2_SSI_ERROR_TEXT;
        Crestron.Logos.SplusObjects.StringOutput DISPLAY2_SSI_OK_TEXT;
        Crestron.Logos.SplusObjects.StringOutput DISPLAY3_NAME;
        Crestron.Logos.SplusObjects.StringOutput DISPLAY3_TYPE;
        Crestron.Logos.SplusObjects.DigitalOutput DISPLAY3_SCREEN_ENABLED;
        Crestron.Logos.SplusObjects.AnalogOutput DISPLAY3_SWITCHER_VALUE;
        Crestron.Logos.SplusObjects.AnalogOutput DISPLAY3_ICON_VALUE;
        Crestron.Logos.SplusObjects.AnalogOutput DISPLAY3_WARMING_TIME;
        Crestron.Logos.SplusObjects.StringOutput DISPLAY3_SSI_USAGE_NAME;
        Crestron.Logos.SplusObjects.StringOutput DISPLAY3_SSI_SEVERITY_MESSAGE;
        Crestron.Logos.SplusObjects.StringOutput DISPLAY3_SSI_ERROR_TEXT;
        Crestron.Logos.SplusObjects.StringOutput DISPLAY3_SSI_OK_TEXT;
        Crestron.Logos.SplusObjects.StringOutput DISPLAY4_NAME;
        Crestron.Logos.SplusObjects.StringOutput DISPLAY4_TYPE;
        Crestron.Logos.SplusObjects.DigitalOutput DISPLAY4_SCREEN_ENABLED;
        Crestron.Logos.SplusObjects.AnalogOutput DISPLAY4_SWITCHER_VALUE;
        Crestron.Logos.SplusObjects.AnalogOutput DISPLAY4_ICON_VALUE;
        Crestron.Logos.SplusObjects.AnalogOutput DISPLAY4_WARMING_TIME;
        Crestron.Logos.SplusObjects.StringOutput DISPLAY4_SSI_USAGE_NAME;
        Crestron.Logos.SplusObjects.StringOutput DISPLAY4_SSI_SEVERITY_MESSAGE;
        Crestron.Logos.SplusObjects.StringOutput DISPLAY4_SSI_ERROR_TEXT;
        Crestron.Logos.SplusObjects.StringOutput DISPLAY4_SSI_OK_TEXT;
        Crestron.Logos.SplusObjects.StringOutput PRESENTATION1_NAME;
        Crestron.Logos.SplusObjects.StringOutput PRESENTATION1_TYPE;
        Crestron.Logos.SplusObjects.StringOutput PRESENTATION1_GENERIC_PAGE_TEXT;
        Crestron.Logos.SplusObjects.AnalogOutput PRESENTATION1_SWITCHER_VALUE;
        Crestron.Logos.SplusObjects.AnalogOutput PRESENTATION1_ICON_VALUE;
        Crestron.Logos.SplusObjects.StringOutput PRESENTATION1_SSI_DEVICE_USAGE_TYPE;
        Crestron.Logos.SplusObjects.StringOutput PRESENTATION1_SSI_DEVICE_USAGE_NAME;
        Crestron.Logos.SplusObjects.StringOutput PRESENTATION1_SSI_SEVERITY_MESSAGE;
        Crestron.Logos.SplusObjects.StringOutput PRESENTATION1_SSI_ERROR_TEXT;
        Crestron.Logos.SplusObjects.StringOutput PRESENTATION1_SSI_OK_TEXT;
        Crestron.Logos.SplusObjects.StringOutput PRESENTATION2_NAME;
        Crestron.Logos.SplusObjects.StringOutput PRESENTATION2_TYPE;
        Crestron.Logos.SplusObjects.StringOutput PRESENTATION2_GENERIC_PAGE_TEXT;
        Crestron.Logos.SplusObjects.AnalogOutput PRESENTATION2_SWITCHER_VALUE;
        Crestron.Logos.SplusObjects.AnalogOutput PRESENTATION2_ICON_VALUE;
        Crestron.Logos.SplusObjects.StringOutput PRESENTATION2_SSI_DEVICE_USAGE_TYPE;
        Crestron.Logos.SplusObjects.StringOutput PRESENTATION2_SSI_DEVICE_USAGE_NAME;
        Crestron.Logos.SplusObjects.StringOutput PRESENTATION2_SSI_SEVERITY_MESSAGE;
        Crestron.Logos.SplusObjects.StringOutput PRESENTATION2_SSI_ERROR_TEXT;
        Crestron.Logos.SplusObjects.StringOutput PRESENTATION2_SSI_OK_TEXT;
        Crestron.Logos.SplusObjects.StringOutput PRESENTATION3_NAME;
        Crestron.Logos.SplusObjects.StringOutput PRESENTATION3_TYPE;
        Crestron.Logos.SplusObjects.StringOutput PRESENTATION3_GENERIC_PAGE_TEXT;
        Crestron.Logos.SplusObjects.AnalogOutput PRESENTATION3_SWITCHER_VALUE;
        Crestron.Logos.SplusObjects.AnalogOutput PRESENTATION3_ICON_VALUE;
        Crestron.Logos.SplusObjects.StringOutput PRESENTATION3_SSI_DEVICE_USAGE_TYPE;
        Crestron.Logos.SplusObjects.StringOutput PRESENTATION3_SSI_DEVICE_USAGE_NAME;
        Crestron.Logos.SplusObjects.StringOutput PRESENTATION3_SSI_SEVERITY_MESSAGE;
        Crestron.Logos.SplusObjects.StringOutput PRESENTATION3_SSI_ERROR_TEXT;
        Crestron.Logos.SplusObjects.StringOutput PRESENTATION3_SSI_OK_TEXT;
        Crestron.Logos.SplusObjects.StringOutput PRESENTATION4_NAME;
        Crestron.Logos.SplusObjects.StringOutput PRESENTATION4_TYPE;
        Crestron.Logos.SplusObjects.StringOutput PRESENTATION4_GENERIC_PAGE_TEXT;
        Crestron.Logos.SplusObjects.AnalogOutput PRESENTATION4_SWITCHER_VALUE;
        Crestron.Logos.SplusObjects.AnalogOutput PRESENTATION4_ICON_VALUE;
        Crestron.Logos.SplusObjects.StringOutput PRESENTATION4_SSI_DEVICE_USAGE_TYPE;
        Crestron.Logos.SplusObjects.StringOutput PRESENTATION4_SSI_DEVICE_USAGE_NAME;
        Crestron.Logos.SplusObjects.StringOutput PRESENTATION4_SSI_SEVERITY_MESSAGE;
        Crestron.Logos.SplusObjects.StringOutput PRESENTATION4_SSI_ERROR_TEXT;
        Crestron.Logos.SplusObjects.StringOutput PRESENTATION4_SSI_OK_TEXT;
        Crestron.Logos.SplusObjects.StringOutput PRESENTATION5_NAME;
        Crestron.Logos.SplusObjects.StringOutput PRESENTATION5_TYPE;
        Crestron.Logos.SplusObjects.StringOutput PRESENTATION5_GENERIC_PAGE_TEXT;
        Crestron.Logos.SplusObjects.AnalogOutput PRESENTATION5_SWITCHER_VALUE;
        Crestron.Logos.SplusObjects.AnalogOutput PRESENTATION5_ICON_VALUE;
        Crestron.Logos.SplusObjects.StringOutput PRESENTATION5_SSI_DEVICE_USAGE_TYPE;
        Crestron.Logos.SplusObjects.StringOutput PRESENTATION5_SSI_DEVICE_USAGE_NAME;
        Crestron.Logos.SplusObjects.StringOutput PRESENTATION5_SSI_SEVERITY_MESSAGE;
        Crestron.Logos.SplusObjects.StringOutput PRESENTATION5_SSI_ERROR_TEXT;
        Crestron.Logos.SplusObjects.StringOutput PRESENTATION5_SSI_OK_TEXT;
        Crestron.Logos.SplusObjects.StringOutput PRESENTATION6_NAME;
        Crestron.Logos.SplusObjects.StringOutput PRESENTATION6_TYPE;
        Crestron.Logos.SplusObjects.StringOutput PRESENTATION6_GENERIC_PAGE_TEXT;
        Crestron.Logos.SplusObjects.AnalogOutput PRESENTATION6_SWITCHER_VALUE;
        Crestron.Logos.SplusObjects.AnalogOutput PRESENTATION6_ICON_VALUE;
        Crestron.Logos.SplusObjects.StringOutput PRESENTATION6_SSI_DEVICE_USAGE_TYPE;
        Crestron.Logos.SplusObjects.StringOutput PRESENTATION6_SSI_DEVICE_USAGE_NAME;
        Crestron.Logos.SplusObjects.StringOutput PRESENTATION6_SSI_SEVERITY_MESSAGE;
        Crestron.Logos.SplusObjects.StringOutput PRESENTATION6_SSI_ERROR_TEXT;
        Crestron.Logos.SplusObjects.StringOutput PRESENTATION6_SSI_OK_TEXT;
        CrestronString FILEPATH;
        CrestronString PROGRAMNUMBER;
        IMS_Configuration.Configuration CONFIG;
        IMS_Configuration.RESTfulApi API;
        object FILENAME__DOLLAR___OnChange_0 ( Object __EventInfo__ )
        
            { 
            Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
            try
            {
                SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
                
                __context__.SourceCodeLine = 235;
                MakeString ( FILEPATH , "\\USER\\{0:d}\\{1}", (short)GetProgramNumber(), FILENAME__DOLLAR__ ) ; 
                __context__.SourceCodeLine = 236;
                 Configuration.filePath  =( FILEPATH )  .ToString()  ;  
 
                
                
            }
            catch(Exception e) { ObjectCatchHandler(e); }
            finally { ObjectFinallyHandler( __SignalEventArg__ ); }
            return this;
            
        }
        
    object PULL_CONFIG_OnPush_1 ( Object __EventInfo__ )
    
        { 
        Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
        try
        {
            SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
            
            __context__.SourceCodeLine = 241;
            CONFIG . Reader ( ) ; 
            __context__.SourceCodeLine = 243;
            ROOM_NAME  .UpdateValue ( CONFIG . Obj . Room_Name  ) ; 
            __context__.SourceCodeLine = 244;
            WELCOME_TEXT  .UpdateValue ( CONFIG . Obj . Welcome_Text  ) ; 
            __context__.SourceCodeLine = 245;
            SHUTDOWN_TEXT  .UpdateValue ( CONFIG . Obj . Shutdown_Text  ) ; 
            __context__.SourceCodeLine = 246;
            STARTUP_TIME  .Value = (ushort) ( CONFIG.Obj.Startup_Time ) ; 
            __context__.SourceCodeLine = 247;
            SHUTDOWN_TIME_ACTIVE  .Value = (ushort) ( CONFIG.Obj.Shutdown_Time_Display_Active ) ; 
            __context__.SourceCodeLine = 248;
            SHUTDOWN_TIME_INACTIVE  .Value = (ushort) ( CONFIG.Obj.Shutdown_Time_Display_Inactive ) ; 
            __context__.SourceCodeLine = 249;
            WARMING_TEXT  .UpdateValue ( CONFIG . Obj . Warming_Text  ) ; 
            __context__.SourceCodeLine = 250;
            COOLING_TEXT  .UpdateValue ( CONFIG . Obj . Cooling_Text  ) ; 
            __context__.SourceCodeLine = 251;
            MICROPHONE_MUTE_ENABLE  .Value = (ushort) ( CONFIG.Obj.Microphone_Mute_Enable ) ; 
            __context__.SourceCodeLine = 252;
            MICROPHONE_MUTED_TEXT  .UpdateValue ( CONFIG . Obj . Microphone_Muted_Text  ) ; 
            __context__.SourceCodeLine = 253;
            MICROPHONE_MUTED_NOT_TEXT  .UpdateValue ( CONFIG . Obj . Microphone_Muted_Not_Text  ) ; 
            __context__.SourceCodeLine = 254;
            PRESENTATION_PAGE_TEXT  .UpdateValue ( CONFIG . Obj . Presentation_Page_Text  ) ; 
            __context__.SourceCodeLine = 257;
            try 
                { 
                __context__.SourceCodeLine = 258;
                CONFIG . Obj . DisplaysToArray ( ) ; 
                __context__.SourceCodeLine = 259;
                DISPLAY1_NAME  .UpdateValue ( CONFIG . Obj . DisplayArray [ 0] . Name  ) ; 
                __context__.SourceCodeLine = 260;
                DISPLAY1_TYPE  .UpdateValue ( CONFIG . Obj . DisplayArray [ 0] . Type  ) ; 
                __context__.SourceCodeLine = 261;
                DISPLAY1_SCREEN_ENABLED  .Value = (ushort) ( CONFIG.Obj.DisplayArray[ 0 ].Screen_Enabled ) ; 
                __context__.SourceCodeLine = 262;
                DISPLAY1_SWITCHER_VALUE  .Value = (ushort) ( CONFIG.Obj.DisplayArray[ 0 ].Switcher_Value ) ; 
                __context__.SourceCodeLine = 263;
                DISPLAY1_ICON_VALUE  .Value = (ushort) ( CONFIG.Obj.DisplayArray[ 0 ].Icon_Value ) ; 
                __context__.SourceCodeLine = 264;
                DISPLAY1_WARMING_TIME  .Value = (ushort) ( CONFIG.Obj.DisplayArray[ 0 ].Warming_Time ) ; 
                __context__.SourceCodeLine = 265;
                DISPLAY1_SSI_USAGE_NAME  .UpdateValue ( CONFIG . Obj . DisplayArray [ 0] . SSI_Display_Usage . Display_Name  ) ; 
                __context__.SourceCodeLine = 266;
                DISPLAY1_SSI_SEVERITY_MESSAGE  .UpdateValue ( CONFIG . Obj . DisplayArray [ 0] . SSI_Equipment_Status . Severity_Message  ) ; 
                __context__.SourceCodeLine = 267;
                DISPLAY1_SSI_ERROR_TEXT  .UpdateValue ( CONFIG . Obj . DisplayArray [ 0] . SSI_Equipment_Status . Error_Text  ) ; 
                __context__.SourceCodeLine = 268;
                DISPLAY1_SSI_OK_TEXT  .UpdateValue ( CONFIG . Obj . DisplayArray [ 0] . SSI_Equipment_Status . Ok_Text  ) ; 
                } 
            
            catch (Exception __splus_exception__)
                { 
                SimplPlusException __splus_exceptionobj__ = new SimplPlusException(__splus_exception__, this );
                
                
                }
                
                __context__.SourceCodeLine = 269;
                ; 
                __context__.SourceCodeLine = 272;
                try 
                    { 
                    __context__.SourceCodeLine = 273;
                    DISPLAY2_NAME  .UpdateValue ( CONFIG . Obj . DisplayArray [ 1] . Name  ) ; 
                    __context__.SourceCodeLine = 274;
                    DISPLAY2_TYPE  .UpdateValue ( CONFIG . Obj . DisplayArray [ 1] . Type  ) ; 
                    __context__.SourceCodeLine = 275;
                    DISPLAY2_SCREEN_ENABLED  .Value = (ushort) ( CONFIG.Obj.DisplayArray[ 1 ].Screen_Enabled ) ; 
                    __context__.SourceCodeLine = 276;
                    DISPLAY2_SWITCHER_VALUE  .Value = (ushort) ( CONFIG.Obj.DisplayArray[ 1 ].Switcher_Value ) ; 
                    __context__.SourceCodeLine = 277;
                    DISPLAY2_ICON_VALUE  .Value = (ushort) ( CONFIG.Obj.DisplayArray[ 1 ].Icon_Value ) ; 
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
                        DISPLAY3_NAME  .UpdateValue ( CONFIG . Obj . DisplayArray [ 2] . Name  ) ; 
                        __context__.SourceCodeLine = 288;
                        DISPLAY3_TYPE  .UpdateValue ( CONFIG . Obj . DisplayArray [ 2] . Type  ) ; 
                        __context__.SourceCodeLine = 289;
                        DISPLAY3_SCREEN_ENABLED  .Value = (ushort) ( CONFIG.Obj.DisplayArray[ 2 ].Screen_Enabled ) ; 
                        __context__.SourceCodeLine = 290;
                        DISPLAY3_SWITCHER_VALUE  .Value = (ushort) ( CONFIG.Obj.DisplayArray[ 2 ].Switcher_Value ) ; 
                        __context__.SourceCodeLine = 291;
                        DISPLAY3_ICON_VALUE  .Value = (ushort) ( CONFIG.Obj.DisplayArray[ 2 ].Icon_Value ) ; 
                        __context__.SourceCodeLine = 292;
                        DISPLAY3_WARMING_TIME  .Value = (ushort) ( CONFIG.Obj.DisplayArray[ 2 ].Warming_Time ) ; 
                        __context__.SourceCodeLine = 293;
                        DISPLAY3_SSI_USAGE_NAME  .UpdateValue ( CONFIG . Obj . DisplayArray [ 2] . SSI_Display_Usage . Display_Name  ) ; 
                        __context__.SourceCodeLine = 294;
                        DISPLAY3_SSI_SEVERITY_MESSAGE  .UpdateValue ( CONFIG . Obj . DisplayArray [ 2] . SSI_Equipment_Status . Severity_Message  ) ; 
                        __context__.SourceCodeLine = 295;
                        DISPLAY3_SSI_ERROR_TEXT  .UpdateValue ( CONFIG . Obj . DisplayArray [ 2] . SSI_Equipment_Status . Error_Text  ) ; 
                        __context__.SourceCodeLine = 296;
                        DISPLAY3_SSI_OK_TEXT  .UpdateValue ( CONFIG . Obj . DisplayArray [ 2] . SSI_Equipment_Status . Ok_Text  ) ; 
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
                            DISPLAY4_NAME  .UpdateValue ( CONFIG . Obj . DisplayArray [ 3] . Name  ) ; 
                            __context__.SourceCodeLine = 302;
                            DISPLAY4_TYPE  .UpdateValue ( CONFIG . Obj . DisplayArray [ 3] . Type  ) ; 
                            __context__.SourceCodeLine = 303;
                            DISPLAY4_SCREEN_ENABLED  .Value = (ushort) ( CONFIG.Obj.DisplayArray[ 3 ].Screen_Enabled ) ; 
                            __context__.SourceCodeLine = 304;
                            DISPLAY4_SWITCHER_VALUE  .Value = (ushort) ( CONFIG.Obj.DisplayArray[ 3 ].Switcher_Value ) ; 
                            __context__.SourceCodeLine = 305;
                            DISPLAY4_ICON_VALUE  .Value = (ushort) ( CONFIG.Obj.DisplayArray[ 3 ].Icon_Value ) ; 
                            __context__.SourceCodeLine = 306;
                            DISPLAY4_WARMING_TIME  .Value = (ushort) ( CONFIG.Obj.DisplayArray[ 3 ].Warming_Time ) ; 
                            __context__.SourceCodeLine = 307;
                            DISPLAY4_SSI_USAGE_NAME  .UpdateValue ( CONFIG . Obj . DisplayArray [ 3] . SSI_Display_Usage . Display_Name  ) ; 
                            __context__.SourceCodeLine = 308;
                            DISPLAY4_SSI_SEVERITY_MESSAGE  .UpdateValue ( CONFIG . Obj . DisplayArray [ 3] . SSI_Equipment_Status . Severity_Message  ) ; 
                            __context__.SourceCodeLine = 309;
                            DISPLAY4_SSI_ERROR_TEXT  .UpdateValue ( CONFIG . Obj . DisplayArray [ 3] . SSI_Equipment_Status . Error_Text  ) ; 
                            __context__.SourceCodeLine = 310;
                            DISPLAY4_SSI_OK_TEXT  .UpdateValue ( CONFIG . Obj . DisplayArray [ 3] . SSI_Equipment_Status . Ok_Text  ) ; 
                            } 
                        
                        catch (Exception __splus_exception__)
                            { 
                            SimplPlusException __splus_exceptionobj__ = new SimplPlusException(__splus_exception__, this );
                            
                            
                            }
                            
                            __context__.SourceCodeLine = 311;
                            ; 
                            __context__.SourceCodeLine = 314;
                            try 
                                { 
                                __context__.SourceCodeLine = 315;
                                CONFIG . Obj . PresentationToArray ( ) ; 
                                __context__.SourceCodeLine = 316;
                                PRESENTATION1_NAME  .UpdateValue ( CONFIG . Obj . PresentationInputArray [ 0] . Name  ) ; 
                                __context__.SourceCodeLine = 317;
                                PRESENTATION1_TYPE  .UpdateValue ( CONFIG . Obj . PresentationInputArray [ 0] . Type  ) ; 
                                __context__.SourceCodeLine = 318;
                                PRESENTATION1_GENERIC_PAGE_TEXT  .UpdateValue ( CONFIG . Obj . PresentationInputArray [ 0] . Generic_Page_Text  ) ; 
                                __context__.SourceCodeLine = 319;
                                PRESENTATION1_SWITCHER_VALUE  .Value = (ushort) ( CONFIG.Obj.PresentationInputArray[ 0 ].Switcher_Value ) ; 
                                __context__.SourceCodeLine = 320;
                                PRESENTATION1_ICON_VALUE  .Value = (ushort) ( CONFIG.Obj.PresentationInputArray[ 0 ].Icon_Value ) ; 
                                __context__.SourceCodeLine = 321;
                                PRESENTATION1_SSI_DEVICE_USAGE_TYPE  .UpdateValue ( CONFIG . Obj . PresentationInputArray [ 0] . SSI_Device_Usage . Device_Type  ) ; 
                                __context__.SourceCodeLine = 322;
                                PRESENTATION1_SSI_DEVICE_USAGE_NAME  .UpdateValue ( CONFIG . Obj . PresentationInputArray [ 0] . SSI_Device_Usage . Device_Name  ) ; 
                                __context__.SourceCodeLine = 323;
                                PRESENTATION1_SSI_SEVERITY_MESSAGE  .UpdateValue ( CONFIG . Obj . PresentationInputArray [ 0] . SSI_Equipment_Status . Severity_Message  ) ; 
                                __context__.SourceCodeLine = 324;
                                PRESENTATION1_SSI_ERROR_TEXT  .UpdateValue ( CONFIG . Obj . PresentationInputArray [ 0] . SSI_Equipment_Status . Error_Text  ) ; 
                                __context__.SourceCodeLine = 325;
                                PRESENTATION1_SSI_OK_TEXT  .UpdateValue ( CONFIG . Obj . PresentationInputArray [ 0] . SSI_Equipment_Status . Ok_Text  ) ; 
                                } 
                            
                            catch (Exception __splus_exception__)
                                { 
                                SimplPlusException __splus_exceptionobj__ = new SimplPlusException(__splus_exception__, this );
                                
                                
                                }
                                
                                __context__.SourceCodeLine = 326;
                                ; 
                                __context__.SourceCodeLine = 329;
                                try 
                                    { 
                                    __context__.SourceCodeLine = 330;
                                    PRESENTATION2_NAME  .UpdateValue ( CONFIG . Obj . PresentationInputArray [ 1] . Name  ) ; 
                                    __context__.SourceCodeLine = 331;
                                    PRESENTATION2_TYPE  .UpdateValue ( CONFIG . Obj . PresentationInputArray [ 1] . Type  ) ; 
                                    __context__.SourceCodeLine = 332;
                                    PRESENTATION2_GENERIC_PAGE_TEXT  .UpdateValue ( CONFIG . Obj . PresentationInputArray [ 1] . Generic_Page_Text  ) ; 
                                    __context__.SourceCodeLine = 333;
                                    PRESENTATION2_SWITCHER_VALUE  .Value = (ushort) ( CONFIG.Obj.PresentationInputArray[ 1 ].Switcher_Value ) ; 
                                    __context__.SourceCodeLine = 334;
                                    PRESENTATION2_ICON_VALUE  .Value = (ushort) ( CONFIG.Obj.PresentationInputArray[ 1 ].Icon_Value ) ; 
                                    __context__.SourceCodeLine = 335;
                                    PRESENTATION2_SSI_DEVICE_USAGE_TYPE  .UpdateValue ( CONFIG . Obj . PresentationInputArray [ 1] . SSI_Device_Usage . Device_Type  ) ; 
                                    __context__.SourceCodeLine = 336;
                                    PRESENTATION2_SSI_DEVICE_USAGE_NAME  .UpdateValue ( CONFIG . Obj . PresentationInputArray [ 1] . SSI_Device_Usage . Device_Name  ) ; 
                                    __context__.SourceCodeLine = 337;
                                    PRESENTATION2_SSI_SEVERITY_MESSAGE  .UpdateValue ( CONFIG . Obj . PresentationInputArray [ 1] . SSI_Equipment_Status . Severity_Message  ) ; 
                                    __context__.SourceCodeLine = 338;
                                    PRESENTATION2_SSI_ERROR_TEXT  .UpdateValue ( CONFIG . Obj . PresentationInputArray [ 1] . SSI_Equipment_Status . Error_Text  ) ; 
                                    __context__.SourceCodeLine = 339;
                                    PRESENTATION2_SSI_OK_TEXT  .UpdateValue ( CONFIG . Obj . PresentationInputArray [ 1] . SSI_Equipment_Status . Ok_Text  ) ; 
                                    } 
                                
                                catch (Exception __splus_exception__)
                                    { 
                                    SimplPlusException __splus_exceptionobj__ = new SimplPlusException(__splus_exception__, this );
                                    
                                    
                                    }
                                    
                                    __context__.SourceCodeLine = 340;
                                    ; 
                                    __context__.SourceCodeLine = 343;
                                    try 
                                        { 
                                        __context__.SourceCodeLine = 344;
                                        PRESENTATION3_NAME  .UpdateValue ( CONFIG . Obj . PresentationInputArray [ 2] . Name  ) ; 
                                        __context__.SourceCodeLine = 345;
                                        PRESENTATION3_TYPE  .UpdateValue ( CONFIG . Obj . PresentationInputArray [ 2] . Type  ) ; 
                                        __context__.SourceCodeLine = 346;
                                        PRESENTATION3_GENERIC_PAGE_TEXT  .UpdateValue ( CONFIG . Obj . PresentationInputArray [ 2] . Generic_Page_Text  ) ; 
                                        __context__.SourceCodeLine = 347;
                                        PRESENTATION3_SWITCHER_VALUE  .Value = (ushort) ( CONFIG.Obj.PresentationInputArray[ 2 ].Switcher_Value ) ; 
                                        __context__.SourceCodeLine = 348;
                                        PRESENTATION3_ICON_VALUE  .Value = (ushort) ( CONFIG.Obj.PresentationInputArray[ 2 ].Icon_Value ) ; 
                                        __context__.SourceCodeLine = 349;
                                        PRESENTATION3_SSI_DEVICE_USAGE_TYPE  .UpdateValue ( CONFIG . Obj . PresentationInputArray [ 2] . SSI_Device_Usage . Device_Type  ) ; 
                                        __context__.SourceCodeLine = 350;
                                        PRESENTATION3_SSI_DEVICE_USAGE_NAME  .UpdateValue ( CONFIG . Obj . PresentationInputArray [ 2] . SSI_Device_Usage . Device_Name  ) ; 
                                        __context__.SourceCodeLine = 351;
                                        PRESENTATION3_SSI_SEVERITY_MESSAGE  .UpdateValue ( CONFIG . Obj . PresentationInputArray [ 2] . SSI_Equipment_Status . Severity_Message  ) ; 
                                        __context__.SourceCodeLine = 352;
                                        PRESENTATION3_SSI_ERROR_TEXT  .UpdateValue ( CONFIG . Obj . PresentationInputArray [ 2] . SSI_Equipment_Status . Error_Text  ) ; 
                                        __context__.SourceCodeLine = 353;
                                        PRESENTATION3_SSI_OK_TEXT  .UpdateValue ( CONFIG . Obj . PresentationInputArray [ 2] . SSI_Equipment_Status . Ok_Text  ) ; 
                                        } 
                                    
                                    catch (Exception __splus_exception__)
                                        { 
                                        SimplPlusException __splus_exceptionobj__ = new SimplPlusException(__splus_exception__, this );
                                        
                                        
                                        }
                                        
                                        __context__.SourceCodeLine = 354;
                                        ; 
                                        __context__.SourceCodeLine = 356;
                                        try 
                                            { 
                                            __context__.SourceCodeLine = 357;
                                            PRESENTATION4_NAME  .UpdateValue ( CONFIG . Obj . PresentationInputArray [ 3] . Name  ) ; 
                                            __context__.SourceCodeLine = 358;
                                            PRESENTATION4_TYPE  .UpdateValue ( CONFIG . Obj . PresentationInputArray [ 3] . Type  ) ; 
                                            __context__.SourceCodeLine = 359;
                                            PRESENTATION4_GENERIC_PAGE_TEXT  .UpdateValue ( CONFIG . Obj . PresentationInputArray [ 3] . Generic_Page_Text  ) ; 
                                            __context__.SourceCodeLine = 360;
                                            PRESENTATION4_SWITCHER_VALUE  .Value = (ushort) ( CONFIG.Obj.PresentationInputArray[ 3 ].Switcher_Value ) ; 
                                            __context__.SourceCodeLine = 361;
                                            PRESENTATION4_ICON_VALUE  .Value = (ushort) ( CONFIG.Obj.PresentationInputArray[ 3 ].Icon_Value ) ; 
                                            __context__.SourceCodeLine = 362;
                                            PRESENTATION4_SSI_DEVICE_USAGE_TYPE  .UpdateValue ( CONFIG . Obj . PresentationInputArray [ 3] . SSI_Device_Usage . Device_Type  ) ; 
                                            __context__.SourceCodeLine = 363;
                                            PRESENTATION4_SSI_DEVICE_USAGE_NAME  .UpdateValue ( CONFIG . Obj . PresentationInputArray [ 3] . SSI_Device_Usage . Device_Name  ) ; 
                                            __context__.SourceCodeLine = 364;
                                            PRESENTATION4_SSI_SEVERITY_MESSAGE  .UpdateValue ( CONFIG . Obj . PresentationInputArray [ 3] . SSI_Equipment_Status . Severity_Message  ) ; 
                                            __context__.SourceCodeLine = 365;
                                            PRESENTATION4_SSI_ERROR_TEXT  .UpdateValue ( CONFIG . Obj . PresentationInputArray [ 3] . SSI_Equipment_Status . Error_Text  ) ; 
                                            __context__.SourceCodeLine = 366;
                                            PRESENTATION4_SSI_OK_TEXT  .UpdateValue ( CONFIG . Obj . PresentationInputArray [ 3] . SSI_Equipment_Status . Ok_Text  ) ; 
                                            } 
                                        
                                        catch (Exception __splus_exception__)
                                            { 
                                            SimplPlusException __splus_exceptionobj__ = new SimplPlusException(__splus_exception__, this );
                                            
                                            
                                            }
                                            
                                            __context__.SourceCodeLine = 369;
                                            try 
                                                { 
                                                __context__.SourceCodeLine = 370;
                                                PRESENTATION5_NAME  .UpdateValue ( CONFIG . Obj . PresentationInputArray [ 4] . Name  ) ; 
                                                __context__.SourceCodeLine = 371;
                                                PRESENTATION5_TYPE  .UpdateValue ( CONFIG . Obj . PresentationInputArray [ 4] . Type  ) ; 
                                                __context__.SourceCodeLine = 372;
                                                PRESENTATION5_GENERIC_PAGE_TEXT  .UpdateValue ( CONFIG . Obj . PresentationInputArray [ 4] . Generic_Page_Text  ) ; 
                                                __context__.SourceCodeLine = 373;
                                                PRESENTATION5_SWITCHER_VALUE  .Value = (ushort) ( CONFIG.Obj.PresentationInputArray[ 4 ].Switcher_Value ) ; 
                                                __context__.SourceCodeLine = 374;
                                                PRESENTATION5_ICON_VALUE  .Value = (ushort) ( CONFIG.Obj.PresentationInputArray[ 4 ].Icon_Value ) ; 
                                                __context__.SourceCodeLine = 375;
                                                PRESENTATION5_SSI_DEVICE_USAGE_TYPE  .UpdateValue ( CONFIG . Obj . PresentationInputArray [ 4] . SSI_Device_Usage . Device_Type  ) ; 
                                                __context__.SourceCodeLine = 376;
                                                PRESENTATION5_SSI_DEVICE_USAGE_NAME  .UpdateValue ( CONFIG . Obj . PresentationInputArray [ 4] . SSI_Device_Usage . Device_Name  ) ; 
                                                __context__.SourceCodeLine = 377;
                                                PRESENTATION5_SSI_SEVERITY_MESSAGE  .UpdateValue ( CONFIG . Obj . PresentationInputArray [ 4] . SSI_Equipment_Status . Severity_Message  ) ; 
                                                __context__.SourceCodeLine = 378;
                                                PRESENTATION5_SSI_ERROR_TEXT  .UpdateValue ( CONFIG . Obj . PresentationInputArray [ 4] . SSI_Equipment_Status . Error_Text  ) ; 
                                                __context__.SourceCodeLine = 379;
                                                PRESENTATION5_SSI_OK_TEXT  .UpdateValue ( CONFIG . Obj . PresentationInputArray [ 4] . SSI_Equipment_Status . Ok_Text  ) ; 
                                                } 
                                            
                                            catch (Exception __splus_exception__)
                                                { 
                                                SimplPlusException __splus_exceptionobj__ = new SimplPlusException(__splus_exception__, this );
                                                
                                                
                                                }
                                                
                                                __context__.SourceCodeLine = 382;
                                                try 
                                                    { 
                                                    __context__.SourceCodeLine = 383;
                                                    PRESENTATION6_NAME  .UpdateValue ( CONFIG . Obj . PresentationInputArray [ 5] . Name  ) ; 
                                                    __context__.SourceCodeLine = 384;
                                                    PRESENTATION6_TYPE  .UpdateValue ( CONFIG . Obj . PresentationInputArray [ 5] . Type  ) ; 
                                                    __context__.SourceCodeLine = 385;
                                                    PRESENTATION6_GENERIC_PAGE_TEXT  .UpdateValue ( CONFIG . Obj . PresentationInputArray [ 5] . Generic_Page_Text  ) ; 
                                                    __context__.SourceCodeLine = 386;
                                                    PRESENTATION6_SWITCHER_VALUE  .Value = (ushort) ( CONFIG.Obj.PresentationInputArray[ 5 ].Switcher_Value ) ; 
                                                    __context__.SourceCodeLine = 387;
                                                    PRESENTATION6_ICON_VALUE  .Value = (ushort) ( CONFIG.Obj.PresentationInputArray[ 5 ].Icon_Value ) ; 
                                                    __context__.SourceCodeLine = 388;
                                                    PRESENTATION6_SSI_DEVICE_USAGE_TYPE  .UpdateValue ( CONFIG . Obj . PresentationInputArray [ 5] . SSI_Device_Usage . Device_Type  ) ; 
                                                    __context__.SourceCodeLine = 389;
                                                    PRESENTATION6_SSI_DEVICE_USAGE_NAME  .UpdateValue ( CONFIG . Obj . PresentationInputArray [ 5] . SSI_Device_Usage . Device_Name  ) ; 
                                                    __context__.SourceCodeLine = 390;
                                                    PRESENTATION6_SSI_SEVERITY_MESSAGE  .UpdateValue ( CONFIG . Obj . PresentationInputArray [ 5] . SSI_Equipment_Status . Severity_Message  ) ; 
                                                    __context__.SourceCodeLine = 391;
                                                    PRESENTATION6_SSI_ERROR_TEXT  .UpdateValue ( CONFIG . Obj . PresentationInputArray [ 5] . SSI_Equipment_Status . Error_Text  ) ; 
                                                    __context__.SourceCodeLine = 392;
                                                    PRESENTATION6_SSI_OK_TEXT  .UpdateValue ( CONFIG . Obj . PresentationInputArray [ 5] . SSI_Equipment_Status . Ok_Text  ) ; 
                                                    } 
                                                
                                                catch (Exception __splus_exception__)
                                                    { 
                                                    SimplPlusException __splus_exceptionobj__ = new SimplPlusException(__splus_exception__, this );
                                                    
                                                    
                                                    }
                                                    
                                                    
                                                    
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
                                                
                                                __context__.SourceCodeLine = 449;
                                                MakeString ( PROGRAMNUMBER , "{0:d}", (short)GetProgramNumber()) ; 
                                                __context__.SourceCodeLine = 450;
                                                API . ProgramNumber  =  ( PROGRAMNUMBER  )  .ToString() ; 
                                                __context__.SourceCodeLine = 451;
                                                API . Start ( ) ; 
                                                
                                                
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
                                            FILEPATH  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 32, this );
                                            PROGRAMNUMBER  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 6, this );
                                            
                                            PULL_CONFIG = new Crestron.Logos.SplusObjects.DigitalInput( PULL_CONFIG__DigitalInput__, this );
                                            m_DigitalInputList.Add( PULL_CONFIG__DigitalInput__, PULL_CONFIG );
                                            
                                            MICROPHONE_MUTE_ENABLE = new Crestron.Logos.SplusObjects.DigitalOutput( MICROPHONE_MUTE_ENABLE__DigitalOutput__, this );
                                            m_DigitalOutputList.Add( MICROPHONE_MUTE_ENABLE__DigitalOutput__, MICROPHONE_MUTE_ENABLE );
                                            
                                            DISPLAY1_SCREEN_ENABLED = new Crestron.Logos.SplusObjects.DigitalOutput( DISPLAY1_SCREEN_ENABLED__DigitalOutput__, this );
                                            m_DigitalOutputList.Add( DISPLAY1_SCREEN_ENABLED__DigitalOutput__, DISPLAY1_SCREEN_ENABLED );
                                            
                                            DISPLAY2_SCREEN_ENABLED = new Crestron.Logos.SplusObjects.DigitalOutput( DISPLAY2_SCREEN_ENABLED__DigitalOutput__, this );
                                            m_DigitalOutputList.Add( DISPLAY2_SCREEN_ENABLED__DigitalOutput__, DISPLAY2_SCREEN_ENABLED );
                                            
                                            DISPLAY3_SCREEN_ENABLED = new Crestron.Logos.SplusObjects.DigitalOutput( DISPLAY3_SCREEN_ENABLED__DigitalOutput__, this );
                                            m_DigitalOutputList.Add( DISPLAY3_SCREEN_ENABLED__DigitalOutput__, DISPLAY3_SCREEN_ENABLED );
                                            
                                            DISPLAY4_SCREEN_ENABLED = new Crestron.Logos.SplusObjects.DigitalOutput( DISPLAY4_SCREEN_ENABLED__DigitalOutput__, this );
                                            m_DigitalOutputList.Add( DISPLAY4_SCREEN_ENABLED__DigitalOutput__, DISPLAY4_SCREEN_ENABLED );
                                            
                                            STARTUP_TIME = new Crestron.Logos.SplusObjects.AnalogOutput( STARTUP_TIME__AnalogSerialOutput__, this );
                                            m_AnalogOutputList.Add( STARTUP_TIME__AnalogSerialOutput__, STARTUP_TIME );
                                            
                                            SHUTDOWN_TIME_ACTIVE = new Crestron.Logos.SplusObjects.AnalogOutput( SHUTDOWN_TIME_ACTIVE__AnalogSerialOutput__, this );
                                            m_AnalogOutputList.Add( SHUTDOWN_TIME_ACTIVE__AnalogSerialOutput__, SHUTDOWN_TIME_ACTIVE );
                                            
                                            SHUTDOWN_TIME_INACTIVE = new Crestron.Logos.SplusObjects.AnalogOutput( SHUTDOWN_TIME_INACTIVE__AnalogSerialOutput__, this );
                                            m_AnalogOutputList.Add( SHUTDOWN_TIME_INACTIVE__AnalogSerialOutput__, SHUTDOWN_TIME_INACTIVE );
                                            
                                            DISPLAY1_SWITCHER_VALUE = new Crestron.Logos.SplusObjects.AnalogOutput( DISPLAY1_SWITCHER_VALUE__AnalogSerialOutput__, this );
                                            m_AnalogOutputList.Add( DISPLAY1_SWITCHER_VALUE__AnalogSerialOutput__, DISPLAY1_SWITCHER_VALUE );
                                            
                                            DISPLAY1_ICON_VALUE = new Crestron.Logos.SplusObjects.AnalogOutput( DISPLAY1_ICON_VALUE__AnalogSerialOutput__, this );
                                            m_AnalogOutputList.Add( DISPLAY1_ICON_VALUE__AnalogSerialOutput__, DISPLAY1_ICON_VALUE );
                                            
                                            DISPLAY1_WARMING_TIME = new Crestron.Logos.SplusObjects.AnalogOutput( DISPLAY1_WARMING_TIME__AnalogSerialOutput__, this );
                                            m_AnalogOutputList.Add( DISPLAY1_WARMING_TIME__AnalogSerialOutput__, DISPLAY1_WARMING_TIME );
                                            
                                            DISPLAY2_SWITCHER_VALUE = new Crestron.Logos.SplusObjects.AnalogOutput( DISPLAY2_SWITCHER_VALUE__AnalogSerialOutput__, this );
                                            m_AnalogOutputList.Add( DISPLAY2_SWITCHER_VALUE__AnalogSerialOutput__, DISPLAY2_SWITCHER_VALUE );
                                            
                                            DISPLAY2_ICON_VALUE = new Crestron.Logos.SplusObjects.AnalogOutput( DISPLAY2_ICON_VALUE__AnalogSerialOutput__, this );
                                            m_AnalogOutputList.Add( DISPLAY2_ICON_VALUE__AnalogSerialOutput__, DISPLAY2_ICON_VALUE );
                                            
                                            DISPLAY2_WARMING_TIME = new Crestron.Logos.SplusObjects.AnalogOutput( DISPLAY2_WARMING_TIME__AnalogSerialOutput__, this );
                                            m_AnalogOutputList.Add( DISPLAY2_WARMING_TIME__AnalogSerialOutput__, DISPLAY2_WARMING_TIME );
                                            
                                            DISPLAY3_SWITCHER_VALUE = new Crestron.Logos.SplusObjects.AnalogOutput( DISPLAY3_SWITCHER_VALUE__AnalogSerialOutput__, this );
                                            m_AnalogOutputList.Add( DISPLAY3_SWITCHER_VALUE__AnalogSerialOutput__, DISPLAY3_SWITCHER_VALUE );
                                            
                                            DISPLAY3_ICON_VALUE = new Crestron.Logos.SplusObjects.AnalogOutput( DISPLAY3_ICON_VALUE__AnalogSerialOutput__, this );
                                            m_AnalogOutputList.Add( DISPLAY3_ICON_VALUE__AnalogSerialOutput__, DISPLAY3_ICON_VALUE );
                                            
                                            DISPLAY3_WARMING_TIME = new Crestron.Logos.SplusObjects.AnalogOutput( DISPLAY3_WARMING_TIME__AnalogSerialOutput__, this );
                                            m_AnalogOutputList.Add( DISPLAY3_WARMING_TIME__AnalogSerialOutput__, DISPLAY3_WARMING_TIME );
                                            
                                            DISPLAY4_SWITCHER_VALUE = new Crestron.Logos.SplusObjects.AnalogOutput( DISPLAY4_SWITCHER_VALUE__AnalogSerialOutput__, this );
                                            m_AnalogOutputList.Add( DISPLAY4_SWITCHER_VALUE__AnalogSerialOutput__, DISPLAY4_SWITCHER_VALUE );
                                            
                                            DISPLAY4_ICON_VALUE = new Crestron.Logos.SplusObjects.AnalogOutput( DISPLAY4_ICON_VALUE__AnalogSerialOutput__, this );
                                            m_AnalogOutputList.Add( DISPLAY4_ICON_VALUE__AnalogSerialOutput__, DISPLAY4_ICON_VALUE );
                                            
                                            DISPLAY4_WARMING_TIME = new Crestron.Logos.SplusObjects.AnalogOutput( DISPLAY4_WARMING_TIME__AnalogSerialOutput__, this );
                                            m_AnalogOutputList.Add( DISPLAY4_WARMING_TIME__AnalogSerialOutput__, DISPLAY4_WARMING_TIME );
                                            
                                            PRESENTATION1_SWITCHER_VALUE = new Crestron.Logos.SplusObjects.AnalogOutput( PRESENTATION1_SWITCHER_VALUE__AnalogSerialOutput__, this );
                                            m_AnalogOutputList.Add( PRESENTATION1_SWITCHER_VALUE__AnalogSerialOutput__, PRESENTATION1_SWITCHER_VALUE );
                                            
                                            PRESENTATION1_ICON_VALUE = new Crestron.Logos.SplusObjects.AnalogOutput( PRESENTATION1_ICON_VALUE__AnalogSerialOutput__, this );
                                            m_AnalogOutputList.Add( PRESENTATION1_ICON_VALUE__AnalogSerialOutput__, PRESENTATION1_ICON_VALUE );
                                            
                                            PRESENTATION2_SWITCHER_VALUE = new Crestron.Logos.SplusObjects.AnalogOutput( PRESENTATION2_SWITCHER_VALUE__AnalogSerialOutput__, this );
                                            m_AnalogOutputList.Add( PRESENTATION2_SWITCHER_VALUE__AnalogSerialOutput__, PRESENTATION2_SWITCHER_VALUE );
                                            
                                            PRESENTATION2_ICON_VALUE = new Crestron.Logos.SplusObjects.AnalogOutput( PRESENTATION2_ICON_VALUE__AnalogSerialOutput__, this );
                                            m_AnalogOutputList.Add( PRESENTATION2_ICON_VALUE__AnalogSerialOutput__, PRESENTATION2_ICON_VALUE );
                                            
                                            PRESENTATION3_SWITCHER_VALUE = new Crestron.Logos.SplusObjects.AnalogOutput( PRESENTATION3_SWITCHER_VALUE__AnalogSerialOutput__, this );
                                            m_AnalogOutputList.Add( PRESENTATION3_SWITCHER_VALUE__AnalogSerialOutput__, PRESENTATION3_SWITCHER_VALUE );
                                            
                                            PRESENTATION3_ICON_VALUE = new Crestron.Logos.SplusObjects.AnalogOutput( PRESENTATION3_ICON_VALUE__AnalogSerialOutput__, this );
                                            m_AnalogOutputList.Add( PRESENTATION3_ICON_VALUE__AnalogSerialOutput__, PRESENTATION3_ICON_VALUE );
                                            
                                            PRESENTATION4_SWITCHER_VALUE = new Crestron.Logos.SplusObjects.AnalogOutput( PRESENTATION4_SWITCHER_VALUE__AnalogSerialOutput__, this );
                                            m_AnalogOutputList.Add( PRESENTATION4_SWITCHER_VALUE__AnalogSerialOutput__, PRESENTATION4_SWITCHER_VALUE );
                                            
                                            PRESENTATION4_ICON_VALUE = new Crestron.Logos.SplusObjects.AnalogOutput( PRESENTATION4_ICON_VALUE__AnalogSerialOutput__, this );
                                            m_AnalogOutputList.Add( PRESENTATION4_ICON_VALUE__AnalogSerialOutput__, PRESENTATION4_ICON_VALUE );
                                            
                                            PRESENTATION5_SWITCHER_VALUE = new Crestron.Logos.SplusObjects.AnalogOutput( PRESENTATION5_SWITCHER_VALUE__AnalogSerialOutput__, this );
                                            m_AnalogOutputList.Add( PRESENTATION5_SWITCHER_VALUE__AnalogSerialOutput__, PRESENTATION5_SWITCHER_VALUE );
                                            
                                            PRESENTATION5_ICON_VALUE = new Crestron.Logos.SplusObjects.AnalogOutput( PRESENTATION5_ICON_VALUE__AnalogSerialOutput__, this );
                                            m_AnalogOutputList.Add( PRESENTATION5_ICON_VALUE__AnalogSerialOutput__, PRESENTATION5_ICON_VALUE );
                                            
                                            PRESENTATION6_SWITCHER_VALUE = new Crestron.Logos.SplusObjects.AnalogOutput( PRESENTATION6_SWITCHER_VALUE__AnalogSerialOutput__, this );
                                            m_AnalogOutputList.Add( PRESENTATION6_SWITCHER_VALUE__AnalogSerialOutput__, PRESENTATION6_SWITCHER_VALUE );
                                            
                                            PRESENTATION6_ICON_VALUE = new Crestron.Logos.SplusObjects.AnalogOutput( PRESENTATION6_ICON_VALUE__AnalogSerialOutput__, this );
                                            m_AnalogOutputList.Add( PRESENTATION6_ICON_VALUE__AnalogSerialOutput__, PRESENTATION6_ICON_VALUE );
                                            
                                            FILENAME__DOLLAR__ = new Crestron.Logos.SplusObjects.StringInput( FILENAME__DOLLAR____AnalogSerialInput__, 32, this );
                                            m_StringInputList.Add( FILENAME__DOLLAR____AnalogSerialInput__, FILENAME__DOLLAR__ );
                                            
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
                                            
                                            MICROPHONE_MUTED_TEXT = new Crestron.Logos.SplusObjects.StringOutput( MICROPHONE_MUTED_TEXT__AnalogSerialOutput__, this );
                                            m_StringOutputList.Add( MICROPHONE_MUTED_TEXT__AnalogSerialOutput__, MICROPHONE_MUTED_TEXT );
                                            
                                            MICROPHONE_MUTED_NOT_TEXT = new Crestron.Logos.SplusObjects.StringOutput( MICROPHONE_MUTED_NOT_TEXT__AnalogSerialOutput__, this );
                                            m_StringOutputList.Add( MICROPHONE_MUTED_NOT_TEXT__AnalogSerialOutput__, MICROPHONE_MUTED_NOT_TEXT );
                                            
                                            PRESENTATION_PAGE_TEXT = new Crestron.Logos.SplusObjects.StringOutput( PRESENTATION_PAGE_TEXT__AnalogSerialOutput__, this );
                                            m_StringOutputList.Add( PRESENTATION_PAGE_TEXT__AnalogSerialOutput__, PRESENTATION_PAGE_TEXT );
                                            
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
                                            
                                            DISPLAY3_NAME = new Crestron.Logos.SplusObjects.StringOutput( DISPLAY3_NAME__AnalogSerialOutput__, this );
                                            m_StringOutputList.Add( DISPLAY3_NAME__AnalogSerialOutput__, DISPLAY3_NAME );
                                            
                                            DISPLAY3_TYPE = new Crestron.Logos.SplusObjects.StringOutput( DISPLAY3_TYPE__AnalogSerialOutput__, this );
                                            m_StringOutputList.Add( DISPLAY3_TYPE__AnalogSerialOutput__, DISPLAY3_TYPE );
                                            
                                            DISPLAY3_SSI_USAGE_NAME = new Crestron.Logos.SplusObjects.StringOutput( DISPLAY3_SSI_USAGE_NAME__AnalogSerialOutput__, this );
                                            m_StringOutputList.Add( DISPLAY3_SSI_USAGE_NAME__AnalogSerialOutput__, DISPLAY3_SSI_USAGE_NAME );
                                            
                                            DISPLAY3_SSI_SEVERITY_MESSAGE = new Crestron.Logos.SplusObjects.StringOutput( DISPLAY3_SSI_SEVERITY_MESSAGE__AnalogSerialOutput__, this );
                                            m_StringOutputList.Add( DISPLAY3_SSI_SEVERITY_MESSAGE__AnalogSerialOutput__, DISPLAY3_SSI_SEVERITY_MESSAGE );
                                            
                                            DISPLAY3_SSI_ERROR_TEXT = new Crestron.Logos.SplusObjects.StringOutput( DISPLAY3_SSI_ERROR_TEXT__AnalogSerialOutput__, this );
                                            m_StringOutputList.Add( DISPLAY3_SSI_ERROR_TEXT__AnalogSerialOutput__, DISPLAY3_SSI_ERROR_TEXT );
                                            
                                            DISPLAY3_SSI_OK_TEXT = new Crestron.Logos.SplusObjects.StringOutput( DISPLAY3_SSI_OK_TEXT__AnalogSerialOutput__, this );
                                            m_StringOutputList.Add( DISPLAY3_SSI_OK_TEXT__AnalogSerialOutput__, DISPLAY3_SSI_OK_TEXT );
                                            
                                            DISPLAY4_NAME = new Crestron.Logos.SplusObjects.StringOutput( DISPLAY4_NAME__AnalogSerialOutput__, this );
                                            m_StringOutputList.Add( DISPLAY4_NAME__AnalogSerialOutput__, DISPLAY4_NAME );
                                            
                                            DISPLAY4_TYPE = new Crestron.Logos.SplusObjects.StringOutput( DISPLAY4_TYPE__AnalogSerialOutput__, this );
                                            m_StringOutputList.Add( DISPLAY4_TYPE__AnalogSerialOutput__, DISPLAY4_TYPE );
                                            
                                            DISPLAY4_SSI_USAGE_NAME = new Crestron.Logos.SplusObjects.StringOutput( DISPLAY4_SSI_USAGE_NAME__AnalogSerialOutput__, this );
                                            m_StringOutputList.Add( DISPLAY4_SSI_USAGE_NAME__AnalogSerialOutput__, DISPLAY4_SSI_USAGE_NAME );
                                            
                                            DISPLAY4_SSI_SEVERITY_MESSAGE = new Crestron.Logos.SplusObjects.StringOutput( DISPLAY4_SSI_SEVERITY_MESSAGE__AnalogSerialOutput__, this );
                                            m_StringOutputList.Add( DISPLAY4_SSI_SEVERITY_MESSAGE__AnalogSerialOutput__, DISPLAY4_SSI_SEVERITY_MESSAGE );
                                            
                                            DISPLAY4_SSI_ERROR_TEXT = new Crestron.Logos.SplusObjects.StringOutput( DISPLAY4_SSI_ERROR_TEXT__AnalogSerialOutput__, this );
                                            m_StringOutputList.Add( DISPLAY4_SSI_ERROR_TEXT__AnalogSerialOutput__, DISPLAY4_SSI_ERROR_TEXT );
                                            
                                            DISPLAY4_SSI_OK_TEXT = new Crestron.Logos.SplusObjects.StringOutput( DISPLAY4_SSI_OK_TEXT__AnalogSerialOutput__, this );
                                            m_StringOutputList.Add( DISPLAY4_SSI_OK_TEXT__AnalogSerialOutput__, DISPLAY4_SSI_OK_TEXT );
                                            
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
                                            
                                            
                                            FILENAME__DOLLAR__.OnSerialChange.Add( new InputChangeHandlerWrapper( FILENAME__DOLLAR___OnChange_0, false ) );
                                            PULL_CONFIG.OnDigitalPush.Add( new InputChangeHandlerWrapper( PULL_CONFIG_OnPush_1, false ) );
                                            
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
                                        const uint FILENAME__DOLLAR____AnalogSerialInput__ = 0;
                                        const uint STARTUP_TIME__AnalogSerialOutput__ = 0;
                                        const uint SHUTDOWN_TIME_ACTIVE__AnalogSerialOutput__ = 1;
                                        const uint SHUTDOWN_TIME_INACTIVE__AnalogSerialOutput__ = 2;
                                        const uint ROOM_NAME__AnalogSerialOutput__ = 3;
                                        const uint WELCOME_TEXT__AnalogSerialOutput__ = 4;
                                        const uint SHUTDOWN_TEXT__AnalogSerialOutput__ = 5;
                                        const uint WARMING_TEXT__AnalogSerialOutput__ = 6;
                                        const uint COOLING_TEXT__AnalogSerialOutput__ = 7;
                                        const uint MICROPHONE_MUTE_ENABLE__DigitalOutput__ = 0;
                                        const uint MICROPHONE_MUTED_TEXT__AnalogSerialOutput__ = 8;
                                        const uint MICROPHONE_MUTED_NOT_TEXT__AnalogSerialOutput__ = 9;
                                        const uint PRESENTATION_PAGE_TEXT__AnalogSerialOutput__ = 10;
                                        const uint DISPLAY1_NAME__AnalogSerialOutput__ = 11;
                                        const uint DISPLAY1_TYPE__AnalogSerialOutput__ = 12;
                                        const uint DISPLAY1_SCREEN_ENABLED__DigitalOutput__ = 1;
                                        const uint DISPLAY1_SWITCHER_VALUE__AnalogSerialOutput__ = 13;
                                        const uint DISPLAY1_ICON_VALUE__AnalogSerialOutput__ = 14;
                                        const uint DISPLAY1_WARMING_TIME__AnalogSerialOutput__ = 15;
                                        const uint DISPLAY1_SSI_USAGE_NAME__AnalogSerialOutput__ = 16;
                                        const uint DISPLAY1_SSI_SEVERITY_MESSAGE__AnalogSerialOutput__ = 17;
                                        const uint DISPLAY1_SSI_ERROR_TEXT__AnalogSerialOutput__ = 18;
                                        const uint DISPLAY1_SSI_OK_TEXT__AnalogSerialOutput__ = 19;
                                        const uint DISPLAY2_NAME__AnalogSerialOutput__ = 20;
                                        const uint DISPLAY2_TYPE__AnalogSerialOutput__ = 21;
                                        const uint DISPLAY2_SCREEN_ENABLED__DigitalOutput__ = 2;
                                        const uint DISPLAY2_SWITCHER_VALUE__AnalogSerialOutput__ = 22;
                                        const uint DISPLAY2_ICON_VALUE__AnalogSerialOutput__ = 23;
                                        const uint DISPLAY2_WARMING_TIME__AnalogSerialOutput__ = 24;
                                        const uint DISPLAY2_SSI_USAGE_NAME__AnalogSerialOutput__ = 25;
                                        const uint DISPLAY2_SSI_SEVERITY_MESSAGE__AnalogSerialOutput__ = 26;
                                        const uint DISPLAY2_SSI_ERROR_TEXT__AnalogSerialOutput__ = 27;
                                        const uint DISPLAY2_SSI_OK_TEXT__AnalogSerialOutput__ = 28;
                                        const uint DISPLAY3_NAME__AnalogSerialOutput__ = 29;
                                        const uint DISPLAY3_TYPE__AnalogSerialOutput__ = 30;
                                        const uint DISPLAY3_SCREEN_ENABLED__DigitalOutput__ = 3;
                                        const uint DISPLAY3_SWITCHER_VALUE__AnalogSerialOutput__ = 31;
                                        const uint DISPLAY3_ICON_VALUE__AnalogSerialOutput__ = 32;
                                        const uint DISPLAY3_WARMING_TIME__AnalogSerialOutput__ = 33;
                                        const uint DISPLAY3_SSI_USAGE_NAME__AnalogSerialOutput__ = 34;
                                        const uint DISPLAY3_SSI_SEVERITY_MESSAGE__AnalogSerialOutput__ = 35;
                                        const uint DISPLAY3_SSI_ERROR_TEXT__AnalogSerialOutput__ = 36;
                                        const uint DISPLAY3_SSI_OK_TEXT__AnalogSerialOutput__ = 37;
                                        const uint DISPLAY4_NAME__AnalogSerialOutput__ = 38;
                                        const uint DISPLAY4_TYPE__AnalogSerialOutput__ = 39;
                                        const uint DISPLAY4_SCREEN_ENABLED__DigitalOutput__ = 4;
                                        const uint DISPLAY4_SWITCHER_VALUE__AnalogSerialOutput__ = 40;
                                        const uint DISPLAY4_ICON_VALUE__AnalogSerialOutput__ = 41;
                                        const uint DISPLAY4_WARMING_TIME__AnalogSerialOutput__ = 42;
                                        const uint DISPLAY4_SSI_USAGE_NAME__AnalogSerialOutput__ = 43;
                                        const uint DISPLAY4_SSI_SEVERITY_MESSAGE__AnalogSerialOutput__ = 44;
                                        const uint DISPLAY4_SSI_ERROR_TEXT__AnalogSerialOutput__ = 45;
                                        const uint DISPLAY4_SSI_OK_TEXT__AnalogSerialOutput__ = 46;
                                        const uint PRESENTATION1_NAME__AnalogSerialOutput__ = 47;
                                        const uint PRESENTATION1_TYPE__AnalogSerialOutput__ = 48;
                                        const uint PRESENTATION1_GENERIC_PAGE_TEXT__AnalogSerialOutput__ = 49;
                                        const uint PRESENTATION1_SWITCHER_VALUE__AnalogSerialOutput__ = 50;
                                        const uint PRESENTATION1_ICON_VALUE__AnalogSerialOutput__ = 51;
                                        const uint PRESENTATION1_SSI_DEVICE_USAGE_TYPE__AnalogSerialOutput__ = 52;
                                        const uint PRESENTATION1_SSI_DEVICE_USAGE_NAME__AnalogSerialOutput__ = 53;
                                        const uint PRESENTATION1_SSI_SEVERITY_MESSAGE__AnalogSerialOutput__ = 54;
                                        const uint PRESENTATION1_SSI_ERROR_TEXT__AnalogSerialOutput__ = 55;
                                        const uint PRESENTATION1_SSI_OK_TEXT__AnalogSerialOutput__ = 56;
                                        const uint PRESENTATION2_NAME__AnalogSerialOutput__ = 57;
                                        const uint PRESENTATION2_TYPE__AnalogSerialOutput__ = 58;
                                        const uint PRESENTATION2_GENERIC_PAGE_TEXT__AnalogSerialOutput__ = 59;
                                        const uint PRESENTATION2_SWITCHER_VALUE__AnalogSerialOutput__ = 60;
                                        const uint PRESENTATION2_ICON_VALUE__AnalogSerialOutput__ = 61;
                                        const uint PRESENTATION2_SSI_DEVICE_USAGE_TYPE__AnalogSerialOutput__ = 62;
                                        const uint PRESENTATION2_SSI_DEVICE_USAGE_NAME__AnalogSerialOutput__ = 63;
                                        const uint PRESENTATION2_SSI_SEVERITY_MESSAGE__AnalogSerialOutput__ = 64;
                                        const uint PRESENTATION2_SSI_ERROR_TEXT__AnalogSerialOutput__ = 65;
                                        const uint PRESENTATION2_SSI_OK_TEXT__AnalogSerialOutput__ = 66;
                                        const uint PRESENTATION3_NAME__AnalogSerialOutput__ = 67;
                                        const uint PRESENTATION3_TYPE__AnalogSerialOutput__ = 68;
                                        const uint PRESENTATION3_GENERIC_PAGE_TEXT__AnalogSerialOutput__ = 69;
                                        const uint PRESENTATION3_SWITCHER_VALUE__AnalogSerialOutput__ = 70;
                                        const uint PRESENTATION3_ICON_VALUE__AnalogSerialOutput__ = 71;
                                        const uint PRESENTATION3_SSI_DEVICE_USAGE_TYPE__AnalogSerialOutput__ = 72;
                                        const uint PRESENTATION3_SSI_DEVICE_USAGE_NAME__AnalogSerialOutput__ = 73;
                                        const uint PRESENTATION3_SSI_SEVERITY_MESSAGE__AnalogSerialOutput__ = 74;
                                        const uint PRESENTATION3_SSI_ERROR_TEXT__AnalogSerialOutput__ = 75;
                                        const uint PRESENTATION3_SSI_OK_TEXT__AnalogSerialOutput__ = 76;
                                        const uint PRESENTATION4_NAME__AnalogSerialOutput__ = 77;
                                        const uint PRESENTATION4_TYPE__AnalogSerialOutput__ = 78;
                                        const uint PRESENTATION4_GENERIC_PAGE_TEXT__AnalogSerialOutput__ = 79;
                                        const uint PRESENTATION4_SWITCHER_VALUE__AnalogSerialOutput__ = 80;
                                        const uint PRESENTATION4_ICON_VALUE__AnalogSerialOutput__ = 81;
                                        const uint PRESENTATION4_SSI_DEVICE_USAGE_TYPE__AnalogSerialOutput__ = 82;
                                        const uint PRESENTATION4_SSI_DEVICE_USAGE_NAME__AnalogSerialOutput__ = 83;
                                        const uint PRESENTATION4_SSI_SEVERITY_MESSAGE__AnalogSerialOutput__ = 84;
                                        const uint PRESENTATION4_SSI_ERROR_TEXT__AnalogSerialOutput__ = 85;
                                        const uint PRESENTATION4_SSI_OK_TEXT__AnalogSerialOutput__ = 86;
                                        const uint PRESENTATION5_NAME__AnalogSerialOutput__ = 87;
                                        const uint PRESENTATION5_TYPE__AnalogSerialOutput__ = 88;
                                        const uint PRESENTATION5_GENERIC_PAGE_TEXT__AnalogSerialOutput__ = 89;
                                        const uint PRESENTATION5_SWITCHER_VALUE__AnalogSerialOutput__ = 90;
                                        const uint PRESENTATION5_ICON_VALUE__AnalogSerialOutput__ = 91;
                                        const uint PRESENTATION5_SSI_DEVICE_USAGE_TYPE__AnalogSerialOutput__ = 92;
                                        const uint PRESENTATION5_SSI_DEVICE_USAGE_NAME__AnalogSerialOutput__ = 93;
                                        const uint PRESENTATION5_SSI_SEVERITY_MESSAGE__AnalogSerialOutput__ = 94;
                                        const uint PRESENTATION5_SSI_ERROR_TEXT__AnalogSerialOutput__ = 95;
                                        const uint PRESENTATION5_SSI_OK_TEXT__AnalogSerialOutput__ = 96;
                                        const uint PRESENTATION6_NAME__AnalogSerialOutput__ = 97;
                                        const uint PRESENTATION6_TYPE__AnalogSerialOutput__ = 98;
                                        const uint PRESENTATION6_GENERIC_PAGE_TEXT__AnalogSerialOutput__ = 99;
                                        const uint PRESENTATION6_SWITCHER_VALUE__AnalogSerialOutput__ = 100;
                                        const uint PRESENTATION6_ICON_VALUE__AnalogSerialOutput__ = 101;
                                        const uint PRESENTATION6_SSI_DEVICE_USAGE_TYPE__AnalogSerialOutput__ = 102;
                                        const uint PRESENTATION6_SSI_DEVICE_USAGE_NAME__AnalogSerialOutput__ = 103;
                                        const uint PRESENTATION6_SSI_SEVERITY_MESSAGE__AnalogSerialOutput__ = 104;
                                        const uint PRESENTATION6_SSI_ERROR_TEXT__AnalogSerialOutput__ = 105;
                                        const uint PRESENTATION6_SSI_OK_TEXT__AnalogSerialOutput__ = 106;
                                        
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
                                