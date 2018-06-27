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

namespace UserModule_IMS_CONFIGURATION___DISPLAY
{
    public class UserModuleClass_IMS_CONFIGURATION___DISPLAY : SplusObject
    {
        static CCriticalSection g_criticalSection = new CCriticalSection();
        
        Crestron.Logos.SplusObjects.DigitalInput PULL_CONFIG;
        Crestron.Logos.SplusObjects.DigitalOutput DISPLAY_SCREEN_ENABLED;
        Crestron.Logos.SplusObjects.StringOutput DISPLAY_NAME;
        Crestron.Logos.SplusObjects.StringOutput DISPLAY_TYPE;
        Crestron.Logos.SplusObjects.AnalogOutput DISPLAY_SWITCHER_VALUE;
        Crestron.Logos.SplusObjects.AnalogOutput DISPLAY_ICON_VALUE;
        Crestron.Logos.SplusObjects.AnalogOutput DISPLAY_WARMING_TIME;
        Crestron.Logos.SplusObjects.StringOutput DISPLAY_SSI_USAGE_NAME;
        Crestron.Logos.SplusObjects.StringOutput DISPLAY_SSI_SEVERITY_MESSAGE;
        Crestron.Logos.SplusObjects.StringOutput DISPLAY_SSI_ERROR_TEXT;
        Crestron.Logos.SplusObjects.StringOutput DISPLAY_SSI_OK_TEXT;
        UShortParameter DISPLAY_NUMBER;
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
                     Configuration.Obj.DisplaysToArray()  ;  
 
                    __context__.SourceCodeLine = 165;
                    DISPLAY_NAME  .UpdateValue ( Configuration . Obj . DisplayArray [ DISPLAY_NUMBER  .Value] . Name  ) ; 
                    __context__.SourceCodeLine = 166;
                    DISPLAY_TYPE  .UpdateValue ( Configuration . Obj . DisplayArray [ DISPLAY_NUMBER  .Value] . Type  ) ; 
                    __context__.SourceCodeLine = 167;
                    DISPLAY_SCREEN_ENABLED  .Value = (ushort) ( Configuration.Obj.DisplayArray[ DISPLAY_NUMBER  .Value ].Screen_Enabled ) ; 
                    __context__.SourceCodeLine = 168;
                    DISPLAY_SWITCHER_VALUE  .Value = (ushort) ( Configuration.Obj.DisplayArray[ DISPLAY_NUMBER  .Value ].Switcher_Value ) ; 
                    __context__.SourceCodeLine = 169;
                    DISPLAY_ICON_VALUE  .Value = (ushort) ( Configuration.Obj.DisplayArray[ DISPLAY_NUMBER  .Value ].Icon_Value ) ; 
                    __context__.SourceCodeLine = 170;
                    DISPLAY_WARMING_TIME  .Value = (ushort) ( Configuration.Obj.DisplayArray[ DISPLAY_NUMBER  .Value ].Warming_Time ) ; 
                    __context__.SourceCodeLine = 171;
                    DISPLAY_SSI_USAGE_NAME  .UpdateValue ( Configuration . Obj . DisplayArray [ DISPLAY_NUMBER  .Value] . SSI_Display_Usage . Display_Name  ) ; 
                    __context__.SourceCodeLine = 172;
                    DISPLAY_SSI_SEVERITY_MESSAGE  .UpdateValue ( Configuration . Obj . DisplayArray [ DISPLAY_NUMBER  .Value] . SSI_Equipment_Status . Severity_Message  ) ; 
                    __context__.SourceCodeLine = 173;
                    DISPLAY_SSI_ERROR_TEXT  .UpdateValue ( Configuration . Obj . DisplayArray [ DISPLAY_NUMBER  .Value] . SSI_Equipment_Status . Error_Text  ) ; 
                    __context__.SourceCodeLine = 174;
                    DISPLAY_SSI_OK_TEXT  .UpdateValue ( Configuration . Obj . DisplayArray [ DISPLAY_NUMBER  .Value] . SSI_Equipment_Status . Ok_Text  ) ; 
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
            
            DISPLAY_SCREEN_ENABLED = new Crestron.Logos.SplusObjects.DigitalOutput( DISPLAY_SCREEN_ENABLED__DigitalOutput__, this );
            m_DigitalOutputList.Add( DISPLAY_SCREEN_ENABLED__DigitalOutput__, DISPLAY_SCREEN_ENABLED );
            
            DISPLAY_SWITCHER_VALUE = new Crestron.Logos.SplusObjects.AnalogOutput( DISPLAY_SWITCHER_VALUE__AnalogSerialOutput__, this );
            m_AnalogOutputList.Add( DISPLAY_SWITCHER_VALUE__AnalogSerialOutput__, DISPLAY_SWITCHER_VALUE );
            
