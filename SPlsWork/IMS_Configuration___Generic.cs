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

namespace UserModule_IMS_CONFIGURATION___GENERIC
{
    public class UserModuleClass_IMS_CONFIGURATION___GENERIC : SplusObject
    {
        static CCriticalSection g_criticalSection = new CCriticalSection();
        
        Crestron.Logos.SplusObjects.DigitalInput PULL_CONFIG;
        Crestron.Logos.SplusObjects.StringOutput GENERIC_TYPE;
        Crestron.Logos.SplusObjects.StringOutput GENERIC_NAME;
        Crestron.Logos.SplusObjects.StringOutput GENERIC_VALUE1_NAME;
        Crestron.Logos.SplusObjects.StringOutput GENERIC_VALUE1_VALUE;
        Crestron.Logos.SplusObjects.StringOutput GENERIC_VALUE2_NAME;
        Crestron.Logos.SplusObjects.StringOutput GENERIC_VALUE2_VALUE;
        Crestron.Logos.SplusObjects.StringOutput GENERIC_VALUE3_NAME;
        Crestron.Logos.SplusObjects.StringOutput GENERIC_VALUE3_VALUE;
        Crestron.Logos.SplusObjects.StringOutput GENERIC_VALUE4_NAME;
        Crestron.Logos.SplusObjects.StringOutput GENERIC_VALUE4_VALUE;
        Crestron.Logos.SplusObjects.StringOutput GENERIC_SSI_SEVERITY_MESSAGE;
        Crestron.Logos.SplusObjects.StringOutput GENERIC_SSI_ERROR_TEXT;
        Crestron.Logos.SplusObjects.StringOutput GENERIC_SSI_OK_TEXT;
        UShortParameter GENERIC_NUMBER;
        object PULL_CONFIG_OnPush_0 ( Object __EventInfo__ )
        
