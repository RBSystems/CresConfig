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

namespace UserModule_IMS_CONFIGURATION_P2
{
    public class UserModuleClass_IMS_CONFIGURATION_P2 : SplusObject
    {
        static CCriticalSection g_criticalSection = new CCriticalSection();
        
        Crestron.Logos.SplusObjects.DigitalInput PULL_CONFIG;
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
        CrestronString FILEPATH;
        CrestronString PROGRAMNUMBER;
        IMS_Configuration.Configuration CONFIG;
        IMS_Configuration.RESTfulApi API;
        object PULL_CONFIG_OnPush_0 ( Object __EventInfo__ )
        
            { 
            Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
            try
            {
                SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
                
                __context__.SourceCodeLine = 195;
                CONFIG . Reader ( ) ; 
                __context__.SourceCodeLine = 197;
                ATC_EXTENSION  .UpdateValue ( CONFIG . Obj . ATC . Extension  ) ; 
                __context__.SourceCodeLine = 198;
                ATC_HELP_NUMBER  .UpdateValue ( CONFIG . Obj . ATC . Help_Number  ) ; 
                __context__.SourceCodeLine = 199;
                ATC_HELP_BTN_TEXT  .UpdateValue ( CONFIG . Obj . ATC . Help_Button_Text  ) ; 
                __context__.SourceCodeLine = 200;
                ATC_CONNECTED_DIAL_TEXT  .UpdateValue ( CONFIG . Obj . ATC . Connected_Dial_Text  ) ; 
                __context__.SourceCodeLine = 201;
                ATC_DISCONNECTED_DIAL_TEXT  .UpdateValue ( CONFIG . Obj . ATC . Disconnected_Dial_Text  ) ; 
                __context__.SourceCodeLine = 202;
                ATC_CONNECTED_HANGUP_TEXT  .UpdateValue ( CONFIG . Obj . ATC . Connected_Hangup_Text  ) ; 
                __context__.SourceCodeLine = 203;
                ATC_DISCONNECTED_HANGUP_TEXT  .UpdateValue ( CONFIG . Obj . ATC . Disconnected_Hangup_Text  ) ; 
                __context__.SourceCodeLine = 204;
                ATC_SSI_DEVICE_USAGE_TYPE  .UpdateValue ( CONFIG . Obj . ATC . SSI_Device_Usage . Device_Type  ) ; 
                __context__.SourceCodeLine = 205;
                ATC_SSI_DEVICE_USAGE_NAME  .UpdateValue ( CONFIG . Obj . ATC . SSI_Device_Usage . Device_Name  ) ; 
                __context__.SourceCodeLine = 206;
                ATC_SSI_SEVERITY_MESSAGE  .UpdateValue ( CONFIG . Obj . ATC . SSI_Equipment_Status . Severity_Message  ) ; 
                __context__.SourceCodeLine = 207;
                ATC_SSI_ERROR_TEXT  .UpdateValue ( CONFIG . Obj . ATC . SSI_Equipment_Status . Error_Text  ) ; 
                __context__.SourceCodeLine = 208;
                ATC_SSI_OK_TEXT  .UpdateValue ( CONFIG . Obj . ATC . SSI_Equipment_Status . Ok_Text  ) ; 
                __context__.SourceCodeLine = 210;
                VTC_EXTENSION  .UpdateValue ( CONFIG . Obj . VTC . Extension  ) ; 
                __context__.SourceCodeLine = 211;
                VTC_HELP_NUMBER  .UpdateValue ( CONFIG . Obj . VTC . Help_Number  ) ; 
                __context__.SourceCodeLine = 212;
                VTC_HELP_BTN_TEXT  .UpdateValue ( CONFIG . Obj . VTC . Help_Button_Text  ) ; 
                __context__.SourceCodeLine = 213;
                VTC_CONNECTED_DIAL_TEXT  .UpdateValue ( CONFIG . Obj . VTC . Connected_Dial_Text  ) ; 
                __context__.SourceCodeLine = 214;
                VTC_DISCONNECTED_DIAL_TEXT  .UpdateValue ( CONFIG . Obj . VTC . Disconnected_Dial_Text  ) ; 
                __context__.SourceCodeLine = 215;
                VTC_CONNECTED_HANGUP_TEXT  .UpdateValue ( CONFIG . Obj . VTC . Connected_Hangup_Text  ) ; 
                __context__.SourceCodeLine = 216;
                VTC_DISCONNECTED_HANGUP_TEXT  .UpdateValue ( CONFIG . Obj . VTC . Disconnected_Hangup_Text  ) ; 
                __context__.SourceCodeLine = 217;
                CONFIG . Obj . VTC . PresetToArray ( ) ; 
                __context__.SourceCodeLine = 218;
                try 
                    { 
                    __context__.SourceCodeLine = 219;
                    VTC_CAM_PRESET1_ID  .UpdateValue ( CONFIG . Obj . VTC . PresetsArray [ 0] . Id  ) ; 
                    __context__.SourceCodeLine = 220;
                    VTC_CAM_PRESET1_NAME  .UpdateValue ( CONFIG . Obj . VTC . PresetsArray [ 0] . Name  ) ; 
                    } 
                
                catch (Exception __splus_exception__)
                    { 
                    SimplPlusException __splus_exceptionobj__ = new SimplPlusException(__splus_exception__, this );
                    
                    
                    }
                    
                    __context__.SourceCodeLine = 221;
                    ; 
                    __context__.SourceCodeLine = 222;
                    try 
                        { 
                        __context__.SourceCodeLine = 223;
                        VTC_CAM_PRESET2_ID  .UpdateValue ( CONFIG . Obj . VTC . PresetsArray [ 1] . Id  ) ; 
                        __context__.SourceCodeLine = 224;
                        VTC_CAM_PRESET2_NAME  .UpdateValue ( CONFIG . Obj . VTC . PresetsArray [ 1] . Name  ) ; 
                        } 
                    
                    catch (Exception __splus_exception__)
                        { 
                        SimplPlusException __splus_exceptionobj__ = new SimplPlusException(__splus_exception__, this );
                        
                        
                        }
                        
                        __context__.SourceCodeLine = 225;
                        ; 
                        __context__.SourceCodeLine = 226;
                        try 
                            { 
                            __context__.SourceCodeLine = 227;
                            VTC_CAM_PRESET3_ID  .UpdateValue ( CONFIG . Obj . VTC . PresetsArray [ 2] . Id  ) ; 
                            __context__.SourceCodeLine = 228;
                            VTC_CAM_PRESET3_NAME  .UpdateValue ( CONFIG . Obj . VTC . PresetsArray [ 2] . Name  ) ; 
                            } 
                        
                        catch (Exception __splus_exception__)
                            { 
                            SimplPlusException __splus_exceptionobj__ = new SimplPlusException(__splus_exception__, this );
                            
                            
                            }
                            
                            __context__.SourceCodeLine = 229;
                            ; 
                            __context__.SourceCodeLine = 230;
                            try 
                                { 
                                __context__.SourceCodeLine = 231;
                                VTC_CAM_PRESET4_ID  .UpdateValue ( CONFIG . Obj . VTC . PresetsArray [ 3] . Id  ) ; 
                                __context__.SourceCodeLine = 232;
                                VTC_CAM_PRESET4_NAME  .UpdateValue ( CONFIG . Obj . VTC . PresetsArray [ 3] . Name  ) ; 
                                } 
                            
                            catch (Exception __splus_exception__)
                                { 
                                SimplPlusException __splus_exceptionobj__ = new SimplPlusException(__splus_exception__, this );
                                
                                
                                }
                                
                                __context__.SourceCodeLine = 233;
                                ; 
                                __context__.SourceCodeLine = 234;
                                try 
                                    { 
                                    __context__.SourceCodeLine = 235;
                                    VTC_CAM_PRESET5_ID  .UpdateValue ( CONFIG . Obj . VTC . PresetsArray [ 4] . Id  ) ; 
                                    __context__.SourceCodeLine = 236;
                                    VTC_CAM_PRESET5_NAME  .UpdateValue ( CONFIG . Obj . VTC . PresetsArray [ 4] . Name  ) ; 
                                    } 
                                
                                catch (Exception __splus_exception__)
                                    { 
                                    SimplPlusException __splus_exceptionobj__ = new SimplPlusException(__splus_exception__, this );
                                    
                                    
                                    }
                                    
                                    __context__.SourceCodeLine = 237;
                                    ; 
                                    __context__.SourceCodeLine = 238;
                                    try 
                                        { 
                                        __context__.SourceCodeLine = 239;
                                        VTC_CAM_PRESET6_ID  .UpdateValue ( CONFIG . Obj . VTC . PresetsArray [ 5] . Id  ) ; 
                                        __context__.SourceCodeLine = 240;
                                        VTC_CAM_PRESET6_NAME  .UpdateValue ( CONFIG . Obj . VTC . PresetsArray [ 5] . Name  ) ; 
                                        } 
                                    
                                    catch (Exception __splus_exception__)
                                        { 
                                        SimplPlusException __splus_exceptionobj__ = new SimplPlusException(__splus_exception__, this );
                                        
                                        
                                        }
                                        
                                        __context__.SourceCodeLine = 241;
                                        ; 
                                        __context__.SourceCodeLine = 242;
                                        VTC_SSI_DEVICE_USAGE_TYPE  .UpdateValue ( CONFIG . Obj . VTC . SSI_Device_Usage . Device_Type  ) ; 
                                        __context__.SourceCodeLine = 243;
                                        VTC_SSI_DEVICE_USAGE_NAME  .UpdateValue ( CONFIG . Obj . VTC . SSI_Device_Usage . Device_Name  ) ; 
                                        __context__.SourceCodeLine = 244;
                                        VTC_SSI_SEVERITY_MESSAGE  .UpdateValue ( CONFIG . Obj . VTC . SSI_Equipment_Status . Severity_Message  ) ; 
                                        __context__.SourceCodeLine = 245;
                                        VTC_SSI_ERROR_TEXT  .UpdateValue ( CONFIG . Obj . VTC . SSI_Equipment_Status . Error_Text  ) ; 
                                        __context__.SourceCodeLine = 246;
                                        VTC_SSI_OK_TEXT  .UpdateValue ( CONFIG . Obj . VTC . SSI_Equipment_Status . Ok_Text  ) ; 
                                        __context__.SourceCodeLine = 249;
                                        CONFIG . Obj . Lighting . PresetToArray ( ) ; 
                                        __context__.SourceCodeLine = 250;
                                        try 
                                            { 
                                            __context__.SourceCodeLine = 251;
                                            LIGHTING_PRESET1_ID  .UpdateValue ( CONFIG . Obj . Lighting . PresetsArray [ 0] . Id  ) ; 
                                            __context__.SourceCodeLine = 252;
                                            LIGHTING_PRESET1_NAME  .UpdateValue ( CONFIG . Obj . Lighting . PresetsArray [ 0] . Name  ) ; 
                                            } 
                                        
                                        catch (Exception __splus_exception__)
                                            { 
                                            SimplPlusException __splus_exceptionobj__ = new SimplPlusException(__splus_exception__, this );
                                            
                                            
                                            }
                                            
                                            __context__.SourceCodeLine = 253;
                                            ; 
                                            __context__.SourceCodeLine = 254;
                                            try 
                                                { 
                                                __context__.SourceCodeLine = 255;
                                                LIGHTING_PRESET2_ID  .UpdateValue ( CONFIG . Obj . Lighting . PresetsArray [ 1] . Id  ) ; 
                                                __context__.SourceCodeLine = 256;
                                                LIGHTING_PRESET2_NAME  .UpdateValue ( CONFIG . Obj . Lighting . PresetsArray [ 1] . Name  ) ; 
                                                } 
                                            
                                            catch (Exception __splus_exception__)
                                                { 
                                                SimplPlusException __splus_exceptionobj__ = new SimplPlusException(__splus_exception__, this );
                                                
                                                
                                                }
                                                
                                                __context__.SourceCodeLine = 257;
                                                ; 
                                                __context__.SourceCodeLine = 258;
                                                try 
                                                    { 
                                                    __context__.SourceCodeLine = 259;
                                                    LIGHTING_PRESET3_ID  .UpdateValue ( CONFIG . Obj . Lighting . PresetsArray [ 2] . Id  ) ; 
                                                    __context__.SourceCodeLine = 260;
                                                    LIGHTING_PRESET3_NAME  .UpdateValue ( CONFIG . Obj . Lighting . PresetsArray [ 2] . Name  ) ; 
                                                    } 
                                                
                                                catch (Exception __splus_exception__)
                                                    { 
                                                    SimplPlusException __splus_exceptionobj__ = new SimplPlusException(__splus_exception__, this );
                                                    
                                                    
                                                    }
                                                    
                                                    __context__.SourceCodeLine = 261;
                                                    ; 
                                                    __context__.SourceCodeLine = 262;
                                                    try 
                                                        { 
                                                        __context__.SourceCodeLine = 263;
                                                        LIGHTING_PRESET4_ID  .UpdateValue ( CONFIG . Obj . Lighting . PresetsArray [ 3] . Id  ) ; 
                                                        __context__.SourceCodeLine = 264;
                                                        LIGHTING_PRESET4_NAME  .UpdateValue ( CONFIG . Obj . Lighting . PresetsArray [ 3] . Name  ) ; 
                                                        } 
                                                    
                                                    catch (Exception __splus_exception__)
                                                        { 
                                                        SimplPlusException __splus_exceptionobj__ = new SimplPlusException(__splus_exception__, this );
                                                        
                                                        
                                                        }
                                                        
                                                        __context__.SourceCodeLine = 265;
                                                        ; 
                                                        __context__.SourceCodeLine = 266;
                                                        try 
                                                            { 
                                                            __context__.SourceCodeLine = 267;
                                                            LIGHTING_PRESET5_ID  .UpdateValue ( CONFIG . Obj . Lighting . PresetsArray [ 4] . Id  ) ; 
                                                            __context__.SourceCodeLine = 268;
                                                            LIGHTING_PRESET5_NAME  .UpdateValue ( CONFIG . Obj . Lighting . PresetsArray [ 4] . Name  ) ; 
                                                            } 
                                                        
                                                        catch (Exception __splus_exception__)
                                                            { 
                                                            SimplPlusException __splus_exceptionobj__ = new SimplPlusException(__splus_exception__, this );
                                                            
                                                            
                                                            }
                                                            
                                                            __context__.SourceCodeLine = 269;
                                                            ; 
                                                            __context__.SourceCodeLine = 270;
                                                            try 
                                                                { 
                                                                __context__.SourceCodeLine = 271;
                                                                LIGHTING_PRESET6_ID  .UpdateValue ( CONFIG . Obj . Lighting . PresetsArray [ 5] . Id  ) ; 
                                                                __context__.SourceCodeLine = 272;
                                                                LIGHTING_PRESET6_NAME  .UpdateValue ( CONFIG . Obj . Lighting . PresetsArray [ 5] . Name  ) ; 
                                                                } 
                                                            
                                                            catch (Exception __splus_exception__)
                                                                { 
                                                                SimplPlusException __splus_exceptionobj__ = new SimplPlusException(__splus_exception__, this );
                                                                
                                                                
                                                                }
                                                                
                                                                __context__.SourceCodeLine = 273;
                                                                ; 
                                                                __context__.SourceCodeLine = 274;
                                                                LIGHTING_SSI_SEVERITY_MESSAGE  .UpdateValue ( CONFIG . Obj . Lighting . SSI_Equipment_Status . Severity_Message  ) ; 
                                                                __context__.SourceCodeLine = 275;
                                                                LIGHTING_SSI_ERROR_TEXT  .UpdateValue ( CONFIG . Obj . Lighting . SSI_Equipment_Status . Error_Text  ) ; 
                                                                __context__.SourceCodeLine = 276;
                                                                LIGHTING_SSI_OK_TEXT  .UpdateValue ( CONFIG . Obj . Lighting . SSI_Equipment_Status . Ok_Text  ) ; 
                                                                __context__.SourceCodeLine = 279;
                                                                CONFIG . Obj . PowerSequencerToArray ( ) ; 
                                                                __context__.SourceCodeLine = 280;
                                                                try 
                                                                    { 
                                                                    __context__.SourceCodeLine = 281;
                                                                    SEQUENCER1_CH1_NAME  .UpdateValue ( CONFIG . Obj . PowerSequencerArray [ 0] . Channel_1_Name  ) ; 
                                                                    __context__.SourceCodeLine = 282;
                                                                    SEQUENCER1_CH2_NAME  .UpdateValue ( CONFIG . Obj . PowerSequencerArray [ 0] . Channel_2_Name  ) ; 
                                                                    __context__.SourceCodeLine = 283;
                                                                    SEQUENCER1_CH3_NAME  .UpdateValue ( CONFIG . Obj . PowerSequencerArray [ 0] . Channel_1_Name  ) ; 
                                                                    __context__.SourceCodeLine = 284;
                                                                    SEQUENCER1_CH4_NAME  .UpdateValue ( CONFIG . Obj . PowerSequencerArray [ 0] . Channel_1_Name  ) ; 
                                                                    __context__.SourceCodeLine = 285;
                                                                    SEQUENCER1_CH5_NAME  .UpdateValue ( CONFIG . Obj . PowerSequencerArray [ 0] . Channel_1_Name  ) ; 
                                                                    __context__.SourceCodeLine = 286;
                                                                    SEQUENCER1_CH6_NAME  .UpdateValue ( CONFIG . Obj . PowerSequencerArray [ 0] . Channel_1_Name  ) ; 
                                                                    __context__.SourceCodeLine = 287;
                                                                    SEQUENCER1_CH7_NAME  .UpdateValue ( CONFIG . Obj . PowerSequencerArray [ 0] . Channel_1_Name  ) ; 
                                                                    __context__.SourceCodeLine = 288;
                                                                    SEQUENCER1_CH8_NAME  .UpdateValue ( CONFIG . Obj . PowerSequencerArray [ 0] . Channel_1_Name  ) ; 
                                                                    } 
                                                                
                                                                catch (Exception __splus_exception__)
                                                                    { 
                                                                    SimplPlusException __splus_exceptionobj__ = new SimplPlusException(__splus_exception__, this );
                                                                    
                                                                    
                                                                    }
                                                                    
                                                                    __context__.SourceCodeLine = 289;
                                                                    ; 
                                                                    __context__.SourceCodeLine = 290;
                                                                    SEQUENCER1_SSI_SEVERITY_MESSAGE  .UpdateValue ( CONFIG . Obj . PowerSequencerArray [ 0] . SSI_Equipment_Status . Severity_Message  ) ; 
                                                                    __context__.SourceCodeLine = 291;
                                                                    SEQUENCER1_SSI_ERROR_TEXT  .UpdateValue ( CONFIG . Obj . PowerSequencerArray [ 0] . SSI_Equipment_Status . Error_Text  ) ; 
                                                                    __context__.SourceCodeLine = 292;
                                                                    SEQUENCER1_SSI_OK_TEXT  .UpdateValue ( CONFIG . Obj . PowerSequencerArray [ 0] . SSI_Equipment_Status . Ok_Text  ) ; 
                                                                    __context__.SourceCodeLine = 296;
                                                                    try 
                                                                        { 
                                                                        __context__.SourceCodeLine = 297;
                                                                        SEQUENCER2_CH1_NAME  .UpdateValue ( CONFIG . Obj . PowerSequencerArray [ 1] . Channel_1_Name  ) ; 
                                                                        __context__.SourceCodeLine = 298;
                                                                        SEQUENCER2_CH2_NAME  .UpdateValue ( CONFIG . Obj . PowerSequencerArray [ 1] . Channel_1_Name  ) ; 
                                                                        __context__.SourceCodeLine = 299;
                                                                        SEQUENCER2_CH3_NAME  .UpdateValue ( CONFIG . Obj . PowerSequencerArray [ 1] . Channel_1_Name  ) ; 
                                                                        __context__.SourceCodeLine = 300;
                                                                        SEQUENCER2_CH4_NAME  .UpdateValue ( CONFIG . Obj . PowerSequencerArray [ 1] . Channel_1_Name  ) ; 
                                                                        __context__.SourceCodeLine = 301;
                                                                        SEQUENCER2_CH5_NAME  .UpdateValue ( CONFIG . Obj . PowerSequencerArray [ 1] . Channel_1_Name  ) ; 
                                                                        __context__.SourceCodeLine = 302;
                                                                        SEQUENCER2_CH6_NAME  .UpdateValue ( CONFIG . Obj . PowerSequencerArray [ 1] . Channel_1_Name  ) ; 
                                                                        __context__.SourceCodeLine = 303;
                                                                        SEQUENCER2_CH7_NAME  .UpdateValue ( CONFIG . Obj . PowerSequencerArray [ 1] . Channel_1_Name  ) ; 
                                                                        __context__.SourceCodeLine = 304;
                                                                        SEQUENCER2_CH8_NAME  .UpdateValue ( CONFIG . Obj . PowerSequencerArray [ 1] . Channel_1_Name  ) ; 
                                                                        } 
                                                                    
                                                                    catch (Exception __splus_exception__)
                                                                        { 
                                                                        SimplPlusException __splus_exceptionobj__ = new SimplPlusException(__splus_exception__, this );
                                                                        
                                                                        
                                                                        }
                                                                        
                                                                        __context__.SourceCodeLine = 305;
                                                                        ; 
                                                                        __context__.SourceCodeLine = 306;
                                                                        SEQUENCER2_SSI_SEVERITY_MESSAGE  .UpdateValue ( CONFIG . Obj . PowerSequencerArray [ 1] . SSI_Equipment_Status . Severity_Message  ) ; 
                                                                        __context__.SourceCodeLine = 307;
                                                                        SEQUENCER2_SSI_ERROR_TEXT  .UpdateValue ( CONFIG . Obj . PowerSequencerArray [ 1] . SSI_Equipment_Status . Error_Text  ) ; 
                                                                        __context__.SourceCodeLine = 308;
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
                                                                
                                                                
                                                                PULL_CONFIG.OnDigitalPush.Add( new InputChangeHandlerWrapper( PULL_CONFIG_OnPush_0, false ) );
                                                                
                                                                _SplusNVRAM.PopulateCustomAttributeList( true );
                                                                
                                                                NVRAM = _SplusNVRAM;
                                                                
                                                            }
                                                            