            DISPLAY_ICON_VALUE = new Crestron.Logos.SplusObjects.AnalogOutput( DISPLAY_ICON_VALUE__AnalogSerialOutput__, this );
            m_AnalogOutputList.Add( DISPLAY_ICON_VALUE__AnalogSerialOutput__, DISPLAY_ICON_VALUE );
            
            DISPLAY_WARMING_TIME = new Crestron.Logos.SplusObjects.AnalogOutput( DISPLAY_WARMING_TIME__AnalogSerialOutput__, this );
            m_AnalogOutputList.Add( DISPLAY_WARMING_TIME__AnalogSerialOutput__, DISPLAY_WARMING_TIME );
            
            DISPLAY_NAME = new Crestron.Logos.SplusObjects.StringOutput( DISPLAY_NAME__AnalogSerialOutput__, this );
            m_StringOutputList.Add( DISPLAY_NAME__AnalogSerialOutput__, DISPLAY_NAME );
            
            DISPLAY_TYPE = new Crestron.Logos.SplusObjects.StringOutput( DISPLAY_TYPE__AnalogSerialOutput__, this );
            m_StringOutputList.Add( DISPLAY_TYPE__AnalogSerialOutput__, DISPLAY_TYPE );
            
            DISPLAY_SSI_USAGE_NAME = new Crestron.Logos.SplusObjects.StringOutput( DISPLAY_SSI_USAGE_NAME__AnalogSerialOutput__, this );
            m_StringOutputList.Add( DISPLAY_SSI_USAGE_NAME__AnalogSerialOutput__, DISPLAY_SSI_USAGE_NAME );
            
            DISPLAY_SSI_SEVERITY_MESSAGE = new Crestron.Logos.SplusObjects.StringOutput( DISPLAY_SSI_SEVERITY_MESSAGE__AnalogSerialOutput__, this );
            m_StringOutputList.Add( DISPLAY_SSI_SEVERITY_MESSAGE__AnalogSerialOutput__, DISPLAY_SSI_SEVERITY_MESSAGE );
            
            DISPLAY_SSI_ERROR_TEXT = new Crestron.Logos.SplusObjects.StringOutput( DISPLAY_SSI_ERROR_TEXT__AnalogSerialOutput__, this );
            m_StringOutputList.Add( DISPLAY_SSI_ERROR_TEXT__AnalogSerialOutput__, DISPLAY_SSI_ERROR_TEXT );
            
            DISPLAY_SSI_OK_TEXT = new Crestron.Logos.SplusObjects.StringOutput( DISPLAY_SSI_OK_TEXT__AnalogSerialOutput__, this );
            m_StringOutputList.Add( DISPLAY_SSI_OK_TEXT__AnalogSerialOutput__, DISPLAY_SSI_OK_TEXT );
            
            DISPLAY_NUMBER = new UShortParameter( DISPLAY_NUMBER__Parameter__, this );
            m_ParameterList.Add( DISPLAY_NUMBER__Parameter__, DISPLAY_NUMBER );
            
            
            PULL_CONFIG.OnDigitalPush.Add( new InputChangeHandlerWrapper( PULL_CONFIG_OnPush_0, false ) );
            
            _SplusNVRAM.PopulateCustomAttributeList( true );
            
            NVRAM = _SplusNVRAM;
            
        }
        
        public override void LogosSimplSharpInitialize()
        {
            
            
        }
        
        public UserModuleClass_IMS_CONFIGURATION___DISPLAY ( string InstanceName, string ReferenceID, Crestron.Logos.SplusObjects.CrestronStringEncoding nEncodingType ) : base( InstanceName, ReferenceID, nEncodingType ) {}
        
        
        
        
        const uint PULL_CONFIG__DigitalInput__ = 0;
        const uint DISPLAY_SCREEN_ENABLED__DigitalOutput__ = 0;
        const uint DISPLAY_NAME__AnalogSerialOutput__ = 0;
        const uint DISPLAY_TYPE__AnalogSerialOutput__ = 1;
        const uint DISPLAY_SWITCHER_VALUE__AnalogSerialOutput__ = 2;
        const uint DISPLAY_ICON_VALUE__AnalogSerialOutput__ = 3;
        const uint DISPLAY_WARMING_TIME__AnalogSerialOutput__ = 4;
        const uint DISPLAY_SSI_USAGE_NAME__AnalogSerialOutput__ = 5;
        const uint DISPLAY_SSI_SEVERITY_MESSAGE__AnalogSerialOutput__ = 6;
        const uint DISPLAY_SSI_ERROR_TEXT__AnalogSerialOutput__ = 7;
        const uint DISPLAY_SSI_OK_TEXT__AnalogSerialOutput__ = 8;
        const uint DISPLAY_NUMBER__Parameter__ = 10;
        
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