            { 
            Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
            try
            {
                SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
                 Configuration.Obj.GenericDeviceToArray()  ;  
 
                
                __context__.SourceCodeLine = 164;
                GENERIC_TYPE  .UpdateValue ( Configuration . Obj . GenericDeviceArray [ GENERIC_NUMBER  .Value] . Type  ) ; 
                __context__.SourceCodeLine = 165;
                GENERIC_NAME  .UpdateValue ( Configuration . Obj . GenericDeviceArray [ GENERIC_NUMBER  .Value] . Name  ) ; 
                __context__.SourceCodeLine = 166;
                GENERIC_VALUE1_NAME  .UpdateValue ( Configuration . Obj . GenericDeviceArray [ GENERIC_NUMBER  .Value] . ValueName1  ) ; 
                __context__.SourceCodeLine = 167;
                GENERIC_VALUE1_VALUE  .UpdateValue ( Configuration . Obj . GenericDeviceArray [ GENERIC_NUMBER  .Value] . Value1  ) ; 
                __context__.SourceCodeLine = 168;
                GENERIC_VALUE2_NAME  .UpdateValue ( Configuration . Obj . GenericDeviceArray [ GENERIC_NUMBER  .Value] . ValueName2  ) ; 
                __context__.SourceCodeLine = 169;
                GENERIC_VALUE2_VALUE  .UpdateValue ( Configuration . Obj . GenericDeviceArray [ GENERIC_NUMBER  .Value] . Value2  ) ; 
                __context__.SourceCodeLine = 170;
                GENERIC_VALUE3_NAME  .UpdateValue ( Configuration . Obj . GenericDeviceArray [ GENERIC_NUMBER  .Value] . ValueName3  ) ; 
                __context__.SourceCodeLine = 171;
                GENERIC_VALUE3_VALUE  .UpdateValue ( Configuration . Obj . GenericDeviceArray [ GENERIC_NUMBER  .Value] . Value3  ) ; 
                __context__.SourceCodeLine = 172;
                GENERIC_VALUE4_NAME  .UpdateValue ( Configuration . Obj . GenericDeviceArray [ GENERIC_NUMBER  .Value] . ValueName4  ) ; 
                __context__.SourceCodeLine = 173;
                GENERIC_VALUE4_VALUE  .UpdateValue ( Configuration . Obj . GenericDeviceArray [ GENERIC_NUMBER  .Value] . Value4  ) ; 
                __context__.SourceCodeLine = 174;
                GENERIC_SSI_SEVERITY_MESSAGE  .UpdateValue ( Configuration . Obj . GenericDeviceArray [ GENERIC_NUMBER  .Value] . SSI_Equipment_Status . Severity_Message  ) ; 
                __context__.SourceCodeLine = 175;
                GENERIC_SSI_ERROR_TEXT  .UpdateValue ( Configuration . Obj . GenericDeviceArray [ GENERIC_NUMBER  .Value] . SSI_Equipment_Status . Error_Text  ) ; 
                __context__.SourceCodeLine = 176;
                GENERIC_SSI_OK_TEXT  .UpdateValue ( Configuration . Obj . GenericDeviceArray [ GENERIC_NUMBER  .Value] . SSI_Equipment_Status . Ok_Text  ) ; 
                
                
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
        
        GENERIC_TYPE = new Crestron.Logos.SplusObjects.StringOutput( GENERIC_TYPE__AnalogSerialOutput__, this );
        m_StringOutputList.Add( GENERIC_TYPE__AnalogSerialOutput__, GENERIC_TYPE );
        
        GENERIC_NAME = new Crestron.Logos.SplusObjects.StringOutput( GENERIC_NAME__AnalogSerialOutput__, this );
        m_StringOutputList.Add( GENERIC_NAME__AnalogSerialOutput__, GENERIC_NAME );
        
        GENERIC_VALUE1_NAME = new Crestron.Logos.SplusObjects.StringOutput( GENERIC_VALUE1_NAME__AnalogSerialOutput__, this );
        m_StringOutputList.Add( GENERIC_VALUE1_NAME__AnalogSerialOutput__, GENERIC_VALUE1_NAME );
        
        GENERIC_VALUE1_VALUE = new Crestron.Logos.SplusObjects.StringOutput( GENERIC_VALUE1_VALUE__AnalogSerialOutput__, this );
        m_StringOutputList.Add( GENERIC_VALUE1_VALUE__AnalogSerialOutput__, GENERIC_VALUE1_VALUE );
        
        GENERIC_VALUE2_NAME = new Crestron.Logos.SplusObjects.StringOutput( GENERIC_VALUE2_NAME__AnalogSerialOutput__, this );
        m_StringOutputList.Add( GENERIC_VALUE2_NAME__AnalogSerialOutput__, GENERIC_VALUE2_NAME );
        
        GENERIC_VALUE2_VALUE = new Crestron.Logos.SplusObjects.StringOutput( GENERIC_VALUE2_VALUE__AnalogSerialOutput__, this );
        m_StringOutputList.Add( GENERIC_VALUE2_VALUE__AnalogSerialOutput__, GENERIC_VALUE2_VALUE );
        
        GENERIC_VALUE3_NAME = new Crestron.Logos.SplusObjects.StringOutput( GENERIC_VALUE3_NAME__AnalogSerialOutput__, this );
        m_StringOutputList.Add( GENERIC_VALUE3_NAME__AnalogSerialOutput__, GENERIC_VALUE3_NAME );
        
        GENERIC_VALUE3_VALUE = new Crestron.Logos.SplusObjects.StringOutput( GENERIC_VALUE3_VALUE__AnalogSerialOutput__, this );
        m_StringOutputList.Add( GENERIC_VALUE3_VALUE__AnalogSerialOutput__, GENERIC_VALUE3_VALUE );
        
        GENERIC_VALUE4_NAME = new Crestron.Logos.SplusObjects.StringOutput( GENERIC_VALUE4_NAME__AnalogSerialOutput__, this );
        m_StringOutputList.Add( GENERIC_VALUE4_NAME__AnalogSerialOutput__, GENERIC_VALUE4_NAME );
        
        GENERIC_VALUE4_VALUE = new Crestron.Logos.SplusObjects.StringOutput( GENERIC_VALUE4_VALUE__AnalogSerialOutput__, this );
        m_StringOutputList.Add( GENERIC_VALUE4_VALUE__AnalogSerialOutput__, GENERIC_VALUE4_VALUE );
        
        GENERIC_SSI_SEVERITY_MESSAGE = new Crestron.Logos.SplusObjects.StringOutput( GENERIC_SSI_SEVERITY_MESSAGE__AnalogSerialOutput__, this );
        m_StringOutputList.Add( GENERIC_SSI_SEVERITY_MESSAGE__AnalogSerialOutput__, GENERIC_SSI_SEVERITY_MESSAGE );
        
        GENERIC_SSI_ERROR_TEXT = new Crestron.Logos.SplusObjects.StringOutput( GENERIC_SSI_ERROR_TEXT__AnalogSerialOutput__, this );
        m_StringOutputList.Add( GENERIC_SSI_ERROR_TEXT__AnalogSerialOutput__, GENERIC_SSI_ERROR_TEXT );
        
        GENERIC_SSI_OK_TEXT = new Crestron.Logos.SplusObjects.StringOutput( GENERIC_SSI_OK_TEXT__AnalogSerialOutput__, this );
        m_StringOutputList.Add( GENERIC_SSI_OK_TEXT__AnalogSerialOutput__, GENERIC_SSI_OK_TEXT );
        
        GENERIC_NUMBER = new UShortParameter( GENERIC_NUMBER__Parameter__, this );
        m_ParameterList.Add( GENERIC_NUMBER__Parameter__, GENERIC_NUMBER );
        
        
        PULL_CONFIG.OnDigitalPush.Add( new InputChangeHandlerWrapper( PULL_CONFIG_OnPush_0, false ) );
        
        _SplusNVRAM.PopulateCustomAttributeList( true );
        
        NVRAM = _SplusNVRAM;
        
    }
    
