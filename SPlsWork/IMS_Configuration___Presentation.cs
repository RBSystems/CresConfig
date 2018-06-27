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

namespace UserModule_IMS_CONFIGURATION___PRESENTATION
{
    public class UserModuleClass_IMS_CONFIGURATION___PRESENTATION : SplusObject
    {
        static CCriticalSection g_criticalSection = new CCriticalSection();
        
        Crestron.Logos.SplusObjects.DigitalInput PULL_CONFIG;
        Crestron.Logos.SplusObjects.StringOutput PRESENTATION_NAME;
        Crestron.Logos.SplusObjects.StringOutput PRESENTATION_TYPE;
        Crestron.Logos.SplusObjects.StringOutput PRESENTATION_GENERIC_PAGE_TEXT;
        Crestron.Logos.SplusObjects.AnalogOutput PRESENTATION_SWITCHER_VALUE;
        Crestron.Logos.SplusObjects.AnalogOutput PRESENTATION_ICON_VALUE;
        Crestron.Logos.SplusObjects.StringOutput PRESENTATION_SSI_DEVICE_USAGE_TYPE;
        Crestron.Logos.SplusObjects.StringOutput PRESENTATION_SSI_DEVICE_USAGE_NAME;
        Crestron.Logos.SplusObjects.StringOutput PRESENTATION_SSI_SEVERITY_MESSAGE;
        Crestron.Logos.SplusObjects.StringOutput PRESENTATION_SSI_ERROR_TEXT;
        Crestron.Logos.SplusObjects.StringOutput PRESENTATION_SSI_OK_TEXT;
        UShortParameter PRESENTATION_NUMBER;
        object PULL_CONFIG_OnPush_0 ( Object __EventInfo__ )
        
