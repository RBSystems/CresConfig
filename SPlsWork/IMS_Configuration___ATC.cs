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

namespace UserModule_IMS_CONFIGURATION___ATC
{
    public class UserModuleClass_IMS_CONFIGURATION___ATC : SplusObject
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
        object PULL_CONFIG_OnPush_0 ( Object __EventInfo__ )
        
            { 
            Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
            try
            {
                SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
                
                __context__.SourceCodeLine = 163;
                ATC_EXTENSION  .UpdateValue ( Configuration . Obj . ATC . Extension  ) ; 
                __context__.SourceCodeLine = 164;
                ATC_HELP_NUMBER  .UpdateValue ( Configuration . Obj . ATC . Help_Number  ) ; 
                __context__.SourceCodeLine = 165;
                ATC_HELP_BTN_TEXT  .UpdateValue ( Configuration . Obj . ATC . Help_Button_Text  ) ; 
                __context__.SourceCodeLine = 166;
                ATC_CONNECTED_DIAL_TEXT  .UpdateValue ( Configuration . Obj . ATC . Connected_Dial_Text  ) ; 
                __context__.SourceCodeLine = 167;
                ATC_DISCONNECTED_DIAL_TEXT  .UpdateValue ( Configuration . Obj . ATC . Disconnected_Dial_Text  ) ; 
                __context__.SourceCodeLine = 168;
                ATC_CONNECTED_HANGUP_TEXT  .UpdateValue ( Configuration . Obj . ATC . Connected_Hangup_Text  ) ; 
                __context__.SourceCodeLine = 169;
                ATC_DISCONNECTED_HANGUP_TEXT  .UpdateValue ( Configuration . Obj . ATC . Disconnected_Hangup_Text  ) ; 
                __context__.SourceCodeLine = 170;
                ATC_SSI_DEVICE_USAGE_TYPE  .UpdateValue ( Configuration . Obj . ATC . SSI_Device_Usage . Device_Type  ) ; 
                __context__.SourceCodeLine = 171;
                ATC_SSI_DEVICE_USAGE_NAME  .UpdateValue ( Configuration . Obj . ATC . SSI_Device_Usage . Device_Name  ) ; 
                __context__.SourceCodeLine = 172;
                ATC_SSI_SEVERITY_MESSAGE  .UpdateValue ( Configuration . Obj . ATC . SSI_Equipment_Status . Severity_Message  ) ; 
                __context__.SourceCodeLine = 173;
                ATC_SSI_ERROR_TEXT  .UpdateValue ( Configuration . Obj . ATC . SSI_Equipment_Status . Error_Text  ) ; 
                __context__.SourceCodeLine = 174;
                ATC_SSI_OK_TEXT  .UpdateValue ( Configuration . Obj . ATC . SSI_Equipment_Status . Ok_Text  ) ; 
                
                
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
        
        
        PULL_CONFIG.OnDigitalPush.Add( new InputChangeHandlerWrapper( PULL_CONFIG_OnPush_0, false ) );
        
        _SplusNVRAM.PopulateCustomAttributeList( true );
        
        NVRAM = _SplusNVRAM;
        
    }
    
    public override void LogosSimplSharpInitialize()
    {
        
        
    }
    
    public UserModuleClass_IMS_CONFIGURATION___ATC ( string InstanceName, string ReferenceID, Crestron.Logos.SplusObjects.CrestronStringEncoding nEncodingType ) : base( InstanceName, ReferenceID, nEncodingType ) {}
    
    
    
    
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