    public override void LogosSimplSharpInitialize()
    {
        
        
    }
    
    public UserModuleClass_IMS_CONFIGURATION___GENERIC ( string InstanceName, string ReferenceID, Crestron.Logos.SplusObjects.CrestronStringEncoding nEncodingType ) : base( InstanceName, ReferenceID, nEncodingType ) {}
    
    
    
    
    const uint PULL_CONFIG__DigitalInput__ = 0;
    const uint GENERIC_TYPE__AnalogSerialOutput__ = 0;
    const uint GENERIC_NAME__AnalogSerialOutput__ = 1;
    const uint GENERIC_VALUE1_NAME__AnalogSerialOutput__ = 2;
    const uint GENERIC_VALUE1_VALUE__AnalogSerialOutput__ = 3;
    const uint GENERIC_VALUE2_NAME__AnalogSerialOutput__ = 4;
    const uint GENERIC_VALUE2_VALUE__AnalogSerialOutput__ = 5;
    const uint GENERIC_VALUE3_NAME__AnalogSerialOutput__ = 6;
    const uint GENERIC_VALUE3_VALUE__AnalogSerialOutput__ = 7;
    const uint GENERIC_VALUE4_NAME__AnalogSerialOutput__ = 8;
    const uint GENERIC_VALUE4_VALUE__AnalogSerialOutput__ = 9;
    const uint GENERIC_SSI_SEVERITY_MESSAGE__AnalogSerialOutput__ = 10;
    const uint GENERIC_SSI_ERROR_TEXT__AnalogSerialOutput__ = 11;
    const uint GENERIC_SSI_OK_TEXT__AnalogSerialOutput__ = 12;
    const uint GENERIC_NUMBER__Parameter__ = 10;
    
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
