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

namespace UserModule_IMS_CONFIGURATION___CAMERA
{
    public class UserModuleClass_IMS_CONFIGURATION___CAMERA : SplusObject
    {
        static CCriticalSection g_criticalSection = new CCriticalSection();
        
        Crestron.Logos.SplusObjects.DigitalInput PULL_CONFIG;
        Crestron.Logos.SplusObjects.DigitalInput SAVE_CAMERA_PRESET;
        InOutArray<Crestron.Logos.SplusObjects.StringInput> CAMERA_PRESET_NAME_IN;
        Crestron.Logos.SplusObjects.StringOutput CAMERA_PRESET1_ID;
        Crestron.Logos.SplusObjects.StringOutput CAMERA_PRESET1_NAME;
        Crestron.Logos.SplusObjects.StringOutput CAMERA_PRESET2_ID;
        Crestron.Logos.SplusObjects.StringOutput CAMERA_PRESET2_NAME;
        Crestron.Logos.SplusObjects.StringOutput CAMERA_PRESET3_ID;
        Crestron.Logos.SplusObjects.StringOutput CAMERA_PRESET3_NAME;
        Crestron.Logos.SplusObjects.StringOutput CAMERA_PRESET4_ID;
        Crestron.Logos.SplusObjects.StringOutput CAMERA_PRESET4_NAME;
        Crestron.Logos.SplusObjects.StringOutput CAMERA_PRESET5_ID;
        Crestron.Logos.SplusObjects.StringOutput CAMERA_PRESET5_NAME;
        Crestron.Logos.SplusObjects.StringOutput CAMERA_PRESET6_ID;
        Crestron.Logos.SplusObjects.StringOutput CAMERA_PRESET6_NAME;
        Crestron.Logos.SplusObjects.StringOutput CAMERA_SSI_SEVERITY_MESSAGE;
        Crestron.Logos.SplusObjects.StringOutput CAMERA_SSI_ERROR_TEXT;
        Crestron.Logos.SplusObjects.StringOutput CAMERA_SSI_OK_TEXT;
        UShortParameter CAMERA_NUMBER;
        ushort INDEX = 0;
        private void PULLCONFIGURATION (  SplusExecutionContext __context__ ) 
            { 
            
            __context__.SourceCodeLine = 130;
            try 
                { 
                __context__.SourceCodeLine = 131;
                 Configuration.Obj.CameraToArray()  ;  
 
                } 
            
            catch (Exception __splus_exception__)
                { 
                SimplPlusException __splus_exceptionobj__ = new SimplPlusException(__splus_exception__, this );
                
                
                }
                
                __context__.SourceCodeLine = 132;
                ; 
                __context__.SourceCodeLine = 134;
                try 
                    { 
                    __context__.SourceCodeLine = 135;
                     Configuration.Obj.CameraArray[ CAMERA_NUMBER  .Value ].PresetToArray()  ;  
 
                    } 
                
                catch (Exception __splus_exception__)
                    { 
                    SimplPlusException __splus_exceptionobj__ = new SimplPlusException(__splus_exception__, this );
                    
                    
                    }
                    
                    __context__.SourceCodeLine = 136;
                    ; 
                    __context__.SourceCodeLine = 138;
                    try 
                        { 
                        __context__.SourceCodeLine = 139;
                        CAMERA_PRESET1_ID  .UpdateValue ( Configuration . Obj . CameraArray [ CAMERA_NUMBER  .Value] . PresetsArray [ 0] . Id  ) ; 
                        __context__.SourceCodeLine = 140;
                        CAMERA_PRESET1_NAME  .UpdateValue ( Configuration . Obj . CameraArray [ CAMERA_NUMBER  .Value] . PresetsArray [ 0] . Name  ) ; 
                        } 
                    
                    catch (Exception __splus_exception__)
                        { 
                        SimplPlusException __splus_exceptionobj__ = new SimplPlusException(__splus_exception__, this );
                        
                        
                        }
                        
                        __context__.SourceCodeLine = 141;
                        ; 
                        __context__.SourceCodeLine = 142;
                        try 
                            { 
                            __context__.SourceCodeLine = 143;
                            CAMERA_PRESET2_ID  .UpdateValue ( Configuration . Obj . CameraArray [ CAMERA_NUMBER  .Value] . PresetsArray [ 1] . Id  ) ; 
                            __context__.SourceCodeLine = 144;
                            CAMERA_PRESET2_NAME  .UpdateValue ( Configuration . Obj . CameraArray [ CAMERA_NUMBER  .Value] . PresetsArray [ 1] . Name  ) ; 
                            } 
                        
                        catch (Exception __splus_exception__)
                            { 
                            SimplPlusException __splus_exceptionobj__ = new SimplPlusException(__splus_exception__, this );
                            
                            
                            }
                            
                            __context__.SourceCodeLine = 145;
                            ; 
                            __context__.SourceCodeLine = 146;
                            try 
                                { 
                                __context__.SourceCodeLine = 147;
                                CAMERA_PRESET3_ID  .UpdateValue ( Configuration . Obj . CameraArray [ CAMERA_NUMBER  .Value] . PresetsArray [ 2] . Id  ) ; 
                                __context__.SourceCodeLine = 148;
                                CAMERA_PRESET3_NAME  .UpdateValue ( Configuration . Obj . CameraArray [ CAMERA_NUMBER  .Value] . PresetsArray [ 2] . Name  ) ; 
                                } 
                            
                            catch (Exception __splus_exception__)
                                { 
                                SimplPlusException __splus_exceptionobj__ = new SimplPlusException(__splus_exception__, this );
                                
                                
                                }
                                
                                __context__.SourceCodeLine = 149;
                                ; 
                                __context__.SourceCodeLine = 150;
                                try 
                                    { 
                                    __context__.SourceCodeLine = 151;
                                    CAMERA_PRESET4_ID  .UpdateValue ( Configuration . Obj . CameraArray [ CAMERA_NUMBER  .Value] . PresetsArray [ 3] . Id  ) ; 
                                    __context__.SourceCodeLine = 152;
                                    CAMERA_PRESET4_NAME  .UpdateValue ( Configuration . Obj . CameraArray [ CAMERA_NUMBER  .Value] . PresetsArray [ 3] . Name  ) ; 
                                    } 
                                
                                catch (Exception __splus_exception__)
                                    { 
                                    SimplPlusException __splus_exceptionobj__ = new SimplPlusException(__splus_exception__, this );
                                    
                                    
                                    }
                                    
                                    __context__.SourceCodeLine = 153;
                                    ; 
                                    __context__.SourceCodeLine = 154;
                                    try 
                                        { 
                                        __context__.SourceCodeLine = 155;
                                        CAMERA_PRESET5_ID  .UpdateValue ( Configuration . Obj . CameraArray [ CAMERA_NUMBER  .Value] . PresetsArray [ 4] . Id  ) ; 
                                        __context__.SourceCodeLine = 156;
                                        CAMERA_PRESET5_NAME  .UpdateValue ( Configuration . Obj . CameraArray [ CAMERA_NUMBER  .Value] . PresetsArray [ 4] . Name  ) ; 
                                        } 
                                    
                                    catch (Exception __splus_exception__)
                                        { 
                                        SimplPlusException __splus_exceptionobj__ = new SimplPlusException(__splus_exception__, this );
                                        
                                        
                                        }
                                        
                                        __context__.SourceCodeLine = 157;
                                        ; 
                                        __context__.SourceCodeLine = 158;
                                        try 
                                            { 
                                            __context__.SourceCodeLine = 159;
                                            CAMERA_PRESET6_ID  .UpdateValue ( Configuration . Obj . CameraArray [ CAMERA_NUMBER  .Value] . PresetsArray [ 5] . Id  ) ; 
                                            __context__.SourceCodeLine = 160;
                                            CAMERA_PRESET6_NAME  .UpdateValue ( Configuration . Obj . CameraArray [ CAMERA_NUMBER  .Value] . PresetsArray [ 5] . Name  ) ; 
                                            } 
                                        
                                        catch (Exception __splus_exception__)
                                            { 
                                            SimplPlusException __splus_exceptionobj__ = new SimplPlusException(__splus_exception__, this );
                                            
                                            
                                            }
                                            
                                            __context__.SourceCodeLine = 161;
                                            ; 
                                            __context__.SourceCodeLine = 162;
                                            CAMERA_SSI_SEVERITY_MESSAGE  .UpdateValue ( Configuration . Obj . CameraArray [ CAMERA_NUMBER  .Value] . SSI_Equipment_Status . Severity_Message  ) ; 
                                            __context__.SourceCodeLine = 163;
                                            CAMERA_SSI_ERROR_TEXT  .UpdateValue ( Configuration . Obj . CameraArray [ CAMERA_NUMBER  .Value] . SSI_Equipment_Status . Error_Text  ) ; 
                                            __context__.SourceCodeLine = 164;
                                            CAMERA_SSI_OK_TEXT  .UpdateValue ( Configuration . Obj . CameraArray [ CAMERA_NUMBER  .Value] . SSI_Equipment_Status . Ok_Text  ) ; 
                                            
                                            }
                                            