            { 
            Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
            try
            {
                SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
                
                __context__.SourceCodeLine = 163;
                try 
                    { 
                    __context__.SourceCodeLine = 164;
                     Configuration.Obj.PresentationToArray()  ;  
 
                    __context__.SourceCodeLine = 165;
                    PRESENTATION_NAME  .UpdateValue ( Configuration . Obj . PresentationInputArray [ PRESENTATION_NUMBER  .Value] . Name  ) ; 
                    __context__.SourceCodeLine = 166;
                    PRESENTATION_TYPE  .UpdateValue ( Configuration . Obj . PresentationInputArray [ PRESENTATION_NUMBER  .Value] . Type  ) ; 
                    __context__.SourceCodeLine = 167;
                    PRESENTATION_GENERIC_PAGE_TEXT  .UpdateValue ( Configuration . Obj . PresentationInputArray [ PRESENTATION_NUMBER  .Value] . Generic_Page_Text  ) ; 
                    __context__.SourceCodeLine = 168;
                    PRESENTATION_SWITCHER_VALUE  .Value = (ushort) ( Configuration.Obj.PresentationInputArray[ PRESENTATION_NUMBER  .Value ].Switcher_Value ) ; 
                    __context__.SourceCodeLine = 169;
                    PRESENTATION_ICON_VALUE  .Value = (ushort) ( Configuration.Obj.PresentationInputArray[ PRESENTATION_NUMBER  .Value ].Icon_Value ) ; 
                    __context__.SourceCodeLine = 170;
                    PRESENTATION_SSI_DEVICE_USAGE_TYPE  .UpdateValue ( Configuration . Obj . PresentationInputArray [ PRESENTATION_NUMBER  .Value] . SSI_Device_Usage . Device_Type  ) ; 
                    __context__.SourceCodeLine = 171;
                    PRESENTATION_SSI_DEVICE_USAGE_NAME  .UpdateValue ( Configuration . Obj . PresentationInputArray [ PRESENTATION_NUMBER  .Value] . SSI_Device_Usage . Device_Name  ) ; 
                    __context__.SourceCodeLine = 172;
                    PRESENTATION_SSI_SEVERITY_MESSAGE  .UpdateValue ( Configuration . Obj . PresentationInputArray [ PRESENTATION_NUMBER  .Value] . SSI_Equipment_Status . Severity_Message  ) ; 
                    __context__.SourceCodeLine = 173;
                    PRESENTATION_SSI_ERROR_TEXT  .UpdateValue ( Configuration . Obj . PresentationInputArray [ PRESENTATION_NUMBER  .Value] . SSI_Equipment_Status . Error_Text  ) ; 
                    __context__.SourceCodeLine = 174;
                    PRESENTATION_SSI_OK_TEXT  .UpdateValue ( Configuration . Obj . PresentationInputArray [ PRESENTATION_NUMBER  .Value] . SSI_Equipment_Status . Ok_Text  ) ; 
                    } 
                
                catch (Exception __splus_exception__)
                    { 
                    SimplPlusException __splus_exceptionobj__ = new SimplPlusException(__splus_exception__, this );
                    
                    
                    }
                    
                    __context__.SourceCodeLine = 175;
                    ; 
                    
                    
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
            
            PRESENTATION_SWITCHER_VALUE = new Crestron.Logos.SplusObjects.AnalogOutput( PRESENTATION_SWITCHER_VALUE__AnalogSerialOutput__, this );
            m_AnalogOutputList.Add( PRESENTATION_SWITCHER_VALUE__AnalogSerialOutput__, PRESENTATION_SWITCHER_VALUE );
            
            PRESENTATION_ICON_VALUE = new Crestron.Logos.SplusObjects.AnalogOutput( PRESENTATION_ICON_VALUE__AnalogSerialOutput__, this );
            m_AnalogOutputList.Add( PRESENTATION_ICON_VALUE__AnalogSerialOutput__, PRESENTATION_ICON_VALUE );
            
            PRESENTATION_NAME = new Crestron.Logos.SplusObjects.StringOutput( PRESENTATION_NAME__AnalogSerialOutput__, this );
            m_StringOutputList.Add( PRESENTATION_NAME__AnalogSerialOutput__, PRESENTATION_NAME );
            
            PRESENTATION_TYPE = new Crestron.Logos.SplusObjects.StringOutput( PRESENTATION_TYPE__AnalogSerialOutput__, this );
            m_StringOutputList.Add( PRESENTATION_TYPE__AnalogSerialOutput__, PRESENTATION_TYPE );
            
            PRESENTATION_GENERIC_PAGE_TEXT = new Crestron.Logos.SplusObjects.StringOutput( PRESENTATION_GENERIC_PAGE_TEXT__AnalogSerialOutput__, this );
            m_StringOutputList.Add( PRESENTATION_GENERIC_PAGE_TEXT__AnalogSerialOutput__, PRESENTATION_GENERIC_PAGE_TEXT );
            
            PRESENTATION_SSI_DEVICE_USAGE_TYPE = new Crestron.Logos.SplusObjects.StringOutput( PRESENTATION_SSI_DEVICE_USAGE_TYPE__AnalogSerialOutput__, this );
            m_StringOutputList.Add( PRESENTATION_SSI_DEVICE_USAGE_TYPE__AnalogSerialOutput__, PRESENTATION_SSI_DEVICE_USAGE_TYPE );
            
            PRESENTATION_SSI_DEVICE_USAGE_NAME = new Crestron.Logos.SplusObjects.StringOutput( PRESENTATION_SSI_DEVICE_USAGE_NAME__AnalogSerialOutput__, this );
            m_StringOutputList.Add( PRESENTATION_SSI_DEVICE_USAGE_NAME__AnalogSerialOutput__, PRESENTATION_SSI_DEVICE_USAGE_NAME );
            
            PRESENTATION_SSI_SEVERITY_MESSAGE = new Crestron.Logos.SplusObjects.StringOutput( PRESENTATION_SSI_SEVERITY_MESSAGE__AnalogSerialOutput__, this );
            m_StringOutputList.Add( PRESENTATION_SSI_SEVERITY_MESSAGE__AnalogSerialOutput__, PRESENTATION_SSI_SEVERITY_MESSAGE );
            
            PRESENTATION_SSI_ERROR_TEXT = new Crestron.Logos.SplusObjects.StringOutput( PRESENTATION_SSI_ERROR_TEXT__AnalogSerialOutput__, this );
            m_StringOutputList.Add( PRESENTATION_SSI_ERROR_TEXT__AnalogSerialOutput__, PRESENTATION_SSI_ERROR_TEXT );
            
            PRESENTATION_SSI_OK_TEXT = new Crestron.Logos.SplusObjects.StringOutput( PRESENTATION_SSI_OK_TEXT__AnalogSerialOutput__, this );
            m_StringOutputList.Add( PRESENTATION_SSI_OK_TEXT__AnalogSerialOutput__, PRESENTATION_SSI_OK_TEXT );
            
            PRESENTATION_NUMBER = new UShortParameter( PRESENTATION_NUMBER__Parameter__, this );
            m_ParameterList.Add( PRESENTATION_NUMBER__Parameter__, PRESENTATION_NUMBER );
            
            
            PULL_CONFIG.OnDigitalPush.Add( new InputChangeHandlerWrapper( PULL_CONFIG_OnPush_0, false ) );
            
            _SplusNVRAM.PopulateCustomAttributeList( true );
            
            NVRAM = _SplusNVRAM;
            
        }
        
        public override void LogosSimplSharpInitialize()
        {
            
            
        }
        
        public UserModuleClass_IMS_CONFIGURATION___PRESENTATION ( string InstanceName, string ReferenceID, Crestron.Logos.SplusObjects.CrestronStringEncoding nEncodingType ) : base( InstanceName, ReferenceID, nEncodingType ) {}
        
        
        
        
        const uint PULL_CONFIG__DigitalInput__ = 0;
        const uint PRESENTATION_NAME__AnalogSerialOutput__ = 0;
        const uint PRESENTATION_TYPE__AnalogSerialOutput__ = 1;
        const uint PRESENTATION_GENERIC_PAGE_TEXT__AnalogSerialOutput__ = 2;
        const uint PRESENTATION_SWITCHER_VALUE__AnalogSerialOutput__ = 3;
        const uint PRESENTATION_ICON_VALUE__AnalogSerialOutput__ = 4;
        const uint PRESENTATION_SSI_DEVICE_USAGE_TYPE__AnalogSerialOutput__ = 5;
        const uint PRESENTATION_SSI_DEVICE_USAGE_NAME__AnalogSerialOutput__ = 6;
        const uint PRESENTATION_SSI_SEVERITY_MESSAGE__AnalogSerialOutput__ = 7;
        const uint PRESENTATION_SSI_ERROR_TEXT__AnalogSerialOutput__ = 8;
        const uint PRESENTATION_SSI_OK_TEXT__AnalogSerialOutput__ = 9;
        const uint PRESENTATION_NUMBER__Parameter__ = 10;
        
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
