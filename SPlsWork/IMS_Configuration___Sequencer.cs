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

namespace UserModule_IMS_CONFIGURATION___SEQUENCER
{
    public class UserModuleClass_IMS_CONFIGURATION___SEQUENCER : SplusObject
    {
        static CCriticalSection g_criticalSection = new CCriticalSection();
        
        Crestron.Logos.SplusObjects.DigitalInput PULL_CONFIG;
        Crestron.Logos.SplusObjects.StringOutput SEQUENCER_CH1_NAME;
        Crestron.Logos.SplusObjects.StringOutput SEQUENCER_CH2_NAME;
        Crestron.Logos.SplusObjects.StringOutput SEQUENCER_CH3_NAME;
        Crestron.Logos.SplusObjects.StringOutput SEQUENCER_CH4_NAME;
        Crestron.Logos.SplusObjects.StringOutput SEQUENCER_CH5_NAME;
        Crestron.Logos.SplusObjects.StringOutput SEQUENCER_CH6_NAME;
        Crestron.Logos.SplusObjects.StringOutput SEQUENCER_CH7_NAME;
        Crestron.Logos.SplusObjects.StringOutput SEQUENCER_CH8_NAME;
        Crestron.Logos.SplusObjects.StringOutput SEQUENCER_SSI_SEVERITY_MESSAGE;
        Crestron.Logos.SplusObjects.StringOutput SEQUENCER_SSI_ERROR_TEXT;
        Crestron.Logos.SplusObjects.StringOutput SEQUENCER_SSI_OK_TEXT;
        UShortParameter SEQUENCER_NUMBER;
        object PULL_CONFIG_OnPush_0 ( Object __EventInfo__ )
        