                                        object PULL_CONFIG_OnPush_0 ( Object __EventInfo__ )
                                        
                                            { 
                                            Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
                                            try
                                            {
                                                SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
                                                
                                                __context__.SourceCodeLine = 198;
                                                PULLCONFIGURATION (  __context__  ) ; 
                                                
                                                
                                            }
                                            catch(Exception e) { ObjectCatchHandler(e); }
                                            finally { ObjectFinallyHandler( __SignalEventArg__ ); }
                                            return this;
                                            
                                        }
                                        
                                    object SAVE_CAMERA_PRESET_OnPush_1 ( Object __EventInfo__ )
                                    
                                        { 
                                        Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
                                        try
                                        {
                                            SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
                                            
                                            __context__.SourceCodeLine = 203;
                                            try 
                                                { 
                                                __context__.SourceCodeLine = 204;
                                                 Configuration.Obj.SaveCameraPreset( (ushort)( CAMERA_NUMBER  .Value ) , (ushort)( (INDEX - 1) ) ,  CAMERA_PRESET_NAME_IN[ INDEX ] .ToString() )  ;  
 
                                                __context__.SourceCodeLine = 205;
                                                 Configuration.Writer()  ;  
 
                                                } 
                                            
                                            catch (Exception __splus_exception__)
                                                { 
                                                SimplPlusException __splus_exceptionobj__ = new SimplPlusException(__splus_exception__, this );
                                                
                                                
                                                }
                                                
                                                __context__.SourceCodeLine = 206;
                                                ; 
                                                __context__.SourceCodeLine = 207;
                                                PULLCONFIGURATION (  __context__  ) ; 
                                                
                                                
                                            }
                                            catch(Exception e) { ObjectCatchHandler(e); }
                                            finally { ObjectFinallyHandler( __SignalEventArg__ ); }
                                            return this;
                                            
                                        }
                                        