                                                            public override void LogosSimplSharpInitialize()
                                                            {
                                                                CONFIG  = new IMS_Configuration.Configuration();
                                                                API  = new IMS_Configuration.RESTfulApi();
                                                                
                                                                
                                                            }
                                                            
                                                            public UserModuleClass_IMS_CONFIGURATION_P2 ( string InstanceName, string ReferenceID, Crestron.Logos.SplusObjects.CrestronStringEncoding nEncodingType ) : base( InstanceName, ReferenceID, nEncodingType ) {}
                                                            
                                                            
                                                            
                                                            
                                                            const uint PULL_CONFIG__DigitalInput__ = 0;
                                                            const uint ATC_EXTENSION__AnalogSerialOutput__ = 0;
                                                            const uint ATC_HELP_NUMBER__AnalogSerialOutput__ = 1;
                                                            const uint ATC_HELP_BTN_TEXT__AnalogSerialOutput__ = 2;
                                                            const uint ATC_CONNECTED_DIAL_TEXT__AnalogSerialOutput__ = 3;
                                                            const uint ATC_DISCONNECTED_DIAL_TEXT__AnalogSerialOutput__ = 4;
                                                            const uint ATC_CONNECTED_HANGUP_TEXT__AnalogSerialOutput__ = 5;
                                                            const uint ATC_DISCONNECTED_HANGUP_TEXT__AnalogSerialOutput__ = 6;
                                                            const uint ATC_SSI_DEVICE_USAGE_TYPE__AnalogSerialOutput__ = 7;
                                                            const uint ATC_SSI_DEVICE_USAGE_NAME__AnalogSerialOutput__ = 8;
                                                            const uint ATC_SSI_SEVERITY_MESSAGE__AnalogSerialOutput__ = 9;
                                                            const uint ATC_SSI_ERROR_TEXT__AnalogSerialOutput__ = 10;
                                                            const uint ATC_SSI_OK_TEXT__AnalogSerialOutput__ = 11;
                                                            const uint VTC_EXTENSION__AnalogSerialOutput__ = 12;
                                                            const uint VTC_HELP_NUMBER__AnalogSerialOutput__ = 13;
                                                            const uint VTC_HELP_BTN_TEXT__AnalogSerialOutput__ = 14;
                                                            const uint VTC_CONNECTED_DIAL_TEXT__AnalogSerialOutput__ = 15;
                                                            const uint VTC_DISCONNECTED_DIAL_TEXT__AnalogSerialOutput__ = 16;
                                                            const uint VTC_CONNECTED_HANGUP_TEXT__AnalogSerialOutput__ = 17;
                                                            const uint VTC_DISCONNECTED_HANGUP_TEXT__AnalogSerialOutput__ = 18;
                                                            const uint VTC_CAM_PRESET1_ID__AnalogSerialOutput__ = 19;
                                                            const uint VTC_CAM_PRESET1_NAME__AnalogSerialOutput__ = 20;
                                                            const uint VTC_CAM_PRESET2_ID__AnalogSerialOutput__ = 21;
                                                            const uint VTC_CAM_PRESET2_NAME__AnalogSerialOutput__ = 22;
                                                            const uint VTC_CAM_PRESET3_ID__AnalogSerialOutput__ = 23;
                                                            const uint VTC_CAM_PRESET3_NAME__AnalogSerialOutput__ = 24;
                                                            const uint VTC_CAM_PRESET4_ID__AnalogSerialOutput__ = 25;
                                                            const uint VTC_CAM_PRESET4_NAME__AnalogSerialOutput__ = 26;
                                                            const uint VTC_CAM_PRESET5_ID__AnalogSerialOutput__ = 27;
                                                            const uint VTC_CAM_PRESET5_NAME__AnalogSerialOutput__ = 28;
                                                            const uint VTC_CAM_PRESET6_ID__AnalogSerialOutput__ = 29;
                                                            const uint VTC_CAM_PRESET6_NAME__AnalogSerialOutput__ = 30;
                                                            const uint VTC_SSI_DEVICE_USAGE_TYPE__AnalogSerialOutput__ = 31;
                                                            const uint VTC_SSI_DEVICE_USAGE_NAME__AnalogSerialOutput__ = 32;
                                                            const uint VTC_SSI_SEVERITY_MESSAGE__AnalogSerialOutput__ = 33;
                                                            const uint VTC_SSI_ERROR_TEXT__AnalogSerialOutput__ = 34;
                                                            const uint VTC_SSI_OK_TEXT__AnalogSerialOutput__ = 35;
                                                            const uint LIGHTING_PRESET1_ID__AnalogSerialOutput__ = 36;
                                                            const uint LIGHTING_PRESET1_NAME__AnalogSerialOutput__ = 37;
                                                            const uint LIGHTING_PRESET2_ID__AnalogSerialOutput__ = 38;
                                                            const uint LIGHTING_PRESET2_NAME__AnalogSerialOutput__ = 39;
                                                            const uint LIGHTING_PRESET3_ID__AnalogSerialOutput__ = 40;
                                                            const uint LIGHTING_PRESET3_NAME__AnalogSerialOutput__ = 41;
                                                            const uint LIGHTING_PRESET4_ID__AnalogSerialOutput__ = 42;
                                                            const uint LIGHTING_PRESET4_NAME__AnalogSerialOutput__ = 43;
                                                            const uint LIGHTING_PRESET5_ID__AnalogSerialOutput__ = 44;
                                                            const uint LIGHTING_PRESET5_NAME__AnalogSerialOutput__ = 45;
                                                            const uint LIGHTING_PRESET6_ID__AnalogSerialOutput__ = 46;
                                                            const uint LIGHTING_PRESET6_NAME__AnalogSerialOutput__ = 47;
                                                            const uint LIGHTING_SSI_SEVERITY_MESSAGE__AnalogSerialOutput__ = 48;
                                                            const uint LIGHTING_SSI_ERROR_TEXT__AnalogSerialOutput__ = 49;
                                                            const uint LIGHTING_SSI_OK_TEXT__AnalogSerialOutput__ = 50;
                                                            const uint SEQUENCER1_CH1_NAME__AnalogSerialOutput__ = 51;
                                                            const uint SEQUENCER1_CH2_NAME__AnalogSerialOutput__ = 52;
                                                            const uint SEQUENCER1_CH3_NAME__AnalogSerialOutput__ = 53;
                                                            const uint SEQUENCER1_CH4_NAME__AnalogSerialOutput__ = 54;
                                                            const uint SEQUENCER1_CH5_NAME__AnalogSerialOutput__ = 55;
                                                            const uint SEQUENCER1_CH6_NAME__AnalogSerialOutput__ = 56;
                                                            const uint SEQUENCER1_CH7_NAME__AnalogSerialOutput__ = 57;
                                                            const uint SEQUENCER1_CH8_NAME__AnalogSerialOutput__ = 58;
                                                            const uint SEQUENCER1_SSI_SEVERITY_MESSAGE__AnalogSerialOutput__ = 59;
                                                            const uint SEQUENCER1_SSI_ERROR_TEXT__AnalogSerialOutput__ = 60;
                                                            const uint SEQUENCER1_SSI_OK_TEXT__AnalogSerialOutput__ = 61;
                                                            const uint SEQUENCER2_CH1_NAME__AnalogSerialOutput__ = 62;
                                                            const uint SEQUENCER2_CH2_NAME__AnalogSerialOutput__ = 63;
                                                            const uint SEQUENCER2_CH3_NAME__AnalogSerialOutput__ = 64;
                                                            const uint SEQUENCER2_CH4_NAME__AnalogSerialOutput__ = 65;
                                                            const uint SEQUENCER2_CH5_NAME__AnalogSerialOutput__ = 66;
                                                            const uint SEQUENCER2_CH6_NAME__AnalogSerialOutput__ = 67;
                                                            const uint SEQUENCER2_CH7_NAME__AnalogSerialOutput__ = 68;
                                                            const uint SEQUENCER2_CH8_NAME__AnalogSerialOutput__ = 69;
                                                            const uint SEQUENCER2_SSI_SEVERITY_MESSAGE__AnalogSerialOutput__ = 70;
                                                            const uint SEQUENCER2_SSI_ERROR_TEXT__AnalogSerialOutput__ = 71;
                                                            const uint SEQUENCER2_SSI_OK_TEXT__AnalogSerialOutput__ = 72;
                                                            
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
                                                    