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
        Crestron.Logos.SplusObjects.DigitalOutput PULSEMODULES;
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
        CrestronString FILEPATH;
        CrestronString PROGRAMNUMBER;
        IMS_Configuration.RESTfulApi API;
        object FILENAME__DOLLAR___OnChange_0 ( Object __EventInfo__ )
        
            { 
            Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
            try
            {
                SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
                
                __context__.SourceCodeLine = 166;
                MakeString ( FILEPATH , "\\USER\\{0:d}\\{1}", (short)GetProgramNumber(), FILENAME__DOLLAR__ ) ; 
                __context__.SourceCodeLine = 167;
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
             Configuration.Reader()  ;  
 
            
            __context__.SourceCodeLine = 173;
            Functions.Pulse ( 1, PULSEMODULES ) ; 
            __context__.SourceCodeLine = 174;
            ROOM_NAME  .UpdateValue ( Configuration . Obj . Room_Name  ) ; 
            __context__.SourceCodeLine = 175;
            WELCOME_TEXT  .UpdateValue ( Configuration . Obj . Welcome_Text  ) ; 
            __context__.SourceCodeLine = 176;
            SHUTDOWN_TEXT  .UpdateValue ( Configuration . Obj . Shutdown_Text  ) ; 
            __context__.SourceCodeLine = 177;
            STARTUP_TIME  .Value = (ushort) ( Configuration.Obj.Startup_Time ) ; 
            __context__.SourceCodeLine = 178;
            SHUTDOWN_TIME_ACTIVE  .Value = (ushort) ( Configuration.Obj.Shutdown_Time_Display_Active ) ; 
            __context__.SourceCodeLine = 179;
            SHUTDOWN_TIME_INACTIVE  .Value = (ushort) ( Configuration.Obj.Shutdown_Time_Display_Inactive ) ; 
            __context__.SourceCodeLine = 180;
            WARMING_TEXT  .UpdateValue ( Configuration . Obj . Warming_Text  ) ; 
            __context__.SourceCodeLine = 181;
            COOLING_TEXT  .UpdateValue ( Configuration . Obj . Cooling_Text  ) ; 
            __context__.SourceCodeLine = 182;
            MICROPHONE_MUTE_ENABLE  .Value = (ushort) ( Configuration.Obj.Microphone_Mute_Enable ) ; 
            __context__.SourceCodeLine = 183;
            MICROPHONE_MUTED_TEXT  .UpdateValue ( Configuration . Obj . Microphone_Muted_Text  ) ; 
            __context__.SourceCodeLine = 184;
            MICROPHONE_MUTED_NOT_TEXT  .UpdateValue ( Configuration . Obj . Microphone_Muted_Not_Text  ) ; 
            __context__.SourceCodeLine = 185;
            PRESENTATION_PAGE_TEXT  .UpdateValue ( Configuration . Obj . Presentation_Page_Text  ) ; 
            
            
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
        
        __context__.SourceCodeLine = 241;
        MakeString ( PROGRAMNUMBER , "{0:d}", (short)GetProgramNumber()) ; 
        __context__.SourceCodeLine = 242;
        API . ProgramNumber  =  ( PROGRAMNUMBER  )  .ToString() ; 
        __context__.SourceCodeLine = 243;
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
    
    PULSEMODULES = new Crestron.Logos.SplusObjects.DigitalOutput( PULSEMODULES__DigitalOutput__, this );
    m_DigitalOutputList.Add( PULSEMODULES__DigitalOutput__, PULSEMODULES );
    
    MICROPHONE_MUTE_ENABLE = new Crestron.Logos.SplusObjects.DigitalOutput( MICROPHONE_MUTE_ENABLE__DigitalOutput__, this );
    m_DigitalOutputList.Add( MICROPHONE_MUTE_ENABLE__DigitalOutput__, MICROPHONE_MUTE_ENABLE );
    
    STARTUP_TIME = new Crestron.Logos.SplusObjects.AnalogOutput( STARTUP_TIME__AnalogSerialOutput__, this );
    m_AnalogOutputList.Add( STARTUP_TIME__AnalogSerialOutput__, STARTUP_TIME );
    
    SHUTDOWN_TIME_ACTIVE = new Crestron.Logos.SplusObjects.AnalogOutput( SHUTDOWN_TIME_ACTIVE__AnalogSerialOutput__, this );
    m_AnalogOutputList.Add( SHUTDOWN_TIME_ACTIVE__AnalogSerialOutput__, SHUTDOWN_TIME_ACTIVE );
    
    SHUTDOWN_TIME_INACTIVE = new Crestron.Logos.SplusObjects.AnalogOutput( SHUTDOWN_TIME_INACTIVE__AnalogSerialOutput__, this );
    m_AnalogOutputList.Add( SHUTDOWN_TIME_INACTIVE__AnalogSerialOutput__, SHUTDOWN_TIME_INACTIVE );
    
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
    
    
    FILENAME__DOLLAR__.OnSerialChange.Add( new InputChangeHandlerWrapper( FILENAME__DOLLAR___OnChange_0, false ) );
    PULL_CONFIG.OnDigitalPush.Add( new InputChangeHandlerWrapper( PULL_CONFIG_OnPush_1, false ) );
    
    _SplusNVRAM.PopulateCustomAttributeList( true );
    
    NVRAM = _SplusNVRAM;
    
}

public override void LogosSimplSharpInitialize()
{
    API  = new IMS_Configuration.RESTfulApi();
    
    
}

public UserModuleClass_IMS_CONFIGURATION ( string InstanceName, string ReferenceID, Crestron.Logos.SplusObjects.CrestronStringEncoding nEncodingType ) : base( InstanceName, ReferenceID, nEncodingType ) {}




const uint PULL_CONFIG__DigitalInput__ = 0;
const uint FILENAME__DOLLAR____AnalogSerialInput__ = 0;
const uint PULSEMODULES__DigitalOutput__ = 0;
const uint STARTUP_TIME__AnalogSerialOutput__ = 0;
const uint SHUTDOWN_TIME_ACTIVE__AnalogSerialOutput__ = 1;
const uint SHUTDOWN_TIME_INACTIVE__AnalogSerialOutput__ = 2;
const uint ROOM_NAME__AnalogSerialOutput__ = 3;
const uint WELCOME_TEXT__AnalogSerialOutput__ = 4;
const uint SHUTDOWN_TEXT__AnalogSerialOutput__ = 5;
const uint WARMING_TEXT__AnalogSerialOutput__ = 6;
const uint COOLING_TEXT__AnalogSerialOutput__ = 7;
const uint MICROPHONE_MUTE_ENABLE__DigitalOutput__ = 1;
const uint MICROPHONE_MUTED_TEXT__AnalogSerialOutput__ = 8;
const uint MICROPHONE_MUTED_NOT_TEXT__AnalogSerialOutput__ = 9;
const uint PRESENTATION_PAGE_TEXT__AnalogSerialOutput__ = 10;

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