                                    object CAMERA_PRESET_NAME_IN_OnChange_2 ( Object __EventInfo__ )
                                    
                                        { 
                                        Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
                                        try
                                        {
                                            SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
                                            
                                            __context__.SourceCodeLine = 213;
                                            INDEX = (ushort) ( Functions.GetLastModifiedArrayIndex( __SignalEventArg__ ) ) ; 
                                            
                                            
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
                                    
                                    PULL_CONFIG = new Crestron.Logos.SplusObjects.DigitalInput( PULL_CONFIG__DigitalInput__, this );
                                    m_DigitalInputList.Add( PULL_CONFIG__DigitalInput__, PULL_CONFIG );
                                    
                                    SAVE_CAMERA_PRESET = new Crestron.Logos.SplusObjects.DigitalInput( SAVE_CAMERA_PRESET__DigitalInput__, this );
                                    m_DigitalInputList.Add( SAVE_CAMERA_PRESET__DigitalInput__, SAVE_CAMERA_PRESET );
                                    
                                    CAMERA_PRESET_NAME_IN = new InOutArray<StringInput>( 6, this );
                                    for( uint i = 0; i < 6; i++ )
                                    {
                                        CAMERA_PRESET_NAME_IN[i+1] = new Crestron.Logos.SplusObjects.StringInput( CAMERA_PRESET_NAME_IN__AnalogSerialInput__ + i, CAMERA_PRESET_NAME_IN__AnalogSerialInput__, 32, this );
                                        m_StringInputList.Add( CAMERA_PRESET_NAME_IN__AnalogSerialInput__ + i, CAMERA_PRESET_NAME_IN[i+1] );
                                    }
                                    
                                    CAMERA_PRESET1_ID = new Crestron.Logos.SplusObjects.StringOutput( CAMERA_PRESET1_ID__AnalogSerialOutput__, this );
                                    m_StringOutputList.Add( CAMERA_PRESET1_ID__AnalogSerialOutput__, CAMERA_PRESET1_ID );
                                    
                                    CAMERA_PRESET1_NAME = new Crestron.Logos.SplusObjects.StringOutput( CAMERA_PRESET1_NAME__AnalogSerialOutput__, this );
                                    m_StringOutputList.Add( CAMERA_PRESET1_NAME__AnalogSerialOutput__, CAMERA_PRESET1_NAME );
                                    
                                    CAMERA_PRESET2_ID = new Crestron.Logos.SplusObjects.StringOutput( CAMERA_PRESET2_ID__AnalogSerialOutput__, this );
                                    m_StringOutputList.Add( CAMERA_PRESET2_ID__AnalogSerialOutput__, CAMERA_PRESET2_ID );
                                    
                                    CAMERA_PRESET2_NAME = new Crestron.Logos.SplusObjects.StringOutput( CAMERA_PRESET2_NAME__AnalogSerialOutput__, this );
                                    m_StringOutputList.Add( CAMERA_PRESET2_NAME__AnalogSerialOutput__, CAMERA_PRESET2_NAME );
                                    
                                    CAMERA_PRESET3_ID = new Crestron.Logos.SplusObjects.StringOutput( CAMERA_PRESET3_ID__AnalogSerialOutput__, this );
                                    m_StringOutputList.Add( CAMERA_PRESET3_ID__AnalogSerialOutput__, CAMERA_PRESET3_ID );
                                    
                                    CAMERA_PRESET3_NAME = new Crestron.Logos.SplusObjects.StringOutput( CAMERA_PRESET3_NAME__AnalogSerialOutput__, this );
                                    m_StringOutputList.Add( CAMERA_PRESET3_NAME__AnalogSerialOutput__, CAMERA_PRESET3_NAME );
                                    
                                    CAMERA_PRESET4_ID = new Crestron.Logos.SplusObjects.StringOutput( CAMERA_PRESET4_ID__AnalogSerialOutput__, this );
                                    m_StringOutputList.Add( CAMERA_PRESET4_ID__AnalogSerialOutput__, CAMERA_PRESET4_ID );
                                    
                                    CAMERA_PRESET4_NAME = new Crestron.Logos.SplusObjects.StringOutput( CAMERA_PRESET4_NAME__AnalogSerialOutput__, this );
                                    m_StringOutputList.Add( CAMERA_PRESET4_NAME__AnalogSerialOutput__, CAMERA_PRESET4_NAME );
                                    
                                    CAMERA_PRESET5_ID = new Crestron.Logos.SplusObjects.StringOutput( CAMERA_PRESET5_ID__AnalogSerialOutput__, this );
                                    m_StringOutputList.Add( CAMERA_PRESET5_ID__AnalogSerialOutput__, CAMERA_PRESET5_ID );
                                    
                                    CAMERA_PRESET5_NAME = new Crestron.Logos.SplusObjects.StringOutput( CAMERA_PRESET5_NAME__AnalogSerialOutput__, this );
                                    m_StringOutputList.Add( CAMERA_PRESET5_NAME__AnalogSerialOutput__, CAMERA_PRESET5_NAME );
                                    
                                    CAMERA_PRESET6_ID = new Crestron.Logos.SplusObjects.StringOutput( CAMERA_PRESET6_ID__AnalogSerialOutput__, this );
                                    m_StringOutputList.Add( CAMERA_PRESET6_ID__AnalogSerialOutput__, CAMERA_PRESET6_ID );
                                    
                                    CAMERA_PRESET6_NAME = new Crestron.Logos.SplusObjects.StringOutput( CAMERA_PRESET6_NAME__AnalogSerialOutput__, this );
                                    m_StringOutputList.Add( CAMERA_PRESET6_NAME__AnalogSerialOutput__, CAMERA_PRESET6_NAME );
                                    
                                    CAMERA_SSI_SEVERITY_MESSAGE = new Crestron.Logos.SplusObjects.StringOutput( CAMERA_SSI_SEVERITY_MESSAGE__AnalogSerialOutput__, this );
                                    m_StringOutputList.Add( CAMERA_SSI_SEVERITY_MESSAGE__AnalogSerialOutput__, CAMERA_SSI_SEVERITY_MESSAGE );
                                    
                                    CAMERA_SSI_ERROR_TEXT = new Crestron.Logos.SplusObjects.StringOutput( CAMERA_SSI_ERROR_TEXT__AnalogSerialOutput__, this );
                                    m_StringOutputList.Add( CAMERA_SSI_ERROR_TEXT__AnalogSerialOutput__, CAMERA_SSI_ERROR_TEXT );
                                    
                                    CAMERA_SSI_OK_TEXT = new Crestron.Logos.SplusObjects.StringOutput( CAMERA_SSI_OK_TEXT__AnalogSerialOutput__, this );
                                    m_StringOutputList.Add( CAMERA_SSI_OK_TEXT__AnalogSerialOutput__, CAMERA_SSI_OK_TEXT );
                                    
                                    CAMERA_NUMBER = new UShortParameter( CAMERA_NUMBER__Parameter__, this );
                                    m_ParameterList.Add( CAMERA_NUMBER__Parameter__, CAMERA_NUMBER );
                                    
                                    
                                    PULL_CONFIG.OnDigitalPush.Add( new InputChangeHandlerWrapper( PULL_CONFIG_OnPush_0, false ) );
                                    SAVE_CAMERA_PRESET.OnDigitalPush.Add( new InputChangeHandlerWrapper( SAVE_CAMERA_PRESET_OnPush_1, false ) );
                                    for( uint i = 0; i < 6; i++ )
                                        CAMERA_PRESET_NAME_IN[i+1].OnSerialChange.Add( new InputChangeHandlerWrapper( CAMERA_PRESET_NAME_IN_OnChange_2, false ) );
                                        
                                    
                                    _SplusNVRAM.PopulateCustomAttributeList( true );
                                    
                                    NVRAM = _SplusNVRAM;
                                    
                                }
                                