            { 
            Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
            try
            {
                SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
                 Configuration.Obj.PowerSequencerToArray()  ;  
 
                
                __context__.SourceCodeLine = 163;
                try 
                    { 
                    __context__.SourceCodeLine = 164;
                    SEQUENCER_CH1_NAME  .UpdateValue ( Configuration . Obj . PowerSequencerArray [ 0] . Channel_1_Name  ) ; 
                    __context__.SourceCodeLine = 165;
                    SEQUENCER_CH2_NAME  .UpdateValue ( Configuration . Obj . PowerSequencerArray [ 0] . Channel_2_Name  ) ; 
                    __context__.SourceCodeLine = 166;
                    SEQUENCER_CH3_NAME  .UpdateValue ( Configuration . Obj . PowerSequencerArray [ 0] . Channel_1_Name  ) ; 
                    __context__.SourceCodeLine = 167;
                    SEQUENCER_CH4_NAME  .UpdateValue ( Configuration . Obj . PowerSequencerArray [ 0] . Channel_1_Name  ) ; 
                    __context__.SourceCodeLine = 168;
                    SEQUENCER_CH5_NAME  .UpdateValue ( Configuration . Obj . PowerSequencerArray [ 0] . Channel_1_Name  ) ; 
                    __context__.SourceCodeLine = 169;
                    SEQUENCER_CH6_NAME  .UpdateValue ( Configuration . Obj . PowerSequencerArray [ 0] . Channel_1_Name  ) ; 
                    __context__.SourceCodeLine = 170;
                    SEQUENCER_CH7_NAME  .UpdateValue ( Configuration . Obj . PowerSequencerArray [ 0] . Channel_1_Name  ) ; 
                    __context__.SourceCodeLine = 171;
                    SEQUENCER_CH8_NAME  .UpdateValue ( Configuration . Obj . PowerSequencerArray [ 0] . Channel_1_Name  ) ; 
                    __context__.SourceCodeLine = 172;
                    SEQUENCER_SSI_SEVERITY_MESSAGE  .UpdateValue ( Configuration . Obj . PowerSequencerArray [ 0] . SSI_Equipment_Status . Severity_Message  ) ; 
                    __context__.SourceCodeLine = 173;
                    SEQUENCER_SSI_ERROR_TEXT  .UpdateValue ( Configuration . Obj . PowerSequencerArray [ 0] . SSI_Equipment_Status . Error_Text  ) ; 
                    __context__.SourceCodeLine = 174;
                    SEQUENCER_SSI_OK_TEXT  .UpdateValue ( Configuration . Obj . PowerSequencerArray [ 0] . SSI_Equipment_Status . Ok_Text  ) ; 
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
            
            SEQUENCER_CH1_NAME = new Crestron.Logos.SplusObjects.StringOutput( SEQUENCER_CH1_NAME__AnalogSerialOutput__, this );
            m_StringOutputList.Add( SEQUENCER_CH1_NAME__AnalogSerialOutput__, SEQUENCER_CH1_NAME );
            
            SEQUENCER_CH2_NAME = new Crestron.Logos.SplusObjects.StringOutput( SEQUENCER_CH2_NAME__AnalogSerialOutput__, this );
            m_StringOutputList.Add( SEQUENCER_CH2_NAME__AnalogSerialOutput__, SEQUENCER_CH2_NAME );
            
            SEQUENCER_CH3_NAME = new Crestron.Logos.SplusObjects.StringOutput( SEQUENCER_CH3_NAME__AnalogSerialOutput__, this );
            m_StringOutputList.Add( SEQUENCER_CH3_NAME__AnalogSerialOutput__, SEQUENCER_CH3_NAME );
            
            SEQUENCER_CH4_NAME = new Crestron.Logos.SplusObjects.StringOutput( SEQUENCER_CH4_NAME__AnalogSerialOutput__, this );
            m_StringOutputList.Add( SEQUENCER_CH4_NAME__AnalogSerialOutput__, SEQUENCER_CH4_NAME );
            
            SEQUENCER_CH5_NAME = new Crestron.Logos.SplusObjects.StringOutput( SEQUENCER_CH5_NAME__AnalogSerialOutput__, this );
            m_StringOutputList.Add( SEQUENCER_CH5_NAME__AnalogSerialOutput__, SEQUENCER_CH5_NAME );
            
            SEQUENCER_CH6_NAME = new Crestron.Logos.SplusObjects.StringOutput( SEQUENCER_CH6_NAME__AnalogSerialOutput__, this );
            m_StringOutputList.Add( SEQUENCER_CH6_NAME__AnalogSerialOutput__, SEQUENCER_CH6_NAME );
            
            SEQUENCER_CH7_NAME = new Crestron.Logos.SplusObjects.StringOutput( SEQUENCER_CH7_NAME__AnalogSerialOutput__, this );
            m_StringOutputList.Add( SEQUENCER_CH7_NAME__AnalogSerialOutput__, SEQUENCER_CH7_NAME );
            
            SEQUENCER_CH8_NAME = new Crestron.Logos.SplusObjects.StringOutput( SEQUENCER_CH8_NAME__AnalogSerialOutput__, this );
            m_StringOutputList.Add( SEQUENCER_CH8_NAME__AnalogSerialOutput__, SEQUENCER_CH8_NAME );
            
            SEQUENCER_SSI_SEVERITY_MESSAGE = new Crestron.Logos.SplusObjects.StringOutput( SEQUENCER_SSI_SEVERITY_MESSAGE__AnalogSerialOutput__, this );
            m_StringOutputList.Add( SEQUENCER_SSI_SEVERITY_MESSAGE__AnalogSerialOutput__, SEQUENCER_SSI_SEVERITY_MESSAGE );
            
            SEQUENCER_SSI_ERROR_TEXT = new Crestron.Logos.SplusObjects.StringOutput( SEQUENCER_SSI_ERROR_TEXT__AnalogSerialOutput__, this );
            m_StringOutputList.Add( SEQUENCER_SSI_ERROR_TEXT__AnalogSerialOutput__, SEQUENCER_SSI_ERROR_TEXT );
            
            SEQUENCER_SSI_OK_TEXT = new Crestron.Logos.SplusObjects.StringOutput( SEQUENCER_SSI_OK_TEXT__AnalogSerialOutput__, this );
            m_StringOutputList.Add( SEQUENCER_SSI_OK_TEXT__AnalogSerialOutput__, SEQUENCER_SSI_OK_TEXT );
            
            SEQUENCER_NUMBER = new UShortParameter( SEQUENCER_NUMBER__Parameter__, this );
            m_ParameterList.Add( SEQUENCER_NUMBER__Parameter__, SEQUENCER_NUMBER );
            
            
            PULL_CONFIG.OnDigitalPush.Add( new InputChangeHandlerWrapper( PULL_CONFIG_OnPush_0, false ) );
            
            _SplusNVRAM.PopulateCustomAttributeList( true );
            
            NVRAM = _SplusNVRAM;
            
        }
        
        public override void LogosSimplSharpInitialize()
        {
            
            
        }
        
        public UserModuleClass_IMS_CONFIGURATION___SEQUENCER ( string InstanceName, string ReferenceID, Crestron.Logos.SplusObjects.CrestronStringEncoding nEncodingType ) : base( InstanceName, ReferenceID, nEncodingType ) {}
        
        
        
        
        const uint PULL_CONFIG__DigitalInput__ = 0;
        const uint SEQUENCER_CH1_NAME__AnalogSerialOutput__ = 0;
        const uint SEQUENCER_CH2_NAME__AnalogSerialOutput__ = 1;
        const uint SEQUENCER_CH3_NAME__AnalogSerialOutput__ = 2;
        const uint SEQUENCER_CH4_NAME__AnalogSerialOutput__ = 3;
        const uint SEQUENCER_CH5_NAME__AnalogSerialOutput__ = 4;
        const uint SEQUENCER_CH6_NAME__AnalogSerialOutput__ = 5;
        const uint SEQUENCER_CH7_NAME__AnalogSerialOutput__ = 6;
        const uint SEQUENCER_CH8_NAME__AnalogSerialOutput__ = 7;
        const uint SEQUENCER_SSI_SEVERITY_MESSAGE__AnalogSerialOutput__ = 8;
        const uint SEQUENCER_SSI_ERROR_TEXT__AnalogSerialOutput__ = 9;
        const uint SEQUENCER_SSI_OK_TEXT__AnalogSerialOutput__ = 10;
        const uint SEQUENCER_NUMBER__Parameter__ = 10;
        
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