                                public override void LogosSimplSharpInitialize()
                                {
                                    
                                    
                                }
                                
                                public UserModuleClass_IMS_CONFIGURATION___CAMERA ( string InstanceName, string ReferenceID, Crestron.Logos.SplusObjects.CrestronStringEncoding nEncodingType ) : base( InstanceName, ReferenceID, nEncodingType ) {}
                                
                                
                                
                                
                                const uint PULL_CONFIG__DigitalInput__ = 0;
                                const uint SAVE_CAMERA_PRESET__DigitalInput__ = 1;
                                const uint CAMERA_PRESET_NAME_IN__AnalogSerialInput__ = 0;
                                const uint CAMERA_PRESET1_ID__AnalogSerialOutput__ = 0;
                                const uint CAMERA_PRESET1_NAME__AnalogSerialOutput__ = 1;
                                const uint CAMERA_PRESET2_ID__AnalogSerialOutput__ = 2;
                                const uint CAMERA_PRESET2_NAME__AnalogSerialOutput__ = 3;
                                const uint CAMERA_PRESET3_ID__AnalogSerialOutput__ = 4;
                                const uint CAMERA_PRESET3_NAME__AnalogSerialOutput__ = 5;
                                const uint CAMERA_PRESET4_ID__AnalogSerialOutput__ = 6;
                                const uint CAMERA_PRESET4_NAME__AnalogSerialOutput__ = 7;
                                const uint CAMERA_PRESET5_ID__AnalogSerialOutput__ = 8;
                                const uint CAMERA_PRESET5_NAME__AnalogSerialOutput__ = 9;
                                const uint CAMERA_PRESET6_ID__AnalogSerialOutput__ = 10;
                                const uint CAMERA_PRESET6_NAME__AnalogSerialOutput__ = 11;
                                const uint CAMERA_SSI_SEVERITY_MESSAGE__AnalogSerialOutput__ = 12;
                                const uint CAMERA_SSI_ERROR_TEXT__AnalogSerialOutput__ = 13;
                                const uint CAMERA_SSI_OK_TEXT__AnalogSerialOutput__ = 14;
                                const uint CAMERA_NUMBER__Parameter__ = 10;
                                
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
                        